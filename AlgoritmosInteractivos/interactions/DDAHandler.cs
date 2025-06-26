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
    internal class DDAHandler
    {
        private DDA AlDDA;
        private Point pIni;
        private Point pEnd;
        public List<Point> totalPoints = new List<Point> ();

        private PictureBox picCanvas;
        private Bitmap bmp;
        private Graphics g;

        public DDAHandler(PictureBox picCanvas) 
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
            pIni = new Point();
            pEnd = new Point();
            totalPoints = new List<Point>();
            g.Clear(Color.White);
            picCanvas.Invalidate();
        }

        public void RegisterPoint(TextBox txtInputX, TextBox txtInputY, Point p, int index)
        {
            txtInputX.Text = p.X.ToString();
            txtInputY.Text = p.Y.ToString();

            if (index == 0)
            {
                pIni = new Point(p.X, p.Y);
                PlotPoint(p);
            }
            else
            {
                pEnd = new Point(p.X, p.Y);
                PlotPoint(p);
            }
        }

        private void PlotPoint(Point p)
        {
            int r = 2;
            Rectangle circ = new Rectangle(p.X - r, p.Y - r, r * 2, r * 2);
            g.FillEllipse(Brushes.Red, circ);
            g.DrawEllipse(Pens.Black, circ);
            picCanvas.Image = bmp;
        }

        public async Task DrawLine(int delay)
        {
            for (int i = 0; i < totalPoints.Count; i++)
            {
                int x = totalPoints[i].X;
                int y = totalPoints[i].Y;
                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                {
                    bmp.SetPixel(totalPoints[i].X, totalPoints[i].Y, Color.Red);
                    picCanvas.Image = (Bitmap)bmp.Clone();
                    await Task.Delay(delay);
                }
            }

            picCanvas.Image = bmp;
        }

        public void ComputeLine()
        {
            AlDDA = new DDA(pIni, pEnd);
            totalPoints = AlDDA.GeneratePoints();
        }

        public void SetDGVPoints(DataGridView table)
        {
            table.Rows.Clear();
            foreach (Point p in totalPoints)
            {
                table.Rows.Add(p.X, p.Y);
            }
        }

        public void InitializeData(
            TextBox txtInputXi, TextBox txtInputYi,
            TextBox txtInputXf, TextBox txtInputYf,
            TrackBar trbVel, DataGridView table)
        {
            ResetValues();

            txtInputXi.Text = ""; txtInputYi.Text = "";
            txtInputXf.Text = ""; txtInputYf.Text = "";
            trbVel.Value = 50;

            table.Rows.Clear();
        }
    }
}
