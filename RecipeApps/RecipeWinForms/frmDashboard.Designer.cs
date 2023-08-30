namespace RecipeWinForms
{
    partial class frmDashboard
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
            tblMain = new TableLayoutPanel();
            lblDesktopDesc = new Label();
            lblHeartyHearthDesc = new Label();
            gAppSummary = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gAppSummary).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lblDesktopDesc, 0, 0);
            tblMain.Controls.Add(lblHeartyHearthDesc, 0, 1);
            tblMain.Controls.Add(gAppSummary, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5555553F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 47.77778F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5555553F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblDesktopDesc
            // 
            lblDesktopDesc.AutoSize = true;
            lblDesktopDesc.Dock = DockStyle.Fill;
            lblDesktopDesc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesktopDesc.Location = new Point(3, 0);
            lblDesktopDesc.Name = "lblDesktopDesc";
            lblDesktopDesc.Size = new Size(794, 68);
            lblDesktopDesc.TabIndex = 0;
            lblDesktopDesc.Text = "Hearty Hearth Desktop App";
            lblDesktopDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeartyHearthDesc
            // 
            lblHeartyHearthDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeartyHearthDesc.AutoSize = true;
            lblHeartyHearthDesc.Location = new Point(3, 68);
            lblHeartyHearthDesc.Name = "lblHeartyHearthDesc";
            lblHeartyHearthDesc.Size = new Size(794, 42);
            lblHeartyHearthDesc.TabIndex = 1;
            lblHeartyHearthDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks, \r\n You can also enjoy a variety of delicious recipes!";
            lblHeartyHearthDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gAppSummary
            // 
            gAppSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gAppSummary.Dock = DockStyle.Fill;
            gAppSummary.Location = new Point(3, 150);
            gAppSummary.Name = "gAppSummary";
            gAppSummary.RowTemplate.Height = 25;
            gAppSummary.Size = new Size(794, 209);
            gAppSummary.TabIndex = 2;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 365);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(794, 82);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Top;
            btnRecipeList.AutoSize = true;
            btnRecipeList.Location = new Point(52, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(159, 31);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Top;
            btnMealList.AutoSize = true;
            btnMealList.Location = new Point(316, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(159, 31);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Anchor = AnchorStyles.Top;
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(589, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(144, 31);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Hearty-Hearth Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gAppSummary).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblDesktopDesc;
        private Label lblHeartyHearthDesc;
        private DataGridView gAppSummary;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}