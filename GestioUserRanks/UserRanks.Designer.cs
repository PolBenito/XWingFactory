namespace GestioUserRanks
{
    partial class UserRanks
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
            this.label1 = new System.Windows.Forms.Label();
            this.sdsTextbox1 = new BibliotecaDeClases.SdsTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.sdsTextbox6 = new BibliotecaDeClases.SdsTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.sdsTextbox2 = new BibliotecaDeClases.SdsTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Descripció Rang *";
            // 
            // sdsTextbox1
            // 
            this.sdsTextbox1.BackColor = System.Drawing.Color.White;
            this.sdsTextbox1.CampBBDD = "DescRank";
            this.sdsTextbox1.ControlId = null;
            this.sdsTextbox1.Font = new System.Drawing.Font("Montserrat", 9F);
            this.sdsTextbox1.Forana = false;
            this.sdsTextbox1.ForeColor = System.Drawing.Color.Black;
            this.sdsTextbox1.Location = new System.Drawing.Point(572, 191);
            this.sdsTextbox1.MaxLength = 50;
            this.sdsTextbox1.Name = "sdsTextbox1";
            this.sdsTextbox1.PlaceHolder = null;
            this.sdsTextbox1.Requerit = true;
            this.sdsTextbox1.Size = new System.Drawing.Size(150, 22);
            this.sdsTextbox1.TabIndex = 50;
            this.sdsTextbox1.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Codi Rang *";
            // 
            // sdsTextbox6
            // 
            this.sdsTextbox6.BackColor = System.Drawing.Color.White;
            this.sdsTextbox6.CampBBDD = "CodeRank";
            this.sdsTextbox6.ControlId = null;
            this.sdsTextbox6.Font = new System.Drawing.Font("Montserrat", 9F);
            this.sdsTextbox6.Forana = false;
            this.sdsTextbox6.ForeColor = System.Drawing.Color.Black;
            this.sdsTextbox6.Location = new System.Drawing.Point(572, 145);
            this.sdsTextbox6.MaxLength = 4;
            this.sdsTextbox6.Name = "sdsTextbox6";
            this.sdsTextbox6.PlaceHolder = null;
            this.sdsTextbox6.Requerit = true;
            this.sdsTextbox6.Size = new System.Drawing.Size(150, 22);
            this.sdsTextbox6.TabIndex = 48;
            this.sdsTextbox6.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "id User Rank";
            // 
            // sdsTextbox2
            // 
            this.sdsTextbox2.BackColor = System.Drawing.Color.White;
            this.sdsTextbox2.CampBBDD = "idUserRank";
            this.sdsTextbox2.ControlId = null;
            this.sdsTextbox2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.sdsTextbox2.Forana = false;
            this.sdsTextbox2.ForeColor = System.Drawing.Color.Black;
            this.sdsTextbox2.Location = new System.Drawing.Point(625, 95);
            this.sdsTextbox2.MaxLength = 50;
            this.sdsTextbox2.Name = "sdsTextbox2";
            this.sdsTextbox2.PlaceHolder = null;
            this.sdsTextbox2.Requerit = false;
            this.sdsTextbox2.Size = new System.Drawing.Size(100, 22);
            this.sdsTextbox2.TabIndex = 52;
            this.sdsTextbox2.Variable = BibliotecaDeClases.SdsTextbox.Tipo.Text;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(459, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 40);
            this.panel5.TabIndex = 54;
            // 
            // UserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 873);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdsTextbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdsTextbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sdsTextbox6);
            this.Name = "UserRanks";
            this.Text = "UserRanks";
            this.Load += new System.EventHandler(this.UserRanks_Load);
            this.Controls.SetChildIndex(this.sdsTextbox6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.sdsTextbox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sdsTextbox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BibliotecaDeClases.SdsTextbox sdsTextbox1;
        private System.Windows.Forms.Label label3;
        private BibliotecaDeClases.SdsTextbox sdsTextbox6;
        private System.Windows.Forms.Label label2;
        private BibliotecaDeClases.SdsTextbox sdsTextbox2;
        private System.Windows.Forms.Panel panel5;
    }
}