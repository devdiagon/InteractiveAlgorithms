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
    internal class FloodFillHandler
    {
        private BresenhamCircle Bresenham;

        private Point origin;
        private Point center;
        private int r;
        public List<Point> points = new List<Point>();
        
        private Color targetColor;

        private PictureBox picCanvas;
        private Bitmap bmp;
        private Graphics g;

        public FloodFillHandler(PictureBox picCanvas)
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
            center = new Point(0,0);
            origin = new Point(0,0);
            points.Clear();
            g.Clear(Color.White);
            picCanvas.Invalidate();
        }

        public void RegisterOrigin(Point p)
        {
            origin = new Point(p.X, p.Y);
            targetColor = bmp.GetPixel(p.X, p.Y);
        }

        public void RegisterCenter(Point p)
        {
            center = new Point(p.X, p.Y);
        }

        public void DrawCircle()
        {
            points.Clear();
            Bresenham = new BresenhamCircle(r, center);
            points = Bresenham.GeneratePoints();

            foreach (Point p in points)
            {
                if (p.X >= 0 && p.X < bmp.Width && p.Y >= 0 && p.Y < bmp.Height)
                {
                    bmp.SetPixel(p.X, p.Y, Color.Black);
                    picCanvas.Image = (Bitmap)bmp.Clone();
                }
            }

            picCanvas.Image = bmp;
        }

        public async Task FillFigure(Color newColor, int delay)
        {
            if (origin.X < 0 || origin.Y < 0 || origin.X >= bmp.Width || origin.Y >= bmp.Height)
                return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(origin);

            while (stack.Count > 0)
            {
                Point p = stack.Pop();

                if (p.X < 0 || p.Y < 0 || p.X >= bmp.Width || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, newColor);

                picCanvas.Image = (Bitmap)bmp.Clone();
                await Task.Delay(delay);

                stack.Push(new Point(p.X + 1, p.Y));
                stack.Push(new Point(p.X - 1, p.Y));
                stack.Push(new Point(p.X, p.Y + 1));
                stack.Push(new Point(p.X, p.Y - 1));
            }
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
