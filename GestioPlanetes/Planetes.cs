using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioPlanetes
{
    public partial class Planetes : Gestio_BC.GestioBaseForanies
    {
        public Planetes()
        {
            InitializeComponent();
        }

        private void Planetes_Load(object sender, EventArgs e)
        {
            this.nomTaula = "Planets";


            GestioBaseForanies_Load();


            graellaDadesForanes.Columns[1].HeaderText = "Codi Planeta";
            graellaDadesForanes.Columns[2].HeaderText = "Descripció Planeta";
            graellaDadesForanes.Columns[4].HeaderText = "Longitud";
            graellaDadesForanes.Columns[5].HeaderText = "Latitud";
            graellaDadesForanes.Columns[6].HeaderText = "Parsecs";
            graellaDadesForanes.Columns[9].HeaderText = "Fotografia Planeta";
            graellaDadesForanes.Columns[10].HeaderText = "IP Planeta";
            graellaDadesForanes.Columns[11].HeaderText = "Port Planeta";
        }
    }
}
