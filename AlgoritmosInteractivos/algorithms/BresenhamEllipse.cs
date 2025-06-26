using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.algorithms
{
    internal class BresenhamEllipse
    {
        private int rx;
        private int ry;
        private int xc;
        private int yc;

        public BresenhamEllipse(int rx, int ry, Point center)
        {
            this.rx = rx;
            this.ry = ry;
            this.xc = center.X;
            this.yc = center.Y;
        }

        public List<Point> GeneratePoints()
        {
            List<Point> points = new List<Point>();

            int x = 0;
            int y = ry;

            // Cuadrados para evitar multiplicar en cada iteración
            int rxSq = rx * rx;
            int rySq = ry * ry;

            // Región 1
            int p1 = (int)(rySq - (rxSq * ry) + (0.25 * rxSq));
            int dx = 2 * rySq * x;
            int dy = 2 * rxSq * y;

            while (dx < dy)
            {
                AddSymmetricPoints(points, x, y);
                x++;
                dx += 2 * rySq;

                if (p1 < 0)
                {
                    p1 += dx + rySq;
                }
                else
                {
                    y--;
                    dy -= 2 * rxSq;
                    p1 += dx - dy + rySq;
                }
            }

            // Región 2
            int p2 = (int)(rySq * (x + 0.5) * (x + 0.5) +
                           rxSq * (y - 1) * (y - 1) -
                           rxSq * rySq);

            while (y >= 0)
            {
                AddSymmetricPoints(points, x, y);
                y--;
                dy -= 2 * rxSq;

                if (p2 > 0)
                {
                    p2 += rxSq - dy;
                }
                else
                {
                    x++;
                    dx += 2 * rySq;
                    p2 += dx - dy + rxSq;
                }
            }

            return points;
        }

        private void AddSymmetricPoints(List<Point> points, int x, int y)
        {
            points.Add(new Point(xc + x, yc + y));
            points.Add(new Point(xc - x, yc + y));
            points.Add(new Point(xc + x, yc - y));
            points.Add(new Point(xc - x, yc - y));
        }
    }
}
