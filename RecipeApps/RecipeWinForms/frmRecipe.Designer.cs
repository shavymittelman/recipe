namespace RecipeWinForms
{
    partial class frmRecipe
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
            lblUserName = new Label();
            lblCuisine = new Label();
            lblCaloriesPerServing = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            txtUserName = new TextBox();
            txtCuisineType = new TextBox();
            txtCaloriesPerServing = new TextBox();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblUserName, 0, 1);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lblCaloriesPerServing, 0, 3);
            tblMain.Controls.Add(lblDateDrafted, 0, 4);
            tblMain.Controls.Add(lblDatePublished, 0, 5);
            tblMain.Controls.Add(lblDateArchived, 0, 6);
            tblMain.Controls.Add(btnSave, 0, 7);
            tblMain.Controls.Add(btnDelete, 1, 7);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtUserName, 1, 1);
            tblMain.Controls.Add(txtCuisineType, 1, 2);
            tblMain.Controls.Add(txtCaloriesPerServing, 1, 3);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995289F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4995317F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5032816F));
            tblMain.Size = new Size(613, 427);
            tblMain.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.PowderBlue;
            lblUserName.BorderStyle = BorderStyle.FixedSingle;
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(3, 53);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(300, 53);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.BackColor = Color.PowderBlue;
            lblCuisine.BorderStyle = BorderStyle.FixedSingle;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuisine.Location = new Point(3, 106);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(300, 53);
            lblCuisine.TabIndex = 3;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.BackColor = Color.PowderBlue;
            lblCaloriesPerServing.BorderStyle = BorderStyle.FixedSingle;
            lblCaloriesPerServing.Dock = DockStyle.Fill;
            lblCaloriesPerServing.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaloriesPerServing.Location = new Point(3, 159);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(300, 53);
            lblCaloriesPerServing.TabIndex = 5;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            lblCaloriesPerServing.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.PowderBlue;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateDrafted.Location = new Point(3, 212);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(300, 53);
            lblDateDrafted.TabIndex = 7;
            lblDateDrafted.Text = "Date Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.PowderBlue;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(3, 265);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(300, 53);
            lblDatePublished.TabIndex = 9;
            lblDatePublished.Text = "Date Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.PowderBlue;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateArchived.Location = new Point(3, 318);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(300, 53);
            lblDateArchived.TabIndex = 11;
            lblDateArchived.Text = "Date Archived";
            lblDateArchived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(3, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(300, 50);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(309, 374);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(301, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.PowderBlue;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(300, 53);
            lblRecipeName.TabIndex = 15;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(309, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(301, 47);
            txtRecipeName.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(309, 56);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(301, 47);
            txtUserName.TabIndex = 17;
            // 
            // txtCuisineType
            // 
            txtCuisineType.Dock = DockStyle.Fill;
            txtCuisineType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuisineType.Location = new Point(309, 109);
            txtCuisineType.Multiline = true;
            txtCuisineType.Name = "txtCuisineType";
            txtCuisineType.Size = new Size(301, 47);
            txtCuisineType.TabIndex = 18;
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.Dock = DockStyle.Fill;
            txtCaloriesPerServing.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaloriesPerServing.Location = new Point(309, 162);
            txtCaloriesPerServing.Multiline = true;
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(301, 47);
            txtCaloriesPerServing.TabIndex = 19;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(309, 215);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(301, 47);
            txtDateDrafted.TabIndex = 20;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatePublished.Location = new Point(309, 268);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(301, 47);
            txtDatePublished.TabIndex = 21;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(309, 321);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(301, 47);
            txtDateArchived.TabIndex = 22;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 427);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblUserName;
        private Label lblCuisine;
        private Label lblCaloriesPerServing;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Button btnSave;
        private Button btnDelete;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private TextBox txtUserName;
        private TextBox txtCuisineType;
        private TextBox txtCaloriesPerServing;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
    }
}