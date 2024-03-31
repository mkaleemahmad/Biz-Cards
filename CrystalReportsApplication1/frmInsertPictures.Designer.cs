namespace CrystalReportsApplication1
{
    partial class frmInsertPictures
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTestPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTestLoadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbInstitutes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFolderDailog = new System.Windows.Forms.Button();
            this.txtStdIDEnd = new System.Windows.Forms.NumericUpDown();
            this.txtImgStart = new System.Windows.Forms.NumericUpDown();
            this.txtStdIDStart = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEndingExtention = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdIDEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImgStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdIDStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(238, 234);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(163, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTestPath
            // 
            this.txtTestPath.Location = new System.Drawing.Point(11, 379);
            this.txtTestPath.Name = "txtTestPath";
            this.txtTestPath.Size = new System.Drawing.Size(420, 20);
            this.txtTestPath.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Test Path";
            // 
            // btnTestLoadImage
            // 
            this.btnTestLoadImage.Location = new System.Drawing.Point(437, 377);
            this.btnTestLoadImage.Name = "btnTestLoadImage";
            this.btnTestLoadImage.Size = new System.Drawing.Size(172, 23);
            this.btnTestLoadImage.TabIndex = 15;
            this.btnTestLoadImage.Text = "Load Test Image";
            this.btnTestLoadImage.UseVisualStyleBackColor = true;
            this.btnTestLoadImage.Click += new System.EventHandler(this.btnTestLoadImage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmbInstitutes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.cmbSession);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnFolderDailog);
            this.panel1.Controls.Add(this.txtStdIDEnd);
            this.panel1.Controls.Add(this.txtImgStart);
            this.panel1.Controls.Add(this.txtStdIDStart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTestLoadImage);
            this.panel1.Controls.Add(this.txtEndingExtention);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTestPath);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalStudents);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 437);
            this.panel1.TabIndex = 16;
            // 
            // cmbInstitutes
            // 
            this.cmbInstitutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstitutes.FormattingEnabled = true;
            this.cmbInstitutes.Location = new System.Drawing.Point(89, 12);
            this.cmbInstitutes.Name = "cmbInstitutes";
            this.cmbInstitutes.Size = new System.Drawing.Size(624, 23);
            this.cmbInstitutes.TabIndex = 22;
            this.cmbInstitutes.SelectedIndexChanged += new System.EventHandler(this.cmbInstitutes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Institute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Session";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(89, 43);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(391, 23);
            this.cmbClass.TabIndex = 24;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // cmbSession
            // 
            this.cmbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(562, 42);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(151, 23);
            this.cmbSession.TabIndex = 26;
            this.cmbSession.SelectedIndexChanged += new System.EventHandler(this.cmbSession_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Class";
            // 
            // btnFolderDailog
            // 
            this.btnFolderDailog.Location = new System.Drawing.Point(491, 143);
            this.btnFolderDailog.Name = "btnFolderDailog";
            this.btnFolderDailog.Size = new System.Drawing.Size(193, 23);
            this.btnFolderDailog.TabIndex = 21;
            this.btnFolderDailog.Text = "Browse Folder";
            this.btnFolderDailog.UseVisualStyleBackColor = true;
            this.btnFolderDailog.Click += new System.EventHandler(this.btnFolderDailog_Click);
            // 
            // txtStdIDEnd
            // 
            this.txtStdIDEnd.Location = new System.Drawing.Point(491, 116);
            this.txtStdIDEnd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtStdIDEnd.Name = "txtStdIDEnd";
            this.txtStdIDEnd.Size = new System.Drawing.Size(190, 20);
            this.txtStdIDEnd.TabIndex = 19;
            // 
            // txtImgStart
            // 
            this.txtImgStart.Location = new System.Drawing.Point(175, 146);
            this.txtImgStart.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtImgStart.Name = "txtImgStart";
            this.txtImgStart.Size = new System.Drawing.Size(190, 20);
            this.txtImgStart.TabIndex = 20;
            this.txtImgStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtImgStart.ValueChanged += new System.EventHandler(this.txtImgStart_ValueChanged);
            this.txtImgStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImgStart_KeyDown);
            this.txtImgStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtImgStart_KeyUp);
            // 
            // txtStdIDStart
            // 
            this.txtStdIDStart.Location = new System.Drawing.Point(175, 116);
            this.txtStdIDStart.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtStdIDStart.Name = "txtStdIDStart";
            this.txtStdIDStart.Size = new System.Drawing.Size(190, 20);
            this.txtStdIDStart.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Cards\\3_rd_year_2017_city_college\\img\\(20).jpg";
            this.pictureBox1.Location = new System.Drawing.Point(612, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtEndingExtention
            // 
            this.txtEndingExtention.Location = new System.Drawing.Point(175, 198);
            this.txtEndingExtention.Name = "txtEndingExtention";
            this.txtEndingExtention.Size = new System.Drawing.Size(509, 20);
            this.txtEndingExtention.TabIndex = 16;
            this.txtEndingExtention.Text = ").jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ending Extention";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(175, 172);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(509, 20);
            this.txtPath.TabIndex = 14;
            this.txtPath.Text = "D:\\Cards\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Path of Images:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1st Image Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ending Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Starting Student ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total Students:";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(172, 84);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(13, 13);
            this.lblTotalStudents.TabIndex = 7;
            this.lblTotalStudents.Text = "0";
            // 
            // frmInsertPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "frmInsertPictures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Students Pictures";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInsertPictures_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdIDEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImgStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdIDStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTestPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTestLoadImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEndingExtention;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtStdIDEnd;
        private System.Windows.Forms.NumericUpDown txtImgStart;
        private System.Windows.Forms.NumericUpDown txtStdIDStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderDailog;
        private System.Windows.Forms.ComboBox cmbInstitutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label label10;
    }
}