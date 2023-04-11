namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigKrisch
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
            delta = new NumericUpDown();
            alpha1 = new Label();
            alpha = new NumericUpDown();
            beta1 = new Label();
            beta = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)delta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 49);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "delta(Filter2D)";
            // 
            // delta
            // 
            delta.DecimalPlaces = 2;
            delta.Location = new Point(206, 47);
            delta.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            delta.Name = "delta";
            delta.Size = new Size(92, 23);
            delta.TabIndex = 1;
            delta.TextAlign = HorizontalAlignment.Center;
            // 
            // alpha1
            // 
            alpha1.AutoSize = true;
            alpha1.Location = new Point(72, 78);
            alpha1.Name = "alpha1";
            alpha1.Size = new Size(128, 17);
            alpha1.TabIndex = 0;
            alpha1.Text = "alpha(AddWeighted)";
            // 
            // alpha
            // 
            alpha.DecimalPlaces = 2;
            alpha.Location = new Point(206, 76);
            alpha.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            alpha.Name = "alpha";
            alpha.Size = new Size(92, 23);
            alpha.TabIndex = 1;
            alpha.TextAlign = HorizontalAlignment.Center;
            alpha.Value = new decimal(new int[] { 8, 0, 0, 65536 });
            // 
            // beta1
            // 
            beta1.AutoSize = true;
            beta1.Location = new Point(78, 107);
            beta1.Name = "beta1";
            beta1.Size = new Size(122, 17);
            beta1.TabIndex = 0;
            beta1.Text = "beta(AddWeighted)";
            // 
            // beta
            // 
            beta.DecimalPlaces = 2;
            beta.Location = new Point(206, 105);
            beta.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            beta.Name = "beta";
            beta.Size = new Size(92, 23);
            beta.TabIndex = 1;
            beta.TextAlign = HorizontalAlignment.Center;
            beta.Value = new decimal(new int[] { 6, 0, 0, 65536 });
            // 
            // ConfigKrisch
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 230);
            Controls.Add(beta);
            Controls.Add(beta1);
            Controls.Add(alpha);
            Controls.Add(alpha1);
            Controls.Add(delta);
            Controls.Add(label1);
            Name = "ConfigKrisch";
            Text = "ConfigKrisch";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(delta, 0);
            Controls.SetChildIndex(alpha1, 0);
            Controls.SetChildIndex(alpha, 0);
            Controls.SetChildIndex(beta1, 0);
            Controls.SetChildIndex(beta, 0);
            ((System.ComponentModel.ISupportInitialize)delta).EndInit();
            ((System.ComponentModel.ISupportInitialize)alpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)beta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown delta;
        private Label alpha1;
        private NumericUpDown alpha;
        private Label beta1;
        private NumericUpDown beta;
    }
}