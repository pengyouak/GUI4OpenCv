namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigTranslation
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
            ((System.ComponentModel.ISupportInitialize)x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 36);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 1;
            label1.Text = "水平平移距离";
            // 
            // x
            // 
            x.Location = new Point(176, 32);
            x.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            x.Minimum = new decimal(new int[] { 2048, 0, 0, int.MinValue });
            x.Name = "x";
            x.Size = new Size(90, 23);
            x.TabIndex = 2;
            x.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // y
            // 
            y.Location = new Point(176, 61);
            y.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            y.Minimum = new decimal(new int[] { 2048, 0, 0, int.MinValue });
            y.Name = "y";
            y.Size = new Size(90, 23);
            y.TabIndex = 2;
            y.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "垂直平移距离";
            // 
            // ConfigTranslation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 177);
            Controls.Add(y);
            Controls.Add(x);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConfigTranslation";
            Text = "ConfigTranslation";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(x, 0);
            Controls.SetChildIndex(y, 0);
            ((System.ComponentModel.ISupportInitialize)x).EndInit();
            ((System.ComponentModel.ISupportInitialize)y).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown x;
        private NumericUpDown y;
        private Label label2;
    }
}