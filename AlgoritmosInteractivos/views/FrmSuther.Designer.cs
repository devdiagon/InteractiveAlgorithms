namespace AlgoritmosInteractivos.views
{
    partial class FrmSuther
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
            this.lblYi = new System.Windows.Forms.Label();
            this.lblXi = new System.Windows.Forms.Label();
            this.txtInYi = new System.Windows.Forms.TextBox();
            this.txtInXi = new System.Windows.Forms.TextBox();
            this.grbEndTitle = new System.Windows.Forms.GroupBox();
            this.lblYf = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.txtInYf = new System.Windows.Forms.TextBox();
            this.txtInXf = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbVel = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSetPoints = new System.Windows.Forms.Label();
            this.txtPolPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbSourceTitle.SuspendLayout();
            this.grbEndTitle.SuspendLayout();
            this.grbVel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Recorte Polígonos";
            // 
            // grbSourceTitle
            // 
            this.grbSourceTitle.Controls.Add(this.lblYi);
            this.grbSourceTitle.Controls.Add(this.lblXi);
            this.grbSourceTitle.Controls.Add(this.txtInYi);
            this.grbSourceTitle.Controls.Add(this.txtInXi);
            this.grbSourceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSourceTitle.Location = new System.Drawing.Point(12, 57);
            this.grbSourceTitle.Name = "grbSourceTitle";
            this.grbSourceTitle.Size = new System.Drawing.Size(162, 138);
            this.grbSourceTitle.TabIndex = 2;
            this.grbSourceTitle.TabStop = false;
            this.grbSourceTitle.Text = "Punto Mínimo";
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(12, 83);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(26, 20);
            this.lblYi.TabIndex = 3;
            this.lblYi.Text = "Y:";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(12, 44);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(27, 20);
            this.lblXi.TabIndex = 2;
            this.lblXi.Text = "X:";
            // 
            // txtInYi
            // 
            this.txtInYi.Location = new System.Drawing.Point(56, 83);
            this.txtInYi.Name = "txtInYi";
            this.txtInYi.ReadOnly = true;
            this.txtInYi.Size = new System.Drawing.Size(84, 27);
            this.txtInYi.TabIndex = 1;
            // 
            // txtInXi
            // 
            this.txtInXi.Location = new System.Drawing.Point(56, 41);
            this.txtInXi.Name = "txtInXi";
            this.txtInXi.ReadOnly = true;
            this.txtInXi.Size = new System.Drawing.Size(84, 27);
            this.txtInXi.TabIndex = 0;
            // 
            // grbEndTitle
            // 
            this.grbEndTitle.Controls.Add(this.lblYf);
            this.grbEndTitle.Controls.Add(this.lblXf);
            this.grbEndTitle.Controls.Add(this.txtInYf);
            this.grbEndTitle.Controls.Add(this.txtInXf);
            this.grbEndTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEndTitle.Location = new System.Drawing.Point(189, 57);
            this.grbEndTitle.Name = "grbEndTitle";
            this.grbEndTitle.Size = new System.Drawing.Size(158, 138);
            this.grbEndTitle.TabIndex = 3;
            this.grbEndTitle.TabStop = false;
            this.grbEndTitle.Text = "Punto Máximo";
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(13, 95);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(26, 20);
            this.lblYf.TabIndex = 4;
            this.lblYf.Text = "Y:";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(12, 47);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(27, 20);
            this.lblXf.TabIndex = 4;
            this.lblXf.Text = "X:";
            // 
            // txtInYf
            // 
            this.txtInYf.Location = new System.Drawing.Point(56, 92);
            this.txtInYf.Name = "txtInYf";
            this.txtInYf.ReadOnly = true;
            this.txtInYf.Size = new System.Drawing.Size(84, 27);
            this.txtInYf.TabIndex = 1;
            // 
            // txtInXf
            // 
            this.txtInXf.Location = new System.Drawing.Point(56, 40);
            this.txtInXf.Name = "txtInXf";
            this.txtInXf.ReadOnly = true;
            this.txtInXf.Size = new System.Drawing.Size(84, 27);
            this.txtInXf.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(213, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbVel
            // 
            this.grbVel.Controls.Add(this.btnCalculate);
            this.grbVel.Controls.Add(this.btnReset);
            this.grbVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVel.Location = new System.Drawing.Point(12, 297);
            this.grbVel.Name = "grbVel";
            this.grbVel.Size = new System.Drawing.Size(335, 76);
            this.grbVel.TabIndex = 5;
            this.grbVel.TabStop = false;
            this.grbVel.Text = "Proceso";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(36, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 36);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Recortar";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instrucciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSetPoints);
            this.groupBox2.Controls.Add(this.txtPolPoints);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total de Puntos";
            // 
            // lblSetPoints
            // 
            this.lblSetPoints.AutoSize = true;
            this.lblSetPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPoints.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSetPoints.Location = new System.Drawing.Point(258, 31);
            this.lblSetPoints.Name = "lblSetPoints";
            this.lblSetPoints.Size = new System.Drawing.Size(24, 25);
            this.lblSetPoints.TabIndex = 5;
            this.lblSetPoints.Text = "0";
            // 
            // txtPolPoints
            // 
            this.txtPolPoints.Location = new System.Drawing.Point(16, 29);
            this.txtPolPoints.Name = "txtPolPoints";
            this.txtPolPoints.Size = new System.Drawing.Size(146, 27);
            this.txtPolPoints.TabIndex = 4;
            this.txtPolPoints.TextChanged += new System.EventHandler(this.txtPolPoints_TextChanged);
            this.txtPolPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPolPoints_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presione 2 veces en el canvas para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "generar el cuadro central, luego";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "especifique la cantidad de puntos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "del polígono a generar. Presione en el";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "canvas nuevamente para generar el";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "polígono y recortarlo.";
            // 
            // FrmSuther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbVel);
            this.Controls.Add(this.grbEndTitle);
            this.Controls.Add(this.grbSourceTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmSuther";
            this.Text = "FrmSuther";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbSourceTitle.ResumeLayout(false);
            this.grbSourceTitle.PerformLayout();
            this.grbEndTitle.ResumeLayout(false);
            this.grbEndTitle.PerformLayout();
            this.grbVel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSourceTitle;
        private System.Windows.Forms.TextBox txtInYi;
        private System.Windows.Forms.TextBox txtInXi;
        private System.Windows.Forms.GroupBox grbEndTitle;
        private System.Windows.Forms.TextBox txtInYf;
        private System.Windows.Forms.TextBox txtInXf;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.GroupBox grbVel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSetPoints;
        private System.Windows.Forms.TextBox txtPolPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}