using System;
using System.Windows.Forms;

namespace CrystalReportsApplication1
{
    public partial class MDIHome : Form
    {
        dbIDCardEntities db = new dbIDCardEntities();

        private int childFormNumber = 0;

        public MDIHome()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Window " + childFormNumber++
            };
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void insertPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertPictures frm = new frmInsertPictures
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void studentsMenuItem_Click(object sender, EventArgs e)
        {
            frmStudents frm = new frmStudents
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MDIHome_Load(object sender, EventArgs e)
        {
            try
            {
                frmStudents frm = new frmStudents
                {
                    MdiParent = this
                };
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void classwiseCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCardsReports frm = new frmCardsReports
            {
                MdiParent = this
            };
            frm.Show();
            frm.BringToFront();
            frm.TopMost = true;
        }
        

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSession frm = new frmSession
            {
                MdiParent = this
            };
            frm.Show();
        }
    }
}
