namespace BibliotecaDeClases
{
    partial class Sds_Codi
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
            this.tbCodi = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCodi
            // 
            this.tbCodi.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodi.Location = new System.Drawing.Point(162, 12);
            this.tbCodi.Name = "tbCodi";
            this.tbCodi.Size = new System.Drawing.Size(100, 22);
            this.tbCodi.TabIndex = 0;
            this.tbCodi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodi_KeyDown);
            this.tbCodi.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodi_Validating);
            // 
            // tbDesc
            // 
            this.tbDesc.Enabled = false;
            this.tbDesc.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(276, 12);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(215, 22);
            this.tbDesc.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(12, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 21);
            this.label.TabIndex = 2;
            this.label.Text = "label1";
            // 
            // Sds_Codi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbCodi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Sds_Codi";
            this.Size = new System.Drawing.Size(499, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodi;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label;
    }
}
