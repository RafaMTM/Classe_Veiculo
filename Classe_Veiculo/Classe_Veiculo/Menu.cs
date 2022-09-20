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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            btn_Sair.Focus();
        }

        private void btn_Caminhao_Click(object sender, EventArgs e)
        {
            frm_Caminhao Caminhao = new frm_Caminhao();
            this.Hide();
            Caminhao.Show();
        }

        private void btn_Carro_Click(object sender, EventArgs e)
        {
            frm_Carro Carro = new frm_Carro();
            this.Hide();
            Carro.Show();
        }
    }
}
