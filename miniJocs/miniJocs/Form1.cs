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
        FrmPenjat xPenjat;
        public Form1()
        {
            InitializeComponent();
        }

        private void penjatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xPenjat = new FrmPenjat();
            xPenjat.MdiParent = this;
            xPenjat.Show();
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
