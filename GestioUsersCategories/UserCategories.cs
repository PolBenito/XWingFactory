using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioUsersCategories
{
    public partial class UserCategories : Gestio_BC.GestioBase
    {
        public UserCategories()
        {
            InitializeComponent();
        }

        private void UserCategories_Load(object sender, EventArgs e)
        {

            if (DesignMode) return;

            this.nomTaula = "UserCategories";

            GestioBase_Load();

            graellaDades.Columns[1].HeaderText = "Codi Categoria";
            graellaDades.Columns[2].HeaderText = "Descripció Categoria";
            graellaDades.Columns[3].HeaderText = "Nivell d'Accés";
        }
    }
}
