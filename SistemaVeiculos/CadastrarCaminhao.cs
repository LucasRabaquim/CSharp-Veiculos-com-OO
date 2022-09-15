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
    public partial class CadastrarCaminhao : Form
    {
        public CadastrarCaminhao()
        {
            InitializeComponent();
        }

        Caminhao caminhao;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtMarca.Text, txtModelo.Text, Convert.ToInt16(txtQtdRodas.Text), txtAbasteciment.Text, txtEstadoPlaca.Text, txtTipoCarga.Text, Convert.ToInt16(txtCargaMax.Text), Convert.ToDouble(txtAltura.Text));

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.Consulta());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }
    }
}
