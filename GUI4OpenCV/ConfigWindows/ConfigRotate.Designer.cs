namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigRotate
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
            x = new NumericUpDown();
            y = new NumericUpDown();
            label2 = new Label();
            angle = new NumericUpDown();
            label3 = new Label();
            scale = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)angle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scale).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 32);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 1;
            label1.Text = "中心点坐标";
            // 
            // x
            // 
            x.Location = new Point(176, 30);
            x.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            x.Minimum = new decimal(new int[] { 2048, 0, 0, int.MinValue });
            x.Name = "x";
            x.Size = new Size(52, 23);
            x.TabIndex = 2;
            // 
            // y
            // 
            y.Location = new Point(234, 30);
            y.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            y.Minimum = new decimal(new int[] { 2048, 0, 0, int.MinValue });
            y.Name = "y";
            y.Size = new Size(52, 23);
            y.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "旋转角度";
            // 
            // angle
            // 
            angle.DecimalPlaces = 2;
            angle.Location = new Point(175, 59);
            angle.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            angle.Name = "angle";
            angle.Size = new Size(111, 23);
            angle.TabIndex = 2;
            angle.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 90);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 1;
            label3.Text = "系数";
            // 
            // scale
            // 
            scale.DecimalPlaces = 2;
            scale.Location = new Point(176, 88);
            scale.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            scale.Name = "scale";
            scale.Size = new Size(111, 23);
            scale.TabIndex = 2;
            scale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ConfigRotate
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 190);
            Controls.Add(y);
            Controls.Add(scale);
            Controls.Add(angle);
            Controls.Add(label3);
            Controls.Add(x);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConfigRotate";
            Text = "ConfigRotate";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(x, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(angle, 0);
            Controls.SetChildIndex(scale, 0);
            Controls.SetChildIndex(y, 0);
            ((System.ComponentModel.ISupportInitialize)x).EndInit();
            ((System.ComponentModel.ISupportInitialize)y).EndInit();
            ((System.ComponentModel.ISupportInitialize)angle).EndInit();
            ((System.ComponentModel.ISupportInitialize)scale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown x;
        private NumericUpDown y;
        private Label label2;
        private NumericUpDown angle;
        private Label label3;
        private NumericUpDown scale;
    }
}