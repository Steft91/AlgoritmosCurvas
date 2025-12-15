namespace Algorito_Recorte
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.curvasParamétricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasDeBézierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsplinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foolFildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeCohenSutherlandParaRecorteDeLíneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeSutherlandHodgmanParaRecorteDePolígonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeBresenhamParaLíneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeBresenhampuntoMedioParaCircunferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeTipoBresenhamParaElipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvasParamétricasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // curvasParamétricasToolStripMenuItem
            // 
            this.curvasParamétricasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvasDeBézierToolStripMenuItem,
            this.bsplinesToolStripMenuItem});
            this.curvasParamétricasToolStripMenuItem.Name = "curvasParamétricasToolStripMenuItem";
            this.curvasParamétricasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.curvasParamétricasToolStripMenuItem.Text = "Curvas";
            this.curvasParamétricasToolStripMenuItem.Click += new System.EventHandler(this.curvasParamétricasToolStripMenuItem_Click);
            // 
            // curvasDeBézierToolStripMenuItem
            // 
            this.curvasDeBézierToolStripMenuItem.Name = "curvasDeBézierToolStripMenuItem";
            this.curvasDeBézierToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.curvasDeBézierToolStripMenuItem.Text = "Curvas de Bézier";
            this.curvasDeBézierToolStripMenuItem.Click += new System.EventHandler(this.curvasDeBézierToolStripMenuItem_Click);
            // 
            // bsplinesToolStripMenuItem
            // 
            this.bsplinesToolStripMenuItem.Name = "bsplinesToolStripMenuItem";
            this.bsplinesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.bsplinesToolStripMenuItem.Text = "B-splines";
            this.bsplinesToolStripMenuItem.Click += new System.EventHandler(this.bsplinesToolStripMenuItem_Click);
            // 
            // foolFildToolStripMenuItem
            // 
            this.foolFildToolStripMenuItem.Name = "foolFildToolStripMenuItem";
            this.foolFildToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // scanlineToolStripMenuItem
            // 
            this.scanlineToolStripMenuItem.Name = "scanlineToolStripMenuItem";
            this.scanlineToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // algoritmoDeCohenSutherlandParaRecorteDeLíneasToolStripMenuItem
            // 
            this.algoritmoDeCohenSutherlandParaRecorteDeLíneasToolStripMenuItem.Name = "algoritmoDeCohenSutherlandParaRecorteDeLíneasToolStripMenuItem";
            this.algoritmoDeCohenSutherlandParaRecorteDeLíneasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // algoritmoDeSutherlandHodgmanParaRecorteDePolígonosToolStripMenuItem
            // 
            this.algoritmoDeSutherlandHodgmanParaRecorteDePolígonosToolStripMenuItem.Name = "algoritmoDeSutherlandHodgmanParaRecorteDePolígonosToolStripMenuItem";
            this.algoritmoDeSutherlandHodgmanParaRecorteDePolígonosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // algoritmoDeBresenhamParaLíneasToolStripMenuItem
            // 
            this.algoritmoDeBresenhamParaLíneasToolStripMenuItem.Name = "algoritmoDeBresenhamParaLíneasToolStripMenuItem";
            this.algoritmoDeBresenhamParaLíneasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // algoritmoDeBresenhampuntoMedioParaCircunferenciasToolStripMenuItem
            // 
            this.algoritmoDeBresenhampuntoMedioParaCircunferenciasToolStripMenuItem.Name = "algoritmoDeBresenhampuntoMedioParaCircunferenciasToolStripMenuItem";
            this.algoritmoDeBresenhampuntoMedioParaCircunferenciasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // algoritmoDeTipoBresenhamParaElipsesToolStripMenuItem
            // 
            this.algoritmoDeTipoBresenhamParaElipsesToolStripMenuItem.Name = "algoritmoDeTipoBresenhamParaElipsesToolStripMenuItem";
            this.algoritmoDeTipoBresenhamParaElipsesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem curvasParamétricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeCohenSutherlandParaRecorteDeLíneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeSutherlandHodgmanParaRecorteDePolígonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasDeBézierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bsplinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foolFildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeBresenhamParaLíneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeBresenhampuntoMedioParaCircunferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeTipoBresenhamParaElipsesToolStripMenuItem;
    }
}