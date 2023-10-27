using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new DataTable();
        DataTable dtrecipeingredient = new DataTable();
        DataTable dtdirections = new DataTable();
        BindingSource bindingsource = new BindingSource();
        string deletecolumnname = "deletecol";
        int recipeid = 0;
        List<Button> lstmanagebuttons;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            FormClosing += FrmRecipe_FormClosing;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            lstmanagebuttons = new() { btnDelete, btnChangeStatus, btnSaveIngredients, btnSaveSteps };
        }

        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindingsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
                WindowsFormsUtility.DisableAndEnableButtons(lstmanagebuttons);
            }
            DataTable dtcuisine = Recipe.GetCuisineList();
            DataTable dtuser = Recipe.GetUserRefList();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindingsource);
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtuser, dtrecipe, "UserRef");
            WindowsFormsUtility.SetControlBinding(txtCaloriesPerServing, bindingsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindingsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindingsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindingsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindingsource);
            this.Text = GetRecipeDesc();
            LoadRecipeIngredients();
            LoadDirections();
            this.Show();
        }

        private void LoadDirections()
        {
            dtdirections = Directions.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtdirections;
            WindowsFormsUtility.FormatGridForEdit(gSteps, "Directions");
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = RecipeIngredient.LoadByRecipeId(recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientDesc");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("UnitOfMeasure"), "UnitOfMeasure", "UnitOfMeasureDesc");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                AddDraftStatusIfNewRecipe();
                Recipe.Save(dtrecipe);
                b = true;
                bindingsource.ResetBindings(false);
                WindowsFormsUtility.DisableAndEnableButtons(lstmanagebuttons, b);
                this.Tag = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                recipeid = (int)this.Tag;
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }



        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    frmRecipeList f = (frmRecipeList)Application.OpenForms["frmRecipeList"];
                    f.Close();
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveRecipeIngredient()
        {
            try
            {
                RecipeIngredient.SaveTable(dtrecipeingredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }

        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowindex);
            }
        }

        private void SaveSteps()
        {
            try
            {
                Directions.SaveTable(dtdirections, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteDirections(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "DirectionsId");
            if (id > 0)
            {
                try
                {
                    Directions.Delete(id);
                    LoadDirections();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }

        private void ShowRecipeStatusForm()
        {
            int id = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            this.Tag = id;
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), id);
            }
        }

        private void AddDraftStatusIfNewRecipe()
        {
            if (txtDateArchived.Text == "" && txtDateDrafted.Text == "" && txtDatePublished.Text == "")
            {
                txtDateDrafted.Text = DateTime.Today.ToString();
                lblRecipeStatus.Text = "Draft";
            }
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindingsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe) == true)
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveSteps();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ShowRecipeStatusForm();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteDirections(e.RowIndex);
        }
    }

}

