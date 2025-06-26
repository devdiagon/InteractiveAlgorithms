using AlgoritmosInteractivos.algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos.interactions
{
    internal class BresCirHandler
    {
        private BresenhamCircle Bresenham;

        private Point center;
        private int r;
        public List<Point> points = new List<Point>();

        private PictureBox picCanvas;
        private Bitmap bmp;
        private Graphics g;

        public BresCirHandler(PictureBox picCanvas)
        {
            this.picCanvas = picCanvas;
            InitializeDrawingSurface();
        }

        private void InitializeDrawingSurface()
        {
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            picCanvas.Image = bmp;
        }

        private void ResetValues()
        {
            center = new Point();
            points = new List<Point>();
            g.Clear(Color.White);
            picCanvas.Invalidate();
        }

        public void RegisterCenter(Point p)
        {
            center = new Point(p.X, p.Y);
        }

        public void ComputeCircle()
        {
            Bresenham = new BresenhamCircle(r, center);
            points = Bresenham.GeneratePoints();
        }

        public async Task DrawCircle(int delay)
        {
            foreach (Point p in points)
            {
                if (p.X >= 0 && p.X < bmp.Width && p.Y >= 0 && p.Y < bmp.Height)
                {
                    bmp.SetPixel(p.X, p.Y, Color.Black);
                    picCanvas.Image = (Bitmap)bmp.Clone();
                    await Task.Delay(delay);
                }
            }

            picCanvas.Image = bmp;
        }

        public bool ReadData(TextBox txtInputRadius)
        {
            try
            {
                r = int.Parse(txtInputRadius.Text);

                if (r <= 0)
                {
                    MessageBox.Show("El radio no puede ser menor o igual a cero", "Mensaje de error");
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Radio no válido...", "Mensaje de error");
                return false;
            }
        }

        public void InitializeData(
            TextBox txtInputRadius,
            TrackBar trbVel)
        {
            ResetValues();

            txtInputRadius.Text = "";
            trbVel.Value = 3;

            txtInputRadius.Focus();
        }
    }
}
