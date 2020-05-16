using System;

namespace PruebaHerenciaGestioForaneas
{
    public partial class Form1 : Gestio_BC.GestioBaseForanies
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nomTaula = "Users";


            GestioBaseForanies_Load();
        }
    }
}
