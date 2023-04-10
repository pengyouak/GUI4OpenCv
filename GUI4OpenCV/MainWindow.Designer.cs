namespace GUI4OpenCV
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plImages = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            picTopLeft = new PictureBox();
            picTopRight = new PictureBox();
            picBottomLeft = new PictureBox();
            picBottomRight = new PictureBox();
            plOperates = new Panel();
            btnSelectImage = new Button();
            label1 = new Label();
            btnCanny = new Button();
            label2 = new Label();
            plImages.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTopRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBottomLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBottomRight).BeginInit();
            plOperates.SuspendLayout();
            SuspendLayout();
            // 
            // plImages
            // 
            plImages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            plImages.BackColor = SystemColors.WindowFrame;
            plImages.Controls.Add(tableLayoutPanel1);
            plImages.Location = new Point(12, 12);
            plImages.Name = "plImages";
            plImages.Padding = new Padding(1);
            plImages.Size = new Size(779, 757);
            plImages.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(picTopLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(picTopRight, 1, 0);
            tableLayoutPanel1.Controls.Add(picBottomLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(picBottomRight, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(6);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(777, 755);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picTopLeft
            // 
            picTopLeft.Dock = DockStyle.Fill;
            picTopLeft.Location = new Point(9, 9);
            picTopLeft.Name = "picTopLeft";
            picTopLeft.Size = new Size(376, 365);
            picTopLeft.SizeMode = PictureBoxSizeMode.CenterImage;
            picTopLeft.TabIndex = 0;
            picTopLeft.TabStop = false;
            // 
            // picTopRight
            // 
            picTopRight.Dock = DockStyle.Fill;
            picTopRight.Location = new Point(391, 9);
            picTopRight.Name = "picTopRight";
            picTopRight.Size = new Size(377, 365);
            picTopRight.SizeMode = PictureBoxSizeMode.CenterImage;
            picTopRight.TabIndex = 0;
            picTopRight.TabStop = false;
            // 
            // picBottomLeft
            // 
            picBottomLeft.Dock = DockStyle.Fill;
            picBottomLeft.Location = new Point(9, 380);
            picBottomLeft.Name = "picBottomLeft";
            picBottomLeft.Size = new Size(376, 366);
            picBottomLeft.SizeMode = PictureBoxSizeMode.CenterImage;
            picBottomLeft.TabIndex = 0;
            picBottomLeft.TabStop = false;
            // 
            // picBottomRight
            // 
            picBottomRight.Dock = DockStyle.Fill;
            picBottomRight.Location = new Point(391, 380);
            picBottomRight.Name = "picBottomRight";
            picBottomRight.Size = new Size(377, 366);
            picBottomRight.SizeMode = PictureBoxSizeMode.CenterImage;
            picBottomRight.TabIndex = 0;
            picBottomRight.TabStop = false;
            // 
            // plOperates
            // 
            plOperates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plOperates.BorderStyle = BorderStyle.FixedSingle;
            plOperates.Controls.Add(btnCanny);
            plOperates.Controls.Add(btnSelectImage);
            plOperates.Controls.Add(label2);
            plOperates.Controls.Add(label1);
            plOperates.Location = new Point(797, 12);
            plOperates.Name = "plOperates";
            plOperates.Size = new Size(595, 757);
            plOperates.TabIndex = 1;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(27, 40);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(131, 29);
            btnSelectImage.TabIndex = 1;
            btnSelectImage.Text = "选择图像";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnCanny
            // 
            btnCanny.Location = new Point(187, 40);
            btnCanny.Name = "btnCanny";
            btnCanny.Size = new Size(131, 29);
            btnCanny.TabIndex = 1;
            btnCanny.Text = "边缘检测";
            btnCanny.UseVisualStyleBackColor = true;
            btnCanny.Click += btnCanny_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1404, 781);
            Controls.Add(plOperates);
            Controls.Add(plImages);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            plImages.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTopLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTopRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBottomLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBottomRight).EndInit();
            plOperates.ResumeLayout(false);
            plOperates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plImages;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picTopLeft;
        private PictureBox picTopRight;
        private PictureBox picBottomLeft;
        private PictureBox picBottomRight;
        private Panel plOperates;
        private Button btnSelectImage;
        private Label label1;
        private Button btnCanny;
        private Label label2;
    }
}