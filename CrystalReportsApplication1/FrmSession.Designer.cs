namespace CrystalReportsApplication1
{
    partial class frmSession
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
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.tblSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSession
            // 
            this.dgvSession.AutoGenerateColumns = false;
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.sessionNameDataGridViewTextBoxColumn,
            this.tblClassesDataGridViewTextBoxColumn});
            this.dgvSession.DataSource = this.tblSessionBindingSource;
            this.dgvSession.Location = new System.Drawing.Point(0, 62);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.Size = new System.Drawing.Size(884, 499);
            this.dgvSession.TabIndex = 0;
            this.dgvSession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSession_CellContentClick);
            // 
            // tblSessionBindingSource
            // 
            this.tblSessionBindingSource.DataSource = typeof(CrystalReportsApplication1.tblSession);
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            // 
            // sessionNameDataGridViewTextBoxColumn
            // 
            this.sessionNameDataGridViewTextBoxColumn.DataPropertyName = "SessionName";
            this.sessionNameDataGridViewTextBoxColumn.HeaderText = "SessionName";
            this.sessionNameDataGridViewTextBoxColumn.Name = "sessionNameDataGridViewTextBoxColumn";
            this.sessionNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // tblClassesDataGridViewTextBoxColumn
            // 
            this.tblClassesDataGridViewTextBoxColumn.DataPropertyName = "tblClasses";
            this.tblClassesDataGridViewTextBoxColumn.HeaderText = "tblClasses";
            this.tblClassesDataGridViewTextBoxColumn.Name = "tblClassesDataGridViewTextBoxColumn";
            this.tblClassesDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvSession);
            this.Name = "frmSession";
            this.Text = "Sessions";
            this.Load += new System.EventHandler(this.FrmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSessionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSession;
        private System.Windows.Forms.BindingSource tblSessionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblClassesDataGridViewTextBoxColumn;
    }
}