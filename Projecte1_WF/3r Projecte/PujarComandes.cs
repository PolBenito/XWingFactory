using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte1_WF._3r_Projecte
{
    public partial class PujarComandes : Form
    {
        public PujarComandes()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (tbRuta.Text.Trim().Equals("") || tbRuta.Text.Trim().Substring(tbRuta.Text.Trim().Length - 3) != "edi")
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
                //byte[] file = null;
                //Stream stream = FileDialogRuta.OpenFile();
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    stream.CopyTo(ms);
                //    file = ms.ToArray();
                //}

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://172.17.6.0/comandes.edi");

                ftpRequest.Credentials = new NetworkCredential("thegungans", "12345aA");
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] fileContent;

                using (StreamReader sr = new StreamReader(tbRuta.Text))
                {
                    fileContent = Encoding.UTF8.GetBytes(sr.ReadToEnd());
                }

                using (Stream sw = ftpRequest.GetRequestStream())
                {
                    sw.Write(fileContent, 0, fileContent.Length);
                }

                ftpRequest.GetResponse();



                MessageBox.Show(
                    "Arxiu desat correctament.",
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

        private void btRuta_Click(object sender, EventArgs e)
        {
            FileDialogRuta.InitialDirectory = Application.StartupPath + "\\EDI";
            FileDialogRuta.FilterIndex = 1;
            FileDialogRuta.RestoreDirectory = true;

            if (FileDialogRuta.ShowDialog() == DialogResult.OK)
            {
                tbRuta.Text = FileDialogRuta.FileName;
            }
        }

        private void btMinimitzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
