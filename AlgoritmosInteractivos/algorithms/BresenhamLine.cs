using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.algorithms
{
    internal class BresenhamLine
    {
        private Point pIni;
        private Point pEnd;
        private float m;
        private float k;

        public BresenhamLine(Point pI, Point pE)
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

            int x0 = pIni.X;
            int y0 = pIni.Y;
            int x1 = pEnd.X;
            int y1 = pEnd.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            if (dx == 0 && dy == 0)
            {
                points.Add(pIni);
                return points;
            }

            int err = dx - dy;

            while (true)
            {
                points.Add(new Point(x0, y0));

                if (x0 == x1 && y0 == y1) 
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            return points;
        }
    }
}
