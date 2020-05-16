using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace BibliotecaDeClases
{
    public partial class Sds_Codi : UserControl
    {
        public Sds_Codi()
        {
            InitializeComponent();
        }

        string nomFormulari;
        string query;
        bool insertaTbCodi;
        DataSet ds;

        private string _ControlId;
        public string ControlId
        {
            get { return _ControlId; }
            set { _ControlId = value; }
        }
        
        private string _ErrorText;
        public string ErrorText
        {
            get { return _ErrorText; }
            set { _ErrorText = value; }
        }

        private string _NomTaula;

        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        private string _NomCodi;

        public string NomCodi
        {
            get { return _NomCodi; }
            set { _NomCodi = value; }
        }

        private string _NomDesc;

        public string NomDesc
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }

        private string _Text;

        public override string Text
        {
            get { return _Text; }
            set { _Text = value;
                insertaValors(value);
            }
        }

        private string _NomId;

        public string NomId
        {
            get { return _NomId; }
            set { _NomId = value; }
        }

        private string _textLabel;
        public string TextLabel
        {
            get { return _textLabel; }
            set
            {
                label.Text = value;
                _textLabel = label.Text;
            }
        }

        private bool _Requerit;
        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }

        private string _FormCS;

        public string FormCS
        {
            get { return _FormCS; }
            set { value = "FormulariCerca_BC.FormulariCerca";
                _FormCS = value; }
        }

        private string _ClasseCS;

        public string ClasseCS
        {
            get { return _ClasseCS; }
            set { value = @"FormulariCerca_BC.dll";
                _ClasseCS = value; }
        }

        public void PortarDades(string query, bool insertaTbCodi)
        {
            AccesDades_BC.DataAccess db = new AccesDades_BC.DataAccess();

            try
            {
                ds = db.PortarPerConsulta(query);

                if (!insertaTbCodi)
                {
                    tbCodi.Text = ds.Tables[0].Rows[0][NomCodi].ToString();

                }
                tbDesc.Text = ds.Tables[0].Rows[0][_NomDesc].ToString();
            }
            catch
            {
                tbDesc.Clear();
                tbCodi.Clear();

                Form frm = this.FindForm();

                foreach (Control c in frm.Controls)
                {
                    if (c.Name == ControlId)
                    {
                        c.Text = "";
                    }
                }
            }
        }

        public void OmplirTextsBoxs()
        {
            Form frm = this.FindForm();

            try
            {
                foreach (Control c in frm.Controls)
                {
                    if (c.Name == ControlId)
                    {
                        try
                        {
                            c.Text = ds.Tables[0].Rows[0][NomId].ToString();
                        }
                        catch
                        {
                            c.Text = "";
                        }
                    }
                }
            }
            catch
            {
                tbDesc.Clear();
                tbCodi.Clear();

                foreach (Control c in frm.Controls)
                {
                    if (c.Name == ControlId)
                    {
                        c.Text = "";
                    }
                }
            }
        }

        public void insertaValors(string Text)
        {
            insertaTbCodi = false;

            query = "SELECT * FROM " + _NomTaula + " WHERE " + NomId + " = '" + Text + "'";

            PortarDades(query, insertaTbCodi);
            OmplirTextsBoxs();
        }


        public void ValidarCodi()
        {
            insertaTbCodi = true;

            query = "SELECT * FROM " + _NomTaula + " WHERE " + _NomCodi + " = '" + tbCodi.Text + "'";

            PortarDades(query, insertaTbCodi);
            OmplirTextsBoxs();  
        }


        public void ValidarCodiCS(int numId)
        {
            insertaTbCodi = false;

            query = "SELECT * FROM " + _NomTaula + " WHERE " + NomId + " = '" + Text + "'";

            PortarDades(query, insertaTbCodi);
            OmplirTextsBoxs();
         }

        private void tbCodi_Validating(object sender, CancelEventArgs e)
        {
            if (Requerit == true)
            {
                if (tbCodi.Text.Length == 0)
                {
                    e.Cancel = true;
                }
            }
            ValidarCodi();
        }

        private void tbCodi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ObreCS();
            }
        }

        private void ObreCS()
        {
            string nomControl = Name;
            
            Assembly ensamblat = Assembly.LoadFrom(ClasseCS);

            object DLLBD;
            Type tipus;

            nomFormulari = FindForm().Name;

            tipus = ensamblat.GetType(FormCS);
            object[] args = { nomFormulari, nomControl, NomTaula };
            DLLBD = Activator.CreateInstance(tipus, args);
            Form frm = ((Form)DLLBD);

            if(frm.ShowDialog() == DialogResult.OK)
            {
                ValidarCodiCS(int.Parse(Text));
            }
        }
    }
}
