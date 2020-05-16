using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projecte1_WF
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void AcercaDe_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void AcercaDe_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void AcercaDe_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

        private void nom_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown();
        }

        private void nom_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void nom_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }
    }
}
