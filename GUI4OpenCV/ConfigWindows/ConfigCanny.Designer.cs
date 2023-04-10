namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigCanny
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
            threshold1 = new NumericUpDown();
            l2gradient = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            threshold2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            apertureSize = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)threshold1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threshold2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apertureSize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "threshold1";
            // 
            // threshold1
            // 
            threshold1.DecimalPlaces = 2;
            threshold1.Location = new Point(101, 16);
            threshold1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            threshold1.Name = "threshold1";
            threshold1.Size = new Size(92, 23);
            threshold1.TabIndex = 1;
            threshold1.TextAlign = HorizontalAlignment.Center;
            threshold1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // l2gradient
            // 
            l2gradient.AutoSize = true;
            l2gradient.Location = new Point(101, 103);
            l2gradient.Name = "l2gradient";
            l2gradient.Size = new Size(89, 21);
            l2gradient.TabIndex = 2;
            l2gradient.Text = "L2gradient";
            l2gradient.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(199, 18);
            label2.Name = "label2";
            label2.Size = new Size(283, 17);
            label2.TabIndex = 3;
            label2.Text = "The first threshold for the hysteresis procedure";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 47);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 0;
            label3.Text = "threshold2";
            // 
            // threshold2
            // 
            threshold2.DecimalPlaces = 2;
            threshold2.Location = new Point(101, 45);
            threshold2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            threshold2.Name = "threshold2";
            threshold2.Size = new Size(92, 23);
            threshold2.TabIndex = 1;
            threshold2.TextAlign = HorizontalAlignment.Center;
            threshold2.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(199, 47);
            label4.Name = "label4";
            label4.Size = new Size(303, 17);
            label4.TabIndex = 3;
            label4.Text = "The second threshold for the hysteresis procedure";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 76);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 0;
            label5.Text = "apertureSize";
            // 
            // apertureSize
            // 
            apertureSize.Location = new Point(101, 74);
            apertureSize.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            apertureSize.Name = "apertureSize";
            apertureSize.Size = new Size(92, 23);
            apertureSize.TabIndex = 1;
            apertureSize.TextAlign = HorizontalAlignment.Center;
            apertureSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(199, 76);
            label6.Name = "label6";
            label6.Size = new Size(439, 17);
            label6.TabIndex = 3;
            label6.Text = "Aperture size for the Sobel operator [By default this is ApertureSize.Size3]";
            // 
            // label7
            // 
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(199, 104);
            label7.Name = "label7";
            label7.Size = new Size(439, 59);
            label7.TabIndex = 3;
            label7.Text = "Indicates, whether the more accurate L2 norm should be used to compute the image gradient magnitude (true), or a faster default L1 norm is enough (false). [By default this is false]";
            // 
            // ConfigCanny
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 249);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(l2gradient);
            Controls.Add(apertureSize);
            Controls.Add(label5);
            Controls.Add(threshold2);
            Controls.Add(label3);
            Controls.Add(threshold1);
            Controls.Add(label1);
            Name = "ConfigCanny";
            Text = "ConfigCanny";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(threshold1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(threshold2, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(apertureSize, 0);
            Controls.SetChildIndex(l2gradient, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            ((System.ComponentModel.ISupportInitialize)threshold1).EndInit();
            ((System.ComponentModel.ISupportInitialize)threshold2).EndInit();
            ((System.ComponentModel.ISupportInitialize)apertureSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown threshold1;
        private CheckBox l2gradient;
        private Label label2;
        private Label label3;
        private NumericUpDown threshold2;
        private Label label4;
        private Label label5;
        private NumericUpDown apertureSize;
        private Label label6;
        private Label label7;
    }
}