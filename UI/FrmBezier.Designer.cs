namespace Algorito_Recorte
{
    partial class FrmBezier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMCurva = new System.Windows.Forms.Button();
            this.btnMRastro = new System.Windows.Forms.Button();
            this.btnMAnimacion = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(13, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 315);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(434, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stork Delivery", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de puntos de control \r\n(máx 3):";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(270, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.btnMCurva);
            this.groupBox3.Controls.Add(this.btnMRastro);
            this.groupBox3.Controls.Add(this.btnMAnimacion);
            this.groupBox3.Controls.Add(this.btnCalcular);
            this.groupBox3.Controls.Add(this.btnResetear);
            this.groupBox3.Font = new System.Drawing.Font("Stork Delivery", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(434, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 239);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Botones";
            // 
            // btnMCurva
            // 
            this.btnMCurva.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMCurva.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMCurva.Location = new System.Drawing.Point(196, 104);
            this.btnMCurva.Name = "btnMCurva";
            this.btnMCurva.Size = new System.Drawing.Size(138, 50);
            this.btnMCurva.TabIndex = 14;
            this.btnMCurva.Text = "Solo curva";
            this.btnMCurva.UseVisualStyleBackColor = false;
            this.btnMCurva.Click += new System.EventHandler(this.btnMCurva_Click);
            // 
            // btnMRastro
            // 
            this.btnMRastro.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMRastro.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMRastro.Location = new System.Drawing.Point(28, 104);
            this.btnMRastro.Name = "btnMRastro";
            this.btnMRastro.Size = new System.Drawing.Size(154, 50);
            this.btnMRastro.TabIndex = 13;
            this.btnMRastro.Text = "Mostrar rastro";
            this.btnMRastro.UseVisualStyleBackColor = false;
            this.btnMRastro.Click += new System.EventHandler(this.btnMRastro_Click);
            // 
            // btnMAnimacion
            // 
            this.btnMAnimacion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMAnimacion.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMAnimacion.Location = new System.Drawing.Point(196, 48);
            this.btnMAnimacion.Name = "btnMAnimacion";
            this.btnMAnimacion.Size = new System.Drawing.Size(138, 50);
            this.btnMAnimacion.TabIndex = 12;
            this.btnMAnimacion.Text = "Animación";
            this.btnMAnimacion.UseVisualStyleBackColor = false;
            this.btnMAnimacion.Click += new System.EventHandler(this.btnMAnimacion_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCalcular.Location = new System.Drawing.Point(28, 48);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 50);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Lavender;
            this.btnResetear.Location = new System.Drawing.Point(94, 174);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(150, 50);
            this.btnResetear.TabIndex = 9;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Stork Delivery", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(217, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 40);
            this.label8.TabIndex = 54;
            this.label8.Text = "Algoritmos de Curvas de Beziér";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 95);
            this.label6.TabIndex = 55;
            this.label6.Text = "- Seleccione 2 puntos en el canva\r\n- Ingrese el número de puntos de control\r\n- Cl" +
    "ic en calcular para crear la línea con los \r\npuntos de control\r\n\r\n";
            // 
            // FrmBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBezier";
            this.Text = "FrmBezier";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnMCurva;
        private System.Windows.Forms.Button btnMRastro;
        private System.Windows.Forms.Button btnMAnimacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}