using System.Data;

namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        BindingSource bindingsource = new BindingSource();
        int recipeid = 0;
        DataTable dtrecipe = new();
        List<Button> lstbtndates;
 
        public frmChangeStatus()
        {
            InitializeComponent();
            btnArchive.Click += BtnArchive_Click;
            btnPublish.Click += BtnPublish_Click;
            btnDraft.Click += BtnDraft_Click;
        }

        public void ShowChangeStatusForm(int recipeid)
        {
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindingsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindingsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindingsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindingsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindingsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindingsource);            
            this.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName") + this.Text;
            DisableCurrentStatus();
        }

        private void DisableCurrentStatus()
        {            
            lstbtndates = new List<Button>() { btnArchive, btnPublish, btnDraft };
   
            foreach (Button btn in lstbtndates)
            {

                btn.Tag = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
                switch (btn.Tag)
                {
                    case "Archived":
                        btnArchive.Enabled = false;
                        btnPublish.Enabled = true;
                        btnDraft.Enabled = true;
                        break;
                    case "Published":
                        btnArchive.Enabled = true;
                        btnPublish.Enabled = false;
                        btnDraft.Enabled = true;
                        break;
                    case "Draft":
                        btnArchive.Enabled = true;
                        btnPublish.Enabled = true;
                        btnDraft.Enabled = false;
                        break;
                }
            }
        }

        private void UpdateRecipeStatus(Label lbl, string status)
        {
            string currentdate = lbl.Text;
            DateTime datetoday = DateTime.Now;
            var response = MessageBox.Show($"Are you sure you want to change this recipe status to {status}?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                lbl.Text = datetoday.ToString();
                Recipe.Save(dtrecipe, "RecipeDateUpdate");                
                int id = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipe.Load(id);
                bindingsource.DataSource = dtrecipe;
                DisableCurrentStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
                lbl.Text = currentdate;
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

 
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus(lblDateArchived, "Archived");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus(lblDatePublished, "Published");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus(lblDateDrafted, "Drafted");
        }
    }
}
