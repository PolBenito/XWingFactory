using Persistencia;
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
using System.IO;

namespace InstruccionsMuntatge
{
    public partial class frmInstruccionsMuntatge :  Proj1.PlantillaXWF
    {
        private static readonly Encoding LocalEncoding = Encoding.UTF8;

        public string idAID = "";

        XWingsFactoryEntities db = new XWingsFactoryEntities();

        List<AssemblyInstructionsDetail> CodeOperationList = new List<AssemblyInstructionsDetail>();
        List<string> CB1;
        List<string> CB2;

        string comboFinal = "";
        bool filaNova = false;

        public frmInstruccionsMuntatge()
        {
            InitializeComponent();
        }

        private void InstruccionsMuntatgeWF_Load(object sender, EventArgs e)
        {
            if (tipusReferenciaCB.Items.Count > 0)
            {
                tipusReferenciaCB.SelectedIndex = 0;
            }

            if (DesignMode) return;

            graellaDades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            graellaDades.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            graellaDades.Font = new Font("Montserrat", 10);
            graellaDades.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            graellaDades.EnableHeadersVisualStyles = false;
        }
        private void tipusReferenciaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB1 = db.References.Where(r => r.idReferenceType == 1).Select(r => r.descReference).ToList();
            
            if (tipusReferenciaCB.SelectedIndex == 0)
            {
                Opcions2CB.Visible = false;
                ProducteIntermigLbl.Visible = false;

            }
            else
            {
                Opcions2CB.Visible = true;
                ProducteIntermigLbl.Visible = true;
            }

            Opcions1CB.Items.Clear();

            foreach (string item in CB1)
            {
                Opcions1CB.Items.Add(item);
            }

            Opcions1CB.SelectedIndex = 0;
        }

