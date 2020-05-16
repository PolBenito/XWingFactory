namespace InstruccionsMuntatge
{
    partial class frmOperationParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperationParts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTancar = new System.Windows.Forms.PictureBox();
            this.PartsList = new System.Windows.Forms.ListBox();
            this.NomPieceCB = new System.Windows.Forms.ComboBox();
            this.afegirBT = new System.Windows.Forms.Button();
            this.NumberPiecesTB = new BibliotecaDeClases.SdsTextbox();
            this.CodeOperationsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarBT = new System.Windows.Forms.Button();
            this.elminarBT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elminarBT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 34);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btTancar
            // 
            this.btTancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancar.Image = ((System.Drawing.Image)(resources.GetObject("btTancar.Image")));
            this.btTancar.Location = new System.Drawing.Point(667, 6);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(20, 23);
            this.btTancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btTancar.TabIndex = 1;
            this.btTancar.TabStop = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // PartsList
            // 
            this.PartsList.BackColor = System.Drawing.Color.Black;
            this.PartsList.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsList.ForeColor = System.Drawing.Color.White;
            this.PartsList.FormattingEnabled = true;
            this.PartsList.ItemHeight = 22;
            this.PartsList.Location = new System.Drawing.Point(35, 53);
            this.PartsList.Name = "PartsList";
            this.PartsList.Size = new System.Drawing.Size(298, 378);
            this.PartsList.TabIndex = 1;
            // 
            // NomPieceCB
            // 
            this.NomPieceCB.BackColor = System.Drawing.Color.Black;
            this.NomPieceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomPieceCB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPieceCB.ForeColor = System.Drawing.Color.White;
            this.NomPieceCB.FormattingEnabled = true;
            this.NomPieceCB.Location = new System.Drawing.Point(386, 132);
            this.NomPieceCB.Name = "NomPieceCB";
            this.NomPieceCB.Size = new System.Drawing.Size(270, 29);
            this.NomPieceCB.TabIndex = 3;
            this.NomPieceCB.SelectedIndexChanged += new System.EventHandler(this.NomPieceCB_SelectedIndexChanged);
            // 
            // afegirBT
            // 
            this.afegirBT.BackColor = System.Drawing.Color.Black;
            this.afegirBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afegirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirBT.Font = new System.Drawing.Font("Montserrat", 12F);
            this.afegirBT.ForeColor = System.Drawing.Color.White;
            this.afegirBT.Location = new System.Drawing.Point(386, 295);
            this.afegirBT.Name = "afegirBT";
            this.afegirBT.Size = new System.Drawing.Size(110, 43);
            this.afegirBT.TabIndex = 2;
            this.afegirBT.Text = "AFEGIR";
            this.afegirBT.UseVisualStyleBackColor = false;
            this.afegirBT.Click += new System.EventHandler(this.afegirBT_Click);
            // 
            // NumberPiecesTB
            // 
            this.NumberPiecesTB.BackColor = System.Drawing.Color.Black;
            this.NumberPiecesTB.CampBBDD = "CodeOperation";
            this.NumberPiecesTB.ControlId = null;
            this.NumberPiecesTB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPiecesTB.Forana = false;
            this.NumberPiecesTB.ForeColor = System.Drawing.Color.White;
            this.NumberPiecesTB.Location = new System.Drawing.Point(523, 203);
            this.NumberPiecesTB.MaxLength = 50;
            this.NumberPiecesTB.Name = "NumberPiecesTB";
            this.NumberPiecesTB.PlaceHolder = null;
            this.NumberPiecesTB.Requerit = false;
            this.NumberPiecesTB.Size = new System.Drawing.Size(133, 26);
            this.NumberPiecesTB.TabIndex = 4;
            this.NumberPiecesTB.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Nombre;
            // 
            // CodeOperationsLbl
            // 
            this.CodeOperationsLbl.AutoSize = true;
            this.CodeOperationsLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeOperationsLbl.ForeColor = System.Drawing.Color.White;
            this.CodeOperationsLbl.Location = new System.Drawing.Point(382, 203);
            this.CodeOperationsLbl.Name = "CodeOperationsLbl";
            this.CodeOperationsLbl.Size = new System.Drawing.Size(122, 22);
            this.CodeOperationsLbl.TabIndex = 21;
            this.CodeOperationsLbl.Text = "Nombre Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Parts utilitzades";
            // 
            // guardarBT
            // 
            this.guardarBT.BackColor = System.Drawing.Color.Black;
            this.guardarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBT.Font = new System.Drawing.Font("Montserrat", 12F);
            this.guardarBT.ForeColor = System.Drawing.Color.White;
            this.guardarBT.Location = new System.Drawing.Point(546, 295);
            this.guardarBT.Name = "guardarBT";
            this.guardarBT.Size = new System.Drawing.Size(110, 43);
            this.guardarBT.TabIndex = 5;
            this.guardarBT.Text = "GUARDAR";
            this.guardarBT.UseVisualStyleBackColor = false;
            this.guardarBT.Click += new System.EventHandler(this.guardarBT_Click);
            // 
            // elminarBT
            // 
            this.elminarBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elminarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elminarBT.Image = global::InstruccionsMuntatge.Properties.Resources.eliminar;
            this.elminarBT.Location = new System.Drawing.Point(667, 138);
            this.elminarBT.Name = "elminarBT";
            this.elminarBT.Size = new System.Drawing.Size(17, 17);
            this.elminarBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elminarBT.TabIndex = 23;
            this.elminarBT.TabStop = false;
            this.elminarBT.Click += new System.EventHandler(this.elminarBT_Click);
            // 
            // frmOperationParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.elminarBT);
            this.Controls.Add(this.guardarBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeOperationsLbl);
            this.Controls.Add(this.NumberPiecesTB);
            this.Controls.Add(this.afegirBT);
            this.Controls.Add(this.NomPieceCB);
            this.Controls.Add(this.PartsList);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOperationParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificació de les Operation Parts";
            this.Load += new System.EventHandler(this.frmOperationParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elminarBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btTancar;
        private System.Windows.Forms.ListBox PartsList;
        private System.Windows.Forms.ComboBox NomPieceCB;
        private System.Windows.Forms.Button afegirBT;
        private BibliotecaDeClases.SdsTextbox NumberPiecesTB;
        private System.Windows.Forms.Label CodeOperationsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarBT;
        private System.Windows.Forms.PictureBox elminarBT;
    }
}