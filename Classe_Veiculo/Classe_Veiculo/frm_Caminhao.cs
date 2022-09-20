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
    public partial class frm_Caminhao : Form
    {
        Caminhao caminhao;
        public frm_Caminhao()
        {
            InitializeComponent();
        }


        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txt__Placa.Text,
                            txt_Modelo.Text,
                            txt_Marca.Text,
                            txt_Preco.Text,
                            txt_Altura.Text,
                            txt_Peso.Text,
                            txt_Largura.Text,
                            txt_TpFreio.Text,
                            txt_Cor.Text,
                            txt_QtdEixos.Text,
                            txt_TpCombustivel.Text,
                            txt_QtdCombustivel.Text,
                            txt_TpCarga.Text,
                            txt_CargaMax.Text,
                            txt_TpCaminhao.Text,
                            txt_TpCabine.Text,
                            txt_QtdPassageiros.Text,
                            txt_PotMotor.Text);

                            txt__Placa.Clear();
                            txt_Modelo.Clear();
                            txt_Marca.Clear();
                            txt_Preco.Clear();
                            txt_Altura.Clear();
                            txt_Peso.Clear();
                            txt_Largura.Clear();
                            txt_TpFreio.Clear();
                            txt_Cor.Clear();
                            txt_QtdEixos.Clear();
                            txt_TpCombustivel.Clear();
                            txt_QtdCombustivel.Clear();
                            txt_TpCarga.Clear();
                            txt_CargaMax.Clear();
                            txt_TpCaminhao.Clear();
                            txt_TpCabine.Clear();
                            txt_QtdPassageiros.Clear();
                            txt_PotMotor.Clear();
        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.ExibirDados());
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
