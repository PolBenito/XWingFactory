namespace MantenimentNivellAcces
{
    partial class frmNivellAcces
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
            this.lbOperaris = new System.Windows.Forms.ListBox();
            this.lbEnginyers = new System.Windows.Forms.ListBox();
            this.lbAdmins = new System.Windows.Forms.ListBox();
            this.tipusReferenciaLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guardarBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOperaris
            // 
            this.lbOperaris.AllowDrop = true;
            this.lbOperaris.BackColor = System.Drawing.Color.Black;
            this.lbOperaris.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperaris.ForeColor = System.Drawing.Color.White;
            this.lbOperaris.FormattingEnabled = true;
            this.lbOperaris.ItemHeight = 21;
            this.lbOperaris.Location = new System.Drawing.Point(474, 209);
            this.lbOperaris.Name = "lbOperaris";
            this.lbOperaris.Size = new System.Drawing.Size(300, 592);
            this.lbOperaris.TabIndex = 1;
            this.lbOperaris.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbOperaris_DragDrop);
            this.lbOperaris.DragOver += new System.Windows.Forms.DragEventHandler(this.lbOperaris_DragOver);
            this.lbOperaris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbOperaris_MouseDown);
            // 
            // lbEnginyers
            // 
            this.lbEnginyers.AllowDrop = true;
            this.lbEnginyers.BackColor = System.Drawing.Color.Black;
            this.lbEnginyers.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnginyers.ForeColor = System.Drawing.Color.White;
            this.lbEnginyers.FormattingEnabled = true;
            this.lbEnginyers.ItemHeight = 21;
            this.lbEnginyers.Location = new System.Drawing.Point(835, 209);
            this.lbEnginyers.Name = "lbEnginyers";
            this.lbEnginyers.Size = new System.Drawing.Size(300, 592);
            this.lbEnginyers.TabIndex = 54;
            this.lbEnginyers.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbEnginyers_DragDrop);
            this.lbEnginyers.DragOver += new System.Windows.Forms.DragEventHandler(this.lbEnginyers_DragOver);
            this.lbEnginyers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbEnginyers_MouseDown);
            // 
            // lbAdmins
            // 
            this.lbAdmins.AllowDrop = true;
            this.lbAdmins.BackColor = System.Drawing.Color.Black;
            this.lbAdmins.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmins.ForeColor = System.Drawing.Color.White;
            this.lbAdmins.FormattingEnabled = true;
            this.lbAdmins.ItemHeight = 21;
            this.lbAdmins.Location = new System.Drawing.Point(1199, 209);
            this.lbAdmins.Name = "lbAdmins";
            this.lbAdmins.Size = new System.Drawing.Size(300, 592);
            this.lbAdmins.TabIndex = 55;
            this.lbAdmins.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbAdmins_DragDrop);
            this.lbAdmins.DragOver += new System.Windows.Forms.DragEventHandler(this.lbAdmins_DragOver);
            this.lbAdmins.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAdmins_MouseDown);
            // 
            // tipusReferenciaLbl
            // 
            this.tipusReferenciaLbl.AutoSize = true;
            this.tipusReferenciaLbl.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipusReferenciaLbl.ForeColor = System.Drawing.Color.White;
            this.tipusReferenciaLbl.Location = new System.Drawing.Point(554, 148);
            this.tipusReferenciaLbl.Name = "tipusReferenciaLbl";
            this.tipusReferenciaLbl.Size = new System.Drawing.Size(119, 37);
            this.tipusReferenciaLbl.TabIndex = 56;
            this.tipusReferenciaLbl.Text = "Operari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(918, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Enginyer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1251, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 58;
            this.label2.Text = "Administrador";
            // 
            // guardarBT
            // 
            this.guardarBT.BackColor = System.Drawing.Color.Black;
            this.guardarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBT.Font = new System.Drawing.Font("Montserrat", 12F);
            this.guardarBT.ForeColor = System.Drawing.Color.White;
            this.guardarBT.Location = new System.Drawing.Point(1389, 838);
            this.guardarBT.Name = "guardarBT";
            this.guardarBT.Size = new System.Drawing.Size(110, 43);
            this.guardarBT.TabIndex = 59;
            this.guardarBT.Text = "GUARDAR";
            this.guardarBT.UseVisualStyleBackColor = false;
            this.guardarBT.Click += new System.EventHandler(this.guardarBT_Click);
            // 
            // frmNivellAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 920);
            this.Controls.Add(this.guardarBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipusReferenciaLbl);
            this.Controls.Add(this.lbAdmins);
            this.Controls.Add(this.lbEnginyers);
            this.Controls.Add(this.lbOperaris);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmNivellAcces";
            this.Text = "Manteniment del nivell d\'accés";
            this.Load += new System.EventHandler(this.frmNivellAcces_Load);
            this.Controls.SetChildIndex(this.lbOperaris, 0);
            this.Controls.SetChildIndex(this.lbEnginyers, 0);
            this.Controls.SetChildIndex(this.lbAdmins, 0);
            this.Controls.SetChildIndex(this.tipusReferenciaLbl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.guardarBT, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOperaris;
        private System.Windows.Forms.ListBox lbEnginyers;
        private System.Windows.Forms.ListBox lbAdmins;
        private System.Windows.Forms.Label tipusReferenciaLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guardarBT;
    }
}