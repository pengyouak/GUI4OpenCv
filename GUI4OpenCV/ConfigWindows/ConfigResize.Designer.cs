namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigResize
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
            shrinkRate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)shrinkRate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 0;
            label1.Text = "shrinkRate";
            // 
            // shrinkRate
            // 
            shrinkRate.DecimalPlaces = 2;
            shrinkRate.Location = new Point(169, 35);
            shrinkRate.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            shrinkRate.Name = "shrinkRate";
            shrinkRate.Size = new Size(92, 23);
            shrinkRate.TabIndex = 1;
            shrinkRate.TextAlign = HorizontalAlignment.Center;
            shrinkRate.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // ConfigResize
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 153);
            Controls.Add(shrinkRate);
            Controls.Add(label1);
            Name = "ConfigResize";
            Text = "ConfigShrink";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(shrinkRate, 0);
            ((System.ComponentModel.ISupportInitialize)shrinkRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown shrinkRate;
    }
}