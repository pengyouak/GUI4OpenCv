namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigSaltNoisy
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
            r = new NumericUpDown();
            label2 = new Label();
            b = new NumericUpDown();
            label3 = new Label();
            g = new NumericUpDown();
            label4 = new Label();
            noiseCount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)r).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noiseCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 34);
            label1.Name = "label1";
            label1.Size = new Size(16, 17);
            label1.TabIndex = 0;
            label1.Text = "R";
            // 
            // r
            // 
            r.Location = new Point(118, 32);
            r.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            r.Name = "r";
            r.Size = new Size(92, 23);
            r.TabIndex = 1;
            r.TextAlign = HorizontalAlignment.Center;
            r.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 92);
            label2.Name = "label2";
            label2.Size = new Size(16, 17);
            label2.TabIndex = 0;
            label2.Text = "B";
            // 
            // b
            // 
            b.Location = new Point(118, 90);
            b.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            b.Name = "b";
            b.Size = new Size(92, 23);
            b.TabIndex = 1;
            b.TextAlign = HorizontalAlignment.Center;
            b.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 63);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 0;
            label3.Text = "G";
            // 
            // g
            // 
            g.Location = new Point(118, 61);
            g.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            g.Name = "g";
            g.Size = new Size(92, 23);
            g.TabIndex = 1;
            g.TextAlign = HorizontalAlignment.Center;
            g.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 136);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 0;
            label4.Text = "噪点数";
            // 
            // v
            // 
            noiseCount.Location = new Point(118, 134);
            noiseCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            noiseCount.Name = "v";
            noiseCount.Size = new Size(92, 23);
            noiseCount.TabIndex = 1;
            noiseCount.TextAlign = HorizontalAlignment.Center;
            noiseCount.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // ConfigSaltNoisy
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 254);
            Controls.Add(noiseCount);
            Controls.Add(label4);
            Controls.Add(g);
            Controls.Add(label3);
            Controls.Add(b);
            Controls.Add(label2);
            Controls.Add(r);
            Controls.Add(label1);
            Name = "ConfigSaltNoisy";
            Text = "ConfigSaltNoisy";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(r, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(b, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(g, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(noiseCount, 0);
            ((System.ComponentModel.ISupportInitialize)r).EndInit();
            ((System.ComponentModel.ISupportInitialize)b).EndInit();
            ((System.ComponentModel.ISupportInitialize)g).EndInit();
            ((System.ComponentModel.ISupportInitialize)noiseCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown r;
        private Label label2;
        private NumericUpDown b;
        private Label label3;
        private NumericUpDown g;
        private Label label4;
        private NumericUpDown noiseCount;
    }
}