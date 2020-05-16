using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDeClases
{
    public partial class RolUsuari : UserControl
    {
        public RolUsuari()
        {
            InitializeComponent();
        }

        private string _usercategory;
        public string UserCategory

        {
            get { return _usercategory; }
            set { _usercategory = value;

                lblRolUsuari.Text = _usercategory;
            }
        }
    }
}
