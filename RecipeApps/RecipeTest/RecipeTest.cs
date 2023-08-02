using System.Data;


namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]
        [TestCase("chicken soup", 1000, "01-01-01")]
        [TestCase("vegetable soup", 2000, "02-02-02")]
        public void InsertNewRecipe(string recipename, int caloriesperserving, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int userrefid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 userrefid from recipe");
            Assume.That(userrefid > 0, "Can't run test , no users in DB");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from recipe");
            Assume.That(cuisineid > 0, "Can't run test , no cuisines in DB");            
            string recipenamedatetime = recipename + DateTime.Now.ToString();
            TestContext.WriteLine("insert recipe with recipename = " + recipenamedatetime);

            r["UserRefId"] = userrefid;
            r["CuisineId"] = cuisineid;            
            r["RecipeName"] = recipenamedatetime;
            r["CaloriesPerServing"] = caloriesperserving;            
            r["DateDrafted"] = datedrafted;
            
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = '" + recipenamedatetime + "'");
            Assert.IsTrue(newid > 0, "president with recipename = " + recipenamedatetime + " is not found in DB");
            TestContext.WriteLine("president with " + recipenamedatetime + " is found in db with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingRecipeCloriesPerServing()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No presidents in DB, can't run test");
            int caloriesperserving = SQLUtility.GetFirstColumnFirstRowValue("select caloriesperserving from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("caloriesperserving for recipeid " + recipeid + " is " + caloriesperserving);
            caloriesperserving = caloriesperserving + 100;
            TestContext.WriteLine("change caloriesperserving to " + caloriesperserving);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["caloriesperserving"] = caloriesperserving;
            Recipe.Save(dt);

            int newcaloriesperserving = SQLUtility.GetFirstColumnFirstRowValue("select caloriesperserving from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcaloriesperserving == caloriesperserving, "caloriesperserving for recipe (" + recipeid + ") = " + newcaloriesperserving);
            TestContext.WriteLine("caloriesperserving for recipe (" + recipeid + ") = " + newcaloriesperserving);
        }

        [Test]
        public void ChangeExistingToInvalidCloriesPerServing()
        {
            int recipeid = GetExistingRecipeId();
            int caloriesperserving = 0;
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            caloriesperserving = SQLUtility.GetFirstColumnFirstRowValue("select caloriesperserving from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("caloriesperserving for recipeid " + recipeid + " is " + caloriesperserving);
            caloriesperserving = 0;
            TestContext.WriteLine("change caloriesperserving to " + caloriesperserving);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["caloriesperserving"] = caloriesperserving;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }


        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from Recipe r left join RecipeIngredient ri on r.RecipeId = ri.RecipeId where ri.RecipeIngredientId is null ");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = "recipe name " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipes without recipe ingredients in DB, can't run test");
            TestContext.WriteLine("Existing recipe without recipe ingredient,  with id = " + recipeid + ", " + recipedesc);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void ChangeExistingRecipeToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();

            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <> " + recipeid);
            string currentrecipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);
            Assume.That(recipename != null, "cannot run test because there's no other recipes in table.");
            TestContext.WriteLine("Change recipeid " + recipeid + " from " + currentrecipename + " to " + recipename + " which belongs to a diff recipe");
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipedInDraftOrArchivedOverThirtyDaysWithIngrdient()
        {
            string sql = @"select top 1 r.RecipeId, r.RecipeName
from Recipe r
left join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
left join Directions d 
on d.RecipeId = r.RecipeId
left join CookBookRecipe cr
on cr.RecipeId = r.RecipeId
left join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
where cr.CookBookRecipeId is null 
and mcr.MealCourseRecipeId is null
and (
    datediff(day, r.DateArchived, CURRENT_TIMESTAMP) <= 30
    or r.RecipeStatus = 'published'
)
";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = "recipe name " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipes not in draft or archived for less than 30 days with recipe ingredients in DB, can't run test");
            TestContext.WriteLine("Existing recipe not in draft or archived for less than 30 days with recipe ingredient,  with id = " + recipeid + ", " + recipedesc);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }


        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, (int)dt.Rows[0]["recipeid"] + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }


        [Test]
        public void GetListOfUsers() 
        {
            int usercount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from userref");
            Assume.That(usercount > 0, "No Users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + usercount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + usercount);

            DataTable dt = Recipe.GetUserRefList();

            Assert.IsTrue(dt.Rows.Count == usercount, "num rows retuned by app (" + dt.Rows.Count + ") <> " + usercount);

            TestContext.WriteLine("Number of rows in userref returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No Cuisines in DB, can't test");
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows retuned by app (" + dt.Rows.Count + ") <> " + cuisinecount);

            TestContext.WriteLine("Number of rows in cuisine returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";

            DataTable dt = SQLUtility.GetDataTable(sql);
           
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                   s = dt.Rows[0][0].ToString();
                }
            }

            return s;
        }

    }
}