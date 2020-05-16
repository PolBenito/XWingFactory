namespace Gestio_BC
{
    partial class GestioBaseForanies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.graellaDadesForanes = new System.Windows.Forms.DataGridView();
            this.btActualitzar = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sds_Codi2 = new BibliotecaDeClases.Sds_Codi();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graellaDadesForanes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.graellaDadesForanes);
            this.panel3.Location = new System.Drawing.Point(452, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 310);
            this.panel3.TabIndex = 5;
            // 
            // graellaDadesForanes
            // 
            this.graellaDadesForanes.AllowUserToAddRows = false;
            this.graellaDadesForanes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graellaDadesForanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.graellaDadesForanes.BackgroundColor = System.Drawing.Color.Black;
            this.graellaDadesForanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graellaDadesForanes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.graellaDadesForanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.graellaDadesForanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.graellaDadesForanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.graellaDadesForanes.DefaultCellStyle = dataGridViewCellStyle2;
            this.graellaDadesForanes.Location = new System.Drawing.Point(5, 5);
            this.graellaDadesForanes.Name = "graellaDadesForanes";
            this.graellaDadesForanes.ReadOnly = true;
            this.graellaDadesForanes.Size = new System.Drawing.Size(740, 300);
            this.graellaDadesForanes.TabIndex = 0;
            // 
            // btActualitzar
            // 
            this.btActualitzar.BackColor = System.Drawing.Color.White;
            this.btActualitzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualitzar.ForeColor = System.Drawing.Color.Black;
            this.btActualitzar.Location = new System.Drawing.Point(5, 54);
            this.btActualitzar.Name = "btActualitzar";
            this.btActualitzar.Size = new System.Drawing.Size(100, 30);
            this.btActualitzar.TabIndex = 12;
            this.btActualitzar.Text = "Actualitzar";
            this.btActualitzar.UseVisualStyleBackColor = false;
            this.btActualitzar.Click += new System.EventHandler(this.btActualitzar_Click);
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Transparent;
            this.btNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNou.ForeColor = System.Drawing.Color.Black;
            this.btNou.Location = new System.Drawing.Point(5, 9);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(100, 30);
            this.btNou.TabIndex = 11;
            this.btNou.Text = "Nou";
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btActualitzar);
            this.panel4.Controls.Add(this.btNou);
            this.panel4.Location = new System.Drawing.Point(1221, 540);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 100);
            this.panel4.TabIndex = 13;
            // 
            // sds_Codi2
            // 
            this.sds_Codi2.BackColor = System.Drawing.Color.Black;
            this.sds_Codi2.ClasseCS = "FormulariCerca_BC.dll";
            this.sds_Codi2.ControlId = "tbCntrId";
            this.sds_Codi2.ErrorText = "Error al omplir el camp";
            this.sds_Codi2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sds_Codi2.FormCS = "FormulariCerca_BC.FormulariCerca";
            this.sds_Codi2.Location = new System.Drawing.Point(26, 344);
            this.sds_Codi2.Name = "sds_Codi2";
            this.sds_Codi2.NomCodi = "CodeCategory";
            this.sds_Codi2.NomDesc = "DescCategory";
            this.sds_Codi2.NomId = "idUserCategory";
            this.sds_Codi2.NomTaula = "UserCategories";
            this.sds_Codi2.Requerit = false;
            this.sds_Codi2.Size = new System.Drawing.Size(478, 48);
            this.sds_Codi2.TabIndex = 15;
            this.sds_Codi2.TextLabel = "Exemple";
            // 
            // GestioBaseForanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 873);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "GestioBaseForanies";
            this.Text = "GestioBaseForanies";
            this.Load += new System.EventHandler(this.GestioBaseForanies_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graellaDadesForanes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btActualitzar;
        private System.Windows.Forms.Button btNou;
        private System.Windows.Forms.Panel panel4;
        private BibliotecaDeClases.Sds_Codi sds_Codi2;
        public System.Windows.Forms.DataGridView graellaDadesForanes;
    }
}