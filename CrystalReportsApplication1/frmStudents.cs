using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReportsApplication1
{
    public partial class frmStudents : Form
    {
        dbIDCardEntities db = new dbIDCardEntities();

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSession.DisplayMember = "SessionName";
                cmbSession.ValueMember = "SessionID";
                cmbSession.DataSource = db.tblSessions.ToList();

                cmbInstitutes.DisplayMember = "Institute";
                cmbInstitutes.ValueMember = "CollegeID";
                cmbInstitutes.DataSource = db.vwColleges.ToList();

                cmbClass.DisplayMember = "ClassName";
                cmbClass.ValueMember = "ClassID";
                cmbClass.DataSource = db.tblClasses.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClass.SelectedValue != null)
                {
                    int classid = Convert.ToInt32(cmbClass.SelectedValue);
                    dgvStudents.AutoGenerateColumns = false;
                    dgvStudents.DataSource = db.vwStudents.Where(a => a.ClassID == classid).ToList();
                }
                else {
                    MessageBox.Show("Please Select a class");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvStudents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvStudents.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void cbxShowPictures_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPictures.Checked)
            {
                dgvStudents.Columns["Picture"].Visible = true;
            }
            else
            {
                dgvStudents.Columns["Picture"].Visible = false;
            }
        }

        private void cmbInstitutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ColeggeID = Convert.ToInt32(cmbInstitutes.SelectedValue);
                int SessionID = Convert.ToInt32(cmbSession.SelectedValue);

                cmbClass.DataSource = db.tblClasses.Where(a => a.CollegeID == ColeggeID && a.SessionID == SessionID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ColeggeID = Convert.ToInt32(cmbInstitutes.SelectedValue);
                int SessionID = Convert.ToInt32(cmbSession.SelectedValue);

                cmbClass.DataSource = db.tblClasses.Where(a => a.CollegeID == ColeggeID && a.SessionID == SessionID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
