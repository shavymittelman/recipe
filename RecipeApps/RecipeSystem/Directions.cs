using System.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class Directions
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);

            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "DirectionsUpdate");
        }

        public static void Delete(int directionsid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionsDelete");
            cmd.Parameters["@DirectionsId"].Value = directionsid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
