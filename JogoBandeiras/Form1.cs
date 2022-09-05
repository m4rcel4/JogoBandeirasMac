using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoBandeiras
{
    public partial class partidas : Form
    {
        public partidas()
        {
            InitializeComponent();
        }

        private void btnDoisJogadores_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu 2 jogadores", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cadastroDoisNomes form = new cadastroDoisNomes();
                this.Hide();
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                partidas form = new partidas();
                this.Hide();
                form.Show();
            }







        }

        private void btnTresJogadores_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu 3 jogadores", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cadastroTresNomes form = new cadastroTresNomes();
                this.Hide();
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                partidas form = new partidas();
                this.Hide();
                form.Show();
            }
        }
    }
}
