namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigGrayToBanary
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
            thresh = new NumericUpDown();
            label2 = new Label();
            maxval = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)thresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxval).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 42);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "thresh";
            // 
            // thresh
            // 
            thresh.Location = new Point(158, 40);
            thresh.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            thresh.Name = "thresh";
            thresh.Size = new Size(92, 23);
            thresh.TabIndex = 1;
            thresh.TextAlign = HorizontalAlignment.Center;
            thresh.Value = new decimal(new int[] { 135, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 42);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 0;
            label2.Text = "maxval";
            // 
            // maxval
            // 
            maxval.Location = new Point(324, 40);
            maxval.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            maxval.Name = "maxval";
            maxval.Size = new Size(92, 23);
            maxval.TabIndex = 1;
            maxval.TextAlign = HorizontalAlignment.Center;
            maxval.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // ConfigGrayToBanary
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 160);
            Controls.Add(maxval);
            Controls.Add(label2);
            Controls.Add(thresh);
            Controls.Add(label1);
            Name = "ConfigGrayToBanary";
            Text = "ConfigGrayToBanary";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(thresh, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(maxval, 0);
            ((System.ComponentModel.ISupportInitialize)thresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown thresh;
        private Label label2;
        private NumericUpDown maxval;
    }
}