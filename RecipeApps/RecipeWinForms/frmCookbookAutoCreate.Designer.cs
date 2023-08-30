namespace RecipeWinForms
{
    partial class frmCookbookAutoCreate
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
            lstUserName = new ComboBox();
            lblSelectUser = new Label();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.Controls.Add(lstUserName, 1, 0);
            tblMain.Controls.Add(lblSelectUser, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(228, 199);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(250, 29);
            lstUserName.TabIndex = 0;
            // 
            // lblSelectUser
            // 
            lblSelectUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelectUser.Location = new Point(3, 182);
            lblSelectUser.Margin = new Padding(3, 0, 3, 4);
            lblSelectUser.Name = "lblSelectUser";
            lblSelectUser.Size = new Size(219, 39);
            lblSelectUser.TabIndex = 2;
            lblSelectUser.Text = "Select a User:";
            lblSelectUser.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Location = new Point(338, 228);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(140, 31);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmCookbookAutoCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmCookbookAutoCreate";
            Text = "Hearty - Hearth Auto-Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnCreateCookbook;
        private Label lblSelectUser;
        private ComboBox lstUserName;
    }
}