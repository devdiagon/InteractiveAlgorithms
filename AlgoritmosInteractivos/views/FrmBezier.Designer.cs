namespace AlgoritmosInteractivos.views
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
            this.components = new System.ComponentModel.Container();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbSourceTitle = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReeset = new System.Windows.Forms.Button();
            this.lstGrado = new System.Windows.Forms.ListBox();
            this.trbVel = new System.Windows.Forms.TrackBar();
            this.lblPointsTitle = new System.Windows.Forms.Label();
            this.grbControls = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.btnToggleGuias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbSourceTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVel)).BeginInit();
            this.grbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picCanvas.Location = new System.Drawing.Point(371, 26);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(690, 518);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(59, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Curvas de Bézier";
            // 
            // grbSourceTitle
            // 
            this.grbSourceTitle.Controls.Add(this.btnGenerate);
            this.grbSourceTitle.Controls.Add(this.btnReeset);
            this.grbSourceTitle.Controls.Add(this.lstGrado);
            this.grbSourceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSourceTitle.Location = new System.Drawing.Point(12, 57);
            this.grbSourceTitle.Name = "grbSourceTitle";
            this.grbSourceTitle.Size = new System.Drawing.Size(339, 132);
            this.grbSourceTitle.TabIndex = 2;
            this.grbSourceTitle.TabStop = false;
            this.grbSourceTitle.Text = "Opciones";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(29, 26);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(104, 36);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReeset
            // 
            this.btnReeset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReeset.Location = new System.Drawing.Point(29, 74);
            this.btnReeset.Name = "btnReeset";
            this.btnReeset.Size = new System.Drawing.Size(104, 36);
            this.btnReeset.TabIndex = 1;
            this.btnReeset.Text = "Limpiar";
            this.btnReeset.UseVisualStyleBackColor = true;
            this.btnReeset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstGrado
            // 
            this.lstGrado.FormattingEnabled = true;
            this.lstGrado.ItemHeight = 20;
            this.lstGrado.Items.AddRange(new object[] {
            "Grado 1",
            "Grado 2",
            "Grado 3"});
            this.lstGrado.Location = new System.Drawing.Point(190, 26);
            this.lstGrado.Name = "lstGrado";
            this.lstGrado.Size = new System.Drawing.Size(120, 84);
            this.lstGrado.TabIndex = 4;
            // 
            // trbVel
            // 
            this.trbVel.Location = new System.Drawing.Point(10, 36);
            this.trbVel.Maximum = 175;
            this.trbVel.Name = "trbVel";
            this.trbVel.Size = new System.Drawing.Size(300, 56);
            this.trbVel.TabIndex = 2;
            this.trbVel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trbVel_MouseDown);
            // 
            // lblPointsTitle
            // 
            this.lblPointsTitle.AutoSize = true;
            this.lblPointsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTitle.Location = new System.Drawing.Point(12, 338);
            this.lblPointsTitle.Name = "lblPointsTitle";
            this.lblPointsTitle.Size = new System.Drawing.Size(0, 25);
            this.lblPointsTitle.TabIndex = 6;
            // 
            // grbControls
            // 
            this.grbControls.Controls.Add(this.btnPause);
            this.grbControls.Controls.Add(this.btnPlay);
            this.grbControls.Controls.Add(this.trbVel);
            this.grbControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbControls.Location = new System.Drawing.Point(12, 195);
            this.grbControls.Name = "grbControls";
            this.grbControls.Size = new System.Drawing.Size(339, 140);
            this.grbControls.TabIndex = 5;
            this.grbControls.TabStop = false;
            this.grbControls.Text = "Controles";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(180, 88);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(104, 36);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(40, 88);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(104, 36);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // btnToggleGuias
            // 
            this.btnToggleGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleGuias.Location = new System.Drawing.Point(52, 357);
            this.btnToggleGuias.Name = "btnToggleGuias";
            this.btnToggleGuias.Size = new System.Drawing.Size(251, 36);
            this.btnToggleGuias.TabIndex = 7;
            this.btnToggleGuias.Text = "Quitar líneas guía";
            this.btnToggleGuias.UseVisualStyleBackColor = true;
            this.btnToggleGuias.Click += new System.EventHandler(this.btnToggleGuias_Click);
            // 
            // FrmBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.btnToggleGuias);
            this.Controls.Add(this.grbControls);
            this.Controls.Add(this.lblPointsTitle);
            this.Controls.Add(this.grbSourceTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmBezier";
            this.Text = "FrmBezier";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbSourceTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbVel)).EndInit();
            this.grbControls.ResumeLayout(false);
            this.grbControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSourceTitle;
        private System.Windows.Forms.TrackBar trbVel;
        private System.Windows.Forms.Label lblPointsTitle;
        private System.Windows.Forms.ListBox lstGrado;
        private System.Windows.Forms.GroupBox grbControls;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReeset;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnToggleGuias;
    }
}