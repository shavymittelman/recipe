namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblDrafted = new Label();
            lblRecipeName = new Label();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.Controls.Add(btnDraft, 0, 3);
            tblMain.Controls.Add(btnPublish, 1, 3);
            tblMain.Controls.Add(btnArchive, 2, 3);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblRecipeStatus, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 21.4F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(811, 500);
            tblMain.TabIndex = 0;
            // 
            // btnDraft
            // 
            btnDraft.AccessibleDescription = "btnDraft";
            btnDraft.Anchor = AnchorStyles.Top;
            btnDraft.FlatStyle = FlatStyle.Popup;
            btnDraft.Location = new Point(77, 378);
            btnDraft.Margin = new Padding(4);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(115, 40);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top;
            btnPublish.FlatStyle = FlatStyle.Popup;
            btnPublish.Location = new Point(347, 378);
            btnPublish.Margin = new Padding(4);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(115, 40);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.Top;
            btnArchive.FlatStyle = FlatStyle.Popup;
            btnArchive.Location = new Point(618, 378);
            btnArchive.Margin = new Padding(4);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(115, 40);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 4;
            tblMain.SetColumnSpan(tblDates, 3);
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.3602486F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6459637F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0931683F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7763977F));
            tblDates.Controls.Add(lblStatusDates, 0, 1);
            tblDates.Controls.Add(lblPublished, 2, 0);
            tblDates.Controls.Add(lblArchived, 3, 0);
            tblDates.Controls.Add(lblDateDrafted, 1, 1);
            tblDates.Controls.Add(lblDatePublished, 2, 1);
            tblDates.Controls.Add(lblDateArchived, 3, 1);
            tblDates.Controls.Add(lblDrafted, 1, 0);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(3, 212);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6729565F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 72.32704F));
            tblDates.Size = new Size(805, 159);
            tblDates.TabIndex = 5;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 54);
            lblStatusDates.Margin = new Padding(3, 10, 3, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(174, 105);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(376, 23);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(78, 21);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(531, 23);
            lblArchived.Margin = new Padding(15, 0, 3, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(71, 21);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Location = new Point(211, 44);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(100, 40);
            lblDateDrafted.TabIndex = 4;
            lblDateDrafted.Text = "\r\n";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Location = new Point(365, 44);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(100, 40);
            lblDatePublished.TabIndex = 5;
            lblDatePublished.Text = "\r\n";
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Location = new Point(519, 44);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(100, 40);
            lblDateArchived.TabIndex = 6;
            lblDateArchived.Text = "\r\n";
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(237, 23);
            lblDrafted.Margin = new Padding(3, 0, 15, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(62, 21);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeName, 3);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(805, 107);
            lblRecipeName.TabIndex = 6;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeStatus, 3);
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(3, 107);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(805, 102);
            lblRecipeStatus.TabIndex = 7;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 500);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = " - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label label2;
        private TableLayoutPanel tblDates;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblRecipeStatus;
    }
}