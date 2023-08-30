using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmCookbookAutoCreate : Form
    {
        int newid = 0;
        public frmCookbookAutoCreate()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetDataList("UserRef", true), null, "UserRef");
        }

        private void CreateCookbook()
        {
            int userrefid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            Cursor = Cursors.WaitCursor;
            try
            {
                SqlCommand cmd = Cookbook.GetCookbookAutoCreate(userrefid);
                newid = Convert.ToInt32(cmd.Parameters["@CookbookId"].Value);

                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), newid);
                    this.Close();
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

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }
    }
}
