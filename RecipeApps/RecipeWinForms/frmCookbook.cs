using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        int cookbookid = 0;
        DataTable dtcookbook = new DataTable();
        DataTable dtcookbookrecipe = new DataTable();
        BindingSource bindingsource = new BindingSource();
        string deletecolumnname = "deletecol";
        List<Button> lstmanagebuttons;
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            gRecipes.CellContentClick += GRecipes_CellContentClick;
            this.FormClosing += FrmCookbook_FormClosing;
            lstmanagebuttons = new List<Button>() { btnDelete, btnSaveRecipes };
        }


        public void ShowForm(int cookbookiddval)
        {
            cookbookid = cookbookiddval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindingsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
                WindowsFormsUtility.DisableAndEnableButtons(lstmanagebuttons);
            }
            DataTable dtuser = Cookbook.GetUserRefList();
            WindowsFormsUtility.SetControlBinding(txtCookBookName, bindingsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtuser, dtcookbook, "UserRef");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindingsource);
            WindowsFormsUtility.SetControlBinding(txtCookbookDateCreated, bindingsource);
            WindowsFormsUtility.SetControlBinding(chkActive, bindingsource);
            this.Text = GetCookbookRecipeDesc();
            LoadCookbookRecipes();
            this.Show();
        }

        private void LoadCookbookRecipes()
        {
            dtcookbookrecipe = CookbookRecipe.LoadByCookbookId(cookbookid);
            gRecipes.Columns.Clear();
            gRecipes.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.FormatGridForEdit(gRecipes, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, deletecolumnname);
            AdjustColumnOrder();
        }



        private bool Save()
        {
            bool b = false;
            string currentdatecreated = txtCookbookDateCreated.Text;
            Application.UseWaitCursor = true;
            try
            {
                CurrentDateCreatedIfNewRecipe();
                Cookbook.Save(dtcookbook);
                b = true;
                bindingsource.ResetBindings(false);
                WindowsFormsUtility.DisableAndEnableButtons(lstmanagebuttons, b);
                this.Tag = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                cookbookid = (int)this.Tag;
                this.Text = GetCookbookRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
                txtCookbookDateCreated.Text = currentdatecreated;
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);                
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    frmCookbookList f = (frmCookbookList)Application.OpenForms["frmCookbookList"];
                    f.Close();
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipe(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipes.Rows.Count)
            {
                gRecipes.Rows.RemoveAt(rowindex);
            }
        }

        private string GetCookbookRecipeDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private void CurrentDateCreatedIfNewRecipe()
        {
            if (txtCookbookDateCreated.Text == "")
            {
                txtCookbookDateCreated.Text = DateTime.Today.ToString();
            }
        }

        private void AdjustColumnOrder()
        {
            gRecipes.Columns["RecipeNum"].DisplayIndex = 1;
            gRecipes.Columns["DeleteCol"].DisplayIndex = 2;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveRecipes_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void GRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindingsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook) == true)
            {
                var result = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

    }
}
