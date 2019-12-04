namespace miniJocs
{
    partial class PedraPaperTisores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedraPaperTisores));
            this.btPedra = new System.Windows.Forms.Button();
            this.btPaper = new System.Windows.Forms.Button();
            this.btTisores = new System.Windows.Forms.Button();
            this.pbOrdinador = new System.Windows.Forms.PictureBox();
            this.pbTisores = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbPedra = new System.Windows.Forms.PictureBox();
            this.lbOrdinador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrdinador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTisores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPedra)).BeginInit();
            this.SuspendLayout();
            // 
            // btPedra
            // 
            this.btPedra.Location = new System.Drawing.Point(132, 42);
            this.btPedra.Name = "btPedra";
            this.btPedra.Size = new System.Drawing.Size(75, 23);
            this.btPedra.TabIndex = 0;
            this.btPedra.Text = "Pedra";
            this.btPedra.UseVisualStyleBackColor = true;
            this.btPedra.Click += new System.EventHandler(this.btPedra_Click);
            // 
            // btPaper
            // 
            this.btPaper.Location = new System.Drawing.Point(132, 177);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(75, 23);
            this.btPaper.TabIndex = 1;
            this.btPaper.Text = "Paper";
            this.btPaper.UseVisualStyleBackColor = true;
            this.btPaper.Click += new System.EventHandler(this.btPaper_Click);
            // 
            // btTisores
            // 
            this.btTisores.Location = new System.Drawing.Point(132, 308);
            this.btTisores.Name = "btTisores";
            this.btTisores.Size = new System.Drawing.Size(75, 23);
            this.btTisores.TabIndex = 2;
            this.btTisores.Text = "Tisores";
            this.btTisores.UseVisualStyleBackColor = true;
            this.btTisores.Click += new System.EventHandler(this.btTisores_Click);
            // 
            // pbOrdinador
            // 
            this.pbOrdinador.Location = new System.Drawing.Point(431, 206);
            this.pbOrdinador.Name = "pbOrdinador";
            this.pbOrdinador.Size = new System.Drawing.Size(76, 68);
            this.pbOrdinador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrdinador.TabIndex = 4;
            this.pbOrdinador.TabStop = false;
            // 
            // pbTisores
            // 
            this.pbTisores.Image = ((System.Drawing.Image)(resources.GetObject("pbTisores.Image")));
            this.pbTisores.Location = new System.Drawing.Point(132, 337);
            this.pbTisores.Name = "pbTisores";
            this.pbTisores.Size = new System.Drawing.Size(75, 68);
            this.pbTisores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTisores.TabIndex = 5;
            this.pbTisores.TabStop = false;
            // 
            // pbPaper
            // 
            this.pbPaper.Image = ((System.Drawing.Image)(resources.GetObject("pbPaper.Image")));
            this.pbPaper.Location = new System.Drawing.Point(132, 206);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(75, 68);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaper.TabIndex = 6;
            this.pbPaper.TabStop = false;
            // 
            // pbPedra
            // 
            this.pbPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPedra.Image = ((System.Drawing.Image)(resources.GetObject("pbPedra.Image")));
            this.pbPedra.Location = new System.Drawing.Point(132, 71);
            this.pbPedra.Name = "pbPedra";
            this.pbPedra.Size = new System.Drawing.Size(75, 71);
            this.pbPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPedra.TabIndex = 7;
            this.pbPedra.TabStop = false;
            // 
            // lbOrdinador
            // 
            this.lbOrdinador.AutoSize = true;
            this.lbOrdinador.Location = new System.Drawing.Point(431, 177);
            this.lbOrdinador.Name = "lbOrdinador";
            this.lbOrdinador.Size = new System.Drawing.Size(76, 17);
            this.lbOrdinador.TabIndex = 8;
            this.lbOrdinador.Text = "Ordinador:";
            // 
            // PedraPaperTisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOrdinador);
            this.Controls.Add(this.pbPedra);
            this.Controls.Add(this.pbPaper);
            this.Controls.Add(this.pbTisores);
            this.Controls.Add(this.pbOrdinador);
            this.Controls.Add(this.btTisores);
            this.Controls.Add(this.btPaper);
            this.Controls.Add(this.btPedra);
            this.Name = "PedraPaperTisores";
            this.Text = "PedraPaperTisores";
            this.Load += new System.EventHandler(this.PedraPaperTisores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOrdinador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTisores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPedra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPedra;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.Button btTisores;
        private System.Windows.Forms.PictureBox pbOrdinador;
        private System.Windows.Forms.PictureBox pbTisores;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.PictureBox pbPedra;
        private System.Windows.Forms.Label lbOrdinador;
    }
}