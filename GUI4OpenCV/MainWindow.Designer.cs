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
            components = new System.ComponentModel.Container();
            plImages = new Panel();
            table = new TableLayoutPanel();
            picTopLeft = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnuSaveAs = new ToolStripMenuItem();
            mnuBig = new ToolStripMenuItem();
            plOperates = new Panel();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnKrisch = new Button();
            btnPrewitt = new Button();
            btnLaplace = new Button();
            btnSobel = new Button();
            btnRoberts = new Button();
            btnMorphologyEx = new Button();
            btnBoxFilter = new Button();
            btnGaussianBlur = new Button();
            btnOpaque = new Button();
            btnBilateralFilter = new Button();
            btnMedianBlur = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            btnRevert = new Button();
            btnDenoise = new Button();
            button11 = new Button();
            btnHSV = new Button();
            btnImgRepair = new Button();
            btnHoughLinTransferCurve = new Button();
            btnHoughLineTransfer = new Button();
            btnBlur = new Button();
            btnCanny = new Button();
            btnStructure = new Button();
            btnPerspective = new Button();
            btnAffine = new Button();
            btnTranslation = new Button();
            btnRotate = new Button();
            btnOverturn = new Button();
            btnShrink = new Button();
            btnBanary = new Button();
            btnEqualHist = new Button();
            btnSaltNoisy = new Button();
            btnGryHist = new Button();
            btnGry = new Button();
            btnRestore = new Button();
            btnSelectImage = new Button();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label1 = new Label();
            btnGaussianNoisy = new Button();
            plImages.SuspendLayout();
            table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLeft).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            plImages.Size = new Size(853, 757);
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
            table.Size = new Size(851, 755);
            table.TabIndex = 0;
            // 
            // picTopLeft
            // 
            picTopLeft.ContextMenuStrip = contextMenuStrip1;
            picTopLeft.Dock = DockStyle.Fill;
            picTopLeft.Location = new Point(9, 9);
            picTopLeft.Name = "picTopLeft";
            picTopLeft.Size = new Size(413, 365);
            picTopLeft.SizeMode = PictureBoxSizeMode.Zoom;
            picTopLeft.TabIndex = 0;
            picTopLeft.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnuSaveAs, mnuBig });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(137, 48);
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.Size = new Size(136, 22);
            mnuSaveAs.Text = "图像另存为";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // mnuBig
            // 
            mnuBig.Name = "mnuBig";
            mnuBig.Size = new Size(136, 22);
            mnuBig.Text = "放大显示";
            mnuBig.Click += mnuBig_Click;
            // 
            // plOperates
            // 
            plOperates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            plOperates.BorderStyle = BorderStyle.FixedSingle;
            plOperates.Controls.Add(label6);
            plOperates.Controls.Add(label7);
            plOperates.Controls.Add(label4);
            plOperates.Controls.Add(label3);
            plOperates.Controls.Add(btnKrisch);
            plOperates.Controls.Add(btnPrewitt);
            plOperates.Controls.Add(btnLaplace);
            plOperates.Controls.Add(btnSobel);
            plOperates.Controls.Add(btnRoberts);
            plOperates.Controls.Add(btnMorphologyEx);
            plOperates.Controls.Add(btnBoxFilter);
            plOperates.Controls.Add(btnGaussianBlur);
            plOperates.Controls.Add(btnOpaque);
            plOperates.Controls.Add(btnBilateralFilter);
            plOperates.Controls.Add(btnMedianBlur);
            plOperates.Controls.Add(button14);
            plOperates.Controls.Add(button13);
            plOperates.Controls.Add(button12);
            plOperates.Controls.Add(btnRevert);
            plOperates.Controls.Add(btnDenoise);
            plOperates.Controls.Add(button11);
            plOperates.Controls.Add(btnHSV);
            plOperates.Controls.Add(btnImgRepair);
            plOperates.Controls.Add(btnHoughLinTransferCurve);
            plOperates.Controls.Add(btnHoughLineTransfer);
            plOperates.Controls.Add(btnBlur);
            plOperates.Controls.Add(btnCanny);
            plOperates.Controls.Add(btnStructure);
            plOperates.Controls.Add(btnPerspective);
            plOperates.Controls.Add(btnAffine);
            plOperates.Controls.Add(btnTranslation);
            plOperates.Controls.Add(btnRotate);
            plOperates.Controls.Add(btnOverturn);
            plOperates.Controls.Add(btnShrink);
            plOperates.Controls.Add(btnBanary);
            plOperates.Controls.Add(btnEqualHist);
            plOperates.Controls.Add(btnGaussianNoisy);
            plOperates.Controls.Add(btnSaltNoisy);
            plOperates.Controls.Add(btnGryHist);
            plOperates.Controls.Add(btnGry);
            plOperates.Controls.Add(btnRestore);
            plOperates.Controls.Add(btnSelectImage);
            plOperates.Controls.Add(label2);
            plOperates.Controls.Add(label9);
            plOperates.Controls.Add(label8);
            plOperates.Controls.Add(label5);
            plOperates.Controls.Add(label1);
            plOperates.Location = new Point(871, 12);
            plOperates.Name = "plOperates";
            plOperates.Size = new Size(636, 757);
            plOperates.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(374, 289);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 0;
            label6.Text = "噪声";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(58, 325);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 0;
            label7.Text = "图像曲线";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(508, 10);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 2;
            label4.Text = "图像变换";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(374, 10);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 2;
            label3.Text = "滤波";
            // 
            // btnKrisch
            // 
            btnKrisch.Location = new Point(175, 215);
            btnKrisch.Name = "btnKrisch";
            btnKrisch.Size = new Size(131, 29);
            btnKrisch.TabIndex = 1;
            btnKrisch.Text = "Krisch算子";
            btnKrisch.UseVisualStyleBackColor = true;
            btnKrisch.Click += btnKrisch_Click;
            // 
            // btnPrewitt
            // 
            btnPrewitt.Location = new Point(175, 180);
            btnPrewitt.Name = "btnPrewitt";
            btnPrewitt.Size = new Size(131, 29);
            btnPrewitt.TabIndex = 1;
            btnPrewitt.Text = "Prewitt算子";
            btnPrewitt.UseVisualStyleBackColor = true;
            btnPrewitt.Click += btnPrewitt_Click;
            // 
            // btnLaplace
            // 
            btnLaplace.Location = new Point(175, 145);
            btnLaplace.Name = "btnLaplace";
            btnLaplace.Size = new Size(131, 29);
            btnLaplace.TabIndex = 1;
            btnLaplace.Text = "Laplace算子";
            btnLaplace.UseVisualStyleBackColor = true;
            btnLaplace.Click += btnLaplace_Click;
            // 
            // btnSobel
            // 
            btnSobel.Location = new Point(175, 110);
            btnSobel.Name = "btnSobel";
            btnSobel.Size = new Size(131, 29);
            btnSobel.TabIndex = 1;
            btnSobel.Text = "Sobel算子";
            btnSobel.UseVisualStyleBackColor = true;
            btnSobel.Click += btnSobel_Click;
            // 
            // btnRoberts
            // 
            btnRoberts.Location = new Point(175, 75);
            btnRoberts.Name = "btnRoberts";
            btnRoberts.Size = new Size(131, 29);
            btnRoberts.TabIndex = 1;
            btnRoberts.Text = "Roberts算子";
            btnRoberts.UseVisualStyleBackColor = true;
            btnRoberts.Click += btnRoberts_Click;
            // 
            // btnMorphologyEx
            // 
            btnMorphologyEx.Location = new Point(325, 250);
            btnMorphologyEx.Name = "btnMorphologyEx";
            btnMorphologyEx.Size = new Size(131, 29);
            btnMorphologyEx.TabIndex = 1;
            btnMorphologyEx.Text = "形态学滤波";
            btnMorphologyEx.UseVisualStyleBackColor = true;
            btnMorphologyEx.Click += btnMorphologyEx_Click;
            // 
            // btnBoxFilter
            // 
            btnBoxFilter.Location = new Point(325, 215);
            btnBoxFilter.Name = "btnBoxFilter";
            btnBoxFilter.Size = new Size(131, 29);
            btnBoxFilter.TabIndex = 1;
            btnBoxFilter.Text = "盒式滤波";
            btnBoxFilter.UseVisualStyleBackColor = true;
            btnBoxFilter.Click += btnBoxFilter_Click;
            // 
            // btnGaussianBlur
            // 
            btnGaussianBlur.Location = new Point(325, 180);
            btnGaussianBlur.Name = "btnGaussianBlur";
            btnGaussianBlur.Size = new Size(131, 29);
            btnGaussianBlur.TabIndex = 1;
            btnGaussianBlur.Text = "高斯滤波";
            btnGaussianBlur.UseVisualStyleBackColor = true;
            btnGaussianBlur.Click += btnGaussianBlur_Click;
            // 
            // btnOpaque
            // 
            btnOpaque.Location = new Point(325, 145);
            btnOpaque.Name = "btnOpaque";
            btnOpaque.Size = new Size(131, 29);
            btnOpaque.TabIndex = 1;
            btnOpaque.Text = "模糊";
            btnOpaque.UseVisualStyleBackColor = true;
            btnOpaque.Click += btnOpaque_Click;
            // 
            // btnBilateralFilter
            // 
            btnBilateralFilter.Location = new Point(325, 110);
            btnBilateralFilter.Name = "btnBilateralFilter";
            btnBilateralFilter.Size = new Size(131, 29);
            btnBilateralFilter.TabIndex = 1;
            btnBilateralFilter.Text = "高斯双边滤波";
            btnBilateralFilter.UseVisualStyleBackColor = true;
            btnBilateralFilter.Click += btnBilateralFilter_Click;
            // 
            // btnMedianBlur
            // 
            btnMedianBlur.Location = new Point(325, 75);
            btnMedianBlur.Name = "btnMedianBlur";
            btnMedianBlur.Size = new Size(131, 29);
            btnMedianBlur.TabIndex = 1;
            btnMedianBlur.Text = "中值滤波";
            btnMedianBlur.UseVisualStyleBackColor = true;
            btnMedianBlur.Click += btnMedianBlur_Click;
            // 
            // button14
            // 
            button14.Location = new Point(175, 390);
            button14.Name = "button14";
            button14.Size = new Size(131, 29);
            button14.TabIndex = 1;
            button14.Tag = "https://blog.csdn.net/lweiyue/article/details/105953206";
            button14.Text = "Mean-Shift算法";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnBlur_Click;
            // 
            // button13
            // 
            button13.Location = new Point(175, 355);
            button13.Name = "button13";
            button13.Size = new Size(131, 29);
            button13.TabIndex = 1;
            button13.Tag = "https://blog.csdn.net/lweiyue/article/details/105953206";
            button13.Text = "Grabcuts算法";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnBlur_Click;
            // 
            // button12
            // 
            button12.Location = new Point(175, 320);
            button12.Name = "button12";
            button12.Size = new Size(131, 29);
            button12.TabIndex = 1;
            button12.Tag = "https://blog.csdn.net/lweiyue/article/details/105953206";
            button12.Text = "分水岭算法";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnBlur_Click;
            // 
            // btnRevert
            // 
            btnRevert.Location = new Point(27, 285);
            btnRevert.Name = "btnRevert";
            btnRevert.Size = new Size(131, 29);
            btnRevert.TabIndex = 1;
            btnRevert.Tag = "";
            btnRevert.Text = "反相";
            btnRevert.UseVisualStyleBackColor = true;
            btnRevert.Click += btnRevert_Click;
            // 
            // btnDenoise
            // 
            btnDenoise.Location = new Point(475, 180);
            btnDenoise.Name = "btnDenoise";
            btnDenoise.Size = new Size(131, 29);
            btnDenoise.TabIndex = 1;
            btnDenoise.Tag = "";
            btnDenoise.Text = "去除噪声";
            btnDenoise.UseVisualStyleBackColor = true;
            btnDenoise.Click += btnDenoise_Click;
            // 
            // button11
            // 
            button11.Location = new Point(175, 285);
            button11.Name = "button11";
            button11.Size = new Size(131, 29);
            button11.TabIndex = 1;
            button11.Tag = "https://blog.csdn.net/lweiyue/article/details/105953206";
            button11.Text = "漫水填充";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnBlur_Click;
            // 
            // btnHSV
            // 
            btnHSV.Location = new Point(27, 250);
            btnHSV.Name = "btnHSV";
            btnHSV.Size = new Size(131, 29);
            btnHSV.TabIndex = 1;
            btnHSV.Tag = "";
            btnHSV.Text = "HSV彩色";
            btnHSV.UseVisualStyleBackColor = true;
            btnHSV.Click += btnHSV_Click;
            // 
            // btnImgRepair
            // 
            btnImgRepair.Location = new Point(475, 145);
            btnImgRepair.Name = "btnImgRepair";
            btnImgRepair.Size = new Size(131, 29);
            btnImgRepair.TabIndex = 1;
            btnImgRepair.Tag = "https://blog.csdn.net/lweiyue/article/details/105784854";
            btnImgRepair.Text = "图像修复";
            btnImgRepair.UseVisualStyleBackColor = true;
            btnImgRepair.Click += btnImgRepair_Click;
            // 
            // btnHoughLinTransferCurve
            // 
            btnHoughLinTransferCurve.Location = new Point(475, 75);
            btnHoughLinTransferCurve.Name = "btnHoughLinTransferCurve";
            btnHoughLinTransferCurve.Size = new Size(131, 29);
            btnHoughLinTransferCurve.TabIndex = 1;
            btnHoughLinTransferCurve.Tag = "";
            btnHoughLinTransferCurve.Text = "霍夫线变换 曲线";
            btnHoughLinTransferCurve.UseVisualStyleBackColor = true;
            btnHoughLinTransferCurve.Click += btnHoughLinTransferCurve_Click;
            // 
            // btnHoughLineTransfer
            // 
            btnHoughLineTransfer.Location = new Point(475, 40);
            btnHoughLineTransfer.Name = "btnHoughLineTransfer";
            btnHoughLineTransfer.Size = new Size(131, 29);
            btnHoughLineTransfer.TabIndex = 1;
            btnHoughLineTransfer.Tag = "";
            btnHoughLineTransfer.Text = "霍夫线变换 直线";
            btnHoughLineTransfer.UseVisualStyleBackColor = true;
            btnHoughLineTransfer.Click += btnHoughLineTransfer_Click;
            // 
            // btnBlur
            // 
            btnBlur.Location = new Point(325, 40);
            btnBlur.Name = "btnBlur";
            btnBlur.Size = new Size(131, 29);
            btnBlur.TabIndex = 1;
            btnBlur.Text = "均值滤波";
            btnBlur.UseVisualStyleBackColor = true;
            btnBlur.Click += btnBlur_Click;
            // 
            // btnCanny
            // 
            btnCanny.Location = new Point(175, 40);
            btnCanny.Name = "btnCanny";
            btnCanny.Size = new Size(131, 29);
            btnCanny.TabIndex = 1;
            btnCanny.Text = "Canny";
            btnCanny.UseVisualStyleBackColor = true;
            btnCanny.Click += btnCanny_Click;
            // 
            // btnStructure
            // 
            btnStructure.Location = new Point(27, 215);
            btnStructure.Name = "btnStructure";
            btnStructure.Size = new Size(131, 29);
            btnStructure.TabIndex = 1;
            btnStructure.Text = "膨胀处理";
            btnStructure.UseVisualStyleBackColor = true;
            btnStructure.Click += btnStructure_Click;
            // 
            // btnPerspective
            // 
            btnPerspective.Location = new Point(475, 426);
            btnPerspective.Name = "btnPerspective";
            btnPerspective.Size = new Size(131, 29);
            btnPerspective.TabIndex = 1;
            btnPerspective.Text = "透视";
            btnPerspective.UseVisualStyleBackColor = true;
            btnPerspective.Click += btnPerspective_Click;
            // 
            // btnAffine
            // 
            btnAffine.Location = new Point(475, 390);
            btnAffine.Name = "btnAffine";
            btnAffine.Size = new Size(131, 29);
            btnAffine.TabIndex = 1;
            btnAffine.Text = "仿射";
            btnAffine.UseVisualStyleBackColor = true;
            btnAffine.Click += btnAffine_Click;
            // 
            // btnTranslation
            // 
            btnTranslation.Location = new Point(475, 355);
            btnTranslation.Name = "btnTranslation";
            btnTranslation.Size = new Size(131, 29);
            btnTranslation.TabIndex = 1;
            btnTranslation.Text = "平移";
            btnTranslation.UseVisualStyleBackColor = true;
            btnTranslation.Click += btnTranslation_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(475, 320);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(131, 29);
            btnRotate.TabIndex = 1;
            btnRotate.Text = "旋转";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnOverturn
            // 
            btnOverturn.Location = new Point(475, 285);
            btnOverturn.Name = "btnOverturn";
            btnOverturn.Size = new Size(131, 29);
            btnOverturn.TabIndex = 1;
            btnOverturn.Text = "翻转";
            btnOverturn.UseVisualStyleBackColor = true;
            btnOverturn.Click += btnOverturn_Click;
            // 
            // btnShrink
            // 
            btnShrink.Location = new Point(475, 250);
            btnShrink.Name = "btnShrink";
            btnShrink.Size = new Size(131, 29);
            btnShrink.TabIndex = 1;
            btnShrink.Text = "缩放";
            btnShrink.UseVisualStyleBackColor = true;
            btnShrink.Click += btnShrink_Click;
            // 
            // btnBanary
            // 
            btnBanary.Location = new Point(27, 180);
            btnBanary.Name = "btnBanary";
            btnBanary.Size = new Size(131, 29);
            btnBanary.TabIndex = 1;
            btnBanary.Text = "二值处理";
            btnBanary.UseVisualStyleBackColor = true;
            btnBanary.Click += btnBanary_Click;
            // 
            // btnEqualHist
            // 
            btnEqualHist.Location = new Point(27, 145);
            btnEqualHist.Name = "btnEqualHist";
            btnEqualHist.Size = new Size(131, 29);
            btnEqualHist.TabIndex = 1;
            btnEqualHist.Text = "灰度均衡";
            btnEqualHist.UseVisualStyleBackColor = true;
            btnEqualHist.Click += btnEqualHist_Click;
            // 
            // btnSaltNoisy
            // 
            btnSaltNoisy.BackColor = Color.White;
            btnSaltNoisy.Location = new Point(325, 321);
            btnSaltNoisy.Name = "btnSaltNoisy";
            btnSaltNoisy.Size = new Size(131, 29);
            btnSaltNoisy.TabIndex = 1;
            btnSaltNoisy.Text = "椒盐噪声";
            btnSaltNoisy.UseVisualStyleBackColor = false;
            btnSaltNoisy.Click += btnSaltNoisy_Click;
            // 
            // btnGryHist
            // 
            btnGryHist.BackColor = Color.White;
            btnGryHist.Location = new Point(27, 355);
            btnGryHist.Name = "btnGryHist";
            btnGryHist.Size = new Size(131, 29);
            btnGryHist.TabIndex = 1;
            btnGryHist.Text = "灰度直方图";
            btnGryHist.UseVisualStyleBackColor = false;
            btnGryHist.Click += btnGryHist_Click;
            // 
            // btnGry
            // 
            btnGry.Location = new Point(27, 110);
            btnGry.Name = "btnGry";
            btnGry.Size = new Size(131, 29);
            btnGry.TabIndex = 1;
            btnGry.Text = "灰度处理";
            btnGry.UseVisualStyleBackColor = true;
            btnGry.Click += btnGry_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(27, 75);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(131, 29);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "还原图像";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
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
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(205, 10);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 0;
            label2.Text = "边缘检测";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Purple;
            label9.Location = new Point(206, 254);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 0;
            label9.Text = "图像分割";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Purple;
            label8.Location = new Point(506, 219);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 0;
            label8.Text = "位置变换";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(506, 114);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 0;
            label5.Text = "图像优化";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(52, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 0;
            label1.Text = "图像预处理";
            // 
            // btnGaussianNoisy
            // 
            btnGaussianNoisy.BackColor = Color.White;
            btnGaussianNoisy.Location = new Point(325, 355);
            btnGaussianNoisy.Name = "btnGaussianNoisy";
            btnGaussianNoisy.Size = new Size(131, 29);
            btnGaussianNoisy.TabIndex = 1;
            btnGaussianNoisy.Text = "高斯噪声";
            btnGaussianNoisy.UseVisualStyleBackColor = false;
            btnGaussianNoisy.Click += btnGaussianNoisy_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1519, 781);
            Controls.Add(plOperates);
            Controls.Add(plImages);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            plImages.ResumeLayout(false);
            table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTopLeft).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private Label label3;
        private Button btnBlur;
        private Button btnMedianBlur;
        private Button btnBilateralFilter;
        private Button btnOpaque;
        private Button btnGaussianBlur;
        private Button btnMorphologyEx;
        private Button btnBoxFilter;
        private Button btnGry;
        private Button btnBanary;
        private Button btnStructure;
        private Button btnShrink;
        private Button btnRestore;
        private Label label4;
        private Button btnHoughLineTransfer;
        private Button btnGryHist;
        private Button btnEqualHist;
        private Button btnRevert;
        private Button btnDenoise;
        private Button btnHSV;
        private Button btnImgRepair;
        private Label label5;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Label label9;
        private Label label8;
        private Button btnHoughLinTransferCurve;
        private Label label7;
        private Button btnPerspective;
        private Button btnAffine;
        private Button btnTranslation;
        private Button btnRotate;
        private Button btnOverturn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuSaveAs;
        private Label label6;
        private Button btnSaltNoisy;
        private ToolStripMenuItem mnuBig;
        private Button btnGaussianNoisy;
    }
}