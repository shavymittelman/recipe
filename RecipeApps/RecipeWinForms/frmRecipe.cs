using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select * from UserRef u join Recipe r on u.UserRefId = r.UserRefId join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblOutputRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            lblOutputUser.DataBindings.Add("Text", dt, "UserName");
            lblOutputCuisine.DataBindings.Add("Text", dt, "CuisineType");
            lblOutputCaloriesPerServing.DataBindings.Add("Text", dt, "CaloriesPerServing");
            lblOutputDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            lblOutputDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            lblOutputDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            this.Show();
        }
    }
}
