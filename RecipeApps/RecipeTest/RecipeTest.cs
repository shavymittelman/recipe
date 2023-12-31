using RecipeSystem;
using System.Data;


namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true", true);
        }

        [Test]
        [TestCase("chicken soup", 1000, "01-01-01")]
        [TestCase("vegetable soup", 2000, "02-02-02")]
        public void InsertNewRecipe(string recipename, int caloriesperserving, DateTime datedrafted)
        {
            int userrefid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 userrefid from recipe");
            Assume.That(userrefid > 0, "Can't run test , no users in DB");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from recipe");
            Assume.That(cuisineid > 0, "Can't run test , no cuisines in DB");            
            string recipenamedatetime = recipename + DateTime.Now.ToString();
            TestContext.WriteLine("insert recipe with recipename = " + recipenamedatetime);

            bizRecipe recipe = new bizRecipe();
            recipe.UserRefId = userrefid;
            recipe.CuisineId = cuisineid;            
            recipe.RecipeName = recipenamedatetime;
            recipe.CaloriesPerServing = caloriesperserving;            
            recipe.DateDrafted = datedrafted;
                        
            recipe.Save();

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

            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();

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

            bizRecipe recipe = new();
            recipe.Load(recipeid);

            int loadedid = recipe.RecipeId;
            string recipename = recipe.RecipeName;

            Assert.IsTrue(loadedid == recipeid && recipename != "", loadedid + " <> " + recipeid + "RecipeName = " + recipename);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")" + "RecipeName = " + recipename);
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

        [Test]
        public void GetListOfRecipes()
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "No recipes in DB can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + recipecount);
            bizRecipe r = new();
            var lst = r.GetList();

            Assert.IsTrue(lst.Count == recipecount, "num rows retuned by app (" + lst.Count + ") <> " + recipecount);

            TestContext.WriteLine("Number of rows in recipes returned by app = " + lst.Count);
        }

        [Test]
        public void GetListOfIngredients()
        {
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            Assume.That(ingredientcount > 0, "No ingredients in DB can't test");
            TestContext.WriteLine("Num of ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + ingredientcount);
            bizIngredient i = new();
            var lst = i.GetList();

            Assert.IsTrue(lst.Count == ingredientcount, "num rows retuned by app (" + lst.Count + ") <> " + ingredientcount);

            TestContext.WriteLine("Number of rows in ingredients returned by app = " + lst.Count);
        }

        [Test]
        public void SearchRecipes()
        {
            string criteria = "o";
            int num = SQLUtility.GetFirstColumnFirstRowValue("select total = Count (*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "no recipe match search for " + num);
            TestContext.WriteLine(num + " recipes that match " + criteria);
            TestContext.WriteLine("ensure recipe search returns " + num + " rows");

            bizRecipe r = new();
            List<bizRecipe> lst  = r.Search(criteria);

            Assert.IsTrue(lst.Count == num, "results of recipe search doesn't match num of recipes, " + lst.Count + " <> " + num);
            TestContext.WriteLine("num of rows returned by recipe search is " + lst.Count);
        }

        [Test]
        public void SearchIngredients()
        {
            string ingredientdesc = "m";
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from ingredient where ingredientdesc like '%{ingredientdesc}%'");
            TestContext.WriteLine("Num of search results in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizIngredient i = new();
            List<bizIngredient> lst = i.Search(ingredientdesc);
            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by search (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Number of rows in search results return by app = " + lst.Count);
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