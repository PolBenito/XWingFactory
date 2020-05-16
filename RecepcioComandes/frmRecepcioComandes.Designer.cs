namespace RecepcioComandes
{
    partial class frmRecepcioComandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcioComandes));
            this.btProcessarComandes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbComandes = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btMostrarCR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProcessarComandes
            // 
            this.btProcessarComandes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProcessarComandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcessarComandes.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessarComandes.ForeColor = System.Drawing.Color.White;
            this.btProcessarComandes.Location = new System.Drawing.Point(698, 136);
            this.btProcessarComandes.Name = "btProcessarComandes";
            this.btProcessarComandes.Size = new System.Drawing.Size(210, 70);
            this.btProcessarComandes.TabIndex = 1;
            this.btProcessarComandes.Text = "Processar comandes";
            this.btProcessarComandes.UseVisualStyleBackColor = true;
            this.btProcessarComandes.Click += new System.EventHandler(this.btProcessarComandes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(421, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 78);
            this.label1.TabIndex = 54;
            this.label1.Text = "- Baixar arxiu .edi\r\n- Guardar les comandes \r\n   a la Base de dades";
            // 
            // lbComandes
            // 
            this.lbComandes.AutoSize = true;
            this.lbComandes.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComandes.ForeColor = System.Drawing.Color.White;
            this.lbComandes.Location = new System.Drawing.Point(434, 331);
            this.lbComandes.Name = "lbComandes";
            this.lbComandes.Size = new System.Drawing.Size(0, 37);
            this.lbComandes.TabIndex = 55;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(426, 267);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1100, 600);
            this.crystalReportViewer1.TabIndex = 56;
            // 
            // btMostrarCR
            // 
            this.btMostrarCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMostrarCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrarCR.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrarCR.ForeColor = System.Drawing.Color.White;
            this.btMostrarCR.Location = new System.Drawing.Point(1183, 136);
            this.btMostrarCR.Name = "btMostrarCR";
            this.btMostrarCR.Size = new System.Drawing.Size(210, 70);
            this.btMostrarCR.TabIndex = 58;
            this.btMostrarCR.Text = "Mostrar dades";
            this.btMostrarCR.UseVisualStyleBackColor = true;
            this.btMostrarCR.Click += new System.EventHandler(this.btMostrarCR_Click);
            // 
            // frmRecepcioComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 920);
            this.Controls.Add(this.btMostrarCR);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lbComandes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btProcessarComandes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmRecepcioComandes";
            this.Text = "Recepcio de Comandes";
            this.Controls.SetChildIndex(this.btProcessarComandes, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbComandes, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.btMostrarCR, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcessarComandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbComandes;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btMostrarCR;
    }
}