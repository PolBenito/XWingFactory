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

namespace MantenimentNivellAcces
{
    public partial class frmNivellAcces : Proj1.PlantillaXWF
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();
        public frmNivellAcces()
        {
            InitializeComponent();
        }

        private void frmNivellAcces_Load(object sender, EventArgs e)
        {
            List<string> listOperaris = queryList(1);
            List<string> listEnginyers = queryList(2);
            List<string> listAdmins = queryList(3);

            foreach (string item in listOperaris)
            {
                lbOperaris.Items.Add(item);
            }
            foreach (string item in listEnginyers)
            {
                lbEnginyers.Items.Add(item);
            }
            foreach (string item in listAdmins)
            {
                lbAdmins.Items.Add(item);
            }
        }

        private List<string> queryList(short userType)
        {
            List<string> llista = (from f in db.FactoryUsers
                                where f.idUserType == userType
                                select f.UserName).ToList();

            return llista;
        }

        private void lbOperaris_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbOperaris_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    string str = (string)e.Data.GetData(
                        DataFormats.StringFormat);

                    lbOperaris.Items.Add(str);
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

        private void lbOperaris_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbOperaris.Items.Count == 0)
                return;

            int index = lbOperaris.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = lbOperaris.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    lbOperaris.Items.RemoveAt(lbEnginyers.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void lbEnginyers_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbEnginyers_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    string str = (string)e.Data.GetData(
                        DataFormats.StringFormat);

                    lbEnginyers.Items.Add(str);
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

        private void lbEnginyers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbEnginyers.Items.Count == 0)
                return;

            int index = lbEnginyers.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = lbEnginyers.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    lbEnginyers.Items.RemoveAt(lbEnginyers.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void lbAdmins_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbAdmins_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    string str = (string)e.Data.GetData(
                        DataFormats.StringFormat);

                    lbAdmins.Items.Add(str);
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

        private void lbAdmins_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbAdmins.Items.Count == 0)
                return;

            int index = lbAdmins.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = lbAdmins.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    lbAdmins.Items.RemoveAt(lbEnginyers.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void guardarBT_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string item in lbOperaris.Items)
                {
                    var query = from f in db.FactoryUsers
                                where f.UserName == item
                                select f;

                    foreach (FactoryUsers f in query)
                    {
                        f.idUserType = 1;
                    }
                }

                foreach (string item in lbEnginyers.Items)
                {
                    var query = from f in db.FactoryUsers
                                where f.UserName == item
                                select f;

                    foreach (FactoryUsers f in query)
                    {
                        f.idUserType = 2;
                    }
                }

                foreach (string item in lbAdmins.Items)
                {
                    var query = from f in db.FactoryUsers
                                where f.UserName == item
                                select f;

                    foreach (FactoryUsers f in query)
                    {
                        f.idUserType = 3;
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
                   "Hi ha hagut un error, torna a provar més tard.",
                   "TheGungans Developers",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }
    }
}
