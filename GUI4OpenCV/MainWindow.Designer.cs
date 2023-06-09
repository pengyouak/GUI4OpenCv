﻿namespace GUI4OpenCV
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
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
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
            btnMeanShift = new Button();
            btnGrabcuts = new Button();
            btnWatershed = new Button();
            btnRevert = new Button();
            btnDenoise = new Button();
            btnFloodFill = new Button();
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
            btnPoissonNoisy = new Button();
            btnGaussianNoisy = new Button();
            button18 = new Button();
            button17 = new Button();
            button11 = new Button();
            button16 = new Button();
            button10 = new Button();
            button5 = new Button();
            button15 = new Button();
            button9 = new Button();
            button4 = new Button();
            button14 = new Button();
            button8 = new Button();
            btnKittler = new Button();
            button13 = new Button();
            button7 = new Button();
            btnOSTUThreshSeg = new Button();
            button12 = new Button();
            btnLBP = new Button();
            btnThreshSeg = new Button();
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
            label13 = new Label();
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
            plOperates.Controls.Add(label11);
            plOperates.Controls.Add(label12);
            plOperates.Controls.Add(label10);
            plOperates.Controls.Add(label13);
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
            plOperates.Controls.Add(btnMeanShift);
            plOperates.Controls.Add(btnGrabcuts);
            plOperates.Controls.Add(btnWatershed);
            plOperates.Controls.Add(btnRevert);
            plOperates.Controls.Add(btnDenoise);
            plOperates.Controls.Add(btnFloodFill);
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
            plOperates.Controls.Add(btnPoissonNoisy);
            plOperates.Controls.Add(btnGaussianNoisy);
            plOperates.Controls.Add(button18);
            plOperates.Controls.Add(button17);
            plOperates.Controls.Add(button11);
            plOperates.Controls.Add(button16);
            plOperates.Controls.Add(button10);
            plOperates.Controls.Add(button5);
            plOperates.Controls.Add(button15);
            plOperates.Controls.Add(button9);
            plOperates.Controls.Add(button4);
            plOperates.Controls.Add(button14);
            plOperates.Controls.Add(button8);
            plOperates.Controls.Add(btnKittler);
            plOperates.Controls.Add(button13);
            plOperates.Controls.Add(button7);
            plOperates.Controls.Add(btnOSTUThreshSeg);
            plOperates.Controls.Add(button12);
            plOperates.Controls.Add(btnLBP);
            plOperates.Controls.Add(btnThreshSeg);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Purple;
            label11.Location = new Point(506, 463);
            label11.Name = "label11";
            label11.Size = new Size(65, 19);
            label11.TabIndex = 0;
            label11.Text = "特征提取";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Purple;
            label12.Location = new Point(206, 429);
            label12.Name = "label12";
            label12.Size = new Size(65, 19);
            label12.TabIndex = 0;
            label12.Text = "背景处理";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Purple;
            label10.Location = new Point(358, 430);
            label10.Name = "label10";
            label10.Size = new Size(65, 19);
            label10.TabIndex = 0;
            label10.Text = "特征明显";
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
            // btnMeanShift
            // 
            btnMeanShift.Location = new Point(175, 390);
            btnMeanShift.Name = "btnMeanShift";
            btnMeanShift.Size = new Size(131, 29);
            btnMeanShift.TabIndex = 1;
            btnMeanShift.Tag = "";
            btnMeanShift.Text = "Mean-Shift算法";
            btnMeanShift.UseVisualStyleBackColor = true;
            btnMeanShift.Click += btnMeanShift_Click;
            // 
            // btnGrabcuts
            // 
            btnGrabcuts.Location = new Point(175, 355);
            btnGrabcuts.Name = "btnGrabcuts";
            btnGrabcuts.Size = new Size(131, 29);
            btnGrabcuts.TabIndex = 1;
            btnGrabcuts.Tag = "https://blog.csdn.net/lweiyue/article/details/105953206";
            btnGrabcuts.Text = "Grabcuts算法";
            btnGrabcuts.UseVisualStyleBackColor = true;
            btnGrabcuts.Click += btnGrabcuts_Click;
            // 
            // btnWatershed
            // 
            btnWatershed.Location = new Point(175, 320);
            btnWatershed.Name = "btnWatershed";
            btnWatershed.Size = new Size(131, 29);
            btnWatershed.TabIndex = 1;
            btnWatershed.Tag = "";
            btnWatershed.Text = "分水岭算法";
            btnWatershed.UseVisualStyleBackColor = true;
            btnWatershed.Click += btnWatershed_Click;
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
            // btnFloodFill
            // 
            btnFloodFill.Location = new Point(175, 285);
            btnFloodFill.Name = "btnFloodFill";
            btnFloodFill.Size = new Size(131, 29);
            btnFloodFill.TabIndex = 1;
            btnFloodFill.Tag = "";
            btnFloodFill.Text = "泛洪填充";
            btnFloodFill.UseVisualStyleBackColor = true;
            btnFloodFill.Click += btnFloodFill_Click;
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
            // btnPoissonNoisy
            // 
            btnPoissonNoisy.BackColor = Color.White;
            btnPoissonNoisy.Location = new Point(325, 390);
            btnPoissonNoisy.Name = "btnPoissonNoisy";
            btnPoissonNoisy.Size = new Size(131, 29);
            btnPoissonNoisy.TabIndex = 1;
            btnPoissonNoisy.Text = "泊松噪声";
            btnPoissonNoisy.UseVisualStyleBackColor = false;
            btnPoissonNoisy.Click += btnPoissonNoisy_Click;
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
            // button18
            // 
            button18.BackColor = Color.White;
            button18.Location = new Point(472, 704);
            button18.Name = "button18";
            button18.Size = new Size(131, 29);
            button18.TabIndex = 1;
            button18.Text = "Face_Haar";
            button18.UseVisualStyleBackColor = false;
            button18.Click += btnGryHist_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.White;
            button17.Location = new Point(472, 669);
            button17.Name = "button17";
            button17.Size = new Size(131, 29);
            button17.TabIndex = 1;
            button17.Text = "Haar算法 水平";
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnGryHist_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Location = new Point(325, 634);
            button11.Name = "button11";
            button11.Size = new Size(131, 29);
            button11.TabIndex = 1;
            button11.Text = "Garber滤波";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnGryHist_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.Location = new Point(472, 634);
            button16.Name = "button16";
            button16.Size = new Size(131, 29);
            button16.TabIndex = 1;
            button16.Text = "Haar算法 垂直";
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnGryHist_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Location = new Point(325, 599);
            button10.Name = "button10";
            button10.Size = new Size(131, 29);
            button10.TabIndex = 1;
            button10.Text = "颜色匹配";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnGryHist_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Enabled = false;
            button5.Location = new Point(27, 459);
            button5.Name = "button5";
            button5.Size = new Size(131, 29);
            button5.TabIndex = 1;
            button5.Text = "高斯混合";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnGryHist_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.Location = new Point(472, 599);
            button15.Name = "button15";
            button15.Size = new Size(131, 29);
            button15.TabIndex = 1;
            button15.Text = "字符测试";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnGryHist_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Location = new Point(325, 564);
            button9.Name = "button9";
            button9.Size = new Size(131, 29);
            button9.TabIndex = 1;
            button9.Text = "隐身效果";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnGryHist_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Enabled = false;
            button4.Location = new Point(27, 425);
            button4.Name = "button4";
            button4.Size = new Size(131, 29);
            button4.TabIndex = 1;
            button4.Text = "帧间差分";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnGryHist_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.Location = new Point(472, 564);
            button14.Name = "button14";
            button14.Size = new Size(131, 29);
            button14.TabIndex = 1;
            button14.Text = "坐标点SVM";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnGryHist_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(325, 529);
            button8.Name = "button8";
            button8.Size = new Size(131, 29);
            button8.TabIndex = 1;
            button8.Text = "模板匹配";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnGryHist_Click;
            // 
            // btnKittler
            // 
            btnKittler.BackColor = Color.White;
            btnKittler.Location = new Point(175, 529);
            btnKittler.Name = "btnKittler";
            btnKittler.Size = new Size(131, 29);
            btnKittler.TabIndex = 1;
            btnKittler.Text = "Kittler 阈值分割";
            btnKittler.UseVisualStyleBackColor = false;
            btnKittler.Click += btnKittler_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.Location = new Point(472, 529);
            button13.Name = "button13";
            button13.Size = new Size(131, 29);
            button13.TabIndex = 1;
            button13.Text = "ORB";
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnGryHist_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(325, 494);
            button7.Name = "button7";
            button7.Size = new Size(131, 29);
            button7.TabIndex = 1;
            button7.Text = "直方图检测";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnGryHist_Click;
            // 
            // btnOSTUThreshSeg
            // 
            btnOSTUThreshSeg.BackColor = Color.White;
            btnOSTUThreshSeg.Location = new Point(175, 494);
            btnOSTUThreshSeg.Name = "btnOSTUThreshSeg";
            btnOSTUThreshSeg.Size = new Size(131, 29);
            btnOSTUThreshSeg.TabIndex = 1;
            btnOSTUThreshSeg.Text = "OSTU 阈值分割";
            btnOSTUThreshSeg.UseVisualStyleBackColor = false;
            btnOSTUThreshSeg.Click += btnOSTUThreshSeg_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Location = new Point(472, 494);
            button12.Name = "button12";
            button12.Size = new Size(131, 29);
            button12.TabIndex = 1;
            button12.Text = "SIFT";
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnGryHist_Click;
            // 
            // btnLBP
            // 
            btnLBP.BackColor = Color.White;
            btnLBP.Location = new Point(325, 459);
            btnLBP.Name = "btnLBP";
            btnLBP.Size = new Size(131, 29);
            btnLBP.TabIndex = 1;
            btnLBP.Text = "LBP";
            btnLBP.UseVisualStyleBackColor = false;
            btnLBP.Click += btnLBP_Click;
            // 
            // btnThreshSeg
            // 
            btnThreshSeg.BackColor = Color.White;
            btnThreshSeg.Location = new Point(175, 459);
            btnThreshSeg.Name = "btnThreshSeg";
            btnThreshSeg.Size = new Size(131, 29);
            btnThreshSeg.TabIndex = 1;
            btnThreshSeg.Text = "阈值分割";
            btnThreshSeg.UseVisualStyleBackColor = false;
            btnThreshSeg.Click += btnThreshSeg_Click;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Purple;
            label13.Location = new Point(58, 394);
            label13.Name = "label13";
            label13.Size = new Size(65, 19);
            label13.TabIndex = 0;
            label13.Text = "视频处理";
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
        private Button btnMeanShift;
        private Button btnGrabcuts;
        private Button btnWatershed;
        private Button btnFloodFill;
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
        private Button btnPoissonNoisy;
        private Label label10;
        private Button btnThreshSeg;
        private Button btnOSTUThreshSeg;
        private Button btnKittler;
        private Button button4;
        private Button button5;
        private Label label11;
        private Label label12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button btnLBP;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Label label13;
    }
}