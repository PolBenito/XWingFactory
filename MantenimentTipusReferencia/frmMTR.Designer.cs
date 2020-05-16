namespace MantenimentTipusReferencia
{
    partial class frmMTR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMTR));
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAfegir = new System.Windows.Forms.Button();
            this.tbCodeReferenceType = new BibliotecaDeClases.SdsTextbox();
            this.graellaDades = new System.Windows.Forms.DataGridView();
            this.lbCodeReferenceType = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbDescReferenceType = new BibliotecaDeClases.SdsTextbox();
            this.lbDescReferenceType = new System.Windows.Forms.Label();
            this.tbIdReferenceType = new BibliotecaDeClases.SdsTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).BeginInit();
            this.SuspendLayout();
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Black;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(954, 273);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(110, 40);
            this.btEliminar.TabIndex = 4;
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
            this.btAfegir.Location = new System.Drawing.Point(954, 201);
            this.btAfegir.Name = "btAfegir";
            this.btAfegir.Size = new System.Drawing.Size(110, 40);
            this.btAfegir.TabIndex = 3;
            this.btAfegir.Text = "AFEGIR";
            this.btAfegir.UseVisualStyleBackColor = false;
            this.btAfegir.Click += new System.EventHandler(this.btAfegir_Click);
            // 
            // tbCodeReferenceType
            // 
            this.tbCodeReferenceType.BackColor = System.Drawing.Color.Black;
            this.tbCodeReferenceType.CampBBDD = "codeReferenceType";
            this.tbCodeReferenceType.ControlId = null;
            this.tbCodeReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeReferenceType.Forana = false;
            this.tbCodeReferenceType.ForeColor = System.Drawing.Color.White;
            this.tbCodeReferenceType.Location = new System.Drawing.Point(434, 205);
            this.tbCodeReferenceType.MaxLength = 12;
            this.tbCodeReferenceType.Name = "tbCodeReferenceType";
            this.tbCodeReferenceType.PlaceHolder = null;
            this.tbCodeReferenceType.Requerit = false;
            this.tbCodeReferenceType.Size = new System.Drawing.Size(100, 26);
            this.tbCodeReferenceType.TabIndex = 1;
            this.tbCodeReferenceType.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // graellaDades
            // 
            this.graellaDades.AllowUserToAddRows = false;
            this.graellaDades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graellaDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.graellaDades.BackgroundColor = System.Drawing.Color.Black;
            this.graellaDades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graellaDades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.graellaDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graellaDades.GridColor = System.Drawing.Color.DarkGray;
            this.graellaDades.Location = new System.Drawing.Point(434, 385);
            this.graellaDades.Name = "graellaDades";
            this.graellaDades.ReadOnly = true;
            this.graellaDades.Size = new System.Drawing.Size(680, 350);
            this.graellaDades.TabIndex = 6;
            // 
            // lbCodeReferenceType
            // 
            this.lbCodeReferenceType.AutoSize = true;
            this.lbCodeReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeReferenceType.ForeColor = System.Drawing.Color.White;
            this.lbCodeReferenceType.Location = new System.Drawing.Point(430, 166);
            this.lbCodeReferenceType.Name = "lbCodeReferenceType";
            this.lbCodeReferenceType.Size = new System.Drawing.Size(172, 21);
            this.lbCodeReferenceType.TabIndex = 28;
            this.lbCodeReferenceType.Text = "Codi Tipus Referència";
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Black;
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(1104, 239);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(110, 40);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbDescReferenceType
            // 
            this.tbDescReferenceType.BackColor = System.Drawing.Color.Black;
            this.tbDescReferenceType.CampBBDD = "descReferenceType";
            this.tbDescReferenceType.ControlId = null;
            this.tbDescReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescReferenceType.Forana = false;
            this.tbDescReferenceType.ForeColor = System.Drawing.Color.White;
            this.tbDescReferenceType.Location = new System.Drawing.Point(434, 287);
            this.tbDescReferenceType.MaxLength = 200;
            this.tbDescReferenceType.Name = "tbDescReferenceType";
            this.tbDescReferenceType.PlaceHolder = null;
            this.tbDescReferenceType.Requerit = false;
            this.tbDescReferenceType.Size = new System.Drawing.Size(350, 26);
            this.tbDescReferenceType.TabIndex = 2;
            this.tbDescReferenceType.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            this.tbDescReferenceType.Leave += new System.EventHandler(this.tbDescReferenceType_Leave);
            // 
            // lbDescReferenceType
            // 
            this.lbDescReferenceType.AutoSize = true;
            this.lbDescReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescReferenceType.ForeColor = System.Drawing.Color.White;
            this.lbDescReferenceType.Location = new System.Drawing.Point(430, 250);
            this.lbDescReferenceType.Name = "lbDescReferenceType";
            this.lbDescReferenceType.Size = new System.Drawing.Size(215, 21);
            this.lbDescReferenceType.TabIndex = 30;
            this.lbDescReferenceType.Text = "Descripció Tipus Referència";
            // 
            // tbIdReferenceType
            // 
            this.tbIdReferenceType.BackColor = System.Drawing.Color.Black;
            this.tbIdReferenceType.CampBBDD = "idReferenceType";
            this.tbIdReferenceType.ControlId = null;
            this.tbIdReferenceType.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdReferenceType.Forana = false;
            this.tbIdReferenceType.ForeColor = System.Drawing.Color.White;
            this.tbIdReferenceType.Location = new System.Drawing.Point(764, 199);
            this.tbIdReferenceType.MaxLength = 12;
            this.tbIdReferenceType.Name = "tbIdReferenceType";
            this.tbIdReferenceType.PlaceHolder = null;
            this.tbIdReferenceType.Requerit = false;
            this.tbIdReferenceType.Size = new System.Drawing.Size(50, 26);
            this.tbIdReferenceType.TabIndex = 7;
            this.tbIdReferenceType.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(751, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 50);
            this.panel1.TabIndex = 31;
            // 
            // frmMTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdReferenceType);
            this.Controls.Add(this.tbDescReferenceType);
            this.Controls.Add(this.lbDescReferenceType);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAfegir);
            this.Controls.Add(this.tbCodeReferenceType);
            this.Controls.Add(this.graellaDades);
            this.Controls.Add(this.lbCodeReferenceType);
            this.Controls.Add(this.btGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMTR";
            this.Text = "Manteniment de Tipus de Referència";
            this.Load += new System.EventHandler(this.frmMTR_Load);
            this.Controls.SetChildIndex(this.btGuardar, 0);
            this.Controls.SetChildIndex(this.lbCodeReferenceType, 0);
            this.Controls.SetChildIndex(this.graellaDades, 0);
            this.Controls.SetChildIndex(this.tbCodeReferenceType, 0);
            this.Controls.SetChildIndex(this.btAfegir, 0);
            this.Controls.SetChildIndex(this.btEliminar, 0);
            this.Controls.SetChildIndex(this.lbDescReferenceType, 0);
            this.Controls.SetChildIndex(this.tbDescReferenceType, 0);
            this.Controls.SetChildIndex(this.tbIdReferenceType, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAfegir;
        private BibliotecaDeClases.SdsTextbox tbCodeReferenceType;
        public System.Windows.Forms.DataGridView graellaDades;
        private System.Windows.Forms.Label lbCodeReferenceType;
        private System.Windows.Forms.Button btGuardar;
        private BibliotecaDeClases.SdsTextbox tbDescReferenceType;
        private System.Windows.Forms.Label lbDescReferenceType;
        private BibliotecaDeClases.SdsTextbox tbIdReferenceType;
        private System.Windows.Forms.Panel panel1;
    }
}