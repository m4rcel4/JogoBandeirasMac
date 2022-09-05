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
    public partial class campoJog2x1 : Form
    {
        public campoJog2x1()
        {
            InitializeComponent();
        }

        
   

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu a carta 1", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnSlctBand1.Visible = false;
                pictureBox1.Visible = false;


            }
            else if (dialogResult == DialogResult.No)
            {
               
            }

            campoJogo2x2 form=new campoJogo2x2();
            form.Show();
        }

        private void btnSlctBand2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu a carta 2", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnSlctBand2.Visible = false;
                pictureBox2.Visible = false;


            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void btnSlctBand3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu a carta 3", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnSlctBand3.Visible = false;
                pictureBox3.Visible = false;


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnSlctBand4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu a carta 4", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnSlctBand4.Visible = false;
                pictureBox4.Visible = false;


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnSlctBand5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Você escolheu a carta 5", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnSlctBand5.Visible = false;
                pictureBox5.Visible = false;


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
