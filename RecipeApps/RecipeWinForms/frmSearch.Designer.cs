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
            txtSearch = new TextBox();
            btnSearch = new Button();
            gRecipe = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblMain.Controls.Add(txtSearch, 0, 0);
            tblMain.Controls.Add(btnSearch, 1, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.424408F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86.57559F));
            tblMain.Size = new Size(756, 523);
            tblMain.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(3, 3);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 64);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LimeGreen;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(267, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(258, 64);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipe, 3);
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 73);
            gRecipe.Name = "gRecipe";
            gRecipe.RowTemplate.Height = 25;
            gRecipe.Size = new Size(750, 447);
            gRecipe.TabIndex = 2;
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
    }
}