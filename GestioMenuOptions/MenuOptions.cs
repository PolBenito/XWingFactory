using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioMenuOptions
{
    public partial class MenuOptions : Gestio_BC.GestioBase
    {
        public MenuOptions()
        {
            InitializeComponent();
        }

        private void MenuOptions_Load(object sender, EventArgs e)
        {
            this.nomTaula = "MenuOptions";

            GestioBase_Load();


            graellaDades.Columns[1].HeaderText = "Nom DLL";
            graellaDades.Columns[2].HeaderText = "Nom Formulari";
            graellaDades.Columns[3].HeaderText = "Nom";
            graellaDades.Columns[4].HeaderText = "Imatge";
            graellaDades.Columns[5].HeaderText = "Nivell d'Accés";
        }
    }
}
