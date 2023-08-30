using System.Data;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            gRecipe.KeyDown += GRecipe_KeyDown;

        }



        private void SearchRecipe()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataTable dt = Recipe.SearchRecipe(txtSearch.Text);
                gRecipe.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
                if (gRecipe.Rows.Count > 0)
                {
                    gRecipe.Focus();
                    gRecipe.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchRecipe();
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }


        private void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchRecipe();
            }
        }

        private void GRecipe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipe.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipe.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

    }
}
