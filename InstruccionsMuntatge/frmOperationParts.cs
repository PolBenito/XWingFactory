using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace InstruccionsMuntatge
{
    public partial class frmOperationParts : Form
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        public List<string> listUpdate = new List<string>();

        public short valor = 0;
        
        public frmOperationParts()
        {
            InitializeComponent();
        }

        #region DRAG AND DROP FORMULARI

        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion
        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOperationParts_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if(frm.Name == "frmInstruccionsMuntatge")
                {
                    foreach(Control c in frm.Controls)
                    {
                        if(c.Name == "idAIDetailTB")
                        {
                            valor = Int16.Parse(c.Text);
                        }
                    }
                }
            }

            var ReferencesList = (from r in db.References
                                  where !(from o in db.OperationParts
                                          where o.idAssemblyInstructionsDetail == valor
                                          select o.idReference).Contains(r.idReference)
                                  select r.descReference);

            var ComboList= (from r in db.References
                            where (from o in db.OperationParts
                                   where o.idAssemblyInstructionsDetail == valor
                                   select o.idReference).Contains(r.idReference)
                            select r.descReference);

            foreach (var item in ReferencesList)
            {
                PartsList.Items.Add(item.ToString());
            }
            foreach(var item in ComboList)
            {
                NomPieceCB.Items.Add(item.ToString());
            }

            if (NomPieceCB.SelectedIndex != -1) {
                NomPieceCB.SelectedIndex = 0;
            }
        }

        private void NomPieceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var numParts = (from o in db.OperationParts
                            join r in db.References
                            on o.idReference equals r.idReference
                            where r.descReference == NomPieceCB.SelectedItem.ToString()
                            where o.idAssemblyInstructionsDetail == valor
                            select o.NumberOfPieces).FirstOrDefault();

            NumberPiecesTB.Text = numParts.ToString();
        }

        private void afegirBT_Click(object sender, EventArgs e)
        {
            if (PartsList.SelectedIndex != -1)
            {
                NomPieceCB.Items.Add(PartsList.SelectedItem);
                NomPieceCB.SelectedItem = PartsList.SelectedItem;

                listUpdate.Add(PartsList.SelectedItem.ToString());

                PartsList.Items.Remove(PartsList.SelectedItem);
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

        private void guardarBT_Click(object sender, EventArgs e)
        {
            bool exist = false;

            foreach (string item in listUpdate) {
                
                if (NomPieceCB.SelectedItem.ToString() == item)
                {
                    exist = true;
                }
            }

            if (exist)
            {
                //add
                try
                {
                    db.OperationParts.Add(new OperationParts()
                    {
                        idAssemblyInstructionsDetail = valor,
                        idReference = (from r in db.References
                                       where r.descReference == NomPieceCB.SelectedItem.ToString()
                                       select r.idReference).FirstOrDefault(),
                        NumberOfPieces = short.Parse(NumberPiecesTB.Text)
                    });

                    MessageBox.Show(
                        "S'ha guardat correctament!",
                        "TheGungans Developers",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                //update
                try
                {
                    var query = (from o in db.OperationParts
                                 join r in db.References
                                 on o.idReference equals r.idReference
                                 where r.descReference == NomPieceCB.SelectedItem.ToString()
                                 where o.idAssemblyInstructionsDetail == valor
                                 select o).FirstOrDefault();

                    query.NumberOfPieces = Int16.Parse(NumberPiecesTB.Text);

                    MessageBox.Show(
                        "S'ha guardat correctament!",
                        "TheGungans Developers",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.ToString(),
                        "TheGungans Developers",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation
                    );
                }
            }

            db.SaveChanges();
        }

        private void elminarBT_Click(object sender, EventArgs e)
        {
            if (NomPieceCB.SelectedIndex != -1)
            {
                DialogResult result =  MessageBox.Show(
                    "Està segur que vol eliminar aquesta dada?",
                    "TheGungans Developers",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    PartsList.Items.Add(NomPieceCB.SelectedItem);
                    PartsList.SelectedItem = NomPieceCB.SelectedItem;

                    listUpdate.Add(NomPieceCB.SelectedItem.ToString());

                    var query = (from o in db.OperationParts
                                 join r in db.References
                                 on o.idReference equals r.idReference
                                 where r.descReference == NomPieceCB.SelectedItem.ToString()
                                 where o.idAssemblyInstructionsDetail == valor
                                 select o).FirstOrDefault();

                    db.OperationParts.Remove(query);

                    NomPieceCB.Items.Remove(NomPieceCB.SelectedItem);

                    NumberPiecesTB.Clear();

                    db.SaveChanges();
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
    }
}
