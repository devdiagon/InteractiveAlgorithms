using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.algorithms
{
    internal class Bezier
    {
        public static PointF GetPoint(List<PointF> puntos, float t)
        {
            int grado = puntos.Count - 1;
            if (grado == 1)
                return Grado1(puntos, t);
            if (grado == 2)
                return Grado2(puntos, t);
            if (grado == 3)
                return Grado3(puntos, t);

            throw new ArgumentException("Grado no soportado.");
        }

        private static PointF Grado1(List<PointF> pts, float t)
        {
            return new PointF(
                (1 - t) * pts[0].X + t * pts[1].X,
                (1 - t) * pts[0].Y + t * pts[1].Y
            );
        }

        private static PointF Grado2(List<PointF> pts, float t)
        {
            float x = (float)(Math.Pow(1 - t, 2) * pts[0].X +
                              2 * (1 - t) * t * pts[1].X +
                              Math.Pow(t, 2) * pts[2].X);
            float y = (float)(Math.Pow(1 - t, 2) * pts[0].Y +
                              2 * (1 - t) * t * pts[1].Y +
                              Math.Pow(t, 2) * pts[2].Y);
            return new PointF(x, y);
        }

        private static PointF Grado3(List<PointF> pts, float t)
        {
            float x = (float)(Math.Pow(1 - t, 3) * pts[0].X +
                              3 * Math.Pow(1 - t, 2) * t * pts[1].X +
                              3 * (1 - t) * Math.Pow(t, 2) * pts[2].X +
                              Math.Pow(t, 3) * pts[3].X);
            float y = (float)(Math.Pow(1 - t, 3) * pts[0].Y +
                              3 * Math.Pow(1 - t, 2) * t * pts[1].Y +
                              3 * (1 - t) * Math.Pow(t, 2) * pts[2].Y +
                              Math.Pow(t, 3) * pts[3].Y);
            return new PointF(x, y);
        }
    }
}
