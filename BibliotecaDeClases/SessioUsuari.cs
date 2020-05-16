using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BibliotecaDeClases
{
    public partial class SessioUsuari : UserControl
    {
        public bool cargarSessioXWing;

        public SessioUsuari()
        {
            InitializeComponent();
            
            if (cargarSessioXWing)
            {
                BackColor = Color.White;
            }
        }
        
        private int _iduser;
        public int IdUser

        {
            get { return _iduser; }
            set { _iduser = value; }
        }

        private string _codeuser;
        public string CodeUser

        {
            get { return _codeuser; }
            set { _codeuser = value; }
        }

        private string _username;
        public string UserName

        {
            get { return _username; }
            set
            {
                _username = value;
                nomusuari.Text = _username;
            }
        }

        private string _login;
        public string Login

        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;
        public string Password

        {
            get { return _password; }
            set { _password = value; }
        }

        private int _iduserrank;
        public int IdUserRank

        {
            get { return _iduserrank; }
            set { _iduserrank = value; }
        }

        private int _idusercategory;
        public int IdUserCategory

        {
            get { return _idusercategory; }
            set { _idusercategory = value; }
        }

        private string _photo;
        public string Photo

        {
            get { return _photo; }
            set
            {
                _photo = value;
                avatarusuari.ImageLocation = Application.StartupPath + @"\\images\\" + _photo;
            }
        }

        private int _idplanet;
        public int IdPlanet

        {
            get { return _idplanet; }
            set { _idplanet = value; }
        }

        private int _idspecie;
        public int IdSpecie

        {
            get { return _idspecie; }
            set { _idspecie = value; }
        }
    }
}
