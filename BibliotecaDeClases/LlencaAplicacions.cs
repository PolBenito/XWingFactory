
using System;
using System.Windows.Forms;
using System.Reflection;

namespace BibliotecaDeClases
{
    public partial class LlencaAplicacions : UserControl
    {
        public LlencaAplicacions()
        {
            InitializeComponent();
        }

        private string _id;
        public string Id

        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombredll;
        public string Nombredll

        {
            get { return _nombredll; }
            set { _nombredll = value; }
        }

        private string _nombreform;
        public string Nombreform

        {
            get { return _nombreform; }
            set { _nombreform = value; }
        }

        private string _nom;
        public string Nom

        {
            get { return _nom; }
            set { _nom = value;
                nommenu.Text = _nom;
            }
        }

        private string _imatge;
        public string Imatge

        {
            get { return _imatge; }
            set { _imatge = value;
                logomenu.ImageLocation = Application.StartupPath + @"\\images\\" + _imatge;
            }
        }

        private string _accesslevel;
        public string Accesslevel

        {
            get { return _accesslevel; }
            set { _accesslevel = value; }
        }

        private void panelLlencaApps_Click(object sender, EventArgs e)
        {
            Premer();
            Tancar();
        }

        private void Premer()
        {
            try
            {
                Assembly ensamblat = Assembly.LoadFrom(@Nombredll + ".dll");
                Object dllBD;
                Type tipus;
                
                tipus = ensamblat.GetType(Nombredll + "." + Nombreform);
                dllBD = Activator.CreateInstance(tipus);
                ((Form)dllBD).Show();
            }
            catch
            {
                MessageBox.Show("No tens permisos per entrar en aquesta gestió");
            }
        }

        private void Tancar()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != Nombreform)
                {
                    frm.Hide();
                }
            }
        }

        private void nommenu_Click(object sender, EventArgs e)
        {
            Premer();
            Tancar();
        }
    }
}
