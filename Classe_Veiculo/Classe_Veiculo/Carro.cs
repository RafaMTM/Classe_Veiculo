using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Veiculo
{
    public class Carro: Veiculo
    {
        // CRIAÇÃO DE VARIÁVEIS
        private string qtdPortas;
        private string tamPortaMalas;
        private string tipoCarro;



        // INSTÂNCIA DE VARIÁVEIS (SEM PARÂMETROS)
        public Carro()
        {
            this.qtdPortas = null;
            this.tamPortaMalas = null;
            this.tipoCarro = null;
        }



        // INSTÃNCIA DE VARIÁVEIS (COM PARÂMETROS)
        public Carro(   string placa,
                        string modelo,
                        string marca,
                        string preco,
                        string altura,
                        string peso,
                        string largura,
                        string cor,
                        string qtdPortas,
                        string tipoComb,
                        string qtdComb,
                        string tamPortaMalas,
                        string potMotor,
                        string tipoFreio,
                        string tipoCarro,
                        string qtdPassageiros)
                             
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Preco = preco;
            this.Altura = altura;
            this.Peso = peso;
            this.Largura = largura;
            this.Cor = cor;
            this.qtdPortas = qtdPortas;
            this.TipoComb = tipoComb;
            this.QtdComb = qtdComb;
            this.tamPortaMalas = tamPortaMalas;
            this.PotMotor = potMotor;
            this.TipoFreio = tipoFreio;
            this.tipoCarro = tipoCarro;
            this.QtdPassageiros = qtdPassageiros;
        }



        // GET E SET 
        public String QtdPortas
        {
            get { return qtdPortas; }
            set { qtdPortas = value; }
        }
        public String TamPortaMalas
        {
            get { return tamPortaMalas; }
            set { tamPortaMalas = value; }
        }

        public String TipoCarro
        {
            get { return tipoCarro; }
            set { tipoCarro = value; }
        }



        // CONCATENAÇÃO DAS VARIÁVEIS E RETORNO DO MÉTODO EXIBIRDADOS
        public override string ExibirDados()
        {
            String s = String.Empty;
            s = String.Concat("Placa: " + this.Preco, "\n",
                "Modelo: " + this.Modelo, "\n",
                "Marca: " + this.Marca, "\n",
                "Preco: R$" + this.Preco, "\n",
                "Altura: " + this.Altura + " metros", "\n",
                "Peso: " + this.Peso + " toneladas", "\n",
                "Largura: " + this.Largura + " metros", "\n",
                "Cor: " + this.Cor, "\n",
                "Quantidade de portas: " + this.QtdPortas, "\n",
                "Tipo de Combustível: " + this.TipoComb, "\n",
                "Capacidade do tanque: " + this.QtdComb + " litros", "\n",
                "Capacidade do porta malas: " + this.TamPortaMalas + " litros", "\n",
                "Potência do motor: " + this.PotMotor + "cv", "\n",
                "Tipo do freio: " + this.TipoFreio, "\n",
                "Tipo do carro: " + this.TipoCarro, "\n",
                "Quantidade de passageiros: " + this.QtdPassageiros, "\n");
            return s;
            
        }
    }
}
