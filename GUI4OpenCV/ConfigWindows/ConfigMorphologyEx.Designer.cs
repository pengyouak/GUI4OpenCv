namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigMorphologyEx
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
            cboMorphTypes = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 0;
            label1.Text = "MorphTypes";
            // 
            // cboMorphTypes
            // 
            cboMorphTypes.FormattingEnabled = true;
            cboMorphTypes.Location = new Point(144, 29);
            cboMorphTypes.Name = "cboMorphTypes";
            cboMorphTypes.Size = new Size(110, 25);
            cboMorphTypes.TabIndex = 1;
            // 
            // ConfigMorphologyEx
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 140);
            Controls.Add(cboMorphTypes);
            Controls.Add(label1);
            Name = "ConfigMorphologyEx";
            Text = "ConfigMorphologyEx";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(cboMorphTypes, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboMorphTypes;
    }
}