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
    public partial class Frmcomentario : Form
    {
        public Frmcomentario()
        {
            InitializeComponent();
            TestarConexaoBanco();
        }

        private void Frmcomentario_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestarConexaoBanco();
            
        }
        public void TestarConexaoBanco()
        {
            bool bancoOnline = Conexao.testarConexao();
            if (bancoOnline)
            {
                lblEstadoDoBanco.Text = "Online";
                lblEstadoDoBanco.ForeColor = Color.Green;
            }
            else
            {
                lblEstadoDoBanco.Text = "Offline";
                lblEstadoDoBanco.ForeColor = Color.Red;
            }
        }
    }

}
