namespace Evaulation_manager
{
    partial class FrmStudents
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
            dgvStudents = new DataGridView();
            btnEvaluateStudent = new Button();
            btnGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(35, 31);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.Size = new Size(728, 326);
            dgvStudents.TabIndex = 0;
            // 
            // btnEvaluateStudent
            // 
            btnEvaluateStudent.Location = new Point(562, 387);
            btnEvaluateStudent.Name = "btnEvaluateStudent";
            btnEvaluateStudent.Size = new Size(182, 46);
            btnEvaluateStudent.TabIndex = 1;
            btnEvaluateStudent.Text = "Evauliraj studenta";
            btnEvaluateStudent.UseVisualStyleBackColor = true;
            btnEvaluateStudent.Click += btnEvaluateStudent_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(44, 387);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(176, 34);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generiraj izvještaj";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnEvaluateStudent);
            Controls.Add(dgvStudents);
            Name = "FrmStudents";
            Text = "FrmStudents";
            Load += FrmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnEvaluateStudent;
        private Button btnGenerateReport;
    }
}