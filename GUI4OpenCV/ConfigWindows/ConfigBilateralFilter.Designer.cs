namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigBilateralFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBilateralFilter));
            label1 = new Label();
            sigmaColor = new NumericUpDown();
            alpha1 = new Label();
            sigmaSpace = new NumericUpDown();
            label2 = new Label();
            d = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)sigmaColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sigmaSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 76);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 0;
            label1.Text = "sigmaColor";
            // 
            // sigmaColor
            // 
            sigmaColor.DecimalPlaces = 2;
            sigmaColor.Location = new Point(139, 74);
            sigmaColor.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sigmaColor.Name = "sigmaColor";
            sigmaColor.Size = new Size(92, 23);
            sigmaColor.TabIndex = 1;
            sigmaColor.TextAlign = HorizontalAlignment.Center;
            sigmaColor.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // alpha1
            // 
            alpha1.AutoSize = true;
            alpha1.Location = new Point(55, 151);
            alpha1.Name = "alpha1";
            alpha1.Size = new Size(78, 17);
            alpha1.TabIndex = 0;
            alpha1.Text = "sigmaSpace";
            // 
            // sigmaSpace
            // 
            sigmaSpace.DecimalPlaces = 2;
            sigmaSpace.Location = new Point(139, 149);
            sigmaSpace.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sigmaSpace.Name = "sigmaSpace";
            sigmaSpace.Size = new Size(92, 23);
            sigmaSpace.TabIndex = 1;
            sigmaSpace.TextAlign = HorizontalAlignment.Center;
            sigmaSpace.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 34);
            label2.Name = "label2";
            label2.Size = new Size(16, 17);
            label2.TabIndex = 0;
            label2.Text = "d";
            // 
            // d
            // 
            d.Location = new Point(139, 32);
            d.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            d.Name = "d";
            d.Size = new Size(92, 23);
            d.TabIndex = 1;
            d.TextAlign = HorizontalAlignment.Center;
            d.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label3
            // 
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(237, 34);
            label3.Name = "label3";
            label3.Size = new Size(283, 36);
            label3.TabIndex = 4;
            label3.Text = "The diameter of each pixel neighborhood, that is used during filtering. \r\nIf it is non-positive, it's computed from sigmaSpace";
            // 
            // label4
            // 
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(237, 74);
            label4.Name = "label4";
            label4.Size = new Size(283, 73);
            label4.TabIndex = 4;
            label4.Text = "Filter sigma in the color space. Larger value of the parameter means that farther colors within the pixel neighborhood will be mixed together, resulting in larger areas of semi-equal color";
            // 
            // label5
            // 
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(237, 149);
            label5.Name = "label5";
            label5.Size = new Size(283, 73);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // ConfigBilateralFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 287);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sigmaSpace);
            Controls.Add(alpha1);
            Controls.Add(d);
            Controls.Add(label2);
            Controls.Add(sigmaColor);
            Controls.Add(label1);
            Name = "ConfigBilateralFilter";
            Text = "ConfigBilateralFilter";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(sigmaColor, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(d, 0);
            Controls.SetChildIndex(alpha1, 0);
            Controls.SetChildIndex(sigmaSpace, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            ((System.ComponentModel.ISupportInitialize)sigmaColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)sigmaSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)d).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown sigmaColor;
        private Label alpha1;
        private NumericUpDown sigmaSpace;
        private Label label2;
        private NumericUpDown d;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}