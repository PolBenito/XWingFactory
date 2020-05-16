using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestio_BC
{
    public partial class GestioBaseForanies : Proj1.Plantilla
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

        public GestioBaseForanies()
        {
            InitializeComponent();
        }

        public void GestioBaseForanies_Load(object sender = null, EventArgs e = null)
        {
            if (DesignMode) return;

            graellaDadesForanes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 0, 0);
            graellaDadesForanes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            graellaDadesForanes.Font = new Font("Montserrat", 10);
            graellaDadesForanes.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            graellaDadesForanes.EnableHeadersVisualStyles = false;

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

                graellaDadesForanes.DataSource = dts.Tables[0];

                portarDades();

                for (int i = 0; i < graellaDadesForanes.ColumnCount; i++)
                {
                    nomColumna = graellaDadesForanes.Columns[i].Name;

                    if (nomColumna.Contains("id"))
                    {
                        graellaDadesForanes.Columns[nomColumna].Visible = false;
                    }
                    else if (nomColumna == "Password")
                    {
                        graellaDadesForanes.Columns["Password"].Visible = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
        }

        public void portarDades()
        {
            try
            {
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
                    MessageBox.Show("No pots editar el camp");
                    graellaDadesForanes.DataSource = dts.Tables[0];
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
                        if (c is BibliotecaDeClases.SdsTextbox)
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
                MessageBox.Show("Error al actualitzar");
            }
        }
    }
}
