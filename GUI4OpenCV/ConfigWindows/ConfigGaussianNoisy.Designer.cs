namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigGaussianNoisy
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
            mean = new NumericUpDown();
            label3 = new Label();
            stdDev = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)mean).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stdDev).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 34);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "均值";
            // 
            // mean
            // 
            mean.DecimalPlaces = 2;
            mean.Location = new Point(118, 32);
            mean.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            mean.Name = "mean";
            mean.Size = new Size(92, 23);
            mean.TabIndex = 1;
            mean.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 63);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 0;
            label3.Text = "标准差";
            // 
            // stdDev
            // 
            stdDev.DecimalPlaces = 2;
            stdDev.Location = new Point(118, 61);
            stdDev.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            stdDev.Name = "stdDev";
            stdDev.Size = new Size(92, 23);
            stdDev.TabIndex = 1;
            stdDev.TextAlign = HorizontalAlignment.Center;
            stdDev.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ConfigGaussianNoisy
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 172);
            Controls.Add(stdDev);
            Controls.Add(label3);
            Controls.Add(mean);
            Controls.Add(label1);
            Name = "ConfigGaussianNoisy";
            Text = "ConfigGaussianNoisy";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(mean, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(stdDev, 0);
            ((System.ComponentModel.ISupportInitialize)mean).EndInit();
            ((System.ComponentModel.ISupportInitialize)stdDev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown mean;
        private Label label3;
        private NumericUpDown stdDev;
    }
}