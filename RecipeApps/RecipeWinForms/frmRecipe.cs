using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            string sql = "select * from UserRef u join Recipe r on u.UserRefId = r.UserRefId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtuserref = SQLUtility.GetDataTable("select u.UserRefId, u.UserName from UserRef u");
            DataTable dtcuisine = SQLUtility.GetDataTable("select c.CuisineId, c.CuisineType from Cuisine c ");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetListBinding(lstUserName, dtuserref, dtrecipe, "UserRef");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCaloriesPerServing, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            this.Show();
        }

        private void Save()
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

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
