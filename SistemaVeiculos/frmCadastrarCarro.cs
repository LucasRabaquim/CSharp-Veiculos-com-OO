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
    public partial class frmCadastrarCarro : Form
    {
        public frmCadastrarCarro()
        {
            InitializeComponent();
        }

        Carro carro;
        // Botão que verifica se os campos estão preenchidos e cria um objeto carro em caso positivo.
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int caixasNaoPreenchidas = 0;
            TextBox[] campos = { txtMarca, txtModelo, txtQtdRodas, txtAbasteciment, txtEstadoPlaca, txtPortaMalas, txtQtdPortas, txtQtdAssentos };
            foreach(TextBox atributo in campos)
                caixasNaoPreenchidas += (atributo.Text == "") ? 1 : 0;
            if (caixasNaoPreenchidas != 0)
                MessageBox.Show("Preencha todos os campos e tente novamente.", "Campos não preenchidos");
            else{
                carro = new Carro(txtMarca.Text, txtModelo.Text, Convert.ToInt16(txtQtdRodas.Text), txtAbasteciment.Text, txtEstadoPlaca.Text, Convert.ToInt16(txtPortaMalas.Text), Convert.ToInt16(txtQtdPortas.Text), Convert.ToInt16(txtQtdAssentos.Text));
                foreach (TextBox atributo in campos)
                    atributo.Clear();
            }
        }

        // Botão que verifica se há um objeto caminhão criado e apresenta seus dados em caso positivo
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(carro == null)
                MessageBox.Show("Nenhum carro registrado ainda.","Erro de consulta.");
            else
                MessageBox.Show(carro.Consulta());
        }

        // Botão que instancia a tela inicial e retorna para ela
        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu1 menu = new frmMenu1();
            this.Hide();
            menu.Show();
        }
    }
}
