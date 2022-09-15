using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Caminhao : Veiculo
    {
        public string TipoCarga { get; set; }
        public int CargaMaxima { get; set; }
        public double Altura { get; set; }

        public Caminhao(string marca, string modelo, int qtdRodas, string tipoAbastecimento, string estadoPlaca, string tipocarga, int cargamaxima, double altura)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.QtdRodas = qtdRodas;
            this.TipoAbastecimento = tipoAbastecimento;
            this.EstadoPlaca = estadoPlaca;
            this.TipoCarga = tipocarga;
            this.CargaMaxima = cargamaxima;
            this.Altura = altura;
        }

        public override string Consulta()
        {
            return base.Consulta() + $"Tipo de carga: {TipoCarga}\n" +
                $"Carga Máxima: {CargaMaxima}\n" +
                $"Altura: {Altura}";
        }

    }


}