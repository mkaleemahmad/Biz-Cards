namespace CrystalReportsApplication1
{
    partial class frmInstitutes
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblCollegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCardsDatasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCollegeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collegeIDDataGridViewTextBoxColumn,
            this.collegeCodeDataGridViewTextBoxColumn,
            this.collegeNameDataGridViewTextBoxColumn,
            this.collegeAddressDataGridViewTextBoxColumn,
            this.collegeContactDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.tblClassesDataGridViewTextBoxColumn,
            this.tblStudentsDataGridViewTextBoxColumn,
            this.tblCardsDatasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCollegeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblCollegeBindingSource
            // 
            this.tblCollegeBindingSource.DataSource = typeof(CrystalReportsApplication1.tblCollege);
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            // 
            // collegeCodeDataGridViewTextBoxColumn
            // 
            this.collegeCodeDataGridViewTextBoxColumn.DataPropertyName = "CollegeCode";
            this.collegeCodeDataGridViewTextBoxColumn.HeaderText = "CollegeCode";
            this.collegeCodeDataGridViewTextBoxColumn.Name = "collegeCodeDataGridViewTextBoxColumn";
            // 
            // collegeNameDataGridViewTextBoxColumn
            // 
            this.collegeNameDataGridViewTextBoxColumn.DataPropertyName = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.HeaderText = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.Name = "collegeNameDataGridViewTextBoxColumn";
            // 
            // collegeAddressDataGridViewTextBoxColumn
            // 
            this.collegeAddressDataGridViewTextBoxColumn.DataPropertyName = "CollegeAddress";
            this.collegeAddressDataGridViewTextBoxColumn.HeaderText = "CollegeAddress";
            this.collegeAddressDataGridViewTextBoxColumn.Name = "collegeAddressDataGridViewTextBoxColumn";
            // 
            // collegeContactDataGridViewTextBoxColumn
            // 
            this.collegeContactDataGridViewTextBoxColumn.DataPropertyName = "CollegeContact";
            this.collegeContactDataGridViewTextBoxColumn.HeaderText = "CollegeContact";
            this.collegeContactDataGridViewTextBoxColumn.Name = "collegeContactDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            // 
            // tblClassesDataGridViewTextBoxColumn
            // 
            this.tblClassesDataGridViewTextBoxColumn.DataPropertyName = "tblClasses";
            this.tblClassesDataGridViewTextBoxColumn.HeaderText = "tblClasses";
            this.tblClassesDataGridViewTextBoxColumn.Name = "tblClassesDataGridViewTextBoxColumn";
            // 
            // tblStudentsDataGridViewTextBoxColumn
            // 
            this.tblStudentsDataGridViewTextBoxColumn.DataPropertyName = "tblStudents";
            this.tblStudentsDataGridViewTextBoxColumn.HeaderText = "tblStudents";
            this.tblStudentsDataGridViewTextBoxColumn.Name = "tblStudentsDataGridViewTextBoxColumn";
            // 
            // tblCardsDatasDataGridViewTextBoxColumn
            // 
            this.tblCardsDatasDataGridViewTextBoxColumn.DataPropertyName = "tblCardsDatas";
            this.tblCardsDatasDataGridViewTextBoxColumn.HeaderText = "tblCardsDatas";
            this.tblCardsDatasDataGridViewTextBoxColumn.Name = "tblCardsDatasDataGridViewTextBoxColumn";
            // 
            // frmInstitutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmInstitutes";
            this.Text = "frmInstitutes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCollegeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblClassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCardsDatasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblCollegeBindingSource;
    }
}