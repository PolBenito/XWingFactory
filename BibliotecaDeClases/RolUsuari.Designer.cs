namespace BibliotecaDeClases
{
    partial class RolUsuari
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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblRolUsuari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(6, 5);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(53, 29);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Rol:";
            // 
            // lblRolUsuari
            // 
            this.lblRolUsuari.AutoSize = true;
            this.lblRolUsuari.BackColor = System.Drawing.Color.Black;
            this.lblRolUsuari.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuari.ForeColor = System.Drawing.Color.White;
            this.lblRolUsuari.Location = new System.Drawing.Point(50, 5);
            this.lblRolUsuari.Name = "lblRolUsuari";
            this.lblRolUsuari.Size = new System.Drawing.Size(0, 29);
            this.lblRolUsuari.TabIndex = 1;
            // 
            // RolUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblRolUsuari);
            this.Controls.Add(this.lblRol);
            this.Name = "RolUsuari";
            this.Size = new System.Drawing.Size(250, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblRolUsuari;
    }
}
