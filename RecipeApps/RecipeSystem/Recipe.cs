using System.Data;
using System.Diagnostics;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "select RecipeId, RecipeName from Recipe r where r.RecipeName like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select * from UserRef u join Recipe r on u.UserRefId = r.UserRefId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetUserRefList()
        {
            return SQLUtility.GetDataTable("select u.UserRefId, u.UserName from UserRef u");
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select c.CuisineId, c.CuisineType from Cuisine c ");
        }

        public static void Save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"UserRefId = '{r["UserRefId"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"CaloriesPerServing = '{r["CaloriesPerServing"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe(UserRefId, CuisineId, RecipeName, CaloriesPerServing, DateDrafted) ";
                sql += $"select '{r["UserRefId"]}', '{r["CuisineId"]}', '{r["RecipeName"]}', {r["CaloriesPerServing"]}, '{r["DateDrafted"]}'";
            }
            Debug.Print("------------------------------------");
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
