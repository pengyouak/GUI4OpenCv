namespace GUI4OpenCV.ConfigWindows
{
    partial class ConfigOverTurn
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
            rbtnLR = new RadioButton();
            rbtnTB = new RadioButton();
            SuspendLayout();
            // 
            // rbtnLR
            // 
            rbtnLR.AutoSize = true;
            rbtnLR.Checked = true;
            rbtnLR.Location = new Point(107, 34);
            rbtnLR.Name = "rbtnLR";
            rbtnLR.Size = new Size(50, 21);
            rbtnLR.TabIndex = 3;
            rbtnLR.TabStop = true;
            rbtnLR.Text = "左右";
            rbtnLR.UseVisualStyleBackColor = true;
            rbtnLR.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtnTB
            // 
            rbtnTB.AutoSize = true;
            rbtnTB.Location = new Point(192, 34);
            rbtnTB.Name = "rbtnTB";
            rbtnTB.Size = new Size(50, 21);
            rbtnTB.TabIndex = 3;
            rbtnTB.Text = "上下";
            rbtnTB.UseVisualStyleBackColor = true;
            rbtnTB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // ConfigOverTurn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 149);
            Controls.Add(rbtnTB);
            Controls.Add(rbtnLR);
            Name = "ConfigOverTurn";
            Text = "ConfigOverTurn";
            Controls.SetChildIndex(rbtnLR, 0);
            Controls.SetChildIndex(rbtnTB, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtnLR;
        private RadioButton rbtnTB;
    }
}