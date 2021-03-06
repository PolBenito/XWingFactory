﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestio_BC
{
    public partial class GestioBase : Proj1.Plantilla
    {
        DataSet dts;
        string query;
        string nomColumna;
        public bool BindingActiu;

        AccesDades_BC.DataAccess bd = new AccesDades_BC.DataAccess();

        private string _nomTaula;
        public string nomTaula
        {
            get { return _nomTaula; }
            set { _nomTaula = value; }
        }
        
        public GestioBase()
        {
            InitializeComponent();
        }

        public void GestioBase_Load(object sender = null, EventArgs e = null)
        {
            if (DesignMode) return;

            graellaDades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 0, 0);
            graellaDades.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            graellaDades.Font = new Font("Montserrat", 10);
            graellaDades.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            graellaDades.EnableHeadersVisualStyles = false;

            if (nomTaula != null)
            {
                cargaDts();
            }
        }
        private void cargaDts()
        {
            BindingActiu = true;

            try
            {
                dts = bd.PortarTaula(nomTaula);

                query = "SELECT * FROM " + nomTaula;

                graellaDades.DataSource = dts.Tables[0];

                portarDades();

                nomColumna = graellaDades.Columns[0].Name;
                graellaDades.Columns[nomColumna].Visible = false;
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
        }

        public void portarDades()
        {
            try { 
                foreach (Control c in this.Controls)
                {
                    if (c is BibliotecaDeClases.SdsTextbox)
                    {

                        ((BibliotecaDeClases.SdsTextbox)c).DataBindings.Clear();

                        ((BibliotecaDeClases.SdsTextbox)c).DataBindings.Add("Text", dts.Tables[0], ((BibliotecaDeClases.SdsTextbox)c).CampBBDD);

                        c.Validated += c_Validated;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
        }
        
        private void c_Validated(object sender, EventArgs e)
        {
            if (BindingActiu)
            {
                try
                {
                    ((BibliotecaDeClases.SdsTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                }
                catch
                {
                    MessageBox.Show("No pots editar el camp.");
                    graellaDades.DataSource = dts.Tables[0];
                }
            }
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            BindingActiu = false;

            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is BibliotecaDeClases.SdsTextbox)
                    {
                        ((BibliotecaDeClases.SdsTextbox)c).DataBindings.Clear();
                        ((BibliotecaDeClases.SdsTextbox)c).Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
        }
        private void btActualitzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BindingActiu)
                {
                    DataRow datarow;
                    datarow = dts.Tables[0].NewRow();

                    foreach (Control c in this.Controls)
                    {
                        if (c is BibliotecaDeClases.SdsTextbox && ((BibliotecaDeClases.SdsTextbox)c).CampBBDD != nomColumna)
                        {

                            if (((BibliotecaDeClases.SdsTextbox)c).Variable == BibliotecaDeClases.SdsTextbox.Tipo.Nombre)
                            {
                                
                                datarow[((BibliotecaDeClases.SdsTextbox)c).CampBBDD] = Int32.Parse(((BibliotecaDeClases.SdsTextbox)c).Text);
                                
                            }
                            else
                            {
                                datarow[((BibliotecaDeClases.SdsTextbox)c).CampBBDD] = ((BibliotecaDeClases.SdsTextbox)c).Text;
                            }
                        }
                    }
                    dts.Tables[0].Rows.Add(datarow);

                    BindingActiu = true;
                }
                bd.Actualitzar(query, dts);
                dts.Clear();
                cargaDts();
            }
            catch
            {
                MessageBox.Show("Error al actualitzar el camp.");
            }
        }
        
    }
}