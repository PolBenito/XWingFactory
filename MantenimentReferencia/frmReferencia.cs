using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using Persistencia;

namespace MantenimentReferencia
{
    public partial class frmReferencia : Proj1.PlantillaXWF
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        List<References> CodeReferenceList = new List<References>();

        bool filaNova = false;

        public frmReferencia()
        {
            InitializeComponent();
        }

        private void frmReferencia_Load(object sender, EventArgs e)
        {
            var query = (from rt in db.ReferenceTypes
                         select rt.descReferenceType);


            foreach (string item in query)
            {
                cbTipusReferencia.Items.Add(item);
            }

            if (cbTipusReferencia.Items.Count > 0)
            {
                cbTipusReferencia.SelectedIndex = 0;
            }

            if (DesignMode) return;

            graellaDades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            graellaDades.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            graellaDades.Font = new Font("Montserrat", 10);
            graellaDades.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            graellaDades.EnableHeadersVisualStyles = false;

            actualitzarDGV();
        }

        private void actualitzarDGV()
        {
            CodeReferenceList = (from r in db.References
                                 select r).ToList();

            Databinding();

            graellaDades.Columns[0].Visible = false;
            graellaDades.Columns[1].HeaderText = "Codi Referència";
            graellaDades.Columns[2].HeaderText = "Descripció Referència";
            graellaDades.Columns[3].HeaderText = "Foto";
            graellaDades.Columns[4].HeaderText = "Video";
            graellaDades.Columns[5].Visible = false;
            graellaDades.Columns[6].Visible = false;
            graellaDades.Columns[7].Visible = false;
            graellaDades.Columns[8].Visible = false;
            graellaDades.Columns[9].Visible = false;
            graellaDades.Columns[10].Visible = false;
        }

        private void Databinding()
        {
            foreach (Control textbox in Controls)
            {
                if (textbox is SdsTextbox)
                {
                    ((SdsTextbox)textbox).DataBindings.Clear();
                    ((SdsTextbox)textbox).DataBindings.Add("Text", CodeReferenceList, ((SdsTextbox)textbox).CampBBDD);
                }
            }

            graellaDades.DataSource = CodeReferenceList;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();

                MessageBox.Show(
                    "S'ha guardat correctament!",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                actualitzarDGV();
            }
            catch
            {
                MessageBox.Show(
                     "No s'ha guardat correctament!",
                     "TheGungans Developers",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                 );
            }
        }

        private void btAfegir_Click(object sender, EventArgs e)
        {
            cbTipusReferencia.SelectedIndex = -1;
            filaNova = true;

            foreach (Control textbox in Controls)
            {
                if (textbox is SdsTextbox)
                {
                    ((SdsTextbox)textbox).DataBindings.Clear();
                    textbox.Text = "";
                }
            }
            
            tbCodeReference.Focus();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (graellaDades.SelectedRows.Count != 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Està segur que vol eliminar aquesta dada?",
                        "TheGungans Developers",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        short id = Int16.Parse(tbIdReference.Text);

                        var query = (from r in db.References
                                       where r.idReference == id
                                       select r);

                        foreach (var item in query)
                        {
                            db.References.Remove(item);
                        }

                        db.SaveChanges();

                        MessageBox.Show(
                            "S'ha eliminat correctament!",
                            "TheGungans Developers",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        actualitzarDGV();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Siusplau selecciona un element.",
                        "TheGungans Developers",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
            }
            catch
            {
                MessageBox.Show(
                     "No s'ha eliminat correctament!",
                     "TheGungans Developers",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                 );
            }
        }

        private void cbTipusReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbIdReferenceType.Text = (cbTipusReferencia.SelectedIndex + 1).ToString();

            if (filaNova)
            {
                CodeReferenceList.Add(new References()
                {
                    codeReference = tbCodeReference.Text.ToString(),
                    descReference = tbDescReference.Text.ToString(),
                    Photo = tbFoto.Text.ToString(),
                    VideoExplode = tbVideo.Text.ToString(),
                    idReferenceType = Int16.Parse(tbIdReferenceType.Text)
                });

                db.References.Add(new References()
                {
                    codeReference = tbCodeReference.Text.ToString(),
                    descReference = tbDescReference.Text.ToString(),
                    Photo = tbFoto.Text.ToString(),
                    VideoExplode = tbVideo.Text.ToString(),
                    idReferenceType = Int16.Parse(tbIdReferenceType.Text)
                });

                graellaDades.DataSource = CodeReferenceList.ToList();
                Databinding();
            }
            filaNova = false;
        }

        private void tbIdReferenceType_TextChanged(object sender, EventArgs e)
        {
            if (!filaNova)
            {
                cbTipusReferencia.SelectedIndex = Int32.Parse(tbIdReferenceType.Text) - 1;
            }          
        }
    }
}
