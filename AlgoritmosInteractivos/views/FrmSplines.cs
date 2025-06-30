using AlgoritmosInteractivos.algorithms;
using AlgoritmosInteractivos.interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos.views
{
    public partial class FrmSplines : Form
    {
        private static FrmSplines instance;

        private List<PointF> puntosControl;
        private bool isDragging = false;
        private int draggingIndex = -1;
        private bool increasing = true;
        private BSplineHandler splineHandler;
        private List<PointF> curva;
        private float tActual = 0f;

        private List<(PointF punto, int indiceDominante)> curvaConInfluencia;

        public static FrmSplines GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSplines();
            }
            return instance;
        }
        private FrmSplines()
        {
            InitializeComponent();

            animationTimer.Interval = 30;
            trbVel.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            trbVel.Value = 0;
            increasing = true;
            puntosControl = new List<PointF>
            {
                new PointF(50, 250),
                new PointF(120, 100),
                new PointF(200, 150),
                new PointF(300, 100),
                new PointF(400, 200),
                new PointF(500, 120),
            };
            splineHandler = new BSplineHandler(puntosControl);
            curva = splineHandler.GenerarCurva();
            curvaConInfluencia = splineHandler.GenerarCurvaConInfluencia();
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < puntosControl.Count; i++)
            {
                if (Math.Sqrt(Math.Pow(e.X - puntosControl[i].X, 2) + Math.Pow(e.Y - puntosControl[i].Y, 2)) < 10)
                {
                    isDragging = true;
                    draggingIndex = i;
                    break;
                }
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggingIndex = -1;
            curva = splineHandler.GenerarCurva();
            curvaConInfluencia = splineHandler.GenerarCurvaConInfluencia();
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggingIndex != -1)
            {
                puntosControl[draggingIndex] = new PointF(e.X, e.Y);
                splineHandler = new BSplineHandler(puntosControl);
                curva = splineHandler.GenerarCurva();
                curvaConInfluencia = splineHandler.GenerarCurvaConInfluencia();
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDragging) return;

            if (e.Button == MouseButtons.Left)
            {
                puntosControl.Add(new PointF(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (puntosControl.Count > 3)
                {
                    puntosControl.RemoveAt(puntosControl.Count - 1);
                }
                else
                {
                    MessageBox.Show("Se requieren al menos 3 puntos para generar la curva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            splineHandler = new BSplineHandler(puntosControl);
            curva = splineHandler.GenerarCurva();
            curvaConInfluencia = splineHandler.GenerarCurvaConInfluencia();

            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (curvaConInfluencia != null && curvaConInfluencia.Count > 1)
            {
                using (Pen penNormal = new Pen(Color.Blue, 2))
                using (Pen penResaltado = new Pen(Color.Orange, 3))
                {
                    for (int i = 0; i < curvaConInfluencia.Count - 1; i++)
                    {
                        var a = curvaConInfluencia[i];
                        var b = curvaConInfluencia[i + 1];

                        // Si está siendo arrastrado este índice, resalta
                        if (isDragging && draggingIndex != -1 &&
                            (a.indiceDominante == draggingIndex || b.indiceDominante == draggingIndex))
                        {
                            g.DrawLine(penResaltado, a.punto, b.punto);
                        }
                        else
                        {
                            g.DrawLine(penNormal, a.punto, b.punto);
                        }
                    }
                }
            }

            if (puntosControl != null && puntosControl.Count > 1)
            {
                using (Pen marcoPen = new Pen(Color.Red, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                {
                    g.DrawLines(marcoPen, puntosControl.ToArray());
                }
            }

            foreach (var pt in puntosControl)
            {
                g.FillEllipse(Brushes.Red, pt.X - 5, pt.Y - 5, 10, 10);
                g.DrawEllipse(Pens.Black, pt.X - 5, pt.Y - 5, 10, 10);
            }

            if (curva != null && curva.Count > 1)
            {
                int idx = (int)(tActual * (curva.Count - 1));
                PointF p = curva[idx];
                g.FillEllipse(Brushes.Green, p.X - 5, p.Y - 5, 10, 10);
                g.DrawEllipse(Pens.Black, p.X - 5, p.Y - 5, 10, 10);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (increasing)
            {
                trbVel.Value++;
                if (trbVel.Value == trbVel.Maximum)
                    increasing = false;
            }
            else
            {
                trbVel.Value--;
                if (trbVel.Value == trbVel.Minimum)
                    increasing = true;
            }

            tActual = trbVel.Value / (float)trbVel.Maximum;
            picCanvas.Invalidate();
        }

        private void trbVel_MouseDown(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void FrmSplines_Load(object sender, EventArgs e)
        {
            trbVel.Enabled = false;
            trbVel.Value = 0;
            puntosControl = new List<PointF>
            {
                new PointF(50, 250),
                new PointF(120, 100),
                new PointF(200, 150),
                new PointF(300, 100),
                new PointF(400, 200),
                new PointF(500, 120),
            };
            splineHandler = new BSplineHandler(puntosControl);
            curva = splineHandler.GenerarCurva();
            curvaConInfluencia = splineHandler.GenerarCurvaConInfluencia();
            picCanvas.Invalidate();
        }
    }
}
