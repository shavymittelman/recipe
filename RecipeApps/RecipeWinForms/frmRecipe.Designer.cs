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
            lblOutputRecipeName = new Label();
            lblUser = new Label();
            lblOutputUser = new Label();
            lblCuisine = new Label();
            lblOutputCuisine = new Label();
            lblCaloriesPerServing = new Label();
            lblOutputCaloriesPerServing = new Label();
            lblDateDrafted = new Label();
            lblOutputDateDrafted = new Label();
            lblDatePublished = new Label();
            lblOutputDatePublished = new Label();
            lblDateArchived = new Label();
            lblOutputDateArchived = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblUser, 0, 1);
            tblMain.Controls.Add(lblOutputUser, 1, 1);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lblOutputCuisine, 1, 2);
            tblMain.Controls.Add(lblCaloriesPerServing, 0, 3);
            tblMain.Controls.Add(lblOutputCaloriesPerServing, 1, 3);
            tblMain.Controls.Add(lblDateDrafted, 0, 4);
            tblMain.Controls.Add(lblOutputDateDrafted, 1, 4);
            tblMain.Controls.Add(lblDatePublished, 0, 5);
            tblMain.Controls.Add(lblOutputDatePublished, 1, 5);
            tblMain.Controls.Add(lblDateArchived, 0, 6);
            tblMain.Controls.Add(lblOutputDateArchived, 1, 6);
            tblMain.Controls.Add(lblOutputRecipeName, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.Size = new Size(613, 427);
            tblMain.TabIndex = 0;
            // 
            // lblOutputRecipeName
            // 
            lblOutputRecipeName.AutoSize = true;
            lblOutputRecipeName.BorderStyle = BorderStyle.FixedSingle;
            tblMain.SetColumnSpan(lblOutputRecipeName, 2);
            lblOutputRecipeName.Dock = DockStyle.Fill;
            lblOutputRecipeName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputRecipeName.Location = new Point(3, 0);
            lblOutputRecipeName.Name = "lblOutputRecipeName";
            lblOutputRecipeName.Size = new Size(607, 61);
            lblOutputRecipeName.TabIndex = 0;
            lblOutputRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.PowderBlue;
            lblUser.BorderStyle = BorderStyle.FixedSingle;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(3, 61);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(300, 61);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutputUser
            // 
            lblOutputUser.AutoSize = true;
            lblOutputUser.BackColor = Color.LightCyan;
            lblOutputUser.BorderStyle = BorderStyle.FixedSingle;
            lblOutputUser.Dock = DockStyle.Fill;
            lblOutputUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputUser.Location = new Point(309, 61);
            lblOutputUser.Name = "lblOutputUser";
            lblOutputUser.Size = new Size(301, 61);
            lblOutputUser.TabIndex = 2;
            lblOutputUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.BackColor = Color.PowderBlue;
            lblCuisine.BorderStyle = BorderStyle.FixedSingle;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuisine.Location = new Point(3, 122);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(300, 61);
            lblCuisine.TabIndex = 3;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutputCuisine
            // 
            lblOutputCuisine.AutoSize = true;
            lblOutputCuisine.BackColor = Color.LightCyan;
            lblOutputCuisine.BorderStyle = BorderStyle.FixedSingle;
            lblOutputCuisine.Dock = DockStyle.Fill;
            lblOutputCuisine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputCuisine.Location = new Point(309, 122);
            lblOutputCuisine.Name = "lblOutputCuisine";
            lblOutputCuisine.Size = new Size(301, 61);
            lblOutputCuisine.TabIndex = 4;
            lblOutputCuisine.Text = "\r\n";
            lblOutputCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.BackColor = Color.PowderBlue;
            lblCaloriesPerServing.BorderStyle = BorderStyle.FixedSingle;
            lblCaloriesPerServing.Dock = DockStyle.Fill;
            lblCaloriesPerServing.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaloriesPerServing.Location = new Point(3, 183);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(300, 61);
            lblCaloriesPerServing.TabIndex = 5;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            lblCaloriesPerServing.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutputCaloriesPerServing
            // 
            lblOutputCaloriesPerServing.AutoSize = true;
            lblOutputCaloriesPerServing.BackColor = Color.LightCyan;
            lblOutputCaloriesPerServing.BorderStyle = BorderStyle.FixedSingle;
            lblOutputCaloriesPerServing.Dock = DockStyle.Fill;
            lblOutputCaloriesPerServing.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputCaloriesPerServing.Location = new Point(309, 183);
            lblOutputCaloriesPerServing.Name = "lblOutputCaloriesPerServing";
            lblOutputCaloriesPerServing.Size = new Size(301, 61);
            lblOutputCaloriesPerServing.TabIndex = 6;
            lblOutputCaloriesPerServing.Text = "\r\n";
            lblOutputCaloriesPerServing.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.PowderBlue;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateDrafted.Location = new Point(3, 244);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(300, 61);
            lblDateDrafted.TabIndex = 7;
            lblDateDrafted.Text = "Date Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutputDateDrafted
            // 
            lblOutputDateDrafted.AutoSize = true;
            lblOutputDateDrafted.BackColor = Color.LightCyan;
            lblOutputDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblOutputDateDrafted.Dock = DockStyle.Fill;
            lblOutputDateDrafted.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputDateDrafted.Location = new Point(309, 244);
            lblOutputDateDrafted.Name = "lblOutputDateDrafted";
            lblOutputDateDrafted.Size = new Size(301, 61);
            lblOutputDateDrafted.TabIndex = 8;
            lblOutputDateDrafted.Text = "\r\n";
            lblOutputDateDrafted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.PowderBlue;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(3, 305);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(300, 61);
            lblDatePublished.TabIndex = 9;
            lblDatePublished.Text = "Date Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutputDatePublished
            // 
            lblOutputDatePublished.AutoSize = true;
            lblOutputDatePublished.BackColor = Color.LightCyan;
            lblOutputDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblOutputDatePublished.Dock = DockStyle.Fill;
            lblOutputDatePublished.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputDatePublished.Location = new Point(309, 305);
            lblOutputDatePublished.Name = "lblOutputDatePublished";
            lblOutputDatePublished.Size = new Size(301, 61);
            lblOutputDatePublished.TabIndex = 10;
            lblOutputDatePublished.Text = "\r\n";
            lblOutputDatePublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.PowderBlue;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateArchived.Location = new Point(3, 366);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(300, 61);
            lblDateArchived.TabIndex = 11;
            lblDateArchived.Text = "Date Archived";
            lblDateArchived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutputDateArchived
            // 
            lblOutputDateArchived.AutoSize = true;
            lblOutputDateArchived.BackColor = Color.LightCyan;
            lblOutputDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblOutputDateArchived.Dock = DockStyle.Fill;
            lblOutputDateArchived.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputDateArchived.Location = new Point(309, 366);
            lblOutputDateArchived.Name = "lblOutputDateArchived";
            lblOutputDateArchived.Size = new Size(301, 61);
            lblOutputDateArchived.TabIndex = 12;
            lblOutputDateArchived.Text = "\r\n";
            lblOutputDateArchived.TextAlign = ContentAlignment.MiddleLeft;
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
        private Label lblOutputRecipeName;
        private Label lblUser;
        private Label lblOutputUser;
        private Label lblCuisine;
        private Label lblOutputCuisine;
        private Label lblCaloriesPerServing;
        private Label lblOutputCaloriesPerServing;
        private Label lblDateDrafted;
        private Label lblOutputDateDrafted;
        private Label lblDatePublished;
        private Label lblOutputDatePublished;
        private Label lblDateArchived;
        private Label lblOutputDateArchived;
    }
}