namespace Evaulation_manager
{
    partial class FrmEvaluation
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
            cboActivities = new ComboBox();
            label1 = new Label();
            txtMinForSignature = new TextBox();
            txtMinForGrade = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtActivityDescription = new TextBox();
            txtTeacher = new TextBox();
            txtEvaulationDate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numPoints = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numPoints).BeginInit();
            SuspendLayout();
            // 
            // cboActivities
            // 
            cboActivities.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActivities.FormattingEnabled = true;
            cboActivities.Location = new Point(58, 29);
            cboActivities.Name = "cboActivities";
            cboActivities.Size = new Size(203, 28);
            cboActivities.TabIndex = 0;
            cboActivities.SelectedIndexChanged += cboActivities_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 6);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Aktivnost:";
            // 
            // txtMinForSignature
            // 
            txtMinForSignature.Location = new Point(369, 30);
            txtMinForSignature.Name = "txtMinForSignature";
            txtMinForSignature.ReadOnly = true;
            txtMinForSignature.Size = new Size(191, 27);
            txtMinForSignature.TabIndex = 2;
            // 
            // txtMinForGrade
            // 
            txtMinForGrade.Location = new Point(597, 30);
            txtMinForGrade.Name = "txtMinForGrade";
            txtMinForGrade.ReadOnly = true;
            txtMinForGrade.Size = new Size(191, 27);
            txtMinForGrade.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 6);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 4;
            label2.Text = "Uvjet za potpis: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 6);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 5;
            label3.Text = "Uvjet za ocjenu:";
            // 
            // txtActivityDescription
            // 
            txtActivityDescription.Location = new Point(58, 101);
            txtActivityDescription.Multiline = true;
            txtActivityDescription.Name = "txtActivityDescription";
            txtActivityDescription.ReadOnly = true;
            txtActivityDescription.Size = new Size(687, 169);
            txtActivityDescription.TabIndex = 6;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(204, 330);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.ReadOnly = true;
            txtTeacher.Size = new Size(191, 27);
            txtTeacher.TabIndex = 7;
            // 
            // txtEvaulationDate
            // 
            txtEvaulationDate.Location = new Point(426, 330);
            txtEvaulationDate.Name = "txtEvaulationDate";
            txtEvaulationDate.ReadOnly = true;
            txtEvaulationDate.Size = new Size(134, 27);
            txtEvaulationDate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 307);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Ocjenjivač: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 307);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 10;
            label5.Text = "Datum evaulacije: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(622, 307);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 11;
            label6.Text = "Bodovi: ";
            // 
            // numPoints
            // 
            numPoints.Location = new Point(622, 331);
            numPoints.Name = "numPoints";
            numPoints.Size = new Size(62, 27);
            numPoints.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(409, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 31);
            btnSave.TabIndex = 13;
            btnSave.Text = "Spremi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(597, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 31);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Odustani";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPoints);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEvaulationDate);
            Controls.Add(txtTeacher);
            Controls.Add(txtActivityDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMinForGrade);
            Controls.Add(txtMinForSignature);
            Controls.Add(label1);
            Controls.Add(cboActivities);
            Name = "FrmEvaluation";
            Text = "FrmEvaluation";
            Load += FrmEvaluation_Load;
            ((System.ComponentModel.ISupportInitialize)numPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboActivities;
        private Label label1;
        private TextBox txtMinForSignature;
        private TextBox txtMinForGrade;
        private Label label2;
        private Label label3;
        private TextBox txtActivityDescription;
        private TextBox txtTeacher;
        private TextBox txtEvaulationDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numPoints;
        private Button btnSave;
        private Button btnCancel;
    }
}