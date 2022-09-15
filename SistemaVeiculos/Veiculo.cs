using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    // Classe com atributos e métodos de veiculo
    public abstract class Veiculo
    {
        // Atributos de Veiculo
        public string Marca{get; set;}
        public string Modelo{ get; set;}
        public int QtdRodas { get; set;}
        public string TipoAbastecimento { get; set;}
        public string EstadoPlaca { get; set;}

        // Construtor de veículo
        public Veiculo()
        {
            this.Marca = null;
            this.Modelo = null;
            this.QtdRodas = 0;
            this.TipoAbastecimento = null;
            this.EstadoPlaca = null;
        }

        // Método para consultar carros
        public virtual string Consulta(){
            return $"Marca: {Marca}\nModelo: {Modelo}\nQuantidade de rodas: {QtdRodas}\nTipo de Abastecimento: {TipoAbastecimento}\nEstado da Placa: {EstadoPlaca}\n";
        }

    }
}
