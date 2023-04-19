namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigGrabcuts
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
            itercount = new NumericUpDown();
            x = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            y = new NumericUpDown();
            label4 = new Label();
            width = new NumericUpDown();
            height = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)itercount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)height).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 1;
            label1.Text = "itercount";
            // 
            // itercount
            // 
            itercount.DecimalPlaces = 2;
            itercount.Location = new Point(91, 27);
            itercount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            itercount.Name = "itercount";
            itercount.Size = new Size(90, 23);
            itercount.TabIndex = 2;
            itercount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // x
            // 
            x.Location = new Point(91, 128);
            x.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            x.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            x.Name = "x";
            x.Size = new Size(74, 23);
            x.TabIndex = 2;
            x.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "检测区域";
            // 
            // label5
            // 
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(187, 30);
            label5.Name = "label5";
            label5.Size = new Size(395, 65);
            label5.TabIndex = 1;
            label5.Text = "Number of iterations the algorithm should make before returning the result. Note that the result can be refined with further calls with mode==GC_INIT_WITH_MASK or mode==GC_EVAL .";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 130);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 1;
            label3.Text = "起点";
            // 
            // y
            // 
            y.Location = new Point(171, 128);
            y.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            y.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            y.Name = "y";
            y.Size = new Size(74, 23);
            y.TabIndex = 2;
            y.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 130);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 1;
            label4.Text = "终点";
            // 
            // width
            // 
            width.Location = new Point(318, 128);
            width.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            width.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            width.Name = "width";
            width.Size = new Size(74, 23);
            width.TabIndex = 2;
            width.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // height
            // 
            height.Location = new Point(398, 128);
            height.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            height.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            height.Name = "height";
            height.Size = new Size(74, 23);
            height.TabIndex = 2;
            height.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // ConfigGrabcuts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 243);
            Controls.Add(height);
            Controls.Add(width);
            Controls.Add(y);
            Controls.Add(x);
            Controls.Add(label4);
            Controls.Add(itercount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "ConfigGrabcuts";
            Text = "ConfigGrabcuts";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(itercount, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(x, 0);
            Controls.SetChildIndex(y, 0);
            Controls.SetChildIndex(width, 0);
            Controls.SetChildIndex(height, 0);
            ((System.ComponentModel.ISupportInitialize)itercount).EndInit();
            ((System.ComponentModel.ISupportInitialize)x).EndInit();
            ((System.ComponentModel.ISupportInitialize)y).EndInit();
            ((System.ComponentModel.ISupportInitialize)width).EndInit();
            ((System.ComponentModel.ISupportInitialize)height).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown itercount;
        private NumericUpDown x;
        private Label label2;
        private Label label5;
        private Label label3;
        private NumericUpDown y;
        private Label label4;
        private NumericUpDown width;
        private NumericUpDown height;
    }
}