namespace RecipeWinForms
{
    partial class frmRecipeClone
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
            lstRecipeName = new ComboBox();
            btnCloneRecipe = new Button();
            lblSelectRecipe = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.1176453F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8823547F));
            tblMain.Controls.Add(lstRecipeName, 2, 0);
            tblMain.Controls.Add(btnCloneRecipe, 2, 1);
            tblMain.Controls.Add(lblSelectRecipe, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 37.3673019F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 62.6326981F));
            tblMain.Size = new Size(870, 471);
            tblMain.TabIndex = 0;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(320, 144);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(300, 29);
            lstRecipeName.TabIndex = 1;
            // 
            // btnCloneRecipe
            // 
            btnCloneRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloneRecipe.AutoSize = true;
            btnCloneRecipe.Location = new Point(470, 179);
            btnCloneRecipe.Name = "btnCloneRecipe";
            btnCloneRecipe.Size = new Size(150, 31);
            btnCloneRecipe.TabIndex = 2;
            btnCloneRecipe.Text = "Clone";
            btnCloneRecipe.UseVisualStyleBackColor = true;
            // 
            // lblSelectRecipe
            // 
            lblSelectRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSelectRecipe.AutoSize = true;
            lblSelectRecipe.Location = new Point(198, 152);
            lblSelectRecipe.Margin = new Padding(3, 0, 3, 3);
            lblSelectRecipe.Name = "lblSelectRecipe";
            lblSelectRecipe.Size = new Size(116, 21);
            lblSelectRecipe.TabIndex = 0;
            lblSelectRecipe.Text = "Select a Recipe:";
            lblSelectRecipe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmRecipeClone
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 471);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipeClone";
            Text = "Hearty Hearth - Clone a Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblSelectRecipe;
        private ComboBox lstRecipeName;
        private Button btnCloneRecipe;
    }
}