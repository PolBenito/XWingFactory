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
    
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        
        private void time_carga_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width>= 610)
            {
                time_carga.Stop();

                Login login = new Login();
                login.Show();

                this.Hide();
            }
        }

        
    }
}
