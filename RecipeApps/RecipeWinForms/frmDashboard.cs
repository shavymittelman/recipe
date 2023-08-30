namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            BindData();
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnRecipeList.Click += BtnRecipeList_Click;
        }

        
        private void BindData()
        {
            gAppSummary.DataSource = DataMaintenance.GetDashboard();
            WindowsFormsUtility.FormatGridForSearchResults(gAppSummary, "DashboardGet");
        }
        
        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
                }
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
            }
        }

    }
}
