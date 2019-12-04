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
            frmPedraPaperTisores = new PedraPaperTisores();
            frmPedraPaperTisores.MdiParent = this;
            frmPedraPaperTisores.Show();
        }
    }
}
