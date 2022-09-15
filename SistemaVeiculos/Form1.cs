using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            CadastrarCarro carro = new CadastrarCarro();
            this.Hide();
            carro.Show();
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            CadastrarCaminhao caminhao = new CadastrarCaminhao();
            this.Hide();
            caminhao.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
