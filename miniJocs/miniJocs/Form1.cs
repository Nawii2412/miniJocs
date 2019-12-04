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
    public partial class Form1 : Form
    {
        PedraPaperTisores frmPedraPaperTisores;
        public Form1()
        {
            InitializeComponent();
        }

        private void penjatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*fFitxerText = new FrmFitxerText();
                fFitxerText.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---
            }
            fFitxerText.WindowState = FormWindowState.Normal;
            fFitxerText.Show();*/
        }

        private void finestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void pedraPaperTisoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("frmPedraPaperTisores")))
            {
                frmPedraPaperTisores = new PedraPaperTisores();
                frmPedraPaperTisores.MdiParent = this;
                //frmPedraPaperTisores.Show();
            }
            frmPedraPaperTisores.WindowState = FormWindowState.Normal;
            frmPedraPaperTisores.Show();
        }

        Boolean ja_està_obert(String xnom_frm)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom_frm);
                x1++;
            }
            return (xb);
        }
    }
}