        private void Opcions1CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipusReferenciaCB.SelectedIndex == 1)
            {
                CB2 = db.References.Where(r => r.idReferenceType == 2).Select(r => r.descReference).ToList();

                Opcions2CB.Items.Clear();

                foreach (string item in CB2)
                {
                    Opcions2CB.Items.Add(item);
                    Opcions2CB.SelectedIndex = 0;
                }
            }
            else
            {
                CodeOperationListFunc(Opcions1CB.SelectedItem.ToString());
                
            }
        }

        private void Opcions2CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodeOperationListFunc(Opcions2CB.SelectedItem.ToString());
        }

        private void CodeOperationListFunc(string combo)
        {
            comboFinal = combo;

            CodeOperationList = (from a in db.AssemblyInstructionsDetail
                                 join b in db.AssemblyInstructions
                                 on a.idAssemblyInstructions equals b.idAssemblyInstructions
                                 join r in db.References
                                 on b.idreference equals r.idReference
                                 where r.descReference == combo
                                 select a).ToList();

            Databinding();
            graellaDades.Columns[0].Visible = false;
            graellaDades.Columns[1].Visible = false;
            graellaDades.Columns[2].HeaderText = "Codi Operació";
            graellaDades.Columns[3].HeaderText = "Descripció Operació";
            graellaDades.Columns[4].HeaderText = "Nombre Usuaris";
            graellaDades.Columns[5].HeaderText = "Ordre Operació";
            graellaDades.Columns[6].Visible = false;
            graellaDades.Columns[7].Visible = false;

            try
            {
                byte[] pdf = (from b in db.AssemblyInstructions.AsEnumerable()
                              join d in db.References.AsEnumerable()
                              on b.idreference equals d.idReference
                              where d.descReference.ToString() == combo
                              select b.Instructions).ToArray()[0];

                File.WriteAllBytes(Application.StartupPath + "/pdf/" + combo + ".pdf", pdf);

                acroPDF.src = Application.StartupPath + "/pdf/" + combo + ".pdf";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Databinding()
        {
            foreach(Control textbox in Controls)
            {
                if (textbox is SdsTextbox)
                {
                    ((SdsTextbox)textbox).DataBindings.Clear();
                    ((SdsTextbox)textbox).DataBindings.Add("Text", CodeOperationList, ((SdsTextbox)textbox).CampBBDD);
                }
            }

            graellaDades.DataSource = CodeOperationList;
        }
        
        private void GuardarBT_Click(object sender, EventArgs e)
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

        private void afegirBT_Click(object sender, EventArgs e)
        {
            filaNova = true;
            foreach(Control textbox in Controls)
            {
                if(textbox is SdsTextbox)
                {
                    ((SdsTextbox)textbox).DataBindings.Clear();
                    textbox.Text = "";
                }
            }
            CodeOperationTB.Focus();
        }

        private void OperationOrderTB_Leave(object sender, EventArgs e)
        {
            if (filaNova)
            {
                var id = (from a in db.AssemblyInstructionsDetail
                          join b in db.AssemblyInstructions
                          on a.idAssemblyInstructions equals b.idAssemblyInstructions
                          join r in db.References
                          on b.idreference equals r.idReference
                          where r.descReference == comboFinal
                          select a.idAssemblyInstructions).FirstOrDefault();

                CodeOperationList.Add(new AssemblyInstructionsDetail()
                {
                    idAssemblyInstructions = id,
                    CodeOperation = CodeOperationTB.Text,
                    DescOperation = DescOperationTB.Text,
                    NumberOfUsers = Int16.Parse(NumberUsersTB.Text),
                    OperationOrder = Int16.Parse(OperationOrderTB.Text)
                });

                db.AssemblyInstructionsDetail.Add(new AssemblyInstructionsDetail()
                {
                    idAssemblyInstructions = id,
                    CodeOperation = CodeOperationTB.Text,
                    DescOperation = DescOperationTB.Text,
                    NumberOfUsers = Int16.Parse(NumberUsersTB.Text),
                    OperationOrder = Int16.Parse(OperationOrderTB.Text)
                });
                graellaDades.DataSource = CodeOperationList.ToList();
                Databinding();
            }
            filaNova = false;
        }

        private void eliminarBT_Click(object sender, EventArgs e)
        {
            try {

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
                        short idDetail = Int16.Parse(idAIDetailTB.Text);

                        var queryOP = (from o in db.OperationParts
                                       where o.idAssemblyInstructionsDetail == idDetail
                                       select o);

                        foreach (var item in queryOP)
                        {
                            db.OperationParts.Remove(item);
                        }

                        var queryAID = (from a in db.AssemblyInstructionsDetail
                                        where a.idAssemblyInstructionsDetail == idDetail
                                        select a);

                        foreach (var item in queryAID)
                        {
                            db.AssemblyInstructionsDetail.Remove(item);
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
            if (tipusReferenciaCB.SelectedIndex == 1)
            {
                CodeOperationListFunc(Opcions2CB.SelectedItem.ToString());
            }
            else
            {
                CodeOperationListFunc(Opcions1CB.SelectedItem.ToString());
            }
        }

        private void rutaBT_Click(object sender, EventArgs e)
        {
            FileDialogRuta.InitialDirectory = "c:\\";
            FileDialogRuta.FilterIndex = 1;
            FileDialogRuta.RestoreDirectory = true;

            if (FileDialogRuta.ShowDialog() == DialogResult.OK)
            {
                rutaTB.Text = FileDialogRuta.FileName;
            }
        }

        private void guardarPdfBT_Click(object sender, EventArgs e)
        {
            //string a = rutaTB.Text.Substring(rutaTB.Text.Length - 3);

            if (rutaTB.Text.Trim().Equals("") || rutaTB.Text.Trim().Substring(rutaTB.Text.Trim().Length - 3) != "pdf")
            {
                MessageBox.Show(
                    "Arxiu no compatible.",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                byte[] file = null;
                Stream stream = FileDialogRuta.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    file = ms.ToArray();
                }
                                
                AssemblyInstructions instructions;
                string combo;

                if (tipusReferenciaCB.SelectedIndex == 1)
                {
                    combo = Opcions2CB.SelectedItem.ToString();
                }
                else
                {
                    combo = Opcions1CB.SelectedItem.ToString();
                }

                var listId = from b in db.AssemblyInstructions
                             join d in db.References
                             on b.idreference equals d.idReference
                             where d.descReference.ToString() == combo
                             select b;


                instructions = listId.FirstOrDefault();
                instructions.Instructions = file;

                db.SaveChanges();

                MessageBox.Show(
                    "Arxiu desat correctament!",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btConfPI_Click(object sender, EventArgs e)
        {
            idAID = idAIDetailTB.Text;
            frmOperationParts frmOP = new frmOperationParts();
            frmOP.ShowDialog();
        }
    }
}
