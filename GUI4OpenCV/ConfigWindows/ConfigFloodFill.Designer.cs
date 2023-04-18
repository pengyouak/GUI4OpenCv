namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigFloodFill
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
            v = new NumericUpDown();
            label2 = new Label();
            g = new NumericUpDown();
            label3 = new Label();
            b = new NumericUpDown();
            label1 = new Label();
            r = new NumericUpDown();
            label4 = new Label();
            y1 = new NumericUpDown();
            x1 = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)v).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x1).BeginInit();
            SuspendLayout();
            // 
            // v
            // 
            v.DecimalPlaces = 2;
            v.Location = new Point(129, 171);
            v.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            v.Name = "v";
            v.Size = new Size(125, 23);
            v.TabIndex = 2;
            v.TextAlign = HorizontalAlignment.Center;
            v.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 174);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "阈值";
            // 
            // g
            // 
            g.Location = new Point(129, 99);
            g.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            g.Name = "g";
            g.Size = new Size(127, 23);
            g.TabIndex = 6;
            g.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 101);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 3;
            label3.Text = "G";
            // 
            // b
            // 
            b.Location = new Point(129, 128);
            b.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            b.Name = "b";
            b.Size = new Size(127, 23);
            b.TabIndex = 7;
            b.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 130);
            label1.Name = "label1";
            label1.Size = new Size(16, 17);
            label1.TabIndex = 4;
            label1.Text = "B";
            // 
            // r
            // 
            r.Location = new Point(129, 70);
            r.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            r.Name = "r";
            r.Size = new Size(127, 23);
            r.TabIndex = 8;
            r.TextAlign = HorizontalAlignment.Center;
            r.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 72);
            label4.Name = "label4";
            label4.Size = new Size(16, 17);
            label4.TabIndex = 5;
            label4.Text = "R";
            // 
            // y1
            // 
            y1.Location = new Point(196, 35);
            y1.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            y1.Name = "y1";
            y1.Size = new Size(60, 23);
            y1.TabIndex = 11;
            y1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // x1
            // 
            x1.Location = new Point(130, 35);
            x1.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            x1.Name = "x1";
            x1.Size = new Size(60, 23);
            x1.TabIndex = 10;
            x1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 37);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 9;
            label5.Text = "起点";
            // 
            // ConfigFloodFill
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 276);
            Controls.Add(y1);
            Controls.Add(x1);
            Controls.Add(label5);
            Controls.Add(g);
            Controls.Add(label3);
            Controls.Add(b);
            Controls.Add(label1);
            Controls.Add(r);
            Controls.Add(label4);
            Controls.Add(v);
            Controls.Add(label2);
            Name = "ConfigFloodFill";
            Text = "ConfigFloodFill";
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(v, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(r, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(b, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(g, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(x1, 0);
            Controls.SetChildIndex(y1, 0);
            ((System.ComponentModel.ISupportInitialize)v).EndInit();
            ((System.ComponentModel.ISupportInitialize)g).EndInit();
            ((System.ComponentModel.ISupportInitialize)b).EndInit();
            ((System.ComponentModel.ISupportInitialize)r).EndInit();
            ((System.ComponentModel.ISupportInitialize)y1).EndInit();
            ((System.ComponentModel.ISupportInitialize)x1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown v;
        private Label label2;
        private NumericUpDown g;
        private Label label3;
        private NumericUpDown b;
        private Label label1;
        private NumericUpDown r;
        private Label label4;
        private NumericUpDown y1;
        private NumericUpDown x1;
        private Label label5;
    }
}