using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniJocs
{
    public partial class FrmPenjat : Form
    {
        String[] LlParaules = new string[7];
        String Paraula;
        Char[] Lletres;
        String lletra;
        int cont = 0;

        public FrmPenjat()
        {

            InitializeComponent();
        }

     

        public void switchCont()
        {
            switch (cont)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Penjat1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Penjat2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Penjat3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Penjat4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Penjat5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.Penjat6;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.Penjat7;
                    break;
                case 8:
                    pictureBox2.Image = Properties.Resources.Penjat8;
                    break;
                default:

                    break;
            }
        }


        private void FrmPenjat_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int n;
            n = r.Next(0, 5);

            LlParaules[0] = "bacon";
            LlParaules[1] = "adios";
            LlParaules[2] = "drama";
            LlParaules[3] = "mafia";
            LlParaules[4] = "juego";
            LlParaules[5] = "pinza";
            LlParaules[6] = "lapiz";

            Paraula = LlParaules[n];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString() == Paraula)
            {
                MessageBox.Show("Has guanyat", "FELICITATS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                cont++;
                if (cont < 8) switchCont();
                else
                {
                    MessageBox.Show("Has perdut", "RIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int trobat = 0;
            lletra = textBox1.Text.ToLower().ToString();

            if (cont < 8 && !(Paraula.Contains(lletra)))
            {
                cont++;

                if (cont == 8)
                {
                    MessageBox.Show("Has perdut", "RIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {

                    switchCont();

                }
            }
            else
            {

                while (trobat == 0 && i < 5)
                {
                    if (lletra == Paraula[i].ToString()) trobat = 1;
                    else i++;
                }

                switch (i)
                {
                    case 0:
                        letra1.Text = lletra;
                        break;
                    case 1:
                        letra2.Text = lletra;
                        break;
                    case 2:
                        letra3.Text = lletra;
                        break;
                    case 3:
                        letra4.Text = lletra;
                        break;
                    case 4:
                        letra5.Text = lletra;
                        break;
                    default:

                        break;
                }

                if (letra1.Text != "#" && letra2.Text != "#" && letra3.Text != "#" && letra4.Text != "#" && letra5.Text != "#")
                {
                    MessageBox.Show("Has guanyat", "FELICITATS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }
    }
}
