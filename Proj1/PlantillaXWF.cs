using AccesDades_BC;
using BibliotecaDeClases;
using Persistencia;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Proj1
{
    public partial class PlantillaXWF : Form
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        private string valAccessLevel = ConfigurationManager.AppSettings["_accesslevel"];
        private string valIdUserCategory = ConfigurationManager.AppSettings["_idUserCategory"];
        private string valLogin = ConfigurationManager.AppSettings["_Login"];

        public PlantillaXWF()
        {
            InitializeComponent();
            toolTip.SetToolTip(this.btTancar, "Tancar");
            toolTip.SetToolTip(this.btMinimitzar, "Minimitzar");
        }

        private void btTancar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btMinimitzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlantillaXWF_Load(object sender, EventArgs e)
        {
            DataSet dts;

            // Mostrar les opcions de menú
            string query = "SELECT nomdll, nomform, nom, imatge FROM MenuOptions WHERE accesslevel >= '" + valAccessLevel + "' AND accesslevel <=100";
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
                panelMenuLateral.Controls.Add(LlencaApp);
            }


            // Mostrar la sessió de l'usuari
            query = "SELECT UserName, Photo FROM Users WHERE Login = '" + valLogin + "'";
            dts = bd.PortarPerConsulta(query);
            SessioUsuari sessioUser = new SessioUsuari();

            if (sessioUser.cargarSessioXWing)
            {
                sessioUser.BackColor = Color.White;
            }

            sessioUser.UserName = dts.Tables[0].Rows[0]["UserName"].ToString();
            sessioUser.Photo = dts.Tables[0].Rows[0]["Photo"].ToString();
            panelSessio.Controls.Add(sessioUser);

            short idUC = Int16.Parse(valIdUserCategory);

            var queryUC = (from u in db.UserTypes
                           where u.idUserType == idUC
                           select u.descUserType).FirstOrDefault();

            RolUsuari rolUser = new RolUsuari();
            rolUser.UserCategory = queryUC.ToString();
            panelRol.Controls.Add(rolUser);


            // Titol Form
            Form frm = this.FindForm();
            TitolForm titolFormulari = new TitolForm();
            titolFormulari.Text = frm.Text;
            panelOpcioMenu.Controls.Add(titolFormulari);

            // Tornar al menú
            MenuIcona menuIcona = new MenuIcona();
            PanelMenuIcona.Controls.Add(menuIcona);
        }
    }
}
