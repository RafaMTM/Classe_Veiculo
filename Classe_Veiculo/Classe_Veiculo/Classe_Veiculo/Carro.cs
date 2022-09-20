using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Veiculo
{
    internal class Carro
    {
        byte QtdPortas { get; set; }

        double TamPortaMalas { get; set; }

        string TipoCarro { get; set; }
    }

    public virtual string Exibir()
    {
        return $"A quantidade de portas é {QtdPortas},  a capacidade do porta malas é: {TamPortaMalas} litros, este carro é do tipo: {TipoCarro}";

    }

    public void Cadastrar()
    {

    }

    public bool Atualizar()
    {
        return true;
    }

}
