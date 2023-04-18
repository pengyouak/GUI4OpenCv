namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigWatershed
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
            alpha = new NumericUpDown();
            beta = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            thresh = new NumericUpDown();
            maxval = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)alpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxval).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 1;
            label1.Text = "alpha";
            // 
            // alpha
            // 
            alpha.DecimalPlaces = 2;
            alpha.Location = new Point(91, 27);
            alpha.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            alpha.Name = "alpha";
            alpha.Size = new Size(90, 23);
            alpha.TabIndex = 2;
            // 
            // beta
            // 
            beta.DecimalPlaces = 2;
            beta.Location = new Point(91, 74);
            beta.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            beta.Name = "beta";
            beta.Size = new Size(90, 23);
            beta.TabIndex = 2;
            beta.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 1;
            label2.Text = "beta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 128);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 1;
            label3.Text = "thresh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 156);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 1;
            label4.Text = "maxval";
            // 
            // thresh
            // 
            thresh.DecimalPlaces = 2;
            thresh.Location = new Point(91, 125);
            thresh.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            thresh.Name = "thresh";
            thresh.Size = new Size(90, 23);
            thresh.TabIndex = 2;
            thresh.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // maxval
            // 
            maxval.DecimalPlaces = 2;
            maxval.Location = new Point(91, 154);
            maxval.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            maxval.Name = "maxval";
            maxval.Size = new Size(90, 23);
            maxval.TabIndex = 2;
            maxval.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label5
            // 
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(187, 30);
            label5.Name = "label5";
            label5.Size = new Size(395, 45);
            label5.TabIndex = 1;
            label5.Text = "The norm value to normalize to or the lower range boundary in the case of range normalization";
            // 
            // label6
            // 
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(187, 74);
            label6.Name = "label6";
            label6.Size = new Size(395, 45);
            label6.TabIndex = 1;
            label6.Text = "The upper range boundary in the case of range normalization; not used for norm normalization";
            // 
            // label7
            // 
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(187, 125);
            label7.Name = "label7";
            label7.Size = new Size(395, 23);
            label7.TabIndex = 1;
            label7.Text = "threshold value.";
            // 
            // label8
            // 
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(187, 154);
            label8.Name = "label8";
            label8.Size = new Size(395, 41);
            label8.TabIndex = 1;
            label8.Text = "maximum value to use with the THRESH_BINARY and THRESH_BINARY_INV thresholding types";
            // 
            // ConfigWatershed
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 273);
            Controls.Add(maxval);
            Controls.Add(beta);
            Controls.Add(thresh);
            Controls.Add(label4);
            Controls.Add(alpha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "ConfigWatershed";
            Text = "ConfigWatershed";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(alpha, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(thresh, 0);
            Controls.SetChildIndex(beta, 0);
            Controls.SetChildIndex(maxval, 0);
            ((System.ComponentModel.ISupportInitialize)alpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)beta).EndInit();
            ((System.ComponentModel.ISupportInitialize)thresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown alpha;
        private NumericUpDown beta;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown thresh;
        private NumericUpDown maxval;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}