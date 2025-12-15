using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Algorito_Recorte
{
    public partial class FrmBSplines : Form
    {
        private List<PointF> initialPoints = new List<PointF>();
        private List<PointF> controlPoints = new List<PointF>();
        private bool isDragging = false;
        private int draggedPointIndex = -1;
        private const int pointRadius = 5;
        private bool lineDrawn = false;

        public FrmBSplines()
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
                    if (controlPoints[i].X != 0 && controlPoints[i].Y != 0 &&
                        controlPoints[i + 1].X != 0 && controlPoints[i + 1].Y != 0)
                    {
                        g.DrawLine(Pens.Gray, controlPoints[i], controlPoints[i + 1]);
                    }
                }

                foreach (PointF p in controlPoints)
                {
                    if (p.X != 0 && p.Y != 0)
                    {
                        g.FillEllipse(Brushes.Blue, p.X - pointRadius, p.Y - pointRadius, pointRadius * 2, pointRadius * 2);
                    }
                }

                if (controlPoints.Count > 3)
                {
                    List<PointF> curvePoints = CB_splines.GetCurvePoints(controlPoints);
                    if (curvePoints.Count > 1)
                    {
                        var validCurvePoints = curvePoints.FindAll(p => p.X != 0 && p.Y != 0);
                        if (validCurvePoints.Count > 1)
                        {
                            g.DrawLines(Pens.Green, validCurvePoints.ToArray());
                        }
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

            if (int.TryParse(textBox1.Text, out int numControlPoints) && numControlPoints >= 1 && numControlPoints <= 5)
            {
                controlPoints = CB_splines.GenerateControlPoints(initialPoints[0], initialPoints[1], numControlPoints);
                if (controlPoints.Count > 1)
                {
                    controlPoints[controlPoints.Count - 1] = initialPoints[1];
                }
                pictureBox1.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de puntos de control (1 a 5).", "Error");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            initialPoints.Clear();
            controlPoints.Clear();
            lineDrawn = false;
            textBox1.Text = "";
            pictureBox1.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}