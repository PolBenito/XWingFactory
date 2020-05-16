using Persistencia;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EscandallProducte
{
    public partial class frmEscandall : Proj1.PlantillaXWF
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        public frmEscandall()
        {
            InitializeComponent();

            mediaPlayer.settings.setMode("loop", true);
        }

        private void frmEscandall_Load(object sender, System.EventArgs e)
        {
            refreshEscandall();
            treeView.ExpandAll();
        }

        private void refreshEscandall()
        {
            IDictionary<string, IDictionary<string, IEnumerable<string>>> dictionaryEscandall; 
            dictionaryEscandall = ObtenirDadesEscandall();

            if (dictionaryEscandall != null)
            {
                foreach (var f in dictionaryEscandall)
                {
                    TreeNode final = new TreeNode(f.Key);
                    treeView.Nodes.Add(final);

                    foreach (var i in f.Value)
                    {
                        TreeNode intermig = new TreeNode(i.Key);
                        final.Nodes.Add(intermig);

                        foreach (string p in i.Value)
                        {
                            intermig.Nodes.Add(p);
                        }
                    }
                }
            }
        }

        private IDictionary<string, IDictionary<string, IEnumerable<string>>> ObtenirDadesEscandall()
        {
            IDictionary<string, IDictionary<string, IEnumerable<string>>> dictionaryFinal = new Dictionary<string, IDictionary< string, IEnumerable<string>>>();

            IDictionary<string, IEnumerable<string>> dictionaryIntermig = new Dictionary<string, IEnumerable<string>>(); ;

            try
            {
                IEnumerable<string> ListIdProducteFinal = from rs in db.References.AsEnumerable()
                                                          where rs.idReferenceType == 1
                                                          select rs.idReference.ToString();

                foreach (string idFinal in ListIdProducteFinal)
                {
                    string producteFinal = (from pf in db.References
                                            where pf.idReference.ToString() == idFinal
                                            select pf.descReference).ToArray()[0];

                    IEnumerable<string> ListIdProducteIntermig = from s in db.Structure.AsEnumerable()
                                                                 where s.idReferenceFinal.ToString() == idFinal
                                                                 select s.idReferencePart.ToString();

                    foreach (string id in ListIdProducteIntermig)
                    {
                        string producteIntermig = (from r in db.References
                                                   where r.idReference.ToString() == id.ToString()
                                                   select r.descReference).ToArray()[0];

                        IEnumerable<string> producteInicial = from s in db.Structure.AsEnumerable()
                                                              join rf in db.References.AsEnumerable()
                                                              on s.idReferencePart equals rf.idReference
                                                              where s.idReferenceFinal.ToString() == id
                                                              select rf.descReference.ToString();

                        dictionaryIntermig.Add(producteIntermig, producteInicial);
                        
                    }
                    dictionaryFinal.Add(producteFinal, dictionaryIntermig);
                }
            }
            catch
            {
                dictionaryFinal = null;
                MessageBox.Show("Error a la hora d'obtenir les dades de l'estructura");
            }
            return dictionaryFinal;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var query = from r in db.References
                            where r.descReference == e.Node.Text
                            select new { r.idReference, r.codeReference, r.descReference, r.Photo, r.VideoExplode };

                foreach (var dades in query)
                {
                    lbCodi.Text = dades.codeReference;
                    lbNom.Text = dades.descReference;
                    fotografia.ImageLocation = Application.StartupPath + @"/images/xwings/" + dades.Photo;
                    mediaPlayer.URL = @"videos/" + dades.VideoExplode;
                }
            }
            catch
            {
                MessageBox.Show("Hi ha hagut un problema en els nostres servidors, siusplau, torna a provar-ho més tard.");
            }
        }

        private void btModificar_Click(object sender, System.EventArgs e)
        {
            frmModificacioEscandall frm = new frmModificacioEscandall();

            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);

            frm.ShowDialog();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            treeView.Nodes.Clear();
            //refreshEscandall();

            frmEscandall r = new frmEscandall() ;
            this.Close();
            r.Show();
        }
    }
}
