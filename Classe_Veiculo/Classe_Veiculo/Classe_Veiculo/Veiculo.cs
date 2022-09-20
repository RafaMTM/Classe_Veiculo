using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Veiculo
{
    internal class Veiculo
    {
        string Placa { get; set; }

        double Preco { get; set; }

        string Modelo { get; set; }

        byte QtdPassageiros { get; set; }

        double Alutra { get; set; }

        double Peso { get; set; }

        double Largura { get; set; }

        string TipoCombustivel { get; set; }

        byte QtdCombustivel { get; set; }

        string ItensDeSeguranca { get; set; }

        string Marca { get; set; }

        byte PotenciaDoMotor { get; set; }

        string TipoDeFreio { get; set; }

        byte Cilindradas { get; set; }

        string Cor { get; set; }

        public virtual string Exibir()
        {
            return $"A marca do veiculo é: {Marca}, tem capacidade para {QtdPassageiros} passageiros, mede {Altura} x {Largura} e pesa {Peso}," + $"e tem capacidade para {QtdCombustivel} litros de combustivel";

        }

        public void Cadastrar()
        {

        }

        public bool Atualizar()
        {
            return true;
        }
    }

}
