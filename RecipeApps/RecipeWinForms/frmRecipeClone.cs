using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        int newid = 0;
        public frmRecipeClone()
        {
            InitializeComponent();
            BindData();
            btnCloneRecipe.Click += BtnCloneRecipe_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe", true), null, "Recipe");
        }

        private void CloneRecipe()
        {
            int basedonid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            DataTable dtcurrentrecipe = Recipe.Load(basedonid);            
            Cursor = Cursors.WaitCursor;
            try
            {
                if (dtcurrentrecipe.Rows.Count > 0 && dtcurrentrecipe.Columns.Count > 0)
                {
                    if (dtcurrentrecipe.Rows[0][0] != DBNull.Value)
                    {
                        int.TryParse(dtcurrentrecipe.Rows[0]["UserRefId"].ToString(), out int userrefid);
                        int.TryParse(dtcurrentrecipe.Rows[0]["CuisineId"].ToString(), out int cuisineid);
                        int.TryParse(dtcurrentrecipe.Rows[0]["CaloriesPerServing"].ToString(), out int caloriesperserving);
                        string recipename = dtcurrentrecipe.Rows[0]["RecipeName"].ToString();                        
                       
                        SqlCommand cmd = Recipe.GetRecipeClone(userrefid, cuisineid, recipename, caloriesperserving, basedonid);
                        newid = Convert.ToInt32(cmd.Parameters["@RecipeId"].Value);

                        if (this.MdiParent != null && this.MdiParent is frmMain)
                        {
                            ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newid);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnCloneRecipe_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }
}
