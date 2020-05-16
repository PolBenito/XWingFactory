using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioUserRanks
{
    public partial class UserRanks : Gestio_BC.GestioBase
    {
        public UserRanks()
        {
            InitializeComponent();
        }

        private void UserRanks_Load(object sender, EventArgs e)
        {
            this.nomTaula = "UserRanks";

            GestioBase_Load();

            graellaDades.Columns[1].HeaderText = "Codi Rang";
            graellaDades.Columns[2].HeaderText = "Descripció Rang";
        }
    }
}
