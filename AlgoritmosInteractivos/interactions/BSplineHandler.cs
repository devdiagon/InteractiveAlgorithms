using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosInteractivos.interactions
{
    internal class BSplineHandler
    {
        private List<PointF> puntos;
        private int grado;
        private List<float> nudos;

        public BSplineHandler(List<PointF> puntosControl)
        {
            if (puntosControl == null)
                throw new ArgumentNullException(nameof(puntosControl));

            puntos = new List<PointF>(puntosControl);
            grado = Math.Min(3, puntos.Count - 1);
            CalcularVectorNudos();
        }

        private void CalcularVectorNudos()
        {
            int n = puntos.Count - 1;
            int m = n + grado + 1;
            nudos = new List<float>(m + 1);

            // Primeros k+1 nudos en 0 (clamped start)
            for (int i = 0; i <= grado; i++)
                nudos.Add(0f);

            // Nudos internos uniformemente distribuidos
            int numInternos = m - 2 * (grado + 1) + 1;
            for (int i = 1; i <= numInternos; i++)
                nudos.Add((float)i / (numInternos + 1));

            // Últimos k+1 nudos en 1 (clamped end)
            for (int i = 0; i <= grado; i++)
                nudos.Add(1f);
        }

        // Función para calcular el valor del basis function N_i,k en t (De Boor Cox)
        private float BasisFunction(int i, int k, float t)
        {
            if (k == 1)
            {
                if (nudos[i] <= t && t < nudos[i + 1])
                    return 1f;
                // Asegura el último punto
                if (t == 1f && nudos[i + 1] == 1f && nudos[i] < 1f)
                    return 1f;
                return 0f;
            }

            float left = 0f, right = 0f;
            float denLeft = nudos[i + k - 1] - nudos[i];
            float denRight = nudos[i + k] - nudos[i + 1];

            if (denLeft > 0)
                left = (t - nudos[i]) / denLeft * BasisFunction(i, k - 1, t);
            if (denRight > 0)
                right = (nudos[i + k] - t) / denRight * BasisFunction(i + 1, k - 1, t);

            return left + right;
        }

        // Genera puntos muestreados en la curva B-Spline
        public List<PointF> GenerarCurva(int numPoints = 100)
        {
            List<PointF> curva = new List<PointF>();

            float tInicio = nudos[grado];
            float tFin = nudos[nudos.Count - grado - 1];

            for (int i = 0; i < numPoints; i++)
            {
                float t = tInicio + (tFin - tInicio) * i / (numPoints - 1);

                PointF punto = new PointF(0, 0);
                for (int j = 0; j < puntos.Count; j++)
                {
                    float b = BasisFunction(j, grado + 1, t);
                    punto.X += b * puntos[j].X;
                    punto.Y += b * puntos[j].Y;
                }

                curva.Add(punto);
            }

            return curva;
        }
    }
}
