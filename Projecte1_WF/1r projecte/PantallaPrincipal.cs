﻿using System;
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
    public partial class PantallaPrincipal : Proj1.Plantilla
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btInformacio_Click(object sender, EventArgs e)
        {
            Form frm = new AcercaDe();
            frm.ShowDialog();
        }
    }
}
