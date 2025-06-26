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
        private Point origin;
        private int r;
        private Color targetColor;

        public PictureBox picCanvas { get; set; }
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
            origin = new Point();
            g.Clear(Color.White);
            picCanvas.Invalidate();
        }

        public void RegisterOrigin(Point p)
        {
            origin = new Point(p.X, p.Y);
            targetColor = bmp.GetPixel(p.X, p.Y);
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
