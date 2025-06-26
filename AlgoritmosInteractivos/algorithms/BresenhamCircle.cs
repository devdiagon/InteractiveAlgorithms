using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.algorithms
{
    internal class BresenhamCircle
    {
        private int r;
        private int xc;
        private int yc;

        public BresenhamCircle(int r, Point center)
        {
            this.r = r;
            this.xc = center.X;
            this.yc = center.Y;
        }

        public List<Point> GeneratePoints()
        {
            List<Point> points = new List<Point>();

            int x = 0;
            int y = r;
            int p = 1 - r;

            while (x <= y)
            {
                points.Add(new Point(xc + x, yc + y));
                points.Add(new Point(xc - x, yc + y));
                points.Add(new Point(xc + x, yc - y));
                points.Add(new Point(xc - x, yc - y));
                points.Add(new Point(xc + y, yc + x));
                points.Add(new Point(xc - y, yc + x));
                points.Add(new Point(xc + y, yc - x));
                points.Add(new Point(xc - y, yc - x));

                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
            }

            return points;
        }
    }
}
