using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Veiculo
{
    internal class Caminhao : Veiculo
    {
        //CRIAÇÃO DE VARIÁVEIS
        private string qtdEixos;
        private string tipoCarga;
        private string cargaMax;
        private string tipoCabine;
        private string tipoCaminhao;



        //INSTÂNCIA DE VARIAÉVSI (SEM PARÂMETROS)
        public Caminhao()
        {
            this.qtdEixos = null;
            this.tipoCarga = null;
            this.cargaMax = null;
            this.tipoCabine = null;
            this.tipoCaminhao = null;
        }



        // INSTÂNCIA DE VARIÁVEIS (COM PARÂMETROS)
        public Caminhao(string placa,
                        string modelo,
                        string marca,
                        string preco,
                        string altura,
                        string peso,
                        string largura,
                        string tipoFreio,
                        string cor,
                        string qtdEixos,
                        string tipoComb,
                        string qtdComb,
                        string tipoCarga,
                        string cargaMax,
                        string tipoCaminhao,
                        string tipoCabine,
                        string qtdPassageiros,
                        string potMotor)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Preco = preco;
            this.QtdPassageiros = qtdPassageiros;
            this.Altura = altura;
            this.Peso = peso;
            this.Largura = largura;
            this.TipoComb = tipoComb;
            this.QtdComb = qtdComb;
            this.Marca = marca;
            this.TipoFreio = tipoFreio;
            this.Cor = cor;
            this.qtdEixos = qtdEixos;
            this.tipoCarga = tipoCarga;
            this.cargaMax = cargaMax;
            this.tipoCabine = tipoCabine;
            this.tipoCaminhao = tipoCaminhao;
            this.PotMotor = potMotor;
        }



        // GET E SET
        public String QtdEixos
        {
            get { return this.qtdEixos; }
            set { this.qtdEixos = value; }
        }

        public String TipoCarga
        {
            get { return this.tipoCarga; }
            set { this.tipoCarga = value; }
        }
        public String CargaMax
        {
            get { return this.cargaMax; }
            set { this.cargaMax = value; }
        }
        public String TipoCabine
        {
            get { return this.tipoCabine; }
            set { this.tipoCabine = value; }
        }
        public String TipoCaminhao
        {
            get { return this.tipoCaminhao; }
            set { this.tipoCaminhao = value; }
        }



        // cONCATENAÇÃO DAS VARIÁVEIS E RETORNO DO MÉTODO EXIBIRDADOS
        public override string ExibirDados()
        {
            String s = String.Empty;
            s = String.Concat("Placa: " + this.Placa, "\n",
                "Modelo: " + this.Modelo, "\n",
                "Marca: " + this.Marca, "\n",
                "Preco: R$" + this.Preco, "\n",
                "Altura: " + this.Altura + " metros", "\n",
                "Peso: " + this.Peso + " tonaladas", "\n",
                "Largura: " + this.Largura + " metros", "\n",
                "Tipo do freio: " + this.TipoFreio, "\n",
                "Cor: " + this.Cor, "\n",
                "Quantidade de eixos: " + this.QtdEixos, "\n",
                "Tipo de Combustível: " + this.TipoComb, "\n",
                "Capacidade do tanque: " + this.QtdComb + " litros", "\n",
                "Tipo de carga: " + this.TipoCarga, "\n",
                "Carga máxima: " + this.CargaMax + " toneladas", "\n",
                "Tipo do caminhão: " + this.TipoCaminhao, "\n",
                "Tipo da cabine: " + this.TipoCabine, "\n",
                "Quantidade de passageiros: " + this.QtdPassageiros, "\n",
                "Potência do motor: " + this.PotMotor + "cv", "\n");
            return s;
        }
    }
}

