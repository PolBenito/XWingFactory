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
    public partial class MenuIcona : PictureBox
    {
        public MenuIcona()
        {
            InitializeComponent();
        }

        private void MenuIcona_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "PantallaPrincipalXWF")
                {
                    frm.Show();
                }
                else
                {
                    frm.Hide();
                }
            }
        }
    }
}
