using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioUsuaris
{
    public partial class Usuaris : Gestio_BC.GestioBaseForanies
    {
        public Usuaris()
        {
            InitializeComponent();
        }

        private void Usuaris_Load(object sender, EventArgs e)
        {
            this.nomTaula = "Users";

            GestioBaseForanies_Load();

            graellaDadesForanes.Columns[1].HeaderText = "Codi Usuari";
            graellaDadesForanes.Columns[2].HeaderText = "Nom Usuari";
            graellaDadesForanes.Columns[3].HeaderText = "Login";
            graellaDadesForanes.Columns[7].HeaderText = "Fotografia";
        }
        
    }
}
