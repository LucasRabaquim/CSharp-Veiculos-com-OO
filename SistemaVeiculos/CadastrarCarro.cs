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
    public partial class CadastrarCarro : Form
    {
        public CadastrarCarro()
        {
            InitializeComponent();
        }

        Carro carro;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            carro = new Carro(txtMarca.Text, txtModelo.Text, Convert.ToInt16(txtQtdRodas.Text), txtPortaMalas.Text, txtEstadoPlaca.Text, txtPortaMalas.Text, Convert.ToInt16(txtQtdPortas.Text), Convert.ToInt16(txtQtdAssentos.Text));
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Consulta());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }
    }
}
