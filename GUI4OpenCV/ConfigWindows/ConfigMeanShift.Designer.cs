namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigMeanShift
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
            label1 = new Label();
            sp = new NumericUpDown();
            sr = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)sp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sr).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 48);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 1;
            label1.Text = "sp";
            // 
            // sp
            // 
            sp.DecimalPlaces = 2;
            sp.Location = new Point(91, 45);
            sp.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sp.Name = "sp";
            sp.Size = new Size(90, 23);
            sp.TabIndex = 2;
            sp.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // sr
            // 
            sr.DecimalPlaces = 2;
            sr.Location = new Point(91, 74);
            sr.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sr.Name = "sr";
            sr.Size = new Size(90, 23);
            sr.TabIndex = 2;
            sr.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 76);
            label2.Name = "label2";
            label2.Size = new Size(19, 17);
            label2.TabIndex = 1;
            label2.Text = "sr";
            // 
            // label5
            // 
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(187, 48);
            label5.Name = "label5";
            label5.Size = new Size(204, 20);
            label5.TabIndex = 1;
            label5.Text = "The spatial window radius.";
            // 
            // label6
            // 
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(187, 74);
            label6.Name = "label6";
            label6.Size = new Size(204, 23);
            label6.TabIndex = 1;
            label6.Text = "The color window radius.";
            // 
            // ConfigMeanShift
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 203);
            Controls.Add(sr);
            Controls.Add(sp);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "ConfigMeanShift";
            Text = "ConfigMeanShift";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(sp, 0);
            Controls.SetChildIndex(sr, 0);
            ((System.ComponentModel.ISupportInitialize)sp).EndInit();
            ((System.ComponentModel.ISupportInitialize)sr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown sp;
        private NumericUpDown sr;
        private Label label2;
        private Label label5;
        private Label label6;
    }
}