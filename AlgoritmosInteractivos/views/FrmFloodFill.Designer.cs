namespace AlgoritmosInteractivos.views
{
    partial class FrmFloodFill
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbSourceTitle = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtInRadius = new System.Windows.Forms.TextBox();
            this.grbProcessTitle = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.trbVel = new System.Windows.Forms.TrackBar();
            this.grbVel = new System.Windows.Forms.GroupBox();
            this.lblVelValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbSourceTitle.SuspendLayout();
            this.grbProcessTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVel)).BeginInit();
            this.grbVel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picCanvas.Location = new System.Drawing.Point(319, 26);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(742, 518);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(85, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Flood Fill";
            // 
            // grbSourceTitle
            // 
            this.grbSourceTitle.Controls.Add(this.lblRadius);
            this.grbSourceTitle.Controls.Add(this.txtInRadius);
            this.grbSourceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSourceTitle.Location = new System.Drawing.Point(33, 74);
            this.grbSourceTitle.Name = "grbSourceTitle";
            this.grbSourceTitle.Size = new System.Drawing.Size(241, 79);
            this.grbSourceTitle.TabIndex = 2;
            this.grbSourceTitle.TabStop = false;
            this.grbSourceTitle.Text = "Entrada";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 37);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(63, 20);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radio:";
            // 
            // txtInRadius
            // 
            this.txtInRadius.Location = new System.Drawing.Point(81, 34);
            this.txtInRadius.Name = "txtInRadius";
            this.txtInRadius.Size = new System.Drawing.Size(137, 27);
            this.txtInRadius.TabIndex = 0;
            // 
            // grbProcessTitle
            // 
            this.grbProcessTitle.Controls.Add(this.btnFill);
            this.grbProcessTitle.Controls.Add(this.btnDraw);
            this.grbProcessTitle.Controls.Add(this.btnReset);
            this.grbProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcessTitle.Location = new System.Drawing.Point(33, 305);
            this.grbProcessTitle.Name = "grbProcessTitle";
            this.grbProcessTitle.Size = new System.Drawing.Size(237, 77);
            this.grbProcessTitle.TabIndex = 4;
            this.grbProcessTitle.TabStop = false;
            this.grbProcessTitle.Text = "Proceso";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(115, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // trbVel
            // 
            this.trbVel.Location = new System.Drawing.Point(17, 36);
            this.trbVel.Maximum = 5;
            this.trbVel.Name = "trbVel";
            this.trbVel.Size = new System.Drawing.Size(202, 56);
            this.trbVel.TabIndex = 2;
            this.trbVel.Value = 3;
            this.trbVel.Scroll += new System.EventHandler(this.velocityScroll);
            // 
            // grbVel
            // 
            this.grbVel.Controls.Add(this.lblVelValue);
            this.grbVel.Controls.Add(this.trbVel);
            this.grbVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVel.Location = new System.Drawing.Point(33, 168);
            this.grbVel.Name = "grbVel";
            this.grbVel.Size = new System.Drawing.Size(237, 118);
            this.grbVel.TabIndex = 5;
            this.grbVel.TabStop = false;
            this.grbVel.Text = "Retraso";
            // 
            // lblVelValue
            // 
            this.lblVelValue.AutoSize = true;
            this.lblVelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelValue.Location = new System.Drawing.Point(84, 84);
            this.lblVelValue.Name = "lblVelValue";
            this.lblVelValue.Size = new System.Drawing.Size(46, 20);
            this.lblVelValue.TabIndex = 3;
            this.lblVelValue.Text = "3 ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un modo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "presione en el canvas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "para pintar o graficar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instrucciones";
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(6, 26);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(40, 36);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "1";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(58, 26);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(40, 36);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "2";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // FrmFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbVel);
            this.Controls.Add(this.grbProcessTitle);
            this.Controls.Add(this.grbSourceTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmFloodFill";
            this.Text = "FrmFloodFill";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbSourceTitle.ResumeLayout(false);
            this.grbSourceTitle.PerformLayout();
            this.grbProcessTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbVel)).EndInit();
            this.grbVel.ResumeLayout(false);
            this.grbVel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSourceTitle;
        private System.Windows.Forms.TextBox txtInRadius;
        private System.Windows.Forms.GroupBox grbProcessTitle;
        private System.Windows.Forms.TrackBar trbVel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbVel;
        private System.Windows.Forms.Label lblVelValue;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnFill;
    }
}