using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class Recipe
    {
        
        public static DataTable GetAllRowsFromTable(string sprocname)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);

            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            

            return dt;
        }

        public static DataTable GetUserRefList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UserRefGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);

            return dt; ;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);

            return dt;
        }

        public static void Save(DataTable dtrecipe, string sprocname = "RecipeUpdate")
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save Method because there are no rows in the table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, sprocname);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static SqlCommand GetRecipeClone(int userrefid, int cuisineid, string recipename, int caloriesperserving, int baserecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd, "@UserRefId", userrefid);
            SQLUtility.SetParamValue(cmd, "@CuisineId", cuisineid);
            SQLUtility.SetParamValue(cmd, "@RecipeName", recipename);
            SQLUtility.SetParamValue(cmd, "@CaloriesPerServing", caloriesperserving);
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", baserecipeid);
            SQLUtility.SetParamValue(cmd, "@RecipeId", ParameterDirection.Output);
            SQLUtility.ExecuteSQL(cmd);
            return cmd;
        }
    }
}