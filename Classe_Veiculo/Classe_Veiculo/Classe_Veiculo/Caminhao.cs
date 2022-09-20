using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Veiculo
{
    internal class Caminhao
    {
        byte QtdEixos { get; set; }

        string TipoCarga { get; set; }

        double CargaMax { get; set; }

        string TipoCabina { get; set; }

        string TipoCaminhao { get; set; }
    }

    public virtual string Exibir()
    {
        return $"Este caminhão possui {QtdEixos} eixos, sua carga tem capacidade para {CargaMax} Kg, sendo do tipo {TipoCarga}. O caminhão é do tipo {TipoCaminhao} com cabine {TipoCabine}";

    }

    public void Cadastrar()
    {

    }

    public bool Atualizar()
    {
        return true;
    }

}

