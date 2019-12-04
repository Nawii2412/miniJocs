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
    public partial class PedraPaperTisores : Form
    {
        List<Bitmap> llimatges = new List<Bitmap>();
        public PedraPaperTisores()
        {
            InitializeComponent();
        }

        private void iniImatges()
        {
            llimatges.Add(new Bitmap(miniJocs.Properties.Resources.piedra));
            llimatges.Add(new Bitmap(miniJocs.Properties.Resources.papel));
            llimatges.Add(new Bitmap(miniJocs.Properties.Resources.tijeras));
        }

        private void btPedra_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int nAleatori;
            System.Threading.Thread.Sleep(2);
            nAleatori = R.Next(0, 3);
            pbOrdinador.Image = llimatges[nAleatori];
            if(nAleatori == 1)
            {
                MessageBox.Show("Has perdut", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(nAleatori == 2)
            {
                MessageBox.Show("Has guanyat!", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Empat", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btPaper_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int random;
            System.Threading.Thread.Sleep(2);
            random = R.Next(0, 3);
            pbOrdinador.Image = llimatges[random];
            if (random == 1)
            {
                MessageBox.Show("Empat", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (random == 2)
            {
                MessageBox.Show("Has perdut", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Has guanyat!", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btTisores_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int random;
            System.Threading.Thread.Sleep(2);
            random = R.Next(0, 3);
            pbOrdinador.Image = llimatges[random];
            if (random == 1)
            {
                MessageBox.Show("Has guanyat!", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (random == 2)
            {
                MessageBox.Show("Empat", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Has perdut", "Fi del joc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PedraPaperTisores_Load(object sender, EventArgs e)
        {
            iniImatges();
        }
    }
}
