using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace sistemaAlertrem
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictboxImagemUsu_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnAdicionarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("d:\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pictboxImagemUsu.ImageLocation = (BuscarIMG.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictboxImagemUsu.Image = null;
        }
    }
}
