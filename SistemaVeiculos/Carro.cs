using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    // Classe com atributos do carro herdando da atributos da classe veículo
    public class Carro : Veiculo
    {
        // Atributos da classe carro
        public int TamanhoPortaMalas { get; set; }
        public int QtdPortas { get; set; }
        public int QtdAcento { get; set; }

        // Construtor da classe carro
        public Carro(string marca, string modelo, int qtdRodas, string tipoAbastecimento, string estadoPlaca, int tamanhoPortaMala, int qtdPortas, int qtdAcento)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.QtdRodas = qtdRodas;
            this.TipoAbastecimento = tipoAbastecimento;
            this.EstadoPlaca = estadoPlaca;
            this.TamanhoPortaMalas = tamanhoPortaMala;
            this.QtdPortas = qtdPortas;
            this.QtdAcento = qtdAcento;
        }

        // Utilização do método da classe veículo, usando override para mudar o seu funcionamento. 
        public override string Consulta()
        {
            return base.Consulta() + $"Tamanho do portamalas: {TamanhoPortaMalas}\n" + 
                $"Quantidade de portas: {QtdPortas}\n" +
                $"Quantidade de acentos: {QtdAcento}";
        }

      }

  
}
