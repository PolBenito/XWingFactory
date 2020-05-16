using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaMikeDelegado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestio_BC.GestioBase frm = new Gestio_BC.GestioBase();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestio_BC.GestioBaseForanies frm = new Gestio_BC.GestioBaseForanies();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PruebaHerenciaGestioBase.Form1 frm = new PruebaHerenciaGestioBase.Form1();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PruebaHerenciaGestioForaneas.Form1 frm = new PruebaHerenciaGestioForaneas.Form1();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestioUsersCategories.UserCategories frm = new GestioUsersCategories.UserCategories();
            frm.Show();
        }
    }
}
