using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistemaAlertrem
{
    public partial class frmEstacao1 : Form
    {
        public frmEstacao1()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void ptb3_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }
    }
}
