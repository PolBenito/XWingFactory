using BibliotecaDeClases;
using AccesDades_BC;
using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace Proj1
{
    public partial class Plantilla : Form
    {
        private string val = ConfigurationManager.AppSettings["_accesslevel"];
        private string val2 = ConfigurationManager.AppSettings["_Login"];

        public Plantilla()
        {
            InitializeComponent();
            toolTip.SetToolTip(this.btClose, "Tancar");
            toolTip.SetToolTip(this.btMinimizar, "Minimitzar");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {
            DataSet dts;
            string query = "SELECT nomdll, nomform, nom, imatge FROM MenuOptions WHERE accesslevel <= '" + val + "'";

            DataAccess bd = new DataAccess();
            dts = bd.PortarPerConsulta(query);


            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                LlencaAplicacions LlencaApp = new LlencaAplicacions();
                LlencaApp.Nom = dr["nom"].ToString();
                LlencaApp.Imatge = dr["imatge"].ToString();
                LlencaApp.Nombredll = dr["nomdll"].ToString();
                LlencaApp.Nombreform = dr["nomform"].ToString();
                LlencaApp.Dock = DockStyle.Top;
                menulateral.Controls.Add(LlencaApp);
            }
            
            query = "SELECT UserName, Photo FROM Users WHERE Login = '" + val2 + "'";
            
            dts = bd.PortarPerConsulta(query);
            
            SessioUsuari sessioUser = new SessioUsuari();
            
            sessioUser.UserName = dts.Tables[0].Rows[0]["UserName"].ToString();
            sessioUser.Photo = dts.Tables[0].Rows[0]["Photo"].ToString();
            menusessio.Controls.Add(sessioUser);
            
            Form frm = this.FindForm();
            TitolForm titolFormulari = new TitolForm();
            titolFormulari.Text = frm.Name;
            PanelNomForm.Controls.Add(titolFormulari);
            
            MenuIcona menuIcona = new MenuIcona();
            PanelMenuIcona.Controls.Add(menuIcona);
        }
    }
}
