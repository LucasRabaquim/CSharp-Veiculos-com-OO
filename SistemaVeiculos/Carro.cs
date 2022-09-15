using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Carro : Veiculo
    {
        public string TamanhoPortaMalas { get; set; }
        public int QtdPortas { get; set; }
        public int QtdAcento { get; set; }

        public Carro(string marca, string modelo, int qtdRodas, string tipoAbastecimento, string estadoPlaca, string tamanhoPortaMala, int qtdPortas, int qtdAcento)
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

        public override string Consulta()
        {
            return base.Consulta() + $"Tamanho do portamalas: {TamanhoPortaMalas}\n" + 
                $"Quantidade de portas: {QtdPortas}\n" +
                $"Quantidade de acentos: {QtdAcento}";
        }

      }

  
}
