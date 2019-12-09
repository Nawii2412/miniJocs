using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace miniJocs
{
    public partial class TresEnRatlla : Form
    {
        Boolean turn = true;
        Boolean rival = false;
        Int32 win = 0;
        List<Bitmap> llImatges = new List<Bitmap>();
        List<PictureBox> llPB = new List<PictureBox>();
        Random r = new Random();

        public TresEnRatlla()
        {
            InitializeComponent();
        }

        private void cs1x1_Click(object sender, EventArgs e)
        {
            Int32 rand;
            if (((PictureBox)sender).Image == null && win == 0)
            {
                if (turn)
                {
                    ((PictureBox)sender).Image = llImatges[0];
                    ((PictureBox)sender).SizeMode = PictureBoxSizeMode.StretchImage;
                    if (rival)
                    {
                        lbTurn.Text = "Player2";
                        turn = !turn;
                    }
                }
                else
                {
                    ((PictureBox)sender).Image = llImatges[1];
                    ((PictureBox)sender).SizeMode = PictureBoxSizeMode.StretchImage;
                    lbTurn.Text = "Player1";
                    turn = !turn;
                }

                win = comprovaGuanyador();

                if (!rival && win == 0)
                {
                    do
                    {
                        rand = r.Next(0, 9);
                        Thread.Sleep(5);
                    } while (llPB[rand].Image != null);
                    llPB[rand].Image = llImatges[1];
                    llPB[rand].SizeMode = PictureBoxSizeMode.StretchImage;
                    win = comprovaGuanyador();
                }

                if (win == 1)
                {
                    MessageBox.Show("Ha guanyat el jugador 1", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    if (win == 2)
                    {
                        if (rival)
                        {
                            MessageBox.Show("Ha guanyat el jugador 2", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            MessageBox.Show("Has perdut", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                }
            }
        }

        private void btCPUv2P_Click(object sender, EventArgs e)
        {
            rival = !rival;
            resetPanel();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            resetPanel();
        }

        private void resetPanel()
        {
            Int32 i;
            for (i = 0; i < 9; i += 1)
            {
                llPB[i].Image = null;
            }
            turn = true;
            lbTurn.Text = "Player1";
            win = 0;
        }

        private void TresEnRatlla_Load(object sender, EventArgs e)
        {
            llImatges.Add(new Bitmap(miniJocs.Properties.Resources.o));
            llImatges.Add(new Bitmap(miniJocs.Properties.Resources.x));
            llPB.Add(cs1x1);
            llPB.Add(cs1x2);
            llPB.Add(cs1x3);
            llPB.Add(cs2x1);
            llPB.Add(cs2x2);
            llPB.Add(cs2x3);
            llPB.Add(cs3x1);
            llPB.Add(cs3x2);
            llPB.Add(cs3x3);
        }

        private Int32 comprovaGuanyador()
        {
            Int32 guanyador = 0;
            Int32 i;
            List<Int32> llxo = new List<int>();

            for (i = 0; i < 9; i += 1)
            {
                if (llPB[i].Image == llImatges[0])
                {
                    llxo.Add(1);
                }
                else
                {
                    if (llPB[i].Image == llImatges[1])
                    {
                        llxo.Add(2);
                    }
                    else
                    {
                        llxo.Add(0);
                    }
                }
            }

            try
            {
                if (llxo[0] == 1 && llxo[1] == 1 && llxo[2] == 1 || llxo[0] == 1 && llxo[4] == 1 && llxo[8] == 1 || llxo[0] == 1 && llxo[3] == 1 && llxo[6] == 1 || llxo[2] == 1 && llxo[5] == 1 && llxo[8] == 1 || llxo[2] == 1 && llxo[4] == 1 && llxo[6] == 1 || llxo[3] == 1 && llxo[4] == 1 && llxo[5] == 1 || llxo[6] == 1 && llxo[7] == 1 && llxo[8] == 1)
                {
                    guanyador = 1;
                }
                else
                {
                    if (llxo[0] == 2 && llxo[1] == 2 && llxo[2] == 2 || llxo[0] == 2 && llxo[4] == 2 && llxo[8] == 2 || llxo[0] == 2 && llxo[3] == 2 && llxo[6] == 2 || llxo[2] == 2 && llxo[5] == 2 && llxo[8] == 2 || llxo[2] == 2 && llxo[4] == 2 && llxo[6] == 2 || llxo[3] == 2 && llxo[4] == 2 && llxo[5] == 2 || llxo[6] == 2 && llxo[7] == 2 && llxo[8] == 2)
                    {
                        guanyador = 2;
                    }
                }
            }
            catch (Exception)
            {

            }
            return guanyador;
        }
    }
}
