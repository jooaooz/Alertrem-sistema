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
    public partial class frmComentarios : Form
    {
        public frmComentarios()
        {
            InitializeComponent();
            carregaDados(0);
        }

        public frmComentarios(int user_id)
        {
            InitializeComponent();
            carregaDados(user_id);
        }

        public void carregaDados(int id)
        {
            string commandString = id != 0 ? $"select * from tb_comentarios where codigo = {id}" : "select * from tb_comentarios";

            MySqlCommand comm = new MySqlCommand
            {
                CommandText = commandString,
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };


            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            dgvComentarios.DataSource = tabela;

            Conexao.fecharConexao();

        }
    }
}
