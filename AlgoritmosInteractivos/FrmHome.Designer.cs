namespace AlgoritmosInteractivos
{
    partial class FrmHome
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
            this.dgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsdgfdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamCírculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamElipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjghjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohenSutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sutherlandHodgmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasParametricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasDeBezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgdfgToolStripMenuItem,
            this.fsdgfdgToolStripMenuItem,
            this.hjghjToolStripMenuItem,
            this.recorteToolStripMenuItem,
            this.curvasParametricasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(205, 603);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgdfgToolStripMenuItem
            // 
            this.dgdfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem});
            this.dgdfgToolStripMenuItem.Name = "dgdfgToolStripMenuItem";
            this.dgdfgToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.dgdfgToolStripMenuItem.Text = "Líneas";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.bresenhamToolStripMenuItem.Text = "Bresenham ";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // fsdgfdgToolStripMenuItem
            // 
            this.fsdgfdgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bresenhamCírculoToolStripMenuItem,
            this.bresenhamElipseToolStripMenuItem});
            this.fsdgfdgToolStripMenuItem.Name = "fsdgfdgToolStripMenuItem";
            this.fsdgfdgToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.fsdgfdgToolStripMenuItem.Text = "Curvas";
            // 
            // bresenhamCírculoToolStripMenuItem
            // 
            this.bresenhamCírculoToolStripMenuItem.Name = "bresenhamCírculoToolStripMenuItem";
            this.bresenhamCírculoToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.bresenhamCírculoToolStripMenuItem.Text = "Bresenham Circulo";
            this.bresenhamCírculoToolStripMenuItem.Click += new System.EventHandler(this.bresenhamCírculoToolStripMenuItem_Click);
            // 
            // bresenhamElipseToolStripMenuItem
            // 
            this.bresenhamElipseToolStripMenuItem.Name = "bresenhamElipseToolStripMenuItem";
            this.bresenhamElipseToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.bresenhamElipseToolStripMenuItem.Text = "Bresenham Elipse";
            // 
            // hjghjToolStripMenuItem
            // 
            this.hjghjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floodFillToolStripMenuItem});
            this.hjghjToolStripMenuItem.Name = "hjghjToolStripMenuItem";
            this.hjghjToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.hjghjToolStripMenuItem.Text = "Relleno";
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.floodFillToolStripMenuItem.Text = "Flood Fill";
            this.floodFillToolStripMenuItem.Click += new System.EventHandler(this.floodFillToolStripMenuItem_Click);
            // 
            // recorteToolStripMenuItem
            // 
            this.recorteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cohenSutherlandToolStripMenuItem,
            this.sutherlandHodgmanToolStripMenuItem});
            this.recorteToolStripMenuItem.Name = "recorteToolStripMenuItem";
            this.recorteToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.recorteToolStripMenuItem.Text = "Recorte";
            // 
            // cohenSutherlandToolStripMenuItem
            // 
            this.cohenSutherlandToolStripMenuItem.Name = "cohenSutherlandToolStripMenuItem";
            this.cohenSutherlandToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.cohenSutherlandToolStripMenuItem.Text = "Cohen Sutherland";
            this.cohenSutherlandToolStripMenuItem.Click += new System.EventHandler(this.cohenSutherlandToolStripMenuItem_Click);
            // 
            // sutherlandHodgmanToolStripMenuItem
            // 
            this.sutherlandHodgmanToolStripMenuItem.Name = "sutherlandHodgmanToolStripMenuItem";
            this.sutherlandHodgmanToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.sutherlandHodgmanToolStripMenuItem.Text = "Sutherland Hodgman";
            // 
            // curvasParametricasToolStripMenuItem
            // 
            this.curvasParametricasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvasDeBezierToolStripMenuItem,
            this.bSplinesToolStripMenuItem});
            this.curvasParametricasToolStripMenuItem.Name = "curvasParametricasToolStripMenuItem";
            this.curvasParametricasToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.curvasParametricasToolStripMenuItem.Text = "Curvas Parametricas";
            // 
            // curvasDeBezierToolStripMenuItem
            // 
            this.curvasDeBezierToolStripMenuItem.Name = "curvasDeBezierToolStripMenuItem";
            this.curvasDeBezierToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.curvasDeBezierToolStripMenuItem.Text = "Curvas de Bezier";
            // 
            // bSplinesToolStripMenuItem
            // 
            this.bSplinesToolStripMenuItem.Name = "bSplinesToolStripMenuItem";
            this.bSplinesToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.bSplinesToolStripMenuItem.Text = "B Splines";
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(205, 0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(1102, 603);
            this.pnlWrapper.TabIndex = 1;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 603);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fsdgfdgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjghjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasParametricasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamCírculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamElipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenSutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sutherlandHodgmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasDeBezierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSplinesToolStripMenuItem;
    }
}