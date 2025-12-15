using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algorito_Recorte
{
    internal class CB_splines
    {
        // Calcula un punto en la curva B-spline cúbica para un valor t (0 a 1) en un segmento
        public static PointF CalculateBSplinePoint(float t, List<PointF> controlPoints, int segment, float[] knotVector)
        {
            float x = 0, y = 0;
            int n = controlPoints.Count - 1;
            int degree = 3; // B-spline cúbica

            for (int i = 0; i <= n; i++)
            {
                float basis = BSplineBasis(i, degree, t, knotVector);
                x += basis * controlPoints[i].X;
                y += basis * controlPoints[i].Y;
            }

            return new PointF(x, y);
        }

        // Calcula la función base B-spline (recursiva)
        private static float BSplineBasis(int i, int k, float t, float[] knotVector)
        {
            if (k == 0)
            {
                return (t >= knotVector[i] && t < knotVector[i + 1]) ? 1.0f : 0.0f;
            }

            float left = 0, right = 0;
            if (knotVector[i + k] != knotVector[i])
            {
                left = ((t - knotVector[i]) / (knotVector[i + k] - knotVector[i])) * BSplineBasis(i, k - 1, t, knotVector);
            }
            if (knotVector[i + k + 1] != knotVector[i + 1])
            {
                right = ((knotVector[i + k + 1] - t) / (knotVector[i + k + 1] - knotVector[i + 1])) * BSplineBasis(i + 1, k - 1, t, knotVector);
            }

            return left + right;
        }

        // Genera un vector de nodos uniforme para B-spline
        public static float[] GenerateKnotVector(int numControlPoints, int degree = 3)
        {
            int n = numControlPoints - 1;
            int knotCount = n + degree + 2;
            float[] knots = new float[knotCount];

            for (int i = 0; i < knotCount; i++)
            {
                if (i < degree + 1)
                    knots[i] = 0.0f;
                else if (i <= n)
                    knots[i] = (float)(i - degree) / (n - degree + 1);
                else
                    knots[i] = 1.0f;
            }
            return knots;
        }

        // Genera puntos de control iniciales distribuidos uniformemente entre p0 y p1
        public static List<PointF> GenerateControlPoints(PointF p0, PointF p1, int numControlPoints)
        {
            List<PointF> points = new List<PointF> { p0 }; // Incluye P0

            for (int i = 1; i <= numControlPoints; i++)
            {
                float t = (float)i / (numControlPoints + 1);
                points.Add(new PointF(
                    p0.X + t * (p1.X - p0.X),
                    p0.Y + t * (p1.Y - p0.Y)
                ));
            }

            points.Add(p1); // Incluye P1
            return points;
        }

        // Obtiene una lista de puntos para dibujar la curva B-spline
        public static List<PointF> GetCurvePoints(List<PointF> controlPoints, int segmentsPerSection = 100)
        {
            List<PointF> curvePoints = new List<PointF>();
            int degree = 3;
            int n = controlPoints.Count - 1;
            if (n < degree) return curvePoints; // No hay suficientes puntos

            float[] knotVector = GenerateKnotVector(controlPoints.Count, degree);

            // Iterar sobre los segmentos válidos de la curva
            for (int i = degree; i < controlPoints.Count; i++)
            {
                for (float t = knotVector[i]; t < knotVector[i + 1]; t += (knotVector[i + 1] - knotVector[i]) / segmentsPerSection)
                {
                    curvePoints.Add(CalculateBSplinePoint(t, controlPoints, i, knotVector));
                }
            }

            // Asegurar que el último punto se incluya
            if (controlPoints.Count > degree)
            {
                curvePoints.Add(CalculateBSplinePoint(knotVector[controlPoints.Count], controlPoints, controlPoints.Count - 1, knotVector));
            }

            return curvePoints;
        }
    }
}