namespace Projecte1_WF._3r_Projecte
{
    partial class PujarComandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PujarComandes));
            this.btMinimitzar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTancar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.btRuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.FileDialogRuta = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimitzar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMinimitzar
            // 
            this.btMinimitzar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimitzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimitzar.Image = global::Projecte1_WF.Properties.Resources.iconMinimitzar;
            this.btMinimitzar.Location = new System.Drawing.Point(597, 8);
            this.btMinimitzar.Name = "btMinimitzar";
            this.btMinimitzar.Size = new System.Drawing.Size(23, 20);
            this.btMinimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMinimitzar.TabIndex = 4;
            this.btMinimitzar.TabStop = false;
            this.btMinimitzar.Click += new System.EventHandler(this.btMinimitzar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btTancar);
            this.panel1.Controls.Add(this.btMinimitzar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 34);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btTancar
            // 
            this.btTancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancar.Image = ((System.Drawing.Image)(resources.GetObject("btTancar.Image")));
            this.btTancar.Location = new System.Drawing.Point(627, 6);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(20, 23);
            this.btTancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btTancar.TabIndex = 1;
            this.btTancar.TabStop = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbRuta);
            this.groupBox1.Controls.Add(this.btRuta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 150);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardar";
            // 
            // tbRuta
            // 
            this.tbRuta.BackColor = System.Drawing.Color.Black;
            this.tbRuta.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRuta.ForeColor = System.Drawing.Color.White;
            this.tbRuta.Location = new System.Drawing.Point(73, 34);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.ReadOnly = true;
            this.tbRuta.Size = new System.Drawing.Size(451, 26);
            this.tbRuta.TabIndex = 15;
            // 
            // btRuta
            // 
            this.btRuta.BackColor = System.Drawing.Color.Black;
            this.btRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRuta.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRuta.ForeColor = System.Drawing.Color.White;
            this.btRuta.Location = new System.Drawing.Point(550, 37);
            this.btRuta.Name = "btRuta";
            this.btRuta.Size = new System.Drawing.Size(30, 25);
            this.btRuta.TabIndex = 16;
            this.btRuta.Text = " . . ";
            this.btRuta.UseVisualStyleBackColor = false;
            this.btRuta.Click += new System.EventHandler(this.btRuta_Click);
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
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Black;
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(73, 87);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 35);
            this.btGuardar.TabIndex = 17;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // PujarComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(660, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PujarComandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PujarComandes";
            ((System.ComponentModel.ISupportInitialize)(this.btMinimitzar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btMinimitzar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btTancar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.Button btRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.OpenFileDialog FileDialogRuta;
    }
}