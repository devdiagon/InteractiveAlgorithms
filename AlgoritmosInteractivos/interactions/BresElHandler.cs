using AlgoritmosInteractivos.algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos.interactions
{
    internal class BresElHandler
    {
        private BresenhamEllipse Bresenham;

        private Point center;
        private int a;
        private int b;
        public List<Point> points = new List<Point>();

        public PictureBox picCanvas { get; set; }
        private Bitmap bmp;
        private Graphics g;

        public BresElHandler(PictureBox picCanvas)
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
            Bresenham = new BresenhamEllipse(a, b, center);
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

        public bool ReadData(TextBox txtInputA, TextBox txtInputB)
        {
            try
            {
                a = int.Parse(txtInputA.Text);
                b = int.Parse(txtInputB.Text);

                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Los ejes a y b no pueden ser menor o igual a cero", "Mensaje de error");
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Ejes a o b no válidos...", "Mensaje de error");
                return false;
            }
        }

        public void InitializeData(
            TextBox txtInputA, TextBox txtInputB,
            TrackBar trbVel)
        {
            ResetValues();

            txtInputA.Text = "";
            txtInputB.Text = "";

            trbVel.Value = 3;

            txtInputA.Focus();
        }
    }
}
