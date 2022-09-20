using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Veiculo
{
    public partial class frm_Carro : Form
    {
        Carro carro;
        public frm_Carro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            carro = new Carro(txt__Placa.Text,
                            txt_Modelo.Text,
                            txt_Marca.Text,
                            txt_Preco.Text,
                            txt_Altura.Text,
                            txt_Peso.Text,
                            txt_Largura.Text,
                            txt_Cor.Text,
                            txt_QtdPortas.Text, 
                            txt_TpCombustivel.Text,
                            txt_QtdCombustivel.Text,
                            txt_TamPortaMalas.Text,
                            txt_PotMotor.Text,
                            txt_TpFreio.Text,
                            txt_TpCarro.Text,
                            txt_QtdPassageiros.Text);

                            txt__Placa.Clear();
                            txt_Modelo.Clear();
                            txt_Marca.Clear();
                            txt_Preco.Clear();
                            txt_Altura.Clear();
                            txt_Peso.Clear();
                            txt_Largura.Clear();
                            txt_TpCarro.Clear();
                            txt_Cor.Clear();
                            txt_QtdPortas.Clear();
                            txt_TpCombustivel.Clear();
                            txt_QtdCombustivel.Clear();
                            txt_TamPortaMalas.Clear();
                            txt_PotMotor.Clear();
                            txt_TpFreio.Clear();
                            txt_QtdPassageiros.Clear();

        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.ExibirDados());
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Menu Menu = new frm_Menu();
            this.Hide();
            Menu.Show();
            btn_Voltar.Focus();
        }
    }
}
