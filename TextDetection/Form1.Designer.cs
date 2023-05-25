
namespace TextDetection
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.detectTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCanny = new System.Windows.Forms.GroupBox();
            this.nHigh = new System.Windows.Forms.NumericUpDown();
            this.nLow = new System.Windows.Forms.NumericUpDown();
            this.txtSigma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBinarize = new System.Windows.Forms.GroupBox();
            this.nThreshold = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHorizontalSmear = new System.Windows.Forms.GroupBox();
            this.nHorizontalSmear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.grpCanny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLow)).BeginInit();
            this.grpBinarize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nThreshold)).BeginInit();
            this.grpHorizontalSmear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHorizontalSmear)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1273, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.detectTextToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // detectTextToolStripMenuItem
            // 
            this.detectTextToolStripMenuItem.Enabled = false;
            this.detectTextToolStripMenuItem.Name = "detectTextToolStripMenuItem";
            this.detectTextToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.detectTextToolStripMenuItem.Text = "Detect Text";
            this.detectTextToolStripMenuItem.Click += new System.EventHandler(this.detectTextToolStripMenuItem_Click);
            // 
            // grpCanny
            // 
            this.grpCanny.Controls.Add(this.nHigh);
            this.grpCanny.Controls.Add(this.nLow);
            this.grpCanny.Controls.Add(this.txtSigma);
            this.grpCanny.Controls.Add(this.label3);
            this.grpCanny.Controls.Add(this.label2);
            this.grpCanny.Controls.Add(this.label1);
            this.grpCanny.Location = new System.Drawing.Point(0, 0);
            this.grpCanny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCanny.Name = "grpCanny";
            this.grpCanny.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCanny.Size = new System.Drawing.Size(221, 105);
            this.grpCanny.TabIndex = 3;
            this.grpCanny.TabStop = false;
            this.grpCanny.Text = "Canny Edge Detector";
            // 
            // nHigh
            // 
            this.nHigh.Location = new System.Drawing.Point(117, 50);
            this.nHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nHigh.Name = "nHigh";
            this.nHigh.Size = new System.Drawing.Size(60, 22);
            this.nHigh.TabIndex = 7;
            this.nHigh.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nLow
            // 
            this.nLow.Location = new System.Drawing.Point(117, 25);
            this.nLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nLow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nLow.Name = "nLow";
            this.nLow.Size = new System.Drawing.Size(60, 22);
            this.nLow.TabIndex = 6;
            this.nLow.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // txtSigma
            // 
            this.txtSigma.Location = new System.Drawing.Point(117, 75);
            this.txtSigma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(63, 22);
            this.txtSigma.TabIndex = 5;
            this.txtSigma.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sigma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "High Threshold:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Threshold:";
            // 
            // grpBinarize
            // 
            this.grpBinarize.Controls.Add(this.nThreshold);
            this.grpBinarize.Controls.Add(this.label4);
            this.grpBinarize.Location = new System.Drawing.Point(221, 0);
            this.grpBinarize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBinarize.Name = "grpBinarize";
            this.grpBinarize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBinarize.Size = new System.Drawing.Size(188, 105);
            this.grpBinarize.TabIndex = 4;
            this.grpBinarize.TabStop = false;
            this.grpBinarize.Text = "Binarize Image";
            // 
            // nThreshold
            // 
            this.nThreshold.Location = new System.Drawing.Point(81, 25);
            this.nThreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nThreshold.Name = "nThreshold";
            this.nThreshold.Size = new System.Drawing.Size(60, 22);
            this.nThreshold.TabIndex = 7;
            this.nThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Threshold:";
            // 
            // grpHorizontalSmear
            // 
            this.grpHorizontalSmear.Controls.Add(this.nHorizontalSmear);
            this.grpHorizontalSmear.Controls.Add(this.label5);
            this.grpHorizontalSmear.Location = new System.Drawing.Point(409, 0);
            this.grpHorizontalSmear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpHorizontalSmear.Name = "grpHorizontalSmear";
            this.grpHorizontalSmear.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpHorizontalSmear.Size = new System.Drawing.Size(373, 105);
            this.grpHorizontalSmear.TabIndex = 5;
            this.grpHorizontalSmear.TabStop = false;
            this.grpHorizontalSmear.Text = "Horizontal Smoothing";
            // 
            // nHorizontalSmear
            // 
            this.nHorizontalSmear.Location = new System.Drawing.Point(236, 25);
            this.nHorizontalSmear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nHorizontalSmear.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nHorizontalSmear.Name = "nHorizontalSmear";
            this.nHorizontalSmear.Size = new System.Drawing.Size(60, 22);
            this.nHorizontalSmear.TabIndex = 9;
            this.nHorizontalSmear.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Horizontal Run Length Smoothing:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpHorizontalSmear);
            this.panel1.Controls.Add(this.grpBinarize);
            this.panel1.Controls.Add(this.grpCanny);
            this.panel1.Location = new System.Drawing.Point(1251, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1615, 105);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(638, 56);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 428);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1273, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 25);
            this.toolStripLabel1.Text = "Язык:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 25);
            this.toolStripButton1.Text = "Распознать текст";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(299, 489);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(667, 169);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 718);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Text Detection";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCanny.ResumeLayout(false);
            this.grpCanny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLow)).EndInit();
            this.grpBinarize.ResumeLayout(false);
            this.grpBinarize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nThreshold)).EndInit();
            this.grpHorizontalSmear.ResumeLayout(false);
            this.grpHorizontalSmear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHorizontalSmear)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detectTextToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCanny;
        private System.Windows.Forms.NumericUpDown nHigh;
        private System.Windows.Forms.NumericUpDown nLow;
        private System.Windows.Forms.TextBox txtSigma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBinarize;
        private System.Windows.Forms.NumericUpDown nThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpHorizontalSmear;
        private System.Windows.Forms.NumericUpDown nHorizontalSmear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

