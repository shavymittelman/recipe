namespace RecipeWinForms
{
    partial class frmSearch
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
            gRecipe = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblRecipeName = new Label();
            btnNew = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9230766F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9230766F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Controls.Add(btnSearch, 2, 0);
            tblMain.Controls.Add(txtSearch, 1, 0);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(btnNew, 3, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.424408F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86.57559F));
            tblMain.Size = new Size(756, 523);
            tblMain.TabIndex = 0;
            // 
            // gRecipe
            // 
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipe, 4);
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 73);
            gRecipe.Name = "gRecipe";
            gRecipe.RowTemplate.Height = 25;
            gRecipe.Size = new Size(750, 447);
            gRecipe.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LimeGreen;
            btnSearch.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(409, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 64);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(206, 3);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(197, 64);
            txtSearch.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(197, 70);
            lblRecipeName.TabIndex = 3;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSlateBlue;
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(583, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(170, 64);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 523);
            Controls.Add(tblMain);
            Name = "frmSearch";
            Text = "frmSearch";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Label lblRecipeName;
        private Button btnNew;
    }
}