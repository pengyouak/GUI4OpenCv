namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigGaussianBlur
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
            label2 = new Label();
            sigmaX = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ksize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sigmaX).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "KSize";
            // 
            // ksize
            // 
            ksize.Location = new Point(103, 35);
            ksize.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ksize.Name = "ksize";
            ksize.Size = new Size(92, 23);
            ksize.TabIndex = 1;
            ksize.TextAlign = HorizontalAlignment.Center;
            ksize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 37);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 0;
            label2.Text = "sigmaX";
            // 
            // sigmaX
            // 
            sigmaX.Location = new Point(267, 35);
            sigmaX.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sigmaX.Name = "sigmaX";
            sigmaX.Size = new Size(92, 23);
            sigmaX.TabIndex = 1;
            sigmaX.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfigGaussianBlur
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 153);
            Controls.Add(sigmaX);
            Controls.Add(label2);
            Controls.Add(ksize);
            Controls.Add(label1);
            Name = "ConfigGaussianBlur";
            Text = "ConfigOpaque";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ksize, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(sigmaX, 0);
            ((System.ComponentModel.ISupportInitialize)ksize).EndInit();
            ((System.ComponentModel.ISupportInitialize)sigmaX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown ksize;
        private Label label2;
        private NumericUpDown sigmaX;
    }
}