namespace EscandallProducte
{
    partial class frmModificacioEscandall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacioEscandall));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTancar = new System.Windows.Forms.PictureBox();
            this.cbTipusProducte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSenseAsignar = new System.Windows.Forms.ListBox();
            this.listBoxAsignats = new System.Windows.Forms.ListBox();
            this.btEsquerra = new System.Windows.Forms.Button();
            this.btDreta = new System.Windows.Forms.Button();
            this.cbProductes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btTancar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 34);
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
            this.btTancar.Location = new System.Drawing.Point(867, 6);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(20, 23);
            this.btTancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btTancar.TabIndex = 1;
            this.btTancar.TabStop = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // cbTipusProducte
            // 
            this.cbTipusProducte.BackColor = System.Drawing.Color.White;
            this.cbTipusProducte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipusProducte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipusProducte.ForeColor = System.Drawing.Color.Black;
            this.cbTipusProducte.FormattingEnabled = true;
            this.cbTipusProducte.Items.AddRange(new object[] {
            "Producte Final",
            "Producte Intermig"});
            this.cbTipusProducte.Location = new System.Drawing.Point(37, 97);
            this.cbTipusProducte.Name = "cbTipusProducte";
            this.cbTipusProducte.Size = new System.Drawing.Size(270, 30);
            this.cbTipusProducte.TabIndex = 1;
            this.cbTipusProducte.SelectedIndexChanged += new System.EventHandler(this.cbTipusProducte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipus de producte: ";
            // 
            // listBoxSenseAsignar
            // 
            this.listBoxSenseAsignar.AllowDrop = true;
            this.listBoxSenseAsignar.BackColor = System.Drawing.Color.Black;
            this.listBoxSenseAsignar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSenseAsignar.ForeColor = System.Drawing.Color.White;
            this.listBoxSenseAsignar.FormattingEnabled = true;
            this.listBoxSenseAsignar.ItemHeight = 21;
            this.listBoxSenseAsignar.Location = new System.Drawing.Point(37, 157);
            this.listBoxSenseAsignar.Name = "listBoxSenseAsignar";
            this.listBoxSenseAsignar.Size = new System.Drawing.Size(316, 256);
            this.listBoxSenseAsignar.TabIndex = 3;
            this.listBoxSenseAsignar.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxSenseAsignar_DragDrop);
            this.listBoxSenseAsignar.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxSenseAsignar_DragOver);
            this.listBoxSenseAsignar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSenseAsignar_MouseDown);
            // 
            // listBoxAsignats
            // 
            this.listBoxAsignats.AllowDrop = true;
            this.listBoxAsignats.BackColor = System.Drawing.Color.Black;
            this.listBoxAsignats.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAsignats.ForeColor = System.Drawing.Color.White;
            this.listBoxAsignats.FormattingEnabled = true;
            this.listBoxAsignats.ItemHeight = 21;
            this.listBoxAsignats.Location = new System.Drawing.Point(533, 157);
            this.listBoxAsignats.Name = "listBoxAsignats";
            this.listBoxAsignats.Size = new System.Drawing.Size(316, 256);
            this.listBoxAsignats.TabIndex = 6;
            this.listBoxAsignats.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxAsignats_DragDrop);
            this.listBoxAsignats.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxAsignats_DragOver);
            this.listBoxAsignats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxAsignats_MouseDown);
            // 
            // btEsquerra
            // 
            this.btEsquerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEsquerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsquerra.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEsquerra.Location = new System.Drawing.Point(405, 326);
            this.btEsquerra.Name = "btEsquerra";
            this.btEsquerra.Size = new System.Drawing.Size(75, 40);
            this.btEsquerra.TabIndex = 4;
            this.btEsquerra.Text = "<";
            this.btEsquerra.UseVisualStyleBackColor = true;
            this.btEsquerra.Click += new System.EventHandler(this.btEsquerra_Click);
            // 
            // btDreta
            // 
            this.btDreta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDreta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDreta.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDreta.ForeColor = System.Drawing.Color.White;
            this.btDreta.Location = new System.Drawing.Point(405, 206);
            this.btDreta.Name = "btDreta";
            this.btDreta.Size = new System.Drawing.Size(75, 40);
            this.btDreta.TabIndex = 5;
            this.btDreta.Text = ">";
            this.btDreta.UseVisualStyleBackColor = true;
            this.btDreta.Click += new System.EventHandler(this.btDreta_Click);
            // 
            // cbProductes
            // 
            this.cbProductes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductes.FormattingEnabled = true;
            this.cbProductes.Items.AddRange(new object[] {
            "hyola",
            "ñalskdjfñlaskj",
            "lsdlksdlksd",
            "lksdlksdlkds"});
            this.cbProductes.Location = new System.Drawing.Point(359, 97);
            this.cbProductes.Name = "cbProductes";
            this.cbProductes.Size = new System.Drawing.Size(270, 30);
            this.cbProductes.TabIndex = 2;
            this.cbProductes.SelectedIndexChanged += new System.EventHandler(this.cbProductes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Productes";
            // 
            // btGuardar
            // 
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(729, 89);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(120, 38);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // frmModificacioEscandall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btDreta);
            this.Controls.Add(this.btEsquerra);
            this.Controls.Add(this.listBoxAsignats);
            this.Controls.Add(this.listBoxSenseAsignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductes);
            this.Controls.Add(this.cbTipusProducte);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificacioEscandall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificació de l\'Escandall";
            this.Load += new System.EventHandler(this.frmModificacioEscandall_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btTancar;
        private System.Windows.Forms.ComboBox cbTipusProducte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSenseAsignar;
        private System.Windows.Forms.ListBox listBoxAsignats;
        private System.Windows.Forms.Button btEsquerra;
        private System.Windows.Forms.Button btDreta;
        private System.Windows.Forms.ComboBox cbProductes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGuardar;
    }
}