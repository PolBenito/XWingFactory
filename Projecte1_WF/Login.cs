using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using AccesDades_BC;
using Persistencia;
using System.Linq;

namespace Projecte1_WF
{
    public partial class Login : Form
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        public Login()
        {
            InitializeComponent();
            toolTip.SetToolTip(this.btClose, "Tancar");
        }

        private void entrar()
        {
            DataSet ds = new DataSet();

            string query = "SELECT Users.idUser, Users.Login, Users.Photo FROM Users WHERE(Users.Login = '" + tbUser.Text + "') AND (Users.Password = '" + tbPassword.Text + "')";

            var queryUserCategory = (from u in db.FactoryUsers
                                     where u.UserName == tbUser.Text
                                     select u.idUserType).FirstOrDefault();

            var queryAccessLevel = (from u in db.UserTypes
                                    join f in db.FactoryUsers
                                    on u.idUserType equals f.idUserType
                                    where f.UserName == tbUser.Text
                                    select u.codeUserType).FirstOrDefault();

            DataAccess instance = new DataAccess();

            ds = instance.PortarPerConsulta(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();

                System.Configuration.Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");

                //ConfigurationManager.AppSettings.Set("_idUserCategory", ds.Tables[0].Rows[0]["idUserCategory"].ToString());
                //ConfigurationManager.AppSettings.Set("_accesslevel", ds.Tables[0].Rows[0]["accesslevel"].ToString());
                ConfigurationManager.AppSettings.Set("_idUserCategory", queryUserCategory.ToString());
                ConfigurationManager.AppSettings.Set("_accesslevel", queryAccessLevel.ToString());
                ConfigurationManager.AppSettings.Set("_Login", ds.Tables[0].Rows[0]["Login"].ToString());
                ConfigurationManager.AppSettings.Set("_Photo", ds.Tables[0].Rows[0]["Photo"].ToString());

                opcionesMenu menu = new opcionesMenu();
                menu.Show();

            }
            else
            {
                errorLogin.Visible = true;
                toolTip.SetToolTip(this.errorLogin, "Error al entrar. Pruebe otra vez!");
            }
        }


        #region BOTONS
        private void btLogin_Click(object sender, EventArgs e)
        {

            entrar();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region DRAG AND DROP

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void mouseUp()
        {
            Dragging = false;
        }

        private void mouseDown()
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void mouseMove()
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void titol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void titol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void titol_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }




        #endregion

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }
    }
}
