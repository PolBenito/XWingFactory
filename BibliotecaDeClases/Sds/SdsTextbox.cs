 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace BibliotecaDeClases
{
    public class SdsTextbox : TextBox
    {
        public SdsTextbox()
        {
            InitializeComponent();
        }

        private String _PlaceHolder;

        public String PlaceHolder
        {
            get { return _PlaceHolder; }
            set {
                _PlaceHolder = value;
                Text = _PlaceHolder;
            }
        }

        private void SdsTextbox_Enter(object sender, EventArgs e)
        {
            if (Text == _PlaceHolder && _Variable == Tipo.Contrassenya)
            {
                Clear();
                PasswordChar = '*';
            }
            else if (Text == _PlaceHolder)
            {
                Clear();
            }
        }
        private void SdsTextbox_Leave(object sender, EventArgs e)
        {
            if (Text == "")
            {
                Text = _PlaceHolder;
            }
            if (Text == _PlaceHolder)
            {
                PasswordChar = (char)0;
            }
        }

        private String _CampBBDD;
        public String CampBBDD
        {
            get { return _CampBBDD; }
            set
            {
                _CampBBDD = value;
            }
        }

        public enum Tipo
        {
            Nombre = 1,
            Text = 2,
            Fecha = 3,
            Contrassenya = 4
        }

        public Tipo _Variable;
        public Tipo Variable
        {
            get { return _Variable; }
            set
            {
                _Variable = value;

            }
        }

        private Boolean _Requerit;
        public Boolean Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }

        private Boolean _Forana;
        public Boolean Forana
        {
            get { return _Forana; }
            set { _Forana = value; }
        }

        private void SdsTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Text = Text.Trim();

            if (Requerit == true)
            {
                if (Text.Length == 0 || Text == _PlaceHolder)
                {
                    e.Cancel = true;
                }
            }
            if (_Variable == Tipo.Nombre && Text.Length > 0)
            {
                int ejem = 0;
                if (!(int.TryParse(Text, out ejem)))
                {
                    Clear();
                    Focus();
                    MessageBox.Show("Tipus de Variable Incorrecta");
                }
            }
            else if (_Variable == Tipo.Fecha && Text.Length > 0)
            {
                if (!(DateTime.TryParse(Text, out DateTime tiempo)))
                {
                    Clear();
                    Focus();
                    MessageBox.Show("Tipus de Variable Incorrecta");
                }
            }
        }

        private string _ControlId;
        public string ControlId
        {
            get { return _ControlId; }
            set { _ControlId = value; }
        }

        private void EsForanea()
        {
            if (Forana)
            {
                string nomFormulari = FindForm().Name;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == nomFormulari)
                    {
                        foreach (Control c in frm.Controls)
                        {
                            if (c is Sds_Codi)
                            {
                                try
                                {
                                    foreach (Control x in frm.Controls)
                                    {
                                        if (x.Name == ((Sds_Codi)c).ControlId)
                                        {
                                            c.Text = x.Text;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error 404: " + ex);
                                }
                            }
                        }
                    }
                }   
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SdsTextbox
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaxLength = 50;
            this.TextChanged += new System.EventHandler(this.SdsTextbox_TextChanged);
            this.Enter += new System.EventHandler(this.SdsTextbox_Enter);
            this.Leave += new System.EventHandler(this.SdsTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SdsTextbox_Validating);
            this.ResumeLayout(false);

        }

        private void SdsTextbox_TextChanged(object sender, EventArgs e)
        {
            EsForanea();
        }
    }
}