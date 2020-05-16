using Projecte1_WF._3r_Projecte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte1_WF
{
    public partial class opcionesMenu : Form
    {
        BibliotecaDeClases.SessioUsuari sessioUsuari = new BibliotecaDeClases.SessioUsuari();

        public opcionesMenu()
        {
            InitializeComponent();

            toolTip.SetToolTip(this.btTancar, "Tancar");
            toolTip.SetToolTip(this.btMinimitzar, "Minimitzar");
            toolTip.SetToolTip(this.btSecureCore, "Secure Core");
            toolTip.SetToolTip(this.btRepublicSystem, "Republic System");
            toolTip.SetToolTip(this.btXWingsFactory, "X-Wings Factory");
        }

        #region BOTONS
        private void btSecureCore_Click(object sender, EventArgs e)
        {
            //PantallaPrincipal menu = new PantallaPrincipal();
            //menu.Show();
            MessageBox.Show(
                "Estarà disponible en pròximes actualitzacions.",
                "TheGungans Developers",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btXWingsFactory_Click(object sender, EventArgs e)
        {
            sessioUsuari.cargarSessioXWing = true;
            PantallaPrincipalXWF menu = new PantallaPrincipalXWF();
            menu.Show();
        }

        private void btComandes_Click(object sender, EventArgs e)
        {
            PujarComandes comandes = new PujarComandes();
            comandes.ShowDialog();
        }

        private void btRepublicSystem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Estarà disponible en pròximes actualitzacions.",
                "TheGungans Developers",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btTancar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimitzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
