namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            pnlOptTables = new FlowLayoutPanel();
            optUserRef = new RadioButton();
            optCuisine = new RadioButton();
            optIngredient = new RadioButton();
            optUnitOfMeasure = new RadioButton();
            optCourse = new RadioButton();
            gData = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlOptTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7882881F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.21171F));
            tblMain.Controls.Add(pnlOptTables, 0, 0);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 78.8888855F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 21.11111F));
            tblMain.Size = new Size(888, 540);
            tblMain.TabIndex = 0;
            // 
            // pnlOptTables
            // 
            pnlOptTables.Controls.Add(optUserRef);
            pnlOptTables.Controls.Add(optCuisine);
            pnlOptTables.Controls.Add(optIngredient);
            pnlOptTables.Controls.Add(optUnitOfMeasure);
            pnlOptTables.Controls.Add(optCourse);
            pnlOptTables.Dock = DockStyle.Fill;
            pnlOptTables.FlowDirection = FlowDirection.TopDown;
            pnlOptTables.Location = new Point(3, 3);
            pnlOptTables.Name = "pnlOptTables";
            tblMain.SetRowSpan(pnlOptTables, 2);
            pnlOptTables.Size = new Size(223, 534);
            pnlOptTables.TabIndex = 0;
            // 
            // optUserRef
            // 
            optUserRef.AutoSize = true;
            optUserRef.Checked = true;
            optUserRef.Location = new Point(3, 3);
            optUserRef.Name = "optUserRef";
            optUserRef.Size = new Size(67, 25);
            optUserRef.TabIndex = 0;
            optUserRef.TabStop = true;
            optUserRef.Text = "Users";
            optUserRef.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.AutoSize = true;
            optCuisine.Location = new Point(3, 34);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(86, 25);
            optCuisine.TabIndex = 1;
            optCuisine.Text = "Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(3, 65);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(106, 25);
            optIngredient.TabIndex = 2;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optUnitOfMeasure
            // 
            optUnitOfMeasure.AutoSize = true;
            optUnitOfMeasure.Location = new Point(3, 96);
            optUnitOfMeasure.Name = "optUnitOfMeasure";
            optUnitOfMeasure.Size = new Size(131, 25);
            optUnitOfMeasure.TabIndex = 3;
            optUnitOfMeasure.Text = "Measurements";
            optUnitOfMeasure.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Location = new Point(3, 127);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(84, 25);
            optCourse.TabIndex = 4;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(232, 3);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(653, 420);
            gData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Location = new Point(810, 506);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 540);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlOptTables.ResumeLayout(false);
            pnlOptTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptTables;
        private RadioButton optUserRef;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optUnitOfMeasure;
        private RadioButton optCourse;
        private DataGridView gData;
        private Button btnSave;
    }
}