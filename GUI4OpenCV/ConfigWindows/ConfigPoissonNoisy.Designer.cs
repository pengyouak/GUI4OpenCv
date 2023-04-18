namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigPoissonNoisy
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
            label3 = new Label();
            stdDev = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)stdDev).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 46);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 0;
            label3.Text = "标准差";
            // 
            // stdDev
            // 
            stdDev.DecimalPlaces = 2;
            stdDev.Location = new Point(114, 44);
            stdDev.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            stdDev.Name = "stdDev";
            stdDev.Size = new Size(92, 23);
            stdDev.TabIndex = 1;
            stdDev.TextAlign = HorizontalAlignment.Center;
            stdDev.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ConfigPoissonNoisy
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 172);
            Controls.Add(stdDev);
            Controls.Add(label3);
            Name = "ConfigPoissonNoisy";
            Text = "ConfigPoissonNoisy";
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(stdDev, 0);
            ((System.ComponentModel.ISupportInitialize)stdDev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private NumericUpDown stdDev;
    }
}