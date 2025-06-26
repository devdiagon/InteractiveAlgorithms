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
    internal class SutherHandler
    {
        private CohenSutherland cohenSutherland;
        private Point pMin;
        private Point pMax;

        private List<Point[]> lines = new List<Point[]>();
        private List<Point> points = new List<Point>();

        private PictureBox picCanvas;
        private Bitmap bmp;
        private Graphics g;

        public SutherHandler(PictureBox picCanvas)
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
            lines.Clear();
            points.Clear();
            g.Clear(Color.White);
            picCanvas.Invalidate();
        }

        public void RegisterMinMaxPoint(TextBox txtInputX, TextBox txtInputY, Point p, int index)
        {
            txtInputX.Text = p.X.ToString();
            txtInputY.Text = p.Y.ToString();

            if (index == 0)
            {
                pMin = new Point(p.X, p.Y);
                PlotPoint(p);
            }
            else
            {
                pMax = new Point(p.X, p.Y);
                CheckPoints();
                DrawRectangle();
            }
        }

        public void AddPoint(int x, int y, int clicks)
        {
            points.Add(new Point(x, y));
            if (clicks > 0)
            {
                DrawLine(points[clicks - 1], points[clicks]);
            }
        }

        public void ClosePoligon(int lastIndex)
        {
            DrawLine(points[lastIndex], points[0]);
            SetLinePoints();
        }

        private void SetLinePoints()
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                lines.Add(new Point[] { points[i], points[i + 1] });
            }

            if (points.Count > 2)
            {
                lines.Add(new Point[] { points[points.Count - 1], points[0] });
            }
        }

        public void CutPoligon()
        {
            for (int i = 0; i < lines.Count; i++)
            {
                cohenSutherland = new CohenSutherland(pMin, pMax, lines[i][0], lines[i][1]);
                lines[i] = cohenSutherland.CutLine();
            }

            DrawCutLines();
        }

        private void CheckPoints()
        {
            if (pMin.X > pMax.X && pMin.Y < pMax.Y)
            {
                Point tmp = pMin;
                pMin = pMax;
                pMax = tmp;
                return;
            }

            if (pMin.X < pMax.X && pMin.Y < pMax.Y)
            {
                Point fnMin = new Point(pMin.X, pMax.Y);
                Point fnMax = new Point(pMax.X, pMin.Y);

                pMin = fnMin;
                pMax = fnMax;
                return;
            }

            if (pMax.X < pMin.X && pMax.Y < pMin.Y)
            {
                Point fnMin = new Point(pMax.X, pMin.Y);
                Point fnMax = new Point(pMin.X, pMax.Y);

                pMin = fnMin;
                pMax = fnMax;
                return;
            }
        }

        private void DrawRectangle()
        {
            Pen pen = new Pen(Color.Black, 1);

            g.Clear(Color.White);
            g.DrawLine(pen, pMin, new Point(pMax.X, pMin.Y));
            g.DrawLine(pen, new Point(pMin.X, pMax.Y), pMax);
            g.DrawLine(pen, pMin, new Point(pMin.X, pMax.Y));
            g.DrawLine(pen, new Point(pMax.X, pMin.Y), pMax);

            PlotPoint(pMin);
            PlotPoint(pMax);

            picCanvas.Image = bmp;
        }

        private void PlotPoint(Point p)
        {
            int r = 2;
            Rectangle circ = new Rectangle(p.X - r, p.Y - r, r * 2, r * 2);
            g.FillEllipse(Brushes.Black, circ);
            g.DrawEllipse(Pens.Black, circ);
            picCanvas.Image = bmp;
        }

        private void DrawLine(Point ini, Point end)
        {
            Pen pen = new Pen(Color.Blue, 1);

            g.DrawLine(pen, ini, end);

            picCanvas.Image = bmp;
        }

        private void DrawCutLines()
        {
            picCanvas.Image = null;

            DrawRectangle();

            foreach (Point[] line in lines)
            {
                if (line == null)
                    continue;

                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Red, 1);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.DrawLine(pen, line[0], line[1]);

                picCanvas.Image = bmp;
            }
        }

        public void ReorganizeMinMaxDisplay(
            TextBox txtInputXi, TextBox txtInputYi,
            TextBox txtInputXf, TextBox txtInputYf)
        {
            txtInputXi.Text = pMin.X.ToString();
            txtInputYi.Text = pMin.Y.ToString();
            txtInputXf.Text = pMax.X.ToString();
            txtInputYf.Text = pMax.Y.ToString();
        }

        public void InitializeData(
            TextBox txtInputXi, TextBox txtInputYi,
            TextBox txtInputXf, TextBox txtInputYf,
            TextBox txtPolPoints)
        {
            ResetValues();
            txtInputXi.Text = ""; txtInputYi.Text = "";
            txtInputXf.Text = ""; txtInputYf.Text = "";
            txtPolPoints.Text = "";
        }
    }
}
