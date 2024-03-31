using System;
using System.Linq;
using System.Windows.Forms;

namespace CrystalReportsApplication1
{
    public partial class frmSession : Form
    {
        dbIDCardEntities db = new dbIDCardEntities();

        public frmSession()
        {
            InitializeComponent();
        }

        private void FrmSession_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSession.Columns[1].ReadOnly = false;
                dgvSession.AllowUserToAddRows = true;
                dgvSession.AllowUserToDeleteRows = true;
                dgvSession.AllowUserToOrderColumns = true;
                dgvSession.DataSource = db.tblSessions.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void dgvSession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
