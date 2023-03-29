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
            Conexao.fecharConexao();

            dgvComentarios.DataSource = tabela;

            dgvComentarios.Columns["comentario"].Width = 300;

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.Name = "Excluir";
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvComentarios.Columns.Add(btnExcluir);

            // Impede que o usuário redimensione as colunas e linhas do DataGridView
            dgvComentarios.AllowUserToResizeColumns = false;
            dgvComentarios.AllowUserToResizeRows = false;

            // Define o modo de ajuste da altura das linhas para exibir o conteúdo completo
            dgvComentarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Define a propriedade de ajuste de altura das linhas para que o conteúdo completo seja exibido
            dgvComentarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Faz com que o DataGridView ocupe 100% do espaço disponível
            dgvComentarios.Dock = DockStyle.Fill;            
        }

        public void apagaRegistro(int id_comentario)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"delete from tb_comentarios where codigo = {id_comentario}",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Registro Excluido com Sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();
        }

        private void dgvComentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvComentarios.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                int codigo = (int)dgvComentarios.Rows[e.RowIndex].Cells["codigo"].Value;

                DialogResult confirma = MessageBox.Show($"Você quer mesmo apagar o comentário com id {codigo}?",
                    "Confirmação de exclusão de registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                if (confirma == DialogResult.Yes) {
                    apagaRegistro(codigo);
                    dgvComentarios.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
    }
}
