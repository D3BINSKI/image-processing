namespace WinFormsApp
{
    partial class Form1
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
            this.editorPanel = new System.Windows.Forms.Panel();
            this.editorPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.revertChangesButton = new System.Windows.Forms.Button();
            this.applyChangesBttn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dividerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dividerTextBox = new System.Windows.Forms.TextBox();
            this.offsetPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.customMatrixFieldsGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.matrix11TextBox = new System.Windows.Forms.TextBox();
            this.matrix12TextBox = new System.Windows.Forms.TextBox();
            this.matrix13TextBox = new System.Windows.Forms.TextBox();
            this.matrix21TextBox = new System.Windows.Forms.TextBox();
            this.matrix22TextBox = new System.Windows.Forms.TextBox();
            this.matrix23TextBox = new System.Windows.Forms.TextBox();
            this.matrix31TextBox = new System.Windows.Forms.TextBox();
            this.matrix32TextBox = new System.Windows.Forms.TextBox();
            this.matrix33TextBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.customMatrixRadioButton = new System.Windows.Forms.RadioButton();
            this.negativeRadioButton = new System.Windows.Forms.RadioButton();
            this.edgeDetectionRadioButton = new System.Windows.Forms.RadioButton();
            this.carvingRadioButton = new System.Windows.Forms.RadioButton();
            this.blurRadioButton = new System.Windows.Forms.RadioButton();
            this.identityRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addPolygonButton = new System.Windows.Forms.Button();
            this.PolygonRegionRadioBttn = new System.Windows.Forms.RadioButton();
            this.roundBrushRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.roundBrushRadioBttn = new System.Windows.Forms.RadioButton();
            this.entireImageRadioBttn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blueHistogramPictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.greenHistogramPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.redHistogramPictureBox = new System.Windows.Forms.PictureBox();
            this.editorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.dividerPanel.SuspendLayout();
            this.offsetPanel.SuspendLayout();
            this.customMatrixFieldsGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundBrushRadiusTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueHistogramPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenHistogramPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redHistogramPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // editorPanel
            // 
            this.editorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorPanel.AutoScroll = true;
            this.editorPanel.BackColor = System.Drawing.Color.White;
            this.editorPanel.Controls.Add(this.editorPictureBox);
            this.editorPanel.Location = new System.Drawing.Point(0, 0);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(601, 702);
            this.editorPanel.TabIndex = 0;
            // 
            // editorPictureBox
            // 
            this.editorPictureBox.Location = new System.Drawing.Point(0, 0);
            this.editorPictureBox.Name = "editorPictureBox";
            this.editorPictureBox.Size = new System.Drawing.Size(604, 702);
            this.editorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editorPictureBox.TabIndex = 0;
            this.editorPictureBox.TabStop = false;
            this.editorPictureBox.Click += new System.EventHandler(this.editorPictureBox_Click);
            this.editorPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editorPictureBox_MouseDown);
            this.editorPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editorPictureBox_MouseMove);
            this.editorPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editorPictureBox_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 702);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(374, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 702);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.revertChangesButton);
            this.panel6.Controls.Add(this.applyChangesBttn);
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 676);
            this.panel6.TabIndex = 0;
            // 
            // revertChangesButton
            // 
            this.revertChangesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.revertChangesButton.Location = new System.Drawing.Point(0, 618);
            this.revertChangesButton.Name = "revertChangesButton";
            this.revertChangesButton.Size = new System.Drawing.Size(247, 29);
            this.revertChangesButton.TabIndex = 5;
            this.revertChangesButton.Text = "Revert changes";
            this.revertChangesButton.UseVisualStyleBackColor = true;
            this.revertChangesButton.Click += new System.EventHandler(this.revertChangesButton_Click);
            // 
            // applyChangesBttn
            // 
            this.applyChangesBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyChangesBttn.Location = new System.Drawing.Point(0, 647);
            this.applyChangesBttn.Name = "applyChangesBttn";
            this.applyChangesBttn.Size = new System.Drawing.Size(247, 29);
            this.applyChangesBttn.TabIndex = 4;
            this.applyChangesBttn.Text = "Apply changes";
            this.applyChangesBttn.UseVisualStyleBackColor = true;
            this.applyChangesBttn.Click += new System.EventHandler(this.applyChangesBttn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Controls.Add(this.customMatrixFieldsGroupBox);
            this.groupBox4.Controls.Add(this.panel10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 408);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtering Matrix Properties";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dividerPanel);
            this.panel8.Controls.Add(this.offsetPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 320);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(241, 77);
            this.panel8.TabIndex = 16;
            // 
            // dividerPanel
            // 
            this.dividerPanel.Controls.Add(this.label2);
            this.dividerPanel.Controls.Add(this.dividerTextBox);
            this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dividerPanel.Enabled = false;
            this.dividerPanel.Location = new System.Drawing.Point(0, 32);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(241, 35);
            this.dividerPanel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Divider";
            // 
            // dividerTextBox
            // 
            this.dividerTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.dividerTextBox.Location = new System.Drawing.Point(191, 0);
            this.dividerTextBox.Name = "dividerTextBox";
            this.dividerTextBox.Size = new System.Drawing.Size(50, 27);
            this.dividerTextBox.TabIndex = 2;
            // 
            // offsetPanel
            // 
            this.offsetPanel.Controls.Add(this.label1);
            this.offsetPanel.Controls.Add(this.offsetTextBox);
            this.offsetPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.offsetPanel.Enabled = false;
            this.offsetPanel.Location = new System.Drawing.Point(0, 0);
            this.offsetPanel.Name = "offsetPanel";
            this.offsetPanel.Size = new System.Drawing.Size(241, 32);
            this.offsetPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Offset";
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.offsetTextBox.Location = new System.Drawing.Point(191, 0);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(50, 27);
            this.offsetTextBox.TabIndex = 1;
            // 
            // customMatrixFieldsGroupBox
            // 
            this.customMatrixFieldsGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.customMatrixFieldsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.customMatrixFieldsGroupBox.Enabled = false;
            this.customMatrixFieldsGroupBox.Location = new System.Drawing.Point(3, 171);
            this.customMatrixFieldsGroupBox.Name = "customMatrixFieldsGroupBox";
            this.customMatrixFieldsGroupBox.Size = new System.Drawing.Size(241, 149);
            this.customMatrixFieldsGroupBox.TabIndex = 15;
            this.customMatrixFieldsGroupBox.TabStop = false;
            this.customMatrixFieldsGroupBox.Text = "Custom Matrix";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.matrix11TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix12TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix13TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix21TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix22TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix23TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix31TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix32TextBox);
            this.flowLayoutPanel1.Controls.Add(this.matrix33TextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 26);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(175, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // matrix11TextBox
            // 
            this.matrix11TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrix11TextBox.Location = new System.Drawing.Point(3, 3);
            this.matrix11TextBox.Name = "matrix11TextBox";
            this.matrix11TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix11TextBox.TabIndex = 9;
            // 
            // matrix12TextBox
            // 
            this.matrix12TextBox.Location = new System.Drawing.Point(59, 3);
            this.matrix12TextBox.Name = "matrix12TextBox";
            this.matrix12TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix12TextBox.TabIndex = 10;
            // 
            // matrix13TextBox
            // 
            this.matrix13TextBox.Location = new System.Drawing.Point(115, 3);
            this.matrix13TextBox.Name = "matrix13TextBox";
            this.matrix13TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix13TextBox.TabIndex = 11;
            // 
            // matrix21TextBox
            // 
            this.matrix21TextBox.Location = new System.Drawing.Point(3, 36);
            this.matrix21TextBox.Name = "matrix21TextBox";
            this.matrix21TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix21TextBox.TabIndex = 12;
            // 
            // matrix22TextBox
            // 
            this.matrix22TextBox.Location = new System.Drawing.Point(59, 36);
            this.matrix22TextBox.Name = "matrix22TextBox";
            this.matrix22TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix22TextBox.TabIndex = 13;
            // 
            // matrix23TextBox
            // 
            this.matrix23TextBox.Location = new System.Drawing.Point(115, 36);
            this.matrix23TextBox.Name = "matrix23TextBox";
            this.matrix23TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix23TextBox.TabIndex = 14;
            // 
            // matrix31TextBox
            // 
            this.matrix31TextBox.Location = new System.Drawing.Point(3, 69);
            this.matrix31TextBox.Name = "matrix31TextBox";
            this.matrix31TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix31TextBox.TabIndex = 15;
            // 
            // matrix32TextBox
            // 
            this.matrix32TextBox.Location = new System.Drawing.Point(59, 69);
            this.matrix32TextBox.Name = "matrix32TextBox";
            this.matrix32TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix32TextBox.TabIndex = 16;
            // 
            // matrix33TextBox
            // 
            this.matrix33TextBox.Location = new System.Drawing.Point(115, 69);
            this.matrix33TextBox.Name = "matrix33TextBox";
            this.matrix33TextBox.Size = new System.Drawing.Size(50, 27);
            this.matrix33TextBox.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.customMatrixRadioButton);
            this.panel10.Controls.Add(this.negativeRadioButton);
            this.panel10.Controls.Add(this.edgeDetectionRadioButton);
            this.panel10.Controls.Add(this.carvingRadioButton);
            this.panel10.Controls.Add(this.blurRadioButton);
            this.panel10.Controls.Add(this.identityRadioButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 23);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(241, 148);
            this.panel10.TabIndex = 13;
            // 
            // customMatrixRadioButton
            // 
            this.customMatrixRadioButton.AutoSize = true;
            this.customMatrixRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customMatrixRadioButton.Location = new System.Drawing.Point(0, 120);
            this.customMatrixRadioButton.Name = "customMatrixRadioButton";
            this.customMatrixRadioButton.Size = new System.Drawing.Size(241, 24);
            this.customMatrixRadioButton.TabIndex = 15;
            this.customMatrixRadioButton.TabStop = true;
            this.customMatrixRadioButton.Tag = "matrixProps";
            this.customMatrixRadioButton.Text = "Custom matrix 3x3";
            this.customMatrixRadioButton.UseVisualStyleBackColor = true;
            this.customMatrixRadioButton.CheckedChanged += new System.EventHandler(this.customMatrixRadioButton_CheckedChanged);
            // 
            // negativeRadioButton
            // 
            this.negativeRadioButton.AutoSize = true;
            this.negativeRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.negativeRadioButton.Location = new System.Drawing.Point(0, 96);
            this.negativeRadioButton.Name = "negativeRadioButton";
            this.negativeRadioButton.Size = new System.Drawing.Size(241, 24);
            this.negativeRadioButton.TabIndex = 14;
            this.negativeRadioButton.TabStop = true;
            this.negativeRadioButton.Tag = "matrixProps";
            this.negativeRadioButton.Text = "Negative";
            this.negativeRadioButton.UseVisualStyleBackColor = true;
            this.negativeRadioButton.CheckedChanged += new System.EventHandler(this.negativeRadioButton_CheckedChanged);
            // 
            // edgeDetectionRadioButton
            // 
            this.edgeDetectionRadioButton.AutoSize = true;
            this.edgeDetectionRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.edgeDetectionRadioButton.Location = new System.Drawing.Point(0, 72);
            this.edgeDetectionRadioButton.Name = "edgeDetectionRadioButton";
            this.edgeDetectionRadioButton.Size = new System.Drawing.Size(241, 24);
            this.edgeDetectionRadioButton.TabIndex = 12;
            this.edgeDetectionRadioButton.TabStop = true;
            this.edgeDetectionRadioButton.Tag = "matrixProps";
            this.edgeDetectionRadioButton.Text = "Edge detection";
            this.edgeDetectionRadioButton.UseVisualStyleBackColor = true;
            this.edgeDetectionRadioButton.CheckedChanged += new System.EventHandler(this.edgeDetectionRadioButton_CheckedChanged);
            // 
            // carvingRadioButton
            // 
            this.carvingRadioButton.AutoSize = true;
            this.carvingRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.carvingRadioButton.Location = new System.Drawing.Point(0, 48);
            this.carvingRadioButton.Name = "carvingRadioButton";
            this.carvingRadioButton.Size = new System.Drawing.Size(241, 24);
            this.carvingRadioButton.TabIndex = 11;
            this.carvingRadioButton.TabStop = true;
            this.carvingRadioButton.Tag = "matrixProps";
            this.carvingRadioButton.Text = "Carving";
            this.carvingRadioButton.UseVisualStyleBackColor = true;
            this.carvingRadioButton.CheckedChanged += new System.EventHandler(this.carvingRadioButton_CheckedChanged);
            // 
            // blurRadioButton
            // 
            this.blurRadioButton.AutoSize = true;
            this.blurRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.blurRadioButton.Location = new System.Drawing.Point(0, 24);
            this.blurRadioButton.Name = "blurRadioButton";
            this.blurRadioButton.Size = new System.Drawing.Size(241, 24);
            this.blurRadioButton.TabIndex = 10;
            this.blurRadioButton.TabStop = true;
            this.blurRadioButton.Tag = "matrixProps";
            this.blurRadioButton.Text = "Blur";
            this.blurRadioButton.UseVisualStyleBackColor = true;
            this.blurRadioButton.CheckedChanged += new System.EventHandler(this.blurRadioButton_CheckedChanged);
            // 
            // identityRadioButton
            // 
            this.identityRadioButton.AutoSize = true;
            this.identityRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.identityRadioButton.Location = new System.Drawing.Point(0, 0);
            this.identityRadioButton.Name = "identityRadioButton";
            this.identityRadioButton.Size = new System.Drawing.Size(241, 24);
            this.identityRadioButton.TabIndex = 9;
            this.identityRadioButton.TabStop = true;
            this.identityRadioButton.Tag = "matrixProps";
            this.identityRadioButton.Text = "Identity";
            this.identityRadioButton.UseVisualStyleBackColor = true;
            this.identityRadioButton.CheckedChanged += new System.EventHandler(this.identityRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addPolygonButton);
            this.groupBox3.Controls.Add(this.PolygonRegionRadioBttn);
            this.groupBox3.Controls.Add(this.roundBrushRadiusTrackBar);
            this.groupBox3.Controls.Add(this.roundBrushRadioBttn);
            this.groupBox3.Controls.Add(this.entireImageRadioBttn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtering region";
            // 
            // addPolygonButton
            // 
            this.addPolygonButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addPolygonButton.Enabled = false;
            this.addPolygonButton.Location = new System.Drawing.Point(166, 127);
            this.addPolygonButton.Name = "addPolygonButton";
            this.addPolygonButton.Size = new System.Drawing.Size(78, 25);
            this.addPolygonButton.TabIndex = 6;
            this.addPolygonButton.Text = "Add";
            this.addPolygonButton.UseVisualStyleBackColor = true;
            this.addPolygonButton.Click += new System.EventHandler(this.addPolygonButton_Click);
            // 
            // PolygonRegionRadioBttn
            // 
            this.PolygonRegionRadioBttn.AutoSize = true;
            this.PolygonRegionRadioBttn.Dock = System.Windows.Forms.DockStyle.Left;
            this.PolygonRegionRadioBttn.Location = new System.Drawing.Point(3, 127);
            this.PolygonRegionRadioBttn.Name = "PolygonRegionRadioBttn";
            this.PolygonRegionRadioBttn.Size = new System.Drawing.Size(130, 25);
            this.PolygonRegionRadioBttn.TabIndex = 5;
            this.PolygonRegionRadioBttn.TabStop = true;
            this.PolygonRegionRadioBttn.Tag = "region";
            this.PolygonRegionRadioBttn.Text = "Polygon region";
            this.PolygonRegionRadioBttn.UseVisualStyleBackColor = true;
            this.PolygonRegionRadioBttn.CheckedChanged += new System.EventHandler(this.PolygonRegionRadioBttn_CheckedChanged);
            // 
            // roundBrushRadiusTrackBar
            // 
            this.roundBrushRadiusTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundBrushRadiusTrackBar.Enabled = false;
            this.roundBrushRadiusTrackBar.Location = new System.Drawing.Point(3, 71);
            this.roundBrushRadiusTrackBar.Name = "roundBrushRadiusTrackBar";
            this.roundBrushRadiusTrackBar.Size = new System.Drawing.Size(241, 56);
            this.roundBrushRadiusTrackBar.TabIndex = 2;
            // 
            // roundBrushRadioBttn
            // 
            this.roundBrushRadioBttn.AutoSize = true;
            this.roundBrushRadioBttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundBrushRadioBttn.Location = new System.Drawing.Point(3, 47);
            this.roundBrushRadioBttn.Name = "roundBrushRadioBttn";
            this.roundBrushRadioBttn.Size = new System.Drawing.Size(241, 24);
            this.roundBrushRadioBttn.TabIndex = 1;
            this.roundBrushRadioBttn.TabStop = true;
            this.roundBrushRadioBttn.Tag = "region";
            this.roundBrushRadioBttn.Text = "Round brush";
            this.roundBrushRadioBttn.UseVisualStyleBackColor = true;
            this.roundBrushRadioBttn.CheckedChanged += new System.EventHandler(this.roundBrushRadioBttn_CheckedChanged);
            // 
            // entireImageRadioBttn
            // 
            this.entireImageRadioBttn.AutoSize = true;
            this.entireImageRadioBttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.entireImageRadioBttn.Location = new System.Drawing.Point(3, 23);
            this.entireImageRadioBttn.Name = "entireImageRadioBttn";
            this.entireImageRadioBttn.Size = new System.Drawing.Size(241, 24);
            this.entireImageRadioBttn.TabIndex = 0;
            this.entireImageRadioBttn.TabStop = true;
            this.entireImageRadioBttn.Tag = "region";
            this.entireImageRadioBttn.Text = "Entire image";
            this.entireImageRadioBttn.UseVisualStyleBackColor = true;
            this.entireImageRadioBttn.CheckedChanged += new System.EventHandler(this.entireImageRadioBttn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 702);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histograms";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 676);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.blueHistogramPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(365, 200);
            this.panel3.TabIndex = 6;
            // 
            // blueHistogramPictureBox
            // 
            this.blueHistogramPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueHistogramPictureBox.Location = new System.Drawing.Point(5, 5);
            this.blueHistogramPictureBox.Name = "blueHistogramPictureBox";
            this.blueHistogramPictureBox.Size = new System.Drawing.Size(355, 190);
            this.blueHistogramPictureBox.TabIndex = 1;
            this.blueHistogramPictureBox.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.greenHistogramPictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 200);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(365, 200);
            this.panel5.TabIndex = 5;
            // 
            // greenHistogramPictureBox
            // 
            this.greenHistogramPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenHistogramPictureBox.Location = new System.Drawing.Point(5, 5);
            this.greenHistogramPictureBox.Name = "greenHistogramPictureBox";
            this.greenHistogramPictureBox.Size = new System.Drawing.Size(355, 190);
            this.greenHistogramPictureBox.TabIndex = 1;
            this.greenHistogramPictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.redHistogramPictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(365, 200);
            this.panel4.TabIndex = 4;
            // 
            // redHistogramPictureBox
            // 
            this.redHistogramPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redHistogramPictureBox.Location = new System.Drawing.Point(5, 5);
            this.redHistogramPictureBox.Name = "redHistogramPictureBox";
            this.redHistogramPictureBox.Size = new System.Drawing.Size(355, 190);
            this.redHistogramPictureBox.TabIndex = 1;
            this.redHistogramPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editorPanel);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.editorPanel.ResumeLayout(false);
            this.editorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.dividerPanel.ResumeLayout(false);
            this.dividerPanel.PerformLayout();
            this.offsetPanel.ResumeLayout(false);
            this.offsetPanel.PerformLayout();
            this.customMatrixFieldsGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundBrushRadiusTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blueHistogramPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.greenHistogramPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redHistogramPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel editorPanel;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox editorPictureBox;
        private Panel panel1;
        private Panel panel3;
        private PictureBox blueHistogramPictureBox;
        private Panel panel5;
        private PictureBox greenHistogramPictureBox;
        private Panel panel4;
        private PictureBox redHistogramPictureBox;
        private Panel panel6;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TrackBar roundBrushRadiusTrackBar;
        private RadioButton roundBrushRadioBttn;
        private RadioButton entireImageRadioBttn;
        private Button applyChangesBttn;
        private Button revertChangesButton;
        private Panel panel10;
        private RadioButton edgeDetectionRadioButton;
        private RadioButton carvingRadioButton;
        private RadioButton blurRadioButton;
        private RadioButton identityRadioButton;
        private GroupBox customMatrixFieldsGroupBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox matrix11TextBox;
        private TextBox matrix12TextBox;
        private TextBox matrix13TextBox;
        private TextBox matrix21TextBox;
        private TextBox matrix22TextBox;
        private TextBox matrix23TextBox;
        private TextBox matrix31TextBox;
        private TextBox matrix32TextBox;
        private TextBox matrix33TextBox;
        private RadioButton customMatrixRadioButton;
        private RadioButton negativeRadioButton;
        private Panel panel8;
        private Panel dividerPanel;
        private Label label2;
        private TextBox dividerTextBox;
        private Panel offsetPanel;
        private Label label1;
        private TextBox offsetTextBox;
        private Button addPolygonButton;
        private RadioButton PolygonRegionRadioBttn;
    }
}