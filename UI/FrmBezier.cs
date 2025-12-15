// FrmBezier.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Algorito_Recorte
{
    public partial class FrmBezier : Form
    {
        private List<PointF> initialPoints = new List<PointF>();
        private List<PointF> controlPoints = new List<PointF>();
        private bool isDragging = false;
        private int draggedPointIndex = -1;
        private const int pointRadius = 5;
        private bool lineDrawn = false;

        private bool animacionActiva = false;
        private bool rastroActivo = false;
        private bool curvaActiva = true;

        private Timer timerAnimacion;
        private float tAnimacion = 0f;
        private bool tSube = true;
        private List<PointF> rastro = new List<PointF>();

        public FrmBezier()
        {
            InitializeComponent();
            pictureBox1.MouseClick += PictureBox1_MouseClick;
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lineDrawn && initialPoints.Count < 2)
            {
                initialPoints.Add(new PointF(e.X, e.Y));
                pictureBox1.Invalidate();
                if (initialPoints.Count == 2)
                {
                    lineDrawn = true;
                }
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!lineDrawn) return;

            for (int i = 0; i < controlPoints.Count; i++)
            {
                if (Math.Abs(controlPoints[i].X - e.X) < pointRadius && Math.Abs(controlPoints[i].Y - e.Y) < pointRadius)
                {
                    isDragging = true;
                    draggedPointIndex = i;
                    break;
                }
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggedPointIndex >= 0)
            {
                controlPoints[draggedPointIndex] = new PointF(e.X, e.Y);
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggedPointIndex = -1;
        }

        private float ProjectPointOntoLine(PointF p0, PointF p3, PointF p)
        {
            float dx = p3.X - p0.X;
            float dy = p3.Y - p0.Y;
            if (dx == 0 && dy == 0) return 0;
            return ((p.X - p0.X) * dx + (p.Y - p0.Y) * dy) / (dx * dx + dy * dy);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (initialPoints.Count == 2)
            {
                g.DrawLine(Pens.Black, initialPoints[0], initialPoints[1]);
            }

            foreach (PointF p in initialPoints)
            {
                g.FillEllipse(Brushes.Red, p.X - pointRadius, p.Y - pointRadius, pointRadius * 2, pointRadius * 2);
            }

            if (controlPoints.Count > 0)
            {
                for (int i = 0; i < controlPoints.Count - 1; i++)
                {
                    g.DrawLine(Pens.Gray, controlPoints[i], controlPoints[i + 1]);
                }

                for (int i = 1; i < controlPoints.Count - 1; i++)
                {
                    g.FillEllipse(Brushes.Blue, controlPoints[i].X - pointRadius, controlPoints[i].Y - pointRadius, pointRadius * 2, pointRadius * 2);
                }

                if (curvaActiva)
                {
                    List<PointF> curvePoints = CBezier.GetCurvePoints(controlPoints);
                    if (curvePoints.Count > 1)
                    {
                        g.DrawLines(Pens.Green, curvePoints.ToArray());
                    }
                }

                if (animacionActiva)
                {
                    List<PointF> tempPoints = new List<PointF>(controlPoints);
                    List<PointF> nextPoints = new List<PointF>();

                    while (tempPoints.Count > 1)
                    {
                        nextPoints.Clear();
                        for (int i = 0; i < tempPoints.Count - 1; i++)
                        {
                            PointF p1 = tempPoints[i];
                            PointF p2 = tempPoints[i + 1];
                            PointF inter = new PointF(
                                p1.X + (p2.X - p1.X) * tAnimacion,
                                p1.Y + (p2.Y - p1.Y) * tAnimacion);

                            nextPoints.Add(inter);
                            g.FillEllipse(Brushes.Magenta, inter.X - 2, inter.Y - 2, 4, 4);
                            g.DrawLine(Pens.LightBlue, p1, p2);
                        }
                        tempPoints = new List<PointF>(nextPoints);
                    }

                    if (tempPoints.Count == 1)
                    {
                        PointF puntoFinal = tempPoints[0];
                        g.FillEllipse(Brushes.DarkOrange, puntoFinal.X - 3, puntoFinal.Y - 3, 6, 6);
                        if (rastroActivo)
                        {
                            rastro.Add(puntoFinal);
                        }
                    }

                    foreach (var punto in rastro)
                    {
                        g.FillEllipse(Brushes.Gray, punto.X - 2, punto.Y - 2, 4, 4);
                    }
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!lineDrawn)
            {
                MessageBox.Show("Primero dibuje una línea haciendo clic en dos puntos.", "Advertencia");
                return;
            }

            if (int.TryParse(textBox1.Text, out int numControlPoints) && numControlPoints >= 1 && numControlPoints <= 3)
            {
                controlPoints = CBezier.GenerateControlPoints(initialPoints[0], initialPoints[1], numControlPoints);
                pictureBox1.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de puntos de control (1 a 3).", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            initialPoints.Clear();
            controlPoints.Clear();
            rastro.Clear();
            animacionActiva = false;
            curvaActiva = true;
            rastroActivo = false;
            lineDrawn = false;
            textBox1.Text = "";
            pictureBox1.Invalidate();
            timerAnimacion?.Stop();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMAnimacion_Click(object sender, EventArgs e)
        {
            if (animacionActiva)
            {
                animacionActiva = false;
                timerAnimacion?.Stop();
            }
            else
            {
                animacionActiva = true;
                timerAnimacion = new Timer();
                timerAnimacion.Interval = 16; // 60 FPS
                timerAnimacion.Tick += (s, ev) =>
                {
                    if (tSube)
                    {
                        tAnimacion += 0.01f;
                        if (tAnimacion >= 1f)
                        {
                            tSube = false;
                        }
                    }
                    else
                    {
                        tAnimacion -= 0.01f;
                        if (tAnimacion <= 0f)
                        {
                            tSube = true;
                        }
                    }
                    pictureBox1.Invalidate();
                };
                timerAnimacion.Start();
            }
        }

        private void btnMRastro_Click(object sender, EventArgs e)
        {
            rastroActivo = !rastroActivo;
            if (!rastroActivo) rastro.Clear();
            pictureBox1.Invalidate();
        }

        private void btnMCurva_Click(object sender, EventArgs e)
        {
            curvaActiva = !curvaActiva;
            pictureBox1.Invalidate();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
