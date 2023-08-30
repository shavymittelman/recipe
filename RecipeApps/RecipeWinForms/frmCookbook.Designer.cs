namespace RecipeWinForms
{
    partial class frmCookbook
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
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            txtCookBookName = new TextBox();
            lblUser = new Label();
            lstUserName = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblDateCreated = new Label();
            lblActive = new Label();
            chkActive = new CheckBox();
            tblRecipes = new TableLayoutPanel();
            btnSaveRecipes = new Button();
            gRecipes = new DataGridView();
            txtCookbookDateCreated = new Label();
            tblMain.SuspendLayout();
            tblRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769215F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.4615364F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.4615364F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(txtCookBookName, 1, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(txtPrice, 1, 4);
            tblMain.Controls.Add(lblDateCreated, 2, 3);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(chkActive, 1, 5);
            tblMain.Controls.Add(tblRecipes, 0, 6);
            tblMain.Controls.Add(txtCookbookDateCreated, 2, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(248, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Dock = DockStyle.Fill;
            lblCookbookName.Location = new Point(3, 36);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(178, 41);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            lblCookbookName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCookBookName
            // 
            txtCookBookName.BorderStyle = BorderStyle.FixedSingle;
            txtCookBookName.Dock = DockStyle.Fill;
            txtCookBookName.Location = new Point(187, 45);
            txtCookBookName.Margin = new Padding(3, 9, 3, 3);
            txtCookBookName.Name = "txtCookBookName";
            txtCookBookName.Size = new Size(301, 29);
            txtCookBookName.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(3, 77);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(178, 41);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(187, 86);
            lstUserName.Margin = new Padding(3, 9, 3, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(301, 29);
            lstUserName.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 139);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(178, 42);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(187, 149);
            txtPrice.Margin = new Padding(3, 10, 3, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(301, 29);
            txtPrice.TabIndex = 7;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Dock = DockStyle.Fill;
            lblDateCreated.Location = new Point(494, 118);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(303, 21);
            lblDateCreated.TabIndex = 8;
            lblDateCreated.Text = "Date Created:";
            lblDateCreated.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Dock = DockStyle.Fill;
            lblActive.Location = new Point(3, 181);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(178, 44);
            lblActive.TabIndex = 10;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Dock = DockStyle.Fill;
            chkActive.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            chkActive.Location = new Point(187, 184);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(301, 38);
            chkActive.TabIndex = 11;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // tblRecipes
            // 
            tblRecipes.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipes, 3);
            tblRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblRecipes.Controls.Add(btnSaveRecipes, 0, 0);
            tblRecipes.Controls.Add(gRecipes, 0, 1);
            tblRecipes.Dock = DockStyle.Fill;
            tblRecipes.Location = new Point(3, 228);
            tblRecipes.Name = "tblRecipes";
            tblRecipes.RowCount = 2;
            tblRecipes.RowStyles.Add(new RowStyle());
            tblRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tblRecipes.Size = new Size(794, 219);
            tblRecipes.TabIndex = 12;
            // 
            // btnSaveRecipes
            // 
            btnSaveRecipes.AutoSize = true;
            btnSaveRecipes.BackColor = Color.LimeGreen;
            btnSaveRecipes.Location = new Point(3, 3);
            btnSaveRecipes.Name = "btnSaveRecipes";
            btnSaveRecipes.Size = new Size(110, 31);
            btnSaveRecipes.TabIndex = 0;
            btnSaveRecipes.Text = "Save Recipes";
            btnSaveRecipes.UseVisualStyleBackColor = false;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(3, 40);
            gRecipes.Name = "gRecipes";
            gRecipes.RowTemplate.Height = 25;
            gRecipes.Size = new Size(788, 176);
            gRecipes.TabIndex = 1;
            // 
            // txtCookbookDateCreated
            // 
            txtCookbookDateCreated.BorderStyle = BorderStyle.FixedSingle;
            txtCookbookDateCreated.Location = new Point(494, 149);
            txtCookbookDateCreated.Margin = new Padding(3, 10, 3, 0);
            txtCookbookDateCreated.Name = "txtCookbookDateCreated";
            txtCookbookDateCreated.Size = new Size(294, 23);
            txtCookbookDateCreated.TabIndex = 9;
            txtCookbookDateCreated.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblRecipes.ResumeLayout(false);
            tblRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private TextBox txtCookBookName;
        private Label lblUser;
        private ComboBox lstUserName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblDateCreated;
        private Label txtCookbookDateCreated;
        private Label lblActive;
        private CheckBox chkActive;
        private TableLayoutPanel tblRecipes;
        private Button btnSaveRecipes;
        private DataGridView gRecipes;
    }
}