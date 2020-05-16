namespace InstruccionsMuntatge
{
    partial class frmInstruccionsMuntatge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstruccionsMuntatge));
            this.tipusReferenciaCB = new System.Windows.Forms.ComboBox();
            this.Opcions1CB = new System.Windows.Forms.ComboBox();
            this.Opcions2CB = new System.Windows.Forms.ComboBox();
            this.GuardarBT = new System.Windows.Forms.Button();
            this.tipusReferenciaLbl = new System.Windows.Forms.Label();
            this.ProducteFinalLbl = new System.Windows.Forms.Label();
            this.ProducteIntermigLbl = new System.Windows.Forms.Label();
            this.CodeOperationsLbl = new System.Windows.Forms.Label();
            this.NumberUsersLbl = new System.Windows.Forms.Label();
            this.DescOperationLbl = new System.Windows.Forms.Label();
            this.OperationOrderLbl = new System.Windows.Forms.Label();
            this.graellaDades = new System.Windows.Forms.DataGridView();
            this.afegirBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idAIDetailTB = new BibliotecaDeClases.SdsTextbox();
            this.CodeOperationTB = new BibliotecaDeClases.SdsTextbox();
            this.DescOperationTB = new BibliotecaDeClases.SdsTextbox();
            this.OperationOrderTB = new BibliotecaDeClases.SdsTextbox();
            this.NumberUsersTB = new BibliotecaDeClases.SdsTextbox();
            this.eliminarBT = new System.Windows.Forms.Button();
            this.acroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.rutaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarPdfBT = new System.Windows.Forms.Button();
            this.rutaTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileDialogRuta = new System.Windows.Forms.OpenFileDialog();
            this.btConfPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acroPDF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipusReferenciaCB
            // 
            this.tipusReferenciaCB.BackColor = System.Drawing.Color.Black;
            this.tipusReferenciaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipusReferenciaCB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipusReferenciaCB.ForeColor = System.Drawing.Color.White;
            this.tipusReferenciaCB.FormattingEnabled = true;
            this.tipusReferenciaCB.Items.AddRange(new object[] {
            "Producte Final",
            "Producte Itermig"});
            this.tipusReferenciaCB.Location = new System.Drawing.Point(426, 127);
            this.tipusReferenciaCB.Name = "tipusReferenciaCB";
            this.tipusReferenciaCB.Size = new System.Drawing.Size(270, 29);
            this.tipusReferenciaCB.TabIndex = 1;
            this.tipusReferenciaCB.SelectedIndexChanged += new System.EventHandler(this.tipusReferenciaCB_SelectedIndexChanged);
            // 
            // Opcions1CB
            // 
            this.Opcions1CB.BackColor = System.Drawing.Color.Black;
            this.Opcions1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Opcions1CB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcions1CB.ForeColor = System.Drawing.Color.White;
            this.Opcions1CB.FormattingEnabled = true;
            this.Opcions1CB.Location = new System.Drawing.Point(426, 195);
            this.Opcions1CB.Name = "Opcions1CB";
            this.Opcions1CB.Size = new System.Drawing.Size(270, 29);
            this.Opcions1CB.TabIndex = 2;
            this.Opcions1CB.SelectedIndexChanged += new System.EventHandler(this.Opcions1CB_SelectedIndexChanged);
            // 
            // Opcions2CB
            // 
            this.Opcions2CB.BackColor = System.Drawing.Color.Black;
            this.Opcions2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Opcions2CB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcions2CB.ForeColor = System.Drawing.Color.White;
            this.Opcions2CB.FormattingEnabled = true;
            this.Opcions2CB.Location = new System.Drawing.Point(426, 269);
            this.Opcions2CB.Name = "Opcions2CB";
            this.Opcions2CB.Size = new System.Drawing.Size(270, 29);
            this.Opcions2CB.TabIndex = 3;
            this.Opcions2CB.Visible = false;
            this.Opcions2CB.SelectedIndexChanged += new System.EventHandler(this.Opcions2CB_SelectedIndexChanged);
            // 
            // GuardarBT
            // 
            this.GuardarBT.BackColor = System.Drawing.Color.Black;
            this.GuardarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBT.Font = new System.Drawing.Font("Montserrat", 12F);
            this.GuardarBT.ForeColor = System.Drawing.Color.White;
            this.GuardarBT.Location = new System.Drawing.Point(900, 329);
            this.GuardarBT.Name = "GuardarBT";
            this.GuardarBT.Size = new System.Drawing.Size(110, 40);
            this.GuardarBT.TabIndex = 8;
            this.GuardarBT.Text = "GUARDAR";
            this.GuardarBT.UseVisualStyleBackColor = false;
            this.GuardarBT.Click += new System.EventHandler(this.GuardarBT_Click);
            // 
            // tipusReferenciaLbl
            // 
            this.tipusReferenciaLbl.AutoSize = true;
            this.tipusReferenciaLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipusReferenciaLbl.ForeColor = System.Drawing.Color.White;
            this.tipusReferenciaLbl.Location = new System.Drawing.Point(421, 98);
            this.tipusReferenciaLbl.Name = "tipusReferenciaLbl";
            this.tipusReferenciaLbl.Size = new System.Drawing.Size(160, 22);
            this.tipusReferenciaLbl.TabIndex = 17;
            this.tipusReferenciaLbl.Text = "Tipus de producte:";
            // 
            // ProducteFinalLbl
            // 
            this.ProducteFinalLbl.AutoSize = true;
            this.ProducteFinalLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProducteFinalLbl.ForeColor = System.Drawing.Color.White;
            this.ProducteFinalLbl.Location = new System.Drawing.Point(421, 164);
            this.ProducteFinalLbl.Name = "ProducteFinalLbl";
            this.ProducteFinalLbl.Size = new System.Drawing.Size(130, 22);
            this.ProducteFinalLbl.TabIndex = 18;
            this.ProducteFinalLbl.Text = "Producte Final:";
            // 
            // ProducteIntermigLbl
            // 
            this.ProducteIntermigLbl.AutoSize = true;
            this.ProducteIntermigLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProducteIntermigLbl.ForeColor = System.Drawing.Color.White;
            this.ProducteIntermigLbl.Location = new System.Drawing.Point(421, 236);
            this.ProducteIntermigLbl.Name = "ProducteIntermigLbl";
            this.ProducteIntermigLbl.Size = new System.Drawing.Size(163, 22);
            this.ProducteIntermigLbl.TabIndex = 19;
            this.ProducteIntermigLbl.Text = "Producte Intermig:";
            this.ProducteIntermigLbl.Visible = false;
            // 
            // CodeOperationsLbl
            // 
            this.CodeOperationsLbl.AutoSize = true;
            this.CodeOperationsLbl.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeOperationsLbl.ForeColor = System.Drawing.Color.White;
            this.CodeOperationsLbl.Location = new System.Drawing.Point(463, 332);
            this.CodeOperationsLbl.Name = "CodeOperationsLbl";
            this.CodeOperationsLbl.Size = new System.Drawing.Size(116, 21);
            this.CodeOperationsLbl.TabIndex = 20;
            this.CodeOperationsLbl.Text = "Codi Operació";
            // 
            // NumberUsersLbl
            // 
            this.NumberUsersLbl.AutoSize = true;
            this.NumberUsersLbl.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberUsersLbl.ForeColor = System.Drawing.Color.White;
            this.NumberUsersLbl.Location = new System.Drawing.Point(431, 402);
            this.NumberUsersLbl.Name = "NumberUsersLbl";
            this.NumberUsersLbl.Size = new System.Drawing.Size(144, 21);
            this.NumberUsersLbl.TabIndex = 21;
            this.NumberUsersLbl.Text = "Nombre d\'Usuaris";
            // 
            // DescOperationLbl
            // 
            this.DescOperationLbl.AutoSize = true;
            this.DescOperationLbl.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescOperationLbl.ForeColor = System.Drawing.Color.White;
            this.DescOperationLbl.Location = new System.Drawing.Point(416, 367);
            this.DescOperationLbl.Name = "DescOperationLbl";
            this.DescOperationLbl.Size = new System.Drawing.Size(159, 21);
            this.DescOperationLbl.TabIndex = 22;
            this.DescOperationLbl.Text = "Descripció Operació";
            // 
            // OperationOrderLbl
            // 
            this.OperationOrderLbl.AutoSize = true;
            this.OperationOrderLbl.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationOrderLbl.ForeColor = System.Drawing.Color.White;
            this.OperationOrderLbl.Location = new System.Drawing.Point(454, 441);
            this.OperationOrderLbl.Name = "OperationOrderLbl";
            this.OperationOrderLbl.Size = new System.Drawing.Size(126, 21);
            this.OperationOrderLbl.TabIndex = 23;
            this.OperationOrderLbl.Text = "Ordre Operació";
            // 
            // graellaDades
            // 
            this.graellaDades.AllowUserToAddRows = false;
            this.graellaDades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graellaDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.graellaDades.BackgroundColor = System.Drawing.Color.Black;
            this.graellaDades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graellaDades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.graellaDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graellaDades.GridColor = System.Drawing.Color.DarkGray;
            this.graellaDades.Location = new System.Drawing.Point(426, 567);
            this.graellaDades.Name = "graellaDades";
            this.graellaDades.ReadOnly = true;
            this.graellaDades.Size = new System.Drawing.Size(680, 265);
            this.graellaDades.TabIndex = 12;
            // 
            // afegirBT
            // 
            this.afegirBT.BackColor = System.Drawing.Color.Black;
            this.afegirBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afegirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirBT.Font = new System.Drawing.Font("Montserrat", 12F);
            this.afegirBT.ForeColor = System.Drawing.Color.White;
            this.afegirBT.Location = new System.Drawing.Point(900, 375);
            this.afegirBT.Name = "afegirBT";
            this.afegirBT.Size = new System.Drawing.Size(110, 40);
            this.afegirBT.TabIndex = 9;
            this.afegirBT.Text = "AFEGIR";
            this.afegirBT.UseVisualStyleBackColor = false;
            this.afegirBT.Click += new System.EventHandler(this.afegirBT_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(763, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 26;
            // 
            // idAIDetailTB
            // 
            this.idAIDetailTB.BackColor = System.Drawing.Color.White;
            this.idAIDetailTB.CampBBDD = "idAssemblyInstructionsDetail";
            this.idAIDetailTB.ControlId = null;
            this.idAIDetailTB.Forana = false;
            this.idAIDetailTB.ForeColor = System.Drawing.Color.Black;
            this.idAIDetailTB.Location = new System.Drawing.Point(763, 505);
            this.idAIDetailTB.MaxLength = 50;
            this.idAIDetailTB.Name = "idAIDetailTB";
            this.idAIDetailTB.PlaceHolder = null;
            this.idAIDetailTB.Requerit = false;
            this.idAIDetailTB.Size = new System.Drawing.Size(100, 20);
            this.idAIDetailTB.TabIndex = 25;
            this.idAIDetailTB.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Nombre;
            // 
            // CodeOperationTB
            // 
            this.CodeOperationTB.BackColor = System.Drawing.Color.Black;
            this.CodeOperationTB.CampBBDD = "CodeOperation";
            this.CodeOperationTB.ControlId = null;
            this.CodeOperationTB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeOperationTB.Forana = false;
            this.CodeOperationTB.ForeColor = System.Drawing.Color.White;
            this.CodeOperationTB.Location = new System.Drawing.Point(602, 329);
            this.CodeOperationTB.MaxLength = 8;
            this.CodeOperationTB.Name = "CodeOperationTB";
            this.CodeOperationTB.PlaceHolder = null;
            this.CodeOperationTB.Requerit = false;
            this.CodeOperationTB.Size = new System.Drawing.Size(250, 26);
            this.CodeOperationTB.TabIndex = 4;
            this.CodeOperationTB.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // DescOperationTB
            // 
            this.DescOperationTB.BackColor = System.Drawing.Color.Black;
            this.DescOperationTB.CampBBDD = "DescOperation";
            this.DescOperationTB.ControlId = null;
            this.DescOperationTB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescOperationTB.Forana = false;
            this.DescOperationTB.ForeColor = System.Drawing.Color.White;
            this.DescOperationTB.Location = new System.Drawing.Point(602, 364);
            this.DescOperationTB.MaxLength = 200;
            this.DescOperationTB.Name = "DescOperationTB";
            this.DescOperationTB.PlaceHolder = null;
            this.DescOperationTB.Requerit = false;
            this.DescOperationTB.Size = new System.Drawing.Size(250, 26);
            this.DescOperationTB.TabIndex = 5;
            this.DescOperationTB.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // OperationOrderTB
            // 
            this.OperationOrderTB.BackColor = System.Drawing.Color.Black;
            this.OperationOrderTB.CampBBDD = "OperationOrder";
            this.OperationOrderTB.ControlId = null;
            this.OperationOrderTB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationOrderTB.Forana = false;
            this.OperationOrderTB.ForeColor = System.Drawing.Color.White;
            this.OperationOrderTB.Location = new System.Drawing.Point(602, 436);
            this.OperationOrderTB.MaxLength = 5;
            this.OperationOrderTB.Name = "OperationOrderTB";
            this.OperationOrderTB.PlaceHolder = null;
            this.OperationOrderTB.Requerit = false;
            this.OperationOrderTB.Size = new System.Drawing.Size(250, 26);
            this.OperationOrderTB.TabIndex = 7;
            this.OperationOrderTB.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Nombre;
            this.OperationOrderTB.Leave += new System.EventHandler(this.OperationOrderTB_Leave);
            // 
            // NumberUsersTB
            // 
            this.NumberUsersTB.BackColor = System.Drawing.Color.Black;
            this.NumberUsersTB.CampBBDD = "NumberOfUsers";
            this.NumberUsersTB.ControlId = null;
            this.NumberUsersTB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberUsersTB.Forana = false;
            this.NumberUsersTB.ForeColor = System.Drawing.Color.White;
            this.NumberUsersTB.Location = new System.Drawing.Point(602, 399);
            this.NumberUsersTB.MaxLength = 5;
            this.NumberUsersTB.Name = "NumberUsersTB";
            this.NumberUsersTB.PlaceHolder = null;
            this.NumberUsersTB.Requerit = false;
            this.NumberUsersTB.Size = new System.Drawing.Size(250, 26);
            this.NumberUsersTB.TabIndex = 6;
            this.NumberUsersTB.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // eliminarBT
            // 
            this.eliminarBT.BackColor = System.Drawing.Color.Black;
            this.eliminarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarBT.Font = new System.Drawing.Font("Montserrat", 12F);
            this.eliminarBT.ForeColor = System.Drawing.Color.White;
            this.eliminarBT.Location = new System.Drawing.Point(900, 422);
            this.eliminarBT.Name = "eliminarBT";
            this.eliminarBT.Size = new System.Drawing.Size(110, 40);
            this.eliminarBT.TabIndex = 10;
            this.eliminarBT.Text = "ELIMINAR";
            this.eliminarBT.UseVisualStyleBackColor = false;
            this.eliminarBT.Click += new System.EventHandler(this.eliminarBT_Click);
            // 
            // acroPDF
            // 
            this.acroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acroPDF.Enabled = true;
            this.acroPDF.Location = new System.Drawing.Point(1124, 109);
            this.acroPDF.Name = "acroPDF";
            this.acroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acroPDF.OcxState")));
            this.acroPDF.Size = new System.Drawing.Size(430, 530);
            this.acroPDF.TabIndex = 13;
            // 
            // rutaBT
            // 
            this.rutaBT.BackColor = System.Drawing.Color.Black;
            this.rutaBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rutaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutaBT.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaBT.ForeColor = System.Drawing.Color.White;
            this.rutaBT.Location = new System.Drawing.Point(360, 36);
            this.rutaBT.Name = "rutaBT";
            this.rutaBT.Size = new System.Drawing.Size(30, 25);
            this.rutaBT.TabIndex = 16;
            this.rutaBT.Text = " . . ";
            this.rutaBT.UseVisualStyleBackColor = false;
            this.rutaBT.Click += new System.EventHandler(this.rutaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ruta";
            // 
            // guardarPdfBT
            // 
            this.guardarPdfBT.BackColor = System.Drawing.Color.Black;
            this.guardarPdfBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarPdfBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarPdfBT.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarPdfBT.ForeColor = System.Drawing.Color.White;
            this.guardarPdfBT.Location = new System.Drawing.Point(73, 87);
            this.guardarPdfBT.Name = "guardarPdfBT";
            this.guardarPdfBT.Size = new System.Drawing.Size(100, 35);
            this.guardarPdfBT.TabIndex = 17;
            this.guardarPdfBT.Text = "Guardar";
            this.guardarPdfBT.UseVisualStyleBackColor = false;
            this.guardarPdfBT.Click += new System.EventHandler(this.guardarPdfBT_Click);
            // 
            // rutaTB
            // 
            this.rutaTB.BackColor = System.Drawing.Color.Black;
            this.rutaTB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaTB.ForeColor = System.Drawing.Color.White;
            this.rutaTB.Location = new System.Drawing.Point(73, 34);
            this.rutaTB.Name = "rutaTB";
            this.rutaTB.ReadOnly = true;
            this.rutaTB.Size = new System.Drawing.Size(270, 26);
            this.rutaTB.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rutaTB);
            this.groupBox1.Controls.Add(this.rutaBT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.guardarPdfBT);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1124, 684);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardar";
            // 
            // btConfPI
            // 
            this.btConfPI.BackColor = System.Drawing.Color.Black;
            this.btConfPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfPI.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btConfPI.ForeColor = System.Drawing.Color.White;
            this.btConfPI.Location = new System.Drawing.Point(435, 505);
            this.btConfPI.Name = "btConfPI";
            this.btConfPI.Size = new System.Drawing.Size(300, 50);
            this.btConfPI.TabIndex = 54;
            this.btConfPI.Text = "Configuració Parts Implicades";
            this.btConfPI.UseVisualStyleBackColor = false;
            this.btConfPI.Click += new System.EventHandler(this.btConfPI_Click);
            // 
            // frmInstruccionsMuntatge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 844);
            this.Controls.Add(this.btConfPI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acroPDF);
            this.Controls.Add(this.eliminarBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idAIDetailTB);
            this.Controls.Add(this.afegirBT);
            this.Controls.Add(this.CodeOperationTB);
            this.Controls.Add(this.DescOperationTB);
            this.Controls.Add(this.graellaDades);
            this.Controls.Add(this.OperationOrderTB);
            this.Controls.Add(this.NumberUsersTB);
            this.Controls.Add(this.OperationOrderLbl);
            this.Controls.Add(this.DescOperationLbl);
            this.Controls.Add(this.NumberUsersLbl);
            this.Controls.Add(this.CodeOperationsLbl);
            this.Controls.Add(this.ProducteIntermigLbl);
            this.Controls.Add(this.ProducteFinalLbl);
            this.Controls.Add(this.tipusReferenciaLbl);
            this.Controls.Add(this.GuardarBT);
            this.Controls.Add(this.Opcions2CB);
            this.Controls.Add(this.Opcions1CB);
            this.Controls.Add(this.tipusReferenciaCB);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmInstruccionsMuntatge";
            this.Text = "Instruccions de Muntatge";
            this.Load += new System.EventHandler(this.InstruccionsMuntatgeWF_Load);
            this.Controls.SetChildIndex(this.tipusReferenciaCB, 0);
            this.Controls.SetChildIndex(this.Opcions1CB, 0);
            this.Controls.SetChildIndex(this.Opcions2CB, 0);
            this.Controls.SetChildIndex(this.GuardarBT, 0);
            this.Controls.SetChildIndex(this.tipusReferenciaLbl, 0);
            this.Controls.SetChildIndex(this.ProducteFinalLbl, 0);
            this.Controls.SetChildIndex(this.ProducteIntermigLbl, 0);
            this.Controls.SetChildIndex(this.CodeOperationsLbl, 0);
            this.Controls.SetChildIndex(this.NumberUsersLbl, 0);
            this.Controls.SetChildIndex(this.DescOperationLbl, 0);
            this.Controls.SetChildIndex(this.OperationOrderLbl, 0);
            this.Controls.SetChildIndex(this.NumberUsersTB, 0);
            this.Controls.SetChildIndex(this.OperationOrderTB, 0);
            this.Controls.SetChildIndex(this.graellaDades, 0);
            this.Controls.SetChildIndex(this.DescOperationTB, 0);
            this.Controls.SetChildIndex(this.CodeOperationTB, 0);
            this.Controls.SetChildIndex(this.afegirBT, 0);
            this.Controls.SetChildIndex(this.idAIDetailTB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.eliminarBT, 0);
            this.Controls.SetChildIndex(this.acroPDF, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btConfPI, 0);
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acroPDF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipusReferenciaCB;
        private System.Windows.Forms.ComboBox Opcions1CB;
        private System.Windows.Forms.ComboBox Opcions2CB;
        private System.Windows.Forms.Button GuardarBT;
        private System.Windows.Forms.Label tipusReferenciaLbl;
        private System.Windows.Forms.Label ProducteFinalLbl;
        private System.Windows.Forms.Label ProducteIntermigLbl;
        private System.Windows.Forms.Label CodeOperationsLbl;
        private System.Windows.Forms.Label NumberUsersLbl;
        private System.Windows.Forms.Label DescOperationLbl;
        private System.Windows.Forms.Label OperationOrderLbl;
        private BibliotecaDeClases.SdsTextbox NumberUsersTB;
        private BibliotecaDeClases.SdsTextbox OperationOrderTB;
        public System.Windows.Forms.DataGridView graellaDades;
        private BibliotecaDeClases.SdsTextbox DescOperationTB;
        private BibliotecaDeClases.SdsTextbox CodeOperationTB;
        private System.Windows.Forms.Button afegirBT;
        public BibliotecaDeClases.SdsTextbox idAIDetailTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eliminarBT;
        private AxAcroPDFLib.AxAcroPDF acroPDF;
        private System.Windows.Forms.Button rutaBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarPdfBT;
        private System.Windows.Forms.TextBox rutaTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog FileDialogRuta;
        private System.Windows.Forms.Button btConfPI;
    }
}