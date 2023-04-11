namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigBlur
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
            nwidth = new NumericUpDown();
            alpha1 = new Label();
            nheight = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nwidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nheight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "width";
            // 
            // nwidth
            // 
            nwidth.Location = new Point(100, 32);
            nwidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nwidth.Name = "nwidth";
            nwidth.Size = new Size(92, 23);
            nwidth.TabIndex = 1;
            nwidth.TextAlign = HorizontalAlignment.Center;
            nwidth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // alpha1
            // 
            alpha1.AutoSize = true;
            alpha1.Location = new Point(201, 34);
            alpha1.Name = "alpha1";
            alpha1.Size = new Size(44, 17);
            alpha1.TabIndex = 0;
            alpha1.Text = "height";
            // 
            // nheight
            // 
            nheight.Location = new Point(251, 32);
            nheight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nheight.Name = "nheight";
            nheight.Size = new Size(92, 23);
            nheight.TabIndex = 1;
            nheight.TextAlign = HorizontalAlignment.Center;
            nheight.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // ConfigBlur
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 153);
            Controls.Add(nheight);
            Controls.Add(alpha1);
            Controls.Add(nwidth);
            Controls.Add(label1);
            Name = "ConfigBlur";
            Text = "ConfigBlur";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(nwidth, 0);
            Controls.SetChildIndex(alpha1, 0);
            Controls.SetChildIndex(nheight, 0);
            ((System.ComponentModel.ISupportInitialize)nwidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nheight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nwidth;
        private Label alpha1;
        private NumericUpDown nheight;
    }
}