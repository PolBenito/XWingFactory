namespace FormulariCerca_BC
{
    partial class FormulariCerca
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
            this.graellaDades = new System.Windows.Forms.DataGridView();
            this.TancarPestanya = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TancarPestanya)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // graellaDades
            // 
            this.graellaDades.AllowUserToAddRows = false;
            this.graellaDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.graellaDades.BackgroundColor = System.Drawing.Color.Black;
            this.graellaDades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graellaDades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.graellaDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.graellaDades.DefaultCellStyle = dataGridViewCellStyle1;
            this.graellaDades.Location = new System.Drawing.Point(8, 8);
            this.graellaDades.Name = "graellaDades";
            this.graellaDades.ReadOnly = true;
            this.graellaDades.Size = new System.Drawing.Size(455, 265);
            this.graellaDades.TabIndex = 0;
            this.graellaDades.DoubleClick += new System.EventHandler(this.graellaDades_DoubleClick);
            // 
            // TancarPestanya
            // 
            this.TancarPestanya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TancarPestanya.Image = global::FormulariCerca_BC.Properties.Resources.cerrar;
            this.TancarPestanya.Location = new System.Drawing.Point(443, 4);
            this.TancarPestanya.Name = "TancarPestanya";
            this.TancarPestanya.Size = new System.Drawing.Size(20, 22);
            this.TancarPestanya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TancarPestanya.TabIndex = 1;
            this.TancarPestanya.TabStop = false;
            this.TancarPestanya.Click += new System.EventHandler(this.TancarPestanya_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TancarPestanya);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 42);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pestanya de cerca";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.graellaDades);
            this.panel2.Location = new System.Drawing.Point(4, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 282);
            this.panel2.TabIndex = 3;
            // 
            // FormulariCerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 337);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormulariCerca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulariCerca";
            this.Load += new System.EventHandler(this.FormulariCerca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graellaDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TancarPestanya)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView graellaDades;
        private System.Windows.Forms.PictureBox TancarPestanya;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}