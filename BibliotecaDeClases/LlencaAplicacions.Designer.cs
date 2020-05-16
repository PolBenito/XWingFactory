namespace BibliotecaDeClases
{
    partial class LlencaAplicacions
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLlencaApps = new System.Windows.Forms.Panel();
            this.nommenu = new System.Windows.Forms.Label();
            this.logomenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelLlencaApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logomenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelLlencaApps);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 99);
            this.panel1.TabIndex = 0;
            // 
            // panelLlencaApps
            // 
            this.panelLlencaApps.BackColor = System.Drawing.Color.Black;
            this.panelLlencaApps.Controls.Add(this.nommenu);
            this.panelLlencaApps.Controls.Add(this.logomenu);
            this.panelLlencaApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLlencaApps.ForeColor = System.Drawing.Color.White;
            this.panelLlencaApps.Location = new System.Drawing.Point(3, 0);
            this.panelLlencaApps.Name = "panelLlencaApps";
            this.panelLlencaApps.Size = new System.Drawing.Size(339, 95);
            this.panelLlencaApps.TabIndex = 0;
            this.panelLlencaApps.Click += new System.EventHandler(this.panelLlencaApps_Click);
            // 
            // nommenu
            // 
            this.nommenu.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nommenu.Location = new System.Drawing.Point(69, 19);
            this.nommenu.Name = "nommenu";
            this.nommenu.Size = new System.Drawing.Size(258, 60);
            this.nommenu.TabIndex = 2;
            this.nommenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nommenu.Click += new System.EventHandler(this.nommenu_Click);
            // 
            // logomenu
            // 
            this.logomenu.Enabled = false;
            this.logomenu.Location = new System.Drawing.Point(15, 26);
            this.logomenu.Name = "logomenu";
            this.logomenu.Size = new System.Drawing.Size(40, 40);
            this.logomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logomenu.TabIndex = 0;
            this.logomenu.TabStop = false;
            // 
            // LlencaAplicacions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LlencaAplicacions";
            this.Size = new System.Drawing.Size(345, 99);
            this.panel1.ResumeLayout(false);
            this.panelLlencaApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logomenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLlencaApps;
        private System.Windows.Forms.PictureBox logomenu;
        private System.Windows.Forms.Label nommenu;
    }
}
