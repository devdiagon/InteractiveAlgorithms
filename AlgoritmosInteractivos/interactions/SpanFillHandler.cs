using AlgoritmosInteractivos.algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos.interactions
{
    internal class SpanFillHandler
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

        public SpanFillHandler(PictureBox picCanvas)
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
            center = new Point(0, 0);
            origin = new Point(0, 0);
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

        public async Task FillFigure(Color newColor, int delay, CancellationToken token)
        {
            int x = origin.X;
            int y = origin.Y;

            if (targetColor.ToArgb() == newColor.ToArgb()) return;
            if (!InBounds(x, y)) return;
            if (bmp.GetPixel(x, y).ToArgb() != targetColor.ToArgb()) return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                token.ThrowIfCancellationRequested();

                Point pt = stack.Pop();
                int px = pt.X;
                int py = pt.Y;

                int left = px;
                while (left >= 0 && bmp.GetPixel(left, py).ToArgb() == targetColor.ToArgb())
                {
                    left--;
                }
                left++;

                int right = px;
                while (right < bmp.Width && bmp.GetPixel(right, py).ToArgb() == targetColor.ToArgb())
                {
                    right++;
                }
                right--;

                for (int i = left; i <= right; i++)
                {
                    token.ThrowIfCancellationRequested();

                    bmp.SetPixel(i, py, newColor);
                    picCanvas.Invalidate(new Rectangle(i, py, 1, 1));
                    await Task.Delay(delay);
                }

                for (int i = left; i <= right; i++)
                {
                    if (py > 0 && bmp.GetPixel(i, py - 1).ToArgb() == targetColor.ToArgb())
                        stack.Push(new Point(i, py - 1));
                    if (py < bmp.Height - 1 && bmp.GetPixel(i, py + 1).ToArgb() == targetColor.ToArgb())
                        stack.Push(new Point(i, py + 1));
                }
            }
        }

        private bool InBounds(int x, int y)
        {
            return x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height;
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
