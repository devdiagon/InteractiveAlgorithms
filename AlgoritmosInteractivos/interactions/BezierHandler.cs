using AlgoritmosInteractivos.algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.interactions
{
    internal class BezierHandler
    {
        public List<PointF> PuntosControl { get; private set; } = new List<PointF>();
        public List<PointF> Curva { get; private set; } = new List<PointF>();
        public int Grado { get; private set; } = -1;
        private const int radioSeleccion = 10;

        public void Generar(int grado, Size canvasSize)
        {
            Grado = grado;
            PuntosControl.Clear();
            Random rnd = new Random();
            for (int i = 0; i <= grado; i++)
            {
                PuntosControl.Add(new PointF(rnd.Next(50, canvasSize.Width - 50),
                                             rnd.Next(50, canvasSize.Height - 50)));
            }
            RecalcularCurva();
        }

        public void RecalcularCurva()
        {
            Curva.Clear();
            for (float t = 0; t <= 1.0f; t += 0.01f)
            {
                Curva.Add(Bezier.GetPoint(PuntosControl, t));
            }
        }

        public int? GetPuntoSeleccionado(PointF click)
        {
            for (int i = 0; i < PuntosControl.Count; i++)
            {
                if (Distance(PuntosControl[i], click) <= radioSeleccion)
                    return i;
            }
            return null;
        }

        public void MoverPunto(int index, PointF nuevo)
        {
            if (index >= 0 && index < PuntosControl.Count)
            {
                PuntosControl[index] = nuevo;
                RecalcularCurva();
            }
        }

        public List<List<PointF>> GetLineasIntermedias(float t)
        {
            var niveles = new List<List<PointF>>();
            var actual = new List<PointF>(PuntosControl);

            while (actual.Count > 1)
            {
                var siguienteNivel = new List<PointF>();
                for (int i = 0; i < actual.Count - 1; i++)
                {
                    float x = (1 - t) * actual[i].X + t * actual[i + 1].X;
                    float y = (1 - t) * actual[i].Y + t * actual[i + 1].Y;
                    siguienteNivel.Add(new PointF(x, y));
                }
                niveles.Add(siguienteNivel);
                actual = siguienteNivel;
            }

            return niveles;
        }

        private double Distance(PointF p1, PointF p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
