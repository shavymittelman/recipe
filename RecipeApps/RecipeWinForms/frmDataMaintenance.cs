using Microsoft.VisualBasic.ApplicationServices;
using RecipeSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {

        private enum TableTypeEnum { UserRef, Cuisine, Ingredient, UnitOfMeasure, Course }
        TableTypeEnum currenttabletype = TableTypeEnum.UserRef;
        DataTable dtlist = new DataTable();
        string deletecolname = "delete value";
        public frmDataMaintenance()
        {
            InitializeComponent();
            BindData(currenttabletype);
            SetupRadioBtns();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());            
        }

        private void SetupRadioBtns()
        {
            foreach (Control c in pnlOptTables.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUserRef.Tag = TableTypeEnum.UserRef;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optUnitOfMeasure.Tag = TableTypeEnum.UnitOfMeasure;
            optCourse.Tag = TableTypeEnum.Course;
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void DoDeleteWithMessage(int columnindex, int rowindex)
        {
            string deletemsg = $"Are you sure you want to delete this {currenttabletype}?";
            if (currenttabletype == TableTypeEnum.UserRef)
            {
                deletemsg = $"Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
            }

            var response = MessageBox.Show(deletemsg, Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            else if (response == DialogResult.Yes)
            {
                if (gData.Columns[columnindex].Name == deletecolname)
                {
                    Delete(rowindex);
                }
            }
        }
        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist) == true)
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

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DoDeleteWithMessage(e.ColumnIndex, e.RowIndex);
        }
    }
}
