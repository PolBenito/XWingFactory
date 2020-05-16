using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaHerenciaGestioBase
{
    public partial class Form1 : Gestio_BC.GestioBase
    {
        public Form1()
        {
            //this.nomTaula = "UserCategories";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nomTaula = "UserCategories";

            GestioBase_Load();
        }
    }
}
