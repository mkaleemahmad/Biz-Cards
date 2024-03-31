using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReportsApplication1
{
    public partial class frmInsertPictures : Form
    {
        Functions fn = new Functions();
        dbIDCardEntities db = new dbIDCardEntities();

        public frmInsertPictures()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                int stdStartId = Convert.ToInt32(txtStdIDStart.Value);
                int stdEndId = Convert.ToInt32(txtStdIDEnd.Value);
                int imgID = Convert.ToInt32(txtImgStart.Value);
                string imagePath = txtPath.Text + imgID + txtEndingExtention.Text;

                    while (stdStartId <= stdEndId)
                    {
                        if (File.Exists(imagePath))
                        {
                            //image to byteArray
                            Image img = Image.FromFile(imagePath);
                            byte[] bArr = fn.ImageToByteArray(img);
                            //byte[] bArr = imgToByteConverter(img);
                            //Again convert byteArray to image and displayed in a picturebox
                            Image img1 = fn.ByteArrayToImage(bArr);
                            pictureBox1.Image = img1;
                            tblPicture pic1 = new tblPicture
                            {
                                StudentID = stdStartId,
                                Picture = bArr
                            };
                            db.tblPictures.Add(pic1);
                        }
                        else
                        {
                            MessageBox.Show("Image file not found: " + imagePath);
                        }
                        stdStartId++;
                        imgID++;
                        imagePath = txtPath.Text + imgID + txtEndingExtention.Text;
                    }
                    db.SaveChanges();
                    MessageBox.Show("All images inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException.Message);
            }
        }

        private void txtEndingExtention_TextChanged(object sender, EventArgs e)
        {
            txtTestPath.Text = txtPath.Text + txtImgStart.Value + txtEndingExtention.Text;
            pictureBox1.ImageLocation = txtTestPath.Text;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            txtTestPath.Text = txtPath.Text + txtImgStart.Value + txtEndingExtention.Text;
            pictureBox1.ImageLocation = txtTestPath.Text;

        }
        
        private void btnTestLoadImage_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = txtTestPath.Text;
                 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImgStart_ValueChanged(object sender, EventArgs e)
        {
            txtTestPath.Text = txtPath.Text + txtImgStart.Value + txtEndingExtention.Text;
            pictureBox1.ImageLocation = txtTestPath.Text;
        }

        private void txtImgStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTestPath.Text = txtPath.Text + txtImgStart.Value + txtEndingExtention.Text;
            pictureBox1.ImageLocation = txtTestPath.Text;

        }

        private void txtImgStart_KeyDown(object sender, KeyEventArgs e)
        {
            txtTestPath.Text = txtPath.Text + txtImgStart.Value + txtEndingExtention.Text;
            pictureBox1.ImageLocation = txtTestPath.Text;

        }

        private void txtImgStart_KeyUp(object sender, KeyEventArgs e)
        {
            txtTestPath.Text = txtPath.Text + txtImgStart.Value + txtEndingExtention.Text;
            pictureBox1.ImageLocation = txtTestPath.Text;
        }

        private void frmInsertPictures_Load(object sender, EventArgs e)
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

        private void btnFolderDailog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath.Text = folderBrowserDialog1.SelectedPath;
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

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ClassID = Convert.ToInt32(cmbClass.SelectedValue);

                int StartID = db.tblStudents.Where(a => a.ClassID == ClassID).First().StudentID;
                txtStdIDStart.Value = StartID;

                int EndID = db.tblStudents.Where(a => a.ClassID == ClassID).ToList().Last().StudentID;
                txtStdIDEnd.Value = EndID;

                lblTotalStudents.Text = (EndID - StartID + 1).ToString() +"; "+ db.tblStudents.Where(a => a.ClassID == ClassID).Count();
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
    }
}
