using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Veiculo
{
    public abstract class Veiculo
    {
        // CRIAÇÃO DE VARIÁVEIS
        private string placa;
        private string preco;
        private string modelo;
        private string qtdPassageiros;
        private string altura;
        private string peso;
        private string largura;
        private string tipoComb;
        private string qtdComb;
        private string marca;
        private string potMotor;
        private string tipoFreio;
        private string cor;



        // INSTÂNCIA DE VARIÁVEIS (SEM PARÂEMETROS)
        public Veiculo()
        {
            this.placa = null;
            this.preco = null;
            this.modelo = null;
            this.qtdPassageiros = null;
            this.altura = null;
            this.peso = null;
            this.largura = null;
            this.tipoComb = null;
            this.qtdComb = null;
            this.marca = null;
            this.potMotor = null;
            this.tipoFreio = null;
            this.cor = null;
        }


        // INSTÂNCIA DE VARIÁVEIS (COM PARÂMETROS)
        public Veiculo( string placa,
                        string preco,
                        string modelo,
                        string qtdPassageiros,
                        string altura,
                        string peso,
                        string largura,
                        string tipoComb,
                        string qtdComb,
                        string marca,
                        string potMotor,
                        string tipoFreio,
                        string cor)
        {
            this.placa = placa;
            this.preco = preco;
            this.modelo = modelo;
            this.qtdPassageiros = qtdPassageiros;
            this.altura = altura;
            this.peso = peso;
            this.largura = largura;
            this.tipoComb = tipoComb;
            this.qtdComb = qtdComb;
            this.marca = marca;
            this.potMotor = potMotor;
            this.tipoFreio = tipoFreio;
            this.cor = cor;
        }



        // GET E SET
        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public String Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public String QtdPassageiros
        {
            get { return qtdPassageiros; }
            set { qtdPassageiros = value; }
        }

        public String Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public String Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public String Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        public String TipoComb
        {
            get { return tipoComb; }
            set { tipoComb = value; }
        }
        public String QtdComb
        {
            get { return qtdComb; }
            set { qtdComb = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public String PotMotor
        {
            get { return potMotor; }
            set { potMotor = value; }
        }
        public String TipoFreio
        {
            get { return tipoFreio; }
            set { tipoFreio = value; }
        }
        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }



        // MÉTODO EXIBIRDADOS
        public abstract String ExibirDados();
        
    }

}
