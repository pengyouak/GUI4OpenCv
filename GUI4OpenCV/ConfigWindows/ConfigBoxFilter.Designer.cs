namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigBoxFilter
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
            ksize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ksize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "KSize";
            // 
            // ksize
            // 
            ksize.Location = new Point(169, 35);
            ksize.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ksize.Name = "ksize";
            ksize.Size = new Size(92, 23);
            ksize.TabIndex = 1;
            ksize.TextAlign = HorizontalAlignment.Center;
            ksize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // ConfigBoxFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 153);
            Controls.Add(ksize);
            Controls.Add(label1);
            Name = "ConfigBoxFilter";
            Text = "ConfigBoxFilter";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ksize, 0);
            ((System.ComponentModel.ISupportInitialize)ksize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown ksize;
    }
}