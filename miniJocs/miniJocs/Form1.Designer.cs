namespace miniJocs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedraPaperTisoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jocsToolStripMenuItem,
            this.finestresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jocsToolStripMenuItem
            // 
            this.jocsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjatToolStripMenuItem,
            this.pedraPaperTisoraToolStripMenuItem});
            this.jocsToolStripMenuItem.Name = "jocsToolStripMenuItem";
            this.jocsToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.jocsToolStripMenuItem.Text = "Jocs";
            // 
            // penjatToolStripMenuItem
            // 
            this.penjatToolStripMenuItem.Name = "penjatToolStripMenuItem";
            this.penjatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.penjatToolStripMenuItem.Text = "Penjat";
            this.penjatToolStripMenuItem.Click += new System.EventHandler(this.penjatToolStripMenuItem_Click);
            // 
            // pedraPaperTisoraToolStripMenuItem
            // 
            this.pedraPaperTisoraToolStripMenuItem.Name = "pedraPaperTisoraToolStripMenuItem";
            this.pedraPaperTisoraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pedraPaperTisoraToolStripMenuItem.Text = "Pedra-Paper-Tisora";
            // 
            // finestresToolStripMenuItem
            // 
            this.finestresToolStripMenuItem.Name = "finestresToolStripMenuItem";
            this.finestresToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.finestresToolStripMenuItem.Text = "Finestres";
            this.finestresToolStripMenuItem.Click += new System.EventHandler(this.finestresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MiniJocs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedraPaperTisoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finestresToolStripMenuItem;
    }
}

