namespace Proj1
{
    partial class PlantillaXWF
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
            this.components = new System.ComponentModel.Container();
            this.panelSubSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelMenuIcona = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelOpcioMenu = new System.Windows.Forms.Panel();
            this.panelSessio = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelRol = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btMinimitzar = new System.Windows.Forms.PictureBox();
            this.btTancar = new System.Windows.Forms.PictureBox();
            this.panelSubSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimitzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSubSuperior
            // 
            this.panelSubSuperior.BackColor = System.Drawing.Color.White;
            this.panelSubSuperior.Controls.Add(this.PanelMenuIcona);
            this.panelSubSuperior.Location = new System.Drawing.Point(0, 41);
            this.panelSubSuperior.Name = "panelSubSuperior";
            this.panelSubSuperior.Size = new System.Drawing.Size(1600, 40);
            this.panelSubSuperior.TabIndex = 0;
            // 
            // PanelMenuIcona
            // 
            this.PanelMenuIcona.Location = new System.Drawing.Point(3, 3);
            this.PanelMenuIcona.Name = "PanelMenuIcona";
            this.PanelMenuIcona.Size = new System.Drawing.Size(35, 35);
            this.PanelMenuIcona.TabIndex = 0;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 81);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(391, 827);
            this.panelMenuLateral.TabIndex = 53;
            // 
            // panelOpcioMenu
            // 
            this.panelOpcioMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcioMenu.BackColor = System.Drawing.Color.White;
            this.panelOpcioMenu.Location = new System.Drawing.Point(619, 43);
            this.panelOpcioMenu.Name = "panelOpcioMenu";
            this.panelOpcioMenu.Size = new System.Drawing.Size(619, 33);
            this.panelOpcioMenu.TabIndex = 4;
            // 
            // panelSessio
            // 
            this.panelSessio.BackColor = System.Drawing.Color.White;
            this.panelSessio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelSessio.Location = new System.Drawing.Point(1341, 41);
            this.panelSessio.Name = "panelSessio";
            this.panelSessio.Size = new System.Drawing.Size(250, 40);
            this.panelSessio.TabIndex = 5;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1737, 40);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelRol
            // 
            this.panelRol.BackColor = System.Drawing.Color.Black;
            this.panelRol.Location = new System.Drawing.Point(0, 1);
            this.panelRol.Name = "panelRol";
            this.panelRol.Size = new System.Drawing.Size(250, 40);
            this.panelRol.TabIndex = 6;
            // 
            // btMinimitzar
            // 
            this.btMinimitzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimitzar.Image = global::Proj1.Properties.Resources.iconMinimitzar;
            this.btMinimitzar.Location = new System.Drawing.Point(1529, 8);
            this.btMinimitzar.Name = "btMinimitzar";
            this.btMinimitzar.Size = new System.Drawing.Size(25, 25);
            this.btMinimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMinimitzar.TabIndex = 2;
            this.btMinimitzar.TabStop = false;
            this.btMinimitzar.Click += new System.EventHandler(this.btMinimitzar_Click);
            // 
            // btTancar
            // 
            this.btTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancar.Image = global::Proj1.Properties.Resources.Tancar;
            this.btTancar.Location = new System.Drawing.Point(1563, 8);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(25, 25);
            this.btTancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btTancar.TabIndex = 1;
            this.btTancar.TabStop = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // PlantillaXWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1592, 920);
            this.Controls.Add(this.panelRol);
            this.Controls.Add(this.panelOpcioMenu);
            this.Controls.Add(this.panelSessio);
            this.Controls.Add(this.btMinimitzar);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelSubSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlantillaXWF";
            this.Text = "PlantillaXWF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlantillaXWF_Load);
            this.panelSubSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimitzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSubSuperior;
        private System.Windows.Forms.PictureBox btTancar;
        private System.Windows.Forms.PictureBox btMinimitzar;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelOpcioMenu;
        private System.Windows.Forms.Panel panelSessio;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelRol;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel PanelMenuIcona;
    }
}