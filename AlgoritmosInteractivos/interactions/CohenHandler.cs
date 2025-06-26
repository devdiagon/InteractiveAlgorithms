using AlgoritmosInteractivos.algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace AlgoritmosInteractivos.interactions
{
    internal class CohenHandler
    {
        private CohenSutherland cohenSutherland;
        private Point pMin;
        private Point pMax;

        private List<Point[]> lines = new List<Point[]>();

        private PictureBox picCanvas;
        private Bitmap bmp;
        private Graphics g;

        public CohenHandler(PictureBox picCanvas)
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

        public void SetLinePoints(Point pInitial, Point pEndPoint)
        {
            lines.Add(new Point[] { pInitial, pEndPoint });
            DrawLine(pInitial, pEndPoint);
        }

        public void CutLines()
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
            TextBox txtInputXf, TextBox txtInputYf)
        {
            ResetValues();
            txtInputXi.Text = ""; txtInputYi.Text = "";
            txtInputXf.Text = ""; txtInputYf.Text = "";
        }
    }
}
