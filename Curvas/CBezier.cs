using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algorito_Recorte
{
    internal class CBezier
    {
        // Calcula un punto en la curva de Bézier según el parámetro t (0 a 1)
        public static PointF CalculateBezierPoint(float t, List<PointF> controlPoints)
        {
            int n = controlPoints.Count - 1; // Grado de la curva
            float x = 0, y = 0;

            for (int i = 0; i <= n; i++)
            {
                // Fórmula de Bézier: B(t) = Σ (nCi * (1-t)^(n-i) * t^i * Pi)
                float coeff = BinomialCoefficient(n, i) * (float)Math.Pow(1 - t, n - i) * (float)Math.Pow(t, i);
                x += coeff * controlPoints[i].X;
                y += coeff * controlPoints[i].Y;
            }

            return new PointF(x, y);
        }

        // Calcula el coeficiente binomial (nCi)
        private static int BinomialCoefficient(int n, int i)
        {
            if (i == 0 || i == n) return 1;
            return Factorial(n) / (Factorial(i) * Factorial(n - i));
        }

        // Calcula el factorial
        private static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        // Genera puntos de control iniciales según el número especificado
        public static List<PointF> GenerateControlPoints(PointF p0, PointF p3, int numControlPoints)
        {
            List<PointF> points = new List<PointF> { p0 }; // Siempre incluye P0

            if (numControlPoints == 1)
            {
                // Un punto de control en el punto medio de la línea P0-P3
                points.Add(new PointF((p0.X + p3.X) / 2, (p0.Y + p3.Y) / 2));
            }
            else if (numControlPoints == 2)
            {
                // Dos puntos de control a 1/3 y 2/3 de la línea P0-P3
                points.Add(new PointF(p0.X + (p3.X - p0.X) / 3, p0.Y + (p3.Y - p0.Y) / 3));
                points.Add(new PointF(p0.X + 2 * (p3.X - p0.X) / 3, p0.Y + 2 * (p3.Y - p0.Y) / 3));
            }
            else if (numControlPoints == 3)
            {
                // Tres puntos de control distribuidos uniformemente
                points.Add(new PointF(p0.X + (p3.X - p0.X) / 4, p0.Y + (p3.Y - p0.Y) / 4));
                points.Add(new PointF(p0.X + 2 * (p3.X - p0.X) / 4, p0.Y + 2 * (p3.Y - p0.Y) / 4));
                points.Add(new PointF(p0.X + 3 * (p3.X - p0.X) / 4, p0.Y + 3 * (p3.Y - p0.Y) / 4));
            }

            points.Add(p3); // Siempre incluye P3
            return points;
        }

        // Obtiene una lista de puntos para dibujar la curva (aproximación con pasos pequeños)
        public static List<PointF> GetCurvePoints(List<PointF> controlPoints, int segments = 100)
        {
            List<PointF> curvePoints = new List<PointF>();
            for (float t = 0; t <= 1; t += 1f / segments)
            {
                curvePoints.Add(CalculateBezierPoint(t, controlPoints));
            }
            return curvePoints;
        }
    }
}