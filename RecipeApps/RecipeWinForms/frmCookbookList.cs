namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            BindData();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbook.KeyDown += GCookbook_KeyDown;
            gCookbook.CellDoubleClick += GCookbook_CellDoubleClick;
        }

        public void BindData()
        {
            gCookbook.DataSource = Recipe.GetAllRowsFromTable("CookbookGet");
            WindowsFormsUtility.FormatGridForSearchResults(gCookbook, "Cookbook");
            WindowsFormsUtility.HideColumn(gCookbook, "CookbookDateCreated");
            WindowsFormsUtility.HideColumn(gCookbook, "Active");
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbook, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }
        private void GCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void GCookbook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbook.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gCookbook.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

    }
}


            
        

        

        

