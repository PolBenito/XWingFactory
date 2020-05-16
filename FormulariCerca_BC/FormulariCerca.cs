using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AccesDades_BC;

namespace FormulariCerca_BC
{
    public partial class FormulariCerca : Form
    {
        AccesDades_BC.DataAccess dab = new DataAccess();
        DataSet ds = new DataSet();

        string query, nomColumna;
        string FormulariOrigenGlobal, ControlOrigenGlobal;

        public FormulariCerca(string FormulariOrigen, string ControlOrigen, string NomTaula)
        {
            InitializeComponent();

            FormulariOrigenGlobal = FormulariOrigen;
            ControlOrigenGlobal = ControlOrigen;


            ds = dab.PortarTaula(NomTaula);

            query = "SELECT * FROM " + NomTaula;

            graellaDades.DataSource = ds.Tables[0];

            for (int i=0; i<graellaDades.ColumnCount; i++)
            {
                nomColumna = graellaDades.Columns[i].Name;

                if (nomColumna.Contains("Code") || nomColumna.Contains("Desc"))
                {
                    graellaDades.Columns[nomColumna].Visible = true;
                }
                else
                {
                    graellaDades.Columns[nomColumna].Visible = false;
                }
            }
        }

        private void graellaDades_DoubleClick(object sender, EventArgs e)
        {
            string idTaula;
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == FormulariOrigenGlobal)
                {
                    foreach (Control c in frm.Controls)
                    {
                        if (c.Name == ControlOrigenGlobal)
                        {
                            try
                            {
                                idTaula = graellaDades.CurrentRow.Cells[0].Value.ToString();
                                c.Text = idTaula;

                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error 404: " + ex);
                            }
                        }
                    }
                }
            }
        }

        private void TancarPestanya_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void mouseUp()
        {
            Dragging = false;
        }

        private void mouseDown()
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void mouseMove()
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void FormulariCerca_Load(object sender, EventArgs e)
        {
            graellaDades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 0, 0);
            graellaDades.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            graellaDades.Font = new Font("Montserrat", 10);
            graellaDades.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            graellaDades.EnableHeadersVisualStyles = false;
        }
    }
}
