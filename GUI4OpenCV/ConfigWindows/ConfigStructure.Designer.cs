namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigStructure
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
            width = new NumericUpDown();
            label2 = new Label();
            height = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)height).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "width";
            // 
            // width
            // 
            width.DecimalPlaces = 2;
            width.Location = new Point(107, 34);
            width.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            width.Name = "width";
            width.Size = new Size(92, 23);
            width.TabIndex = 1;
            width.TextAlign = HorizontalAlignment.Center;
            width.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 36);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 0;
            label2.Text = "height";
            // 
            // height
            // 
            height.DecimalPlaces = 2;
            height.Location = new Point(257, 34);
            height.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            height.Name = "height";
            height.Size = new Size(92, 23);
            height.TabIndex = 1;
            height.TextAlign = HorizontalAlignment.Center;
            height.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ConfigStructure
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 153);
            Controls.Add(height);
            Controls.Add(label2);
            Controls.Add(width);
            Controls.Add(label1);
            Name = "ConfigStructure";
            Text = "ConfigStructure";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(width, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(height, 0);
            ((System.ComponentModel.ISupportInitialize)width).EndInit();
            ((System.ComponentModel.ISupportInitialize)height).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown width;
        private Label label2;
        private NumericUpDown height;
    }
}