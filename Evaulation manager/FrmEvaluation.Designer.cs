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
            SuspendLayout();
            // 
            // cboActivities
            // 
            cboActivities.FormattingEnabled = true;
            cboActivities.Location = new Point(58, 29);
            cboActivities.Name = "cboActivities";
            cboActivities.Size = new Size(203, 28);
            cboActivities.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 6);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // FrmEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cboActivities);
            Name = "FrmEvaluation";
            Text = "FrmEvaluation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboActivities;
        private Label label1;
    }
}