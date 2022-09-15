using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SistemaVeiculos
{
    public partial class frmCadastrarCaminhao : Form
    {
        public frmCadastrarCaminhao()
        {
            InitializeComponent();
        }

        Caminhao caminhao;
        // Botão que verifica se os campos estão preenchidos e cria um objeto caminhão em caso positivo.
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int caixasNaoPreenchidas = 0;
            TextBox[] campos = { txtMarca, txtModelo, txtQtdRodas, txtAbasteciment, txtEstadoPlaca, txtTipoCarga, txtCargaMax, txtAltura };
            foreach (TextBox atributo in campos)
                caixasNaoPreenchidas += (atributo.Text == "") ? 1 : 0;
            if (caixasNaoPreenchidas != 0)
                MessageBox.Show("Preencha todos os campos e tente novamente.", "Campos não preenchidos");
            else{
                caminhao = new Caminhao(txtMarca.Text, txtModelo.Text, Convert.ToInt16(txtQtdRodas.Text), txtAbasteciment.Text, txtEstadoPlaca.Text, txtTipoCarga.Text, Convert.ToInt16(txtCargaMax.Text), Convert.ToDouble(txtAltura.Text));
                foreach (TextBox atributo in campos)
                    atributo.Clear();
            }
        }

        // Botão que verifica se há um objeto caminhão criado e apresenta seus dados em caso positivo
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (caminhao == null)
                MessageBox.Show("Nenhum caminhão registrado ainda.", "Erro de consulta.");
            else
                MessageBox.Show(caminhao.Consulta());
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
