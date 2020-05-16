using Persistencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscandallProducte
{
    public partial class frmModificacioEscandall : Form
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        List<string> ListaBorrar = new List<string>();

        public frmModificacioEscandall()
        {
            InitializeComponent();
        }

        private void frmModificacioEscandall_Load(object sender, EventArgs e)
        {
            cbTipusProducte.SelectedIndex = 0;
        }

        private void cbTipusProducte_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> dadesTipusProductes;

            cbProductes.Items.Clear();
            listBoxSenseAsignar.Items.Clear();

            if (cbTipusProducte.SelectedIndex == 0) {
                dadesTipusProductes = db.References.Where(r => r.idReferenceType == 1).Select(r => r.descReference).ToList();
            }
            else
            {
                dadesTipusProductes = db.References.Where(r => r.idReferenceType == 2).Select(r => r.descReference).ToList();
            }

            foreach (string item in dadesTipusProductes)
            {
                cbProductes.Items.Add(item);
            }

            cbProductes.SelectedIndex = 0;
        }

        private void cbProductes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox assignats
            var id_assignats = (from r in db.References
                                where r.descReference == cbProductes.SelectedItem.ToString()
                                select r.idReference).FirstOrDefault();

            var query_assignats = from s in db.Structure
                                  join r in db.References
                                  on s.idReferencePart equals r.idReference
                                  where s.idReferenceFinal == id_assignats
                                  select r.descReference;

            listBoxAsignats.Items.Clear();

            foreach (string item in query_assignats)
            {
                listBoxAsignats.Items.Add(item);
            }


            // ListBox sense assiganar
            var tipus = 3;

            if (cbTipusProducte.SelectedIndex == 0)
            {
                tipus = 2;
               
            }

            var query_noAssignats = (from r in db.References
                                     where !(from s in db.Structure
                                             where s.idReferenceFinal == id_assignats
                                             select s.idReferencePart).Contains(r.idReference)
                                     where r.idReferenceType == tipus
                                     select r.descReference);


            listBoxSenseAsignar.Items.Clear();

            List<string> list_noAssignats = new List<string>();
            bool comprovador;
            foreach (string item in query_noAssignats)
            {
                comprovador = false;

                if (item == query_noAssignats.First())
                {
                    list_noAssignats.Add(item);
                }

                foreach(string dada in list_noAssignats)
                {
                    if (item.ToString() == dada)
                    {
                        comprovador = true;
                    }
                }

                if (!comprovador)
                {
                    list_noAssignats.Add(item);
                }
            }

            foreach(string item in list_noAssignats)
            {
                listBoxSenseAsignar.Items.Add(item);
            }
        }


        #region BOTONS

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Treure productes
                foreach (string item in ListaBorrar)
                {
                    var queryBorar = (from x in db.Structure
                                      join m in db.References
                                      on x.idReferencePart equals m.idReference
                                      where x.idReferenceFinal == (from g in db.References
                                                                   where g.descReference == cbProductes.SelectedItem.ToString()
                                                                   select g.idReference).FirstOrDefault()
                                      where m.descReference == item
                                      select x).FirstOrDefault();

                    db.Structure.Remove(queryBorar);
                }

                // Afegir productes
                foreach (string producte in listBoxAsignats.Items)
                {
                    try
                    {
                        List<Structure> s = (from x in db.Structure
                                             join m in db.References
                                             on x.idReferencePart equals m.idReference
                                             where x.idReferenceFinal == (from g in db.References
                                                                          where g.descReference == cbProductes.SelectedItem.ToString()
                                                                          select g.idReference).FirstOrDefault()
                                             where m.descReference == producte
                                             select x).ToList();
                        
                        if (!s.Any())
                        {
                            db.Structure.Add(new Structure()
                            {
                                idReferenceFinal = (from g in db.References
                                                    where g.descReference == cbProductes.SelectedItem.ToString()
                                                    select g.idReference).FirstOrDefault(),
                                idReferencePart = (from r in db.References
                                                   where r.descReference == producte
                                                   select r.idReference).FirstOrDefault(),
                            });

                        }
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Hi ha hagut un error, torna a provar més tard.",
                            "TheGungans Developers",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }

                db.SaveChanges();

                MessageBox.Show(
                    "S'ha guardat correctament!",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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

        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDreta_Click(object sender, EventArgs e)
        {
            if (listBoxSenseAsignar.SelectedIndex != -1)
            {
                listBoxAsignats.Items.Add(listBoxSenseAsignar.SelectedItem);
                listBoxSenseAsignar.Items.Remove(listBoxSenseAsignar.SelectedItem);
            }
        }

        private void btEsquerra_Click(object sender, EventArgs e)
        {
            if (listBoxAsignats.SelectedIndex != -1)
            {
                ListaBorrar.Add(listBoxAsignats.SelectedItem.ToString());
                listBoxSenseAsignar.Items.Add(listBoxAsignats.SelectedItem);
                listBoxAsignats.Items.Remove(listBoxAsignats.SelectedItem);
            }
        }

        #endregion

        #region DRAG AND DROP LISTBOX

        private void listBoxSenseAsignar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBoxSenseAsignar_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                ListaBorrar.Add(listBoxAsignats.SelectedItem.ToString());
                listBoxSenseAsignar.Items.Add(str);
            }
        }

        private void listBoxSenseAsignar_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxSenseAsignar.Items.Count == 0)
                return;

            int index = listBoxSenseAsignar.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = listBoxSenseAsignar.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    listBoxSenseAsignar.Items.RemoveAt(listBoxSenseAsignar.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void listBoxAsignats_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBoxAsignats_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                listBoxAsignats.Items.Add(str);
            }
        }

        private void listBoxAsignats_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (listBoxAsignats.Items.Count == 0)
                    return;

                int index = listBoxAsignats.IndexFromPoint(e.X, e.Y);
                if (index >= 0)
                {
                    string s = listBoxAsignats.Items[index].ToString();
                    DragDropEffects dde1 = DoDragDrop(s,
                        DragDropEffects.All);

                    if (dde1 == DragDropEffects.All)
                    {
                        if (listBoxAsignats.SelectedIndex == -1)
                        {
                            listBoxAsignats.SelectedIndex = listBoxAsignats.SelectedIndex + 1;
                        }
                        listBoxAsignats.Items.RemoveAt(listBoxSenseAsignar.IndexFromPoint(e.X, e.Y));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Torna a provar!");
            }   
        }

        #endregion

        #region DRAG AND DROP FORMULARI

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
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        #endregion
    }
}
