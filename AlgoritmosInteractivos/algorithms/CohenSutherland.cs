using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.algorithms
{
    internal class CohenSutherland
    {
        private Point pMin;
        private Point pMax;

        public Point pIni;
        public Point pEnd;

        private const int LEFT = 1;
        private const int RIGHT = 2;
        private const int BOTTOM = 4;
        private const int TOP = 8;

        public CohenSutherland(Point pMin, Point pMax, Point pIni, Point pEnd)
        {
            this.pMin = pMin;
            this.pMax = pMax;
            this.pIni = pIni;
            this.pEnd = pEnd;
        }

        public Point[] CutLine()
        {
            int codePI = GetPosCode(pIni);
            int codePF = GetPosCode(pEnd);

            // Ambos puntos están dentro del rectángulo
            if ((codePI | codePF) == 0)
                return new Point[] { pIni, pEnd };

            // Ambos puntos están fuera del rectangulo
            if ((codePI & codePF) != 0)
                return null;

            // Línea parcialmente dentro del rectánuglo, recortar
            float m = (float)(pEnd.Y - pIni.Y) / (float)(pEnd.X - pIni.X);

            // Reemplazar el punto fuera por el punto de intersección
            if (codePI != 0)
                pIni = FindIntersection(pIni, codePI, m);

            if (codePF != 0)
                pEnd = FindIntersection(pEnd, codePF, m);

            return new Point[] { pIni, pEnd };
        }

        private Point FindIntersection(Point p, int code, float m)
        {
            // Encontrar el punto de intersección
            // Calcula la intersección
            // y = y1 + m * (x - x1)       Borde superior/inferior
            // x = x1 + (1/m) * (y - y1)   Borde izquierdo/derecho
            float x = 0, y = 0;

            if ((code & TOP) != 0)
            {
                x = pIni.X + (pMax.Y - pIni.Y) / m;
                y = pMax.Y;
            }

            if ((code & BOTTOM) != 0)
            {
                x = pIni.X + (pMin.Y - pIni.Y) / m;
                y = pMin.Y;
            }

            if ((code & RIGHT) != 0)
            {
                y = pIni.Y + m * (pMax.X - pIni.X);
                x = pMax.X;
            }

            if ((code & LEFT) != 0)
            {
                y = pIni.Y + m * (pMin.X - pIni.X);
                x = pMin.X;
            }

            return Point.Round(new PointF(x, y));
        }

        private int GetPosCode(Point p)
        {
            int code = 0;

            if (p.X < pMin.X)
                code |= LEFT;
            if (p.X > pMax.X)
                code |= RIGHT;

            if (p.Y > pMin.Y)
                code |= BOTTOM;
            if (p.Y < pMax.Y)
                code |= TOP;

            return code;
        }
    }
}
