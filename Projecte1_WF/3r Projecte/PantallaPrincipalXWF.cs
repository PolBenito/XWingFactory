using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte1_WF._3r_Projecte
{
    public partial class PantallaPrincipalXWF : Proj1.PlantillaXWF
    {

        public PantallaPrincipalXWF()
        {
            InitializeComponent();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            AcercaDe frm = new AcercaDe();
            frm.ShowDialog();
        }
    }
}
