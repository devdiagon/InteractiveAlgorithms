using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.algorithms
{
    internal class DDA
    {
        private Point pIni;
        private Point pEnd;
        private float m;
        private float k;

        public DDA(Point pI, Point pE)
        {
            this.pIni = pI;
            this.pEnd = pE;
        }

        public void ResetValues()
        {
            pIni = new Point();
            pEnd = new Point();
            m = 0; k = 0;
        }
        public List<Point> GeneratePoints()
        {
            List<Point> points = new List<Point>();

            int dx = pEnd.X - pIni.X;
            int dy = pEnd.Y - pIni.Y;

            if (dx == 0)
            {
                int step = Math.Sign(dy);
                int y = pIni.Y;
                for (int i = 0; i <= Math.Abs(dy); i++)
                {
                    points.Add(new Point(pIni.X, y));
                    y += step;
                }
                return points;
            }

            m = (float)dy / dx;
            k = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xStep = dx / k;
            float yStep = dy / k;

            float xPrev = pIni.X;
            float yPrev = pIni.Y;

            for (int i = 0; i <= k; i++)
            {
                Point pk = new Point((int)Math.Round(xPrev), (int)Math.Round(yPrev));
                points.Add(pk);

                xPrev += xStep;
                yPrev += yStep;
            }

            return points;
        }
    }
}
