namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            gRecipe.KeyDown += GRecipe_KeyDown;
            BindData();
        }
        
        private void BindData()
        {
            gRecipe.DataSource = Recipe.GetAllRowsFromTable("RecipeGet");
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
            WindowsFormsUtility.HideColumn(gRecipe, "DatePublished");
            WindowsFormsUtility.HideColumn(gRecipe, "DateArchived");
            WindowsFormsUtility.HideColumn(gRecipe, "DateDrafted");
            WindowsFormsUtility.HideColumn(gRecipe, "ListOrder");
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

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
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
