﻿using System.Data;

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
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe);
        }

        
        private void SearchRecipe()
        {
            DataTable dt = Recipe.SearchRecipe(txtSearch.Text);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }            
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
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
        
    }
}
