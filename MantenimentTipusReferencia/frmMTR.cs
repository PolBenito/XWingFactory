using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BibliotecaDeClases;
using System.Data.SqlClient;

namespace MantenimentTipusReferencia
{
    public partial class frmMTR : Proj1.PlantillaXWF
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        List<ReferenceTypes> CodeReferenceTypeList = new List<ReferenceTypes>();

        bool filaNova = false;

        public frmMTR()
        {
            InitializeComponent();
        }

        private void frmMTR_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            graellaDades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            graellaDades.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            graellaDades.Font = new Font("Montserrat", 10);
            graellaDades.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            graellaDades.EnableHeadersVisualStyles = false;

            actualitzarDGV();
        }

        private void Databinding()
        {
            foreach (Control textbox in Controls)
            {
                if (textbox is SdsTextbox)
                {
                    ((SdsTextbox)textbox).DataBindings.Clear();
                    ((SdsTextbox)textbox).DataBindings.Add("Text", CodeReferenceTypeList, ((SdsTextbox)textbox).CampBBDD);
                }
            }

            graellaDades.DataSource = CodeReferenceTypeList;
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
            filaNova = true;
            foreach (Control textbox in Controls)
            {
                if (textbox is SdsTextbox)
                {
                    ((SdsTextbox)textbox).DataBindings.Clear();
                    textbox.Text = "";
                }
            }
            tbCodeReferenceType.Focus();
        }

        private void tbDescReferenceType_Leave(object sender, EventArgs e)
        {
            if (filaNova)
            {
                CodeReferenceTypeList.Add(new ReferenceTypes()
                {
                    codeReferenceType = tbCodeReferenceType.Text.ToString(),
                    descReferenceType = tbDescReferenceType.Text.ToString()
                });

                db.ReferenceTypes.Add(new ReferenceTypes()
                {
                    codeReferenceType = tbCodeReferenceType.Text.ToString(),
                    descReferenceType = tbDescReferenceType.Text.ToString()
                });

                graellaDades.DataSource = CodeReferenceTypeList.ToList();
                Databinding();
            }
            filaNova = false;
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
                        short idRT = Int16.Parse(tbIdReferenceType.Text);

                        var queryRT = (from r in db.ReferenceTypes
                                        where r.idReferenceType == idRT
                                        select r);

                        foreach (var item in queryRT)
                        {
                            db.ReferenceTypes.Remove(item);
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

        private void actualitzarDGV()
        {
            CodeReferenceTypeList = (from r in db.ReferenceTypes
                                     select r).ToList();

            Databinding();
            graellaDades.Columns[0].Visible = false;
            graellaDades.Columns[1].HeaderText = "Codi Tipus Referència";
            graellaDades.Columns[2].HeaderText = "Descripció Tipus Referència";
            graellaDades.Columns[3].Visible = false;
        }
    }
}
