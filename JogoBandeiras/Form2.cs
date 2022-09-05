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
    public partial class cadastroDoisNomes : Form
    {
        public cadastroDoisNomes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            campoJog2x1 form = new campoJog2x1();
            this.Hide();
            form.Show();
        }
    }
}
