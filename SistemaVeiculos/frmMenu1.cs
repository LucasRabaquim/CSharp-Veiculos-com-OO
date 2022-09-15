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
    public partial class frmMenu1 : Form
    {
        public frmMenu1()
        {
            InitializeComponent();
        }

        // Botão que instância a tela para cadastro de carros e apresenta ela.
        private void btnCarro_Click(object sender, EventArgs e)
        {
            frmCadastrarCarro carro = new frmCadastrarCarro();
            this.Hide();
            carro.Show();
        }

        // Botão que instância a tela para cadastro de caminhões e apresenta ela.
        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            frmCadastrarCaminhao caminhao = new frmCadastrarCaminhao();
            this.Hide();
            caminhao.Show();
        }

        // Botão que sai do programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
