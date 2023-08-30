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
            lblCaloriesPerServing = new Label();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            txtCaloriesPerServing = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            lblCuisine = new Label();
            lstCuisineType = new ComboBox();
            lblCurrentStatus = new Label();
            lblRecipeStatus = new Label();
            tblDates = new TableLayoutPanel();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            txtDateDrafted = new Label();
            txtDatePublished = new Label();
            txtDateArchived = new Label();
            lblStatusDates = new Label();
            tabRecipe = new TabControl();
            tabIngredient = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tabSteps = new TabPage();
            tblRecipe = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            lblUserRef = new Label();
            lstUserName = new ComboBox();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblDates.SuspendLayout();
            tabRecipe.SuspendLayout();
            tabIngredient.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabSteps.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaloriesPerServing, 0, 4);
            tblMain.Controls.Add(lblRecipeName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtCaloriesPerServing, 1, 4);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lstCuisineType, 1, 2);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(tblDates, 1, 6);
            tblMain.Controls.Add(lblStatusDates, 0, 7);
            tblMain.Controls.Add(tabRecipe, 0, 8);
            tblMain.Controls.Add(lblUserRef, 0, 3);
            tblMain.Controls.Add(lstUserName, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8555527F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.30580139F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.30580139F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.304412F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.30580139F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.30580139F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.30580139F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.30580139F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 37.0052223F));
            tblMain.Size = new Size(732, 694);
            tblMain.TabIndex = 0;
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.BackColor = SystemColors.Control;
            lblCaloriesPerServing.Dock = DockStyle.Fill;
            lblCaloriesPerServing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaloriesPerServing.Location = new Point(3, 232);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(149, 50);
            lblCaloriesPerServing.TabIndex = 6;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = SystemColors.Control;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 82);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(149, 50);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(158, 85);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(571, 44);
            txtRecipeName.TabIndex = 1;
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.BorderStyle = BorderStyle.FixedSingle;
            txtCaloriesPerServing.Dock = DockStyle.Fill;
            txtCaloriesPerServing.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaloriesPerServing.Location = new Point(158, 235);
            txtCaloriesPerServing.Multiline = true;
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(571, 44);
            txtCaloriesPerServing.TabIndex = 7;
            // 
            // tblButtons
            // 
            tblButtons.BackColor = SystemColors.ButtonHighlight;
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(726, 76);
            tblButtons.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(235, 70);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(244, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(236, 70);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.BackColor = Color.BlueViolet;
            btnChangeStatus.Dock = DockStyle.Fill;
            btnChangeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeStatus.Location = new Point(486, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(237, 70);
            btnChangeStatus.TabIndex = 1;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.BackColor = SystemColors.Control;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuisine.Location = new Point(3, 132);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(149, 50);
            lblCuisine.TabIndex = 2;
            lblCuisine.Text = "Cuisine";
            // 
            // lstCuisineType
            // 
            lstCuisineType.Anchor = AnchorStyles.Top;
            lstCuisineType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(158, 135);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(571, 28);
            lstCuisineType.TabIndex = 3;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = SystemColors.Control;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(3, 282);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(149, 50);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.ButtonHighlight;
            lblRecipeStatus.BorderStyle = BorderStyle.FixedSingle;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(158, 282);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(571, 50);
            lblRecipeStatus.TabIndex = 9;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 3;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDates.Controls.Add(lblDateDrafted, 0, 0);
            tblDates.Controls.Add(lblDatePublished, 1, 0);
            tblDates.Controls.Add(lblDateArchived, 2, 0);
            tblDates.Controls.Add(txtDateDrafted, 0, 1);
            tblDates.Controls.Add(txtDatePublished, 1, 1);
            tblDates.Controls.Add(txtDateArchived, 2, 1);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(158, 335);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblMain.SetRowSpan(tblDates, 2);
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.Size = new Size(571, 94);
            tblDates.TabIndex = 31;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = SystemColors.ButtonFace;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateDrafted.Location = new Point(3, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(184, 47);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = SystemColors.ButtonFace;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(193, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(184, 47);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = SystemColors.ButtonFace;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateArchived.Location = new Point(383, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(185, 47);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "Archived";
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.AutoSize = true;
            txtDateDrafted.BackColor = SystemColors.ButtonHighlight;
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(3, 47);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(184, 47);
            txtDateDrafted.TabIndex = 3;
            txtDateDrafted.Text = "\r\n";
            txtDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDatePublished
            // 
            txtDatePublished.AutoSize = true;
            txtDatePublished.BackColor = SystemColors.ButtonHighlight;
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatePublished.Location = new Point(193, 47);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(184, 47);
            txtDatePublished.TabIndex = 4;
            txtDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateArchived
            // 
            txtDateArchived.AutoSize = true;
            txtDateArchived.BackColor = SystemColors.ButtonHighlight;
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(383, 47);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(185, 47);
            txtDateArchived.TabIndex = 5;
            txtDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(3, 382);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(149, 50);
            lblStatusDates.TabIndex = 10;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabRecipe
            // 
            tblMain.SetColumnSpan(tabRecipe, 2);
            tabRecipe.Controls.Add(tabIngredient);
            tabRecipe.Controls.Add(tabSteps);
            tabRecipe.Dock = DockStyle.Fill;
            tabRecipe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabRecipe.Location = new Point(3, 435);
            tabRecipe.Name = "tabRecipe";
            tabRecipe.SelectedIndex = 0;
            tabRecipe.Size = new Size(726, 256);
            tabRecipe.TabIndex = 11;
            // 
            // tabIngredient
            // 
            tabIngredient.Controls.Add(tblIngredients);
            tabIngredient.Location = new Point(4, 24);
            tabIngredient.Name = "tabIngredient";
            tabIngredient.Padding = new Padding(3);
            tabIngredient.Size = new Size(718, 228);
            tabIngredient.TabIndex = 0;
            tabIngredient.Text = "Ingredients";
            tabIngredient.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(712, 222);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.BackColor = Color.LimeGreen;
            btnSaveIngredients.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(135, 25);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save Ingredients";
            btnSaveIngredients.UseVisualStyleBackColor = false;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 34);
            gIngredients.Name = "gIngredients";
            gIngredients.RowTemplate.Height = 25;
            gIngredients.Size = new Size(706, 185);
            gIngredients.TabIndex = 1;
            // 
            // tabSteps
            // 
            tabSteps.Controls.Add(tblRecipe);
            tabSteps.Location = new Point(4, 24);
            tabSteps.Name = "tabSteps";
            tabSteps.Padding = new Padding(3);
            tabSteps.Size = new Size(718, 228);
            tabSteps.TabIndex = 1;
            tabSteps.Text = "Steps";
            tabSteps.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipe.Controls.Add(btnSaveSteps, 0, 0);
            tblRecipe.Controls.Add(gSteps, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 3);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle());
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 78.6956558F));
            tblRecipe.Size = new Size(712, 222);
            tblRecipe.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.BackColor = Color.LimeGreen;
            btnSaveSteps.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(103, 25);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save Steps";
            btnSaveSteps.UseVisualStyleBackColor = false;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 34);
            gSteps.Name = "gSteps";
            gSteps.RowTemplate.Height = 25;
            gSteps.Size = new Size(706, 185);
            gSteps.TabIndex = 1;
            // 
            // lblUserRef
            // 
            lblUserRef.AutoSize = true;
            lblUserRef.Dock = DockStyle.Fill;
            lblUserRef.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserRef.Location = new Point(3, 182);
            lblUserRef.Name = "lblUserRef";
            lblUserRef.Size = new Size(149, 50);
            lblUserRef.TabIndex = 4;
            lblUserRef.Text = "User";
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(158, 185);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(571, 29);
            lstUserName.TabIndex = 5;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 694);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tabRecipe.ResumeLayout(false);
            tabIngredient.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabSteps.ResumeLayout(false);
            tblRecipe.ResumeLayout(false);
            tblRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCuisine;
        private Label lblCaloriesPerServing;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Button btnSave;
        private Button btnDelete;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private TextBox txtCaloriesPerServing;
        private ComboBox lstCuisineType;
        private TableLayoutPanel tblButtons;
        private Button btnChangeStatus;
        private Label lblCurrentStatus;
        private Label lblRecipeStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblDates;
        private TabControl tabRecipe;
        private TabPage tabIngredient;
        private TabPage tabSteps;
        private Label txtDateDrafted;
        private Label txtDatePublished;
        private Label txtDateArchived;
        private TableLayoutPanel tblRecipe;
        private Button btnSaveSteps;
        private DataGridView gSteps;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private Label lblUserRef;
        private ComboBox lstUserName;
    }
}