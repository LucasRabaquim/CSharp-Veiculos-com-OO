using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    // Classe com atributos do caminhão herdando da atributos da classe veículo
    public class Caminhao : Veiculo
    {
        // Atributos da classe Caminhão
        public string TipoCarga { get; set; }
        public int CargaMaxima { get; set; }
        public double Altura { get; set; }

        // Construtor da classe caminhão
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

        // Utilização do método da classe veículo, usando override para mudar o seu funcionamento. 
        public override string Consulta()
        {
            return base.Consulta() + $"Tipo de carga: {TipoCarga}\n" +
                $"Carga Máxima: {CargaMaxima}\n" +
                $"Altura: {Altura}";
        }

    }


}