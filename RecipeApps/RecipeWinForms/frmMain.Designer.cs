namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashboard = new ToolStripMenuItem();
            mnuRecipe = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneRecipe = new ToolStripMenuItem();
            mnuMeal = new ToolStripMenuItem();
            mnuMealList = new ToolStripMenuItem();
            mnuCookbook = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuCookbookNew = new ToolStripMenuItem();
            mnuCookbookAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuDataMaintenanceEdit = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipe, mnuMeal, mnuCookbook, mnuDataMaintenance, mnuWindow });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(856, 29);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(156, 26);
            mnuFileDashboard.Text = "Dashboard";
            // 
            // mnuRecipe
            // 
            mnuRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuNewRecipe, mnuCloneRecipe });
            mnuRecipe.Name = "mnuRecipe";
            mnuRecipe.Size = new Size(75, 25);
            mnuRecipe.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(180, 26);
            mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(180, 26);
            mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneRecipe
            // 
            mnuCloneRecipe.Name = "mnuCloneRecipe";
            mnuCloneRecipe.Size = new Size(180, 26);
            mnuCloneRecipe.Text = "Clone Recipe";
            // 
            // mnuMeal
            // 
            mnuMeal.DropDownItems.AddRange(new ToolStripItem[] { mnuMealList });
            mnuMeal.Name = "mnuMeal";
            mnuMeal.Size = new Size(63, 25);
            mnuMeal.Text = "Meals";
            // 
            // mnuMealList
            // 
            mnuMealList.Name = "mnuMealList";
            mnuMealList.Size = new Size(104, 26);
            mnuMealList.Text = "List";
            // 
            // mnuCookbook
            // 
            mnuCookbook.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuCookbookNew, mnuCookbookAutoCreate });
            mnuCookbook.Name = "mnuCookbook";
            mnuCookbook.Size = new Size(100, 25);
            mnuCookbook.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(187, 26);
            mnuCookbookList.Text = "List";
            // 
            // mnuCookbookNew
            // 
            mnuCookbookNew.Name = "mnuCookbookNew";
            mnuCookbookNew.Size = new Size(187, 26);
            mnuCookbookNew.Text = "New Cookbook";
            // 
            // mnuCookbookAutoCreate
            // 
            mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            mnuCookbookAutoCreate.Size = new Size(187, 26);
            mnuCookbookAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintenanceEdit });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(147, 25);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuDataMaintenanceEdit
            // 
            mnuDataMaintenanceEdit.Name = "mnuDataMaintenanceEdit";
            mnuDataMaintenanceEdit.Size = new Size(142, 26);
            mnuDataMaintenanceEdit.Text = "Edit Data";
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowTile, mnuWindowCascade });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(80, 25);
            mnuWindow.Text = "Window";
            // 
            // mnuWindowTile
            // 
            mnuWindowTile.Name = "mnuWindowTile";
            mnuWindowTile.Size = new Size(137, 26);
            mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(137, 26);
            mnuWindowCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(856, 25);
            tsMain.TabIndex = 2;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 580);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Recipe";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuDataMaintenanceEdit;
        private ToolStripMenuItem mnuCookbook;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuCookbookNew;
        private ToolStripMenuItem mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuMeal;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
    }
}