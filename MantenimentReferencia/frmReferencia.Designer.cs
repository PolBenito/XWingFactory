namespace MantenimentReferencia
{
    partial class frmReferencia
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
            this.tbDescReference = new BibliotecaDeClases.SdsTextbox();
            this.lbDescReferenceType = new System.Windows.Forms.Label();
            this.tbCodeReference = new BibliotecaDeClases.SdsTextbox();
            this.lbCodeReferenceType = new System.Windows.Forms.Label();
            this.tbVideo = new BibliotecaDeClases.SdsTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFoto = new BibliotecaDeClases.SdsTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdReference = new BibliotecaDeClases.SdsTextbox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAfegir = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.graellaDades = new System.Windows.Forms.DataGridView();
            this.tipusReferenciaLbl = new System.Windows.Forms.Label();
            this.cbTipusReferencia = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbIdReferenceType = new BibliotecaDeClases.SdsTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescReference
            // 
            this.tbDescReference.BackColor = System.Drawing.Color.Black;
            this.tbDescReference.CampBBDD = "descReference";
            this.tbDescReference.ControlId = null;
            this.tbDescReference.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescReference.Forana = false;
            this.tbDescReference.ForeColor = System.Drawing.Color.White;
            this.tbDescReference.Location = new System.Drawing.Point(530, 326);
            this.tbDescReference.MaxLength = 200;
            this.tbDescReference.Name = "tbDescReference";
            this.tbDescReference.PlaceHolder = null;
            this.tbDescReference.Requerit = false;
            this.tbDescReference.Size = new System.Drawing.Size(250, 26);
            this.tbDescReference.TabIndex = 2;
            this.tbDescReference.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // lbDescReferenceType
            // 
            this.lbDescReferenceType.AutoSize = true;
            this.lbDescReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescReferenceType.ForeColor = System.Drawing.Color.White;
            this.lbDescReferenceType.Location = new System.Drawing.Point(526, 289);
            this.lbDescReferenceType.Name = "lbDescReferenceType";
            this.lbDescReferenceType.Size = new System.Drawing.Size(171, 21);
            this.lbDescReferenceType.TabIndex = 34;
            this.lbDescReferenceType.Text = "Descripció Referència";
            // 
            // tbCodeReference
            // 
            this.tbCodeReference.BackColor = System.Drawing.Color.Black;
            this.tbCodeReference.CampBBDD = "codeReference";
            this.tbCodeReference.ControlId = null;
            this.tbCodeReference.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeReference.Forana = false;
            this.tbCodeReference.ForeColor = System.Drawing.Color.White;
            this.tbCodeReference.Location = new System.Drawing.Point(530, 244);
            this.tbCodeReference.MaxLength = 12;
            this.tbCodeReference.Name = "tbCodeReference";
            this.tbCodeReference.PlaceHolder = null;
            this.tbCodeReference.Requerit = false;
            this.tbCodeReference.Size = new System.Drawing.Size(250, 26);
            this.tbCodeReference.TabIndex = 1;
            this.tbCodeReference.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // lbCodeReferenceType
            // 
            this.lbCodeReferenceType.AutoSize = true;
            this.lbCodeReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeReferenceType.ForeColor = System.Drawing.Color.White;
            this.lbCodeReferenceType.Location = new System.Drawing.Point(526, 205);
            this.lbCodeReferenceType.Name = "lbCodeReferenceType";
            this.lbCodeReferenceType.Size = new System.Drawing.Size(128, 21);
            this.lbCodeReferenceType.TabIndex = 33;
            this.lbCodeReferenceType.Text = "Codi Referència";
            // 
            // tbVideo
            // 
            this.tbVideo.BackColor = System.Drawing.Color.Black;
            this.tbVideo.CampBBDD = "VideoExplode";
            this.tbVideo.ControlId = null;
            this.tbVideo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVideo.Forana = false;
            this.tbVideo.ForeColor = System.Drawing.Color.White;
            this.tbVideo.Location = new System.Drawing.Point(883, 326);
            this.tbVideo.MaxLength = 200;
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.PlaceHolder = null;
            this.tbVideo.Requerit = false;
            this.tbVideo.Size = new System.Drawing.Size(250, 26);
            this.tbVideo.TabIndex = 4;
            this.tbVideo.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(879, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Video";
            // 
            // tbFoto
            // 
            this.tbFoto.BackColor = System.Drawing.Color.Black;
            this.tbFoto.CampBBDD = "Photo";
            this.tbFoto.ControlId = null;
            this.tbFoto.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFoto.Forana = false;
            this.tbFoto.ForeColor = System.Drawing.Color.White;
            this.tbFoto.Location = new System.Drawing.Point(883, 244);
            this.tbFoto.MaxLength = 200;
            this.tbFoto.Name = "tbFoto";
            this.tbFoto.PlaceHolder = null;
            this.tbFoto.Requerit = false;
            this.tbFoto.Size = new System.Drawing.Size(250, 26);
            this.tbFoto.TabIndex = 3;
            this.tbFoto.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(879, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Foto";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(804, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 50);
            this.panel1.TabIndex = 40;
            // 
            // tbIdReference
            // 
            this.tbIdReference.BackColor = System.Drawing.Color.Black;
            this.tbIdReference.CampBBDD = "idReference";
            this.tbIdReference.ControlId = null;
            this.tbIdReference.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdReference.Forana = false;
            this.tbIdReference.ForeColor = System.Drawing.Color.White;
            this.tbIdReference.Location = new System.Drawing.Point(804, 153);
            this.tbIdReference.MaxLength = 12;
            this.tbIdReference.Name = "tbIdReference";
            this.tbIdReference.PlaceHolder = null;
            this.tbIdReference.Requerit = false;
            this.tbIdReference.Size = new System.Drawing.Size(50, 26);
            this.tbIdReference.TabIndex = 39;
            this.tbIdReference.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Black;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(1404, 496);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(110, 40);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAfegir
            // 
            this.btAfegir.BackColor = System.Drawing.Color.Black;
            this.btAfegir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAfegir.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btAfegir.ForeColor = System.Drawing.Color.White;
            this.btAfegir.Location = new System.Drawing.Point(1404, 424);
            this.btAfegir.Name = "btAfegir";
            this.btAfegir.Size = new System.Drawing.Size(110, 40);
            this.btAfegir.TabIndex = 6;
            this.btAfegir.Text = "AFEGIR";
            this.btAfegir.UseVisualStyleBackColor = false;
            this.btAfegir.Click += new System.EventHandler(this.btAfegir_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Black;
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(1404, 568);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(110, 40);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // graellaDades
            // 
            this.graellaDades.AllowUserToAddRows = false;
            this.graellaDades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graellaDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.graellaDades.BackgroundColor = System.Drawing.Color.Black;
            this.graellaDades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graellaDades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.graellaDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graellaDades.GridColor = System.Drawing.Color.DarkGray;
            this.graellaDades.Location = new System.Drawing.Point(530, 424);
            this.graellaDades.Name = "graellaDades";
            this.graellaDades.ReadOnly = true;
            this.graellaDades.Size = new System.Drawing.Size(750, 450);
            this.graellaDades.TabIndex = 9;
            // 
            // tipusReferenciaLbl
            // 
            this.tipusReferenciaLbl.AutoSize = true;
            this.tipusReferenciaLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipusReferenciaLbl.ForeColor = System.Drawing.Color.White;
            this.tipusReferenciaLbl.Location = new System.Drawing.Point(1258, 244);
            this.tipusReferenciaLbl.Name = "tipusReferenciaLbl";
            this.tipusReferenciaLbl.Size = new System.Drawing.Size(174, 22);
            this.tipusReferenciaLbl.TabIndex = 42;
            this.tipusReferenciaLbl.Text = "Tipus de referències:";
            // 
            // cbTipusReferencia
            // 
            this.cbTipusReferencia.BackColor = System.Drawing.Color.Black;
            this.cbTipusReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipusReferencia.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipusReferencia.ForeColor = System.Drawing.Color.White;
            this.cbTipusReferencia.FormattingEnabled = true;
            this.cbTipusReferencia.Location = new System.Drawing.Point(1263, 275);
            this.cbTipusReferencia.Name = "cbTipusReferencia";
            this.cbTipusReferencia.Size = new System.Drawing.Size(270, 29);
            this.cbTipusReferencia.TabIndex = 5;
            this.cbTipusReferencia.SelectedIndexChanged += new System.EventHandler(this.cbTipusReferencia_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1200, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 50);
            this.panel2.TabIndex = 44;
            // 
            // tbIdReferenceType
            // 
            this.tbIdReferenceType.BackColor = System.Drawing.Color.Black;
            this.tbIdReferenceType.CampBBDD = "idReferenceType";
            this.tbIdReferenceType.ControlId = null;
            this.tbIdReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdReferenceType.Forana = false;
            this.tbIdReferenceType.ForeColor = System.Drawing.Color.White;
            this.tbIdReferenceType.Location = new System.Drawing.Point(1201, 187);
            this.tbIdReferenceType.MaxLength = 12;
            this.tbIdReferenceType.Name = "tbIdReferenceType";
            this.tbIdReferenceType.PlaceHolder = null;
            this.tbIdReferenceType.Requerit = false;
            this.tbIdReferenceType.Size = new System.Drawing.Size(50, 26);
            this.tbIdReferenceType.TabIndex = 43;
            this.tbIdReferenceType.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            this.tbIdReferenceType.TextChanged += new System.EventHandler(this.tbIdReferenceType_TextChanged);
            // 
            // frmReferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 916);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbIdReferenceType);
            this.Controls.Add(this.tipusReferenciaLbl);
            this.Controls.Add(this.cbTipusReferencia);
            this.Controls.Add(this.graellaDades);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAfegir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdReference);
            this.Controls.Add(this.tbVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescReference);
            this.Controls.Add(this.lbDescReferenceType);
            this.Controls.Add(this.tbCodeReference);
            this.Controls.Add(this.lbCodeReferenceType);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmReferencia";
            this.Text = "Manteniment de referències";
            this.Load += new System.EventHandler(this.frmReferencia_Load);
            this.Controls.SetChildIndex(this.lbCodeReferenceType, 0);
            this.Controls.SetChildIndex(this.tbCodeReference, 0);
            this.Controls.SetChildIndex(this.lbDescReferenceType, 0);
            this.Controls.SetChildIndex(this.tbDescReference, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbFoto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbVideo, 0);
            this.Controls.SetChildIndex(this.tbIdReference, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btGuardar, 0);
            this.Controls.SetChildIndex(this.btAfegir, 0);
            this.Controls.SetChildIndex(this.btEliminar, 0);
            this.Controls.SetChildIndex(this.graellaDades, 0);
            this.Controls.SetChildIndex(this.cbTipusReferencia, 0);
            this.Controls.SetChildIndex(this.tipusReferenciaLbl, 0);
            this.Controls.SetChildIndex(this.tbIdReferenceType, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDeClases.SdsTextbox tbDescReference;
        private System.Windows.Forms.Label lbDescReferenceType;
        private BibliotecaDeClases.SdsTextbox tbCodeReference;
        private System.Windows.Forms.Label lbCodeReferenceType;
        private BibliotecaDeClases.SdsTextbox tbVideo;
        private System.Windows.Forms.Label label1;
        private BibliotecaDeClases.SdsTextbox tbFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private BibliotecaDeClases.SdsTextbox tbIdReference;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAfegir;
        private System.Windows.Forms.Button btGuardar;
        public System.Windows.Forms.DataGridView graellaDades;
        private System.Windows.Forms.Label tipusReferenciaLbl;
        private System.Windows.Forms.ComboBox cbTipusReferencia;
        private System.Windows.Forms.Panel panel2;
        private BibliotecaDeClases.SdsTextbox tbIdReferenceType;
    }
}