// FrmPrincipal.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algorito_Recorte
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Configura el formulario como contenedor MDI

            this.BackColor = Color.White;
            this.IsMdiContainer = true;
            //panel  debajo del MenuStrip
            Panel panelDecorativo = new Panel();
            panelDecorativo.Dock = DockStyle.Top;
            panelDecorativo.Height = 80;
            panelDecorativo.BackColor = Color.Lavender;

            this.Controls.Add(panelDecorativo);
            panelDecorativo.BringToFront();

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "Algoritmos para trazar curvas de Bezier y B-Spline";
            lblTitulo.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.ForeColor = Color.FromArgb(30, 64, 124);

            panelDecorativo.Controls.Add(lblTitulo);
        }

        private void AbrirUnicaVentana<T>() where T : Form, new()
        {
            // Cierra todos los formularios hijos abiertos
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Crea y muestra una nueva instancia del formulario
            var nuevaVentana = new T { MdiParent = this };

            // Ajusta el formulario hijo para que ocupe todo el contenedor MDI
            nuevaVentana.WindowState = FormWindowState.Maximized; // Maximiza el formulario hijo
            // Alternativa: Centrar el formulario hijo
            // nuevaVentana.StartPosition = FormStartPosition.CenterParent;
            // nuevaVentana.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);

            nuevaVentana.Show();
        }

        private void curvasDeBézierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBezier>();
        }

        private void bsplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBSplines>();
        }

        private void curvasParamétricasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}