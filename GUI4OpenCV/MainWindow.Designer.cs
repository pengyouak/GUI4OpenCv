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
            table = new TableLayoutPanel();
            picTopLeft = new PictureBox();
            plOperates = new Panel();
            btnPrewitt = new Button();
            btnLaplace = new Button();
            btnSobel = new Button();
            btnRoberts = new Button();
            btnCanny = new Button();
            btnSelectImage = new Button();
            label2 = new Label();
            label1 = new Label();
            btnKrisch = new Button();
            plImages.SuspendLayout();
            table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLeft).BeginInit();
            plOperates.SuspendLayout();
            SuspendLayout();
            // 
            // plImages
            // 
            plImages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plImages.BackColor = SystemColors.WindowFrame;
            plImages.Controls.Add(table);
            plImages.Location = new Point(12, 12);
            plImages.Name = "plImages";
            plImages.Padding = new Padding(1);
            plImages.Size = new Size(779, 757);
            plImages.TabIndex = 0;
            // 
            // table
            // 
            table.BackColor = Color.White;
            table.ColumnCount = 2;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.Controls.Add(picTopLeft, 0, 0);
            table.Dock = DockStyle.Fill;
            table.Location = new Point(1, 1);
            table.Name = "table";
            table.Padding = new Padding(6);
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.Size = new Size(777, 755);
            table.TabIndex = 0;
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
            // plOperates
            // 
            plOperates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            plOperates.BorderStyle = BorderStyle.FixedSingle;
            plOperates.Controls.Add(btnKrisch);
            plOperates.Controls.Add(btnPrewitt);
            plOperates.Controls.Add(btnLaplace);
            plOperates.Controls.Add(btnSobel);
            plOperates.Controls.Add(btnRoberts);
            plOperates.Controls.Add(btnCanny);
            plOperates.Controls.Add(btnSelectImage);
            plOperates.Controls.Add(label2);
            plOperates.Controls.Add(label1);
            plOperates.Location = new Point(797, 12);
            plOperates.Name = "plOperates";
            plOperates.Size = new Size(595, 757);
            plOperates.TabIndex = 1;
            // 
            // btnPrewitt
            // 
            btnPrewitt.Location = new Point(187, 180);
            btnPrewitt.Name = "btnPrewitt";
            btnPrewitt.Size = new Size(131, 29);
            btnPrewitt.TabIndex = 1;
            btnPrewitt.Text = "Prewitt";
            btnPrewitt.UseVisualStyleBackColor = true;
            btnPrewitt.Click += btnPrewitt_Click;
            // 
            // btnLaplace
            // 
            btnLaplace.Location = new Point(187, 145);
            btnLaplace.Name = "btnLaplace";
            btnLaplace.Size = new Size(131, 29);
            btnLaplace.TabIndex = 1;
            btnLaplace.Text = "Laplace";
            btnLaplace.UseVisualStyleBackColor = true;
            btnLaplace.Click += btnLaplace_Click;
            // 
            // btnSobel
            // 
            btnSobel.Location = new Point(187, 110);
            btnSobel.Name = "btnSobel";
            btnSobel.Size = new Size(131, 29);
            btnSobel.TabIndex = 1;
            btnSobel.Text = "Sobel";
            btnSobel.UseVisualStyleBackColor = true;
            btnSobel.Click += btnSobel_Click;
            // 
            // btnRoberts
            // 
            btnRoberts.Location = new Point(187, 75);
            btnRoberts.Name = "btnRoberts";
            btnRoberts.Size = new Size(131, 29);
            btnRoberts.TabIndex = 1;
            btnRoberts.Text = "Roberts";
            btnRoberts.UseVisualStyleBackColor = true;
            btnRoberts.Click += btnRoberts_Click;
            // 
            // btnCanny
            // 
            btnCanny.Location = new Point(187, 40);
            btnCanny.Name = "btnCanny";
            btnCanny.Size = new Size(131, 29);
            btnCanny.TabIndex = 1;
            btnCanny.Text = "Canny";
            btnCanny.UseVisualStyleBackColor = true;
            btnCanny.Click += btnCanny_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 0;
            label2.Text = "边缘检测";
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
            // btnKrisch
            // 
            btnKrisch.Location = new Point(187, 215);
            btnKrisch.Name = "btnKrisch";
            btnKrisch.Size = new Size(131, 29);
            btnKrisch.TabIndex = 1;
            btnKrisch.Text = "Krisch";
            btnKrisch.UseVisualStyleBackColor = true;
            btnKrisch.Click += btnKrisch_Click;
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
            table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTopLeft).EndInit();
            plOperates.ResumeLayout(false);
            plOperates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plImages;
        private TableLayoutPanel table;
        private Panel plOperates;
        private Button btnSelectImage;
        private Label label1;
        private Button btnCanny;
        private Label label2;
        private Button btnRoberts;
        private Button btnSobel;
        private Button btnLaplace;
        private Button btnPrewitt;
        private PictureBox picTopLeft;
        private Button btnKrisch;
    }
}