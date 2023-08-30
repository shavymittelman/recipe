﻿using System.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            dt = SQLUtility.GetDataTable(cmd);

            return dt;
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
