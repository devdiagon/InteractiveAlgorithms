using AlgoritmosInteractivos.algorithms;
using AlgoritmosInteractivos.interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos.views
{
    public partial class FrmBezier : Form
    {
        private bool goingForward = true;
        private bool isGenerated = false;

        private static FrmBezier instance;

        private BezierHandler HandBezier = new BezierHandler();
        private int? puntoSeleccionado = null;

        private bool isDragging = false;
        private int? draggingPointIndex = null;

        private bool mostrarLineasGuia = true;

        public static FrmBezier GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBezier();
            }
            return instance;
        }
        private FrmBezier()
        {
            InitializeComponent();

            animationTimer.Interval = 30;
            trbVel.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstGrado.ClearSelected();
            animationTimer.Stop();
            trbVel.Value = 0;
            isGenerated = false;
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isGenerated) return;

            var index = HandBezier.GetPuntoSeleccionado(e.Location);
            if (index != null)
            {
                isDragging = true;
                draggingPointIndex = index;
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggingPointIndex = null;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggingPointIndex != null)
            {
                HandBezier.MoverPunto(draggingPointIndex.Value, e.Location);
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isGenerated) return;

            var seleccionado = HandBezier.GetPuntoSeleccionado(e.Location);
            if (seleccionado != null)
            {
                puntoSeleccionado = seleccionado;
            }
            else if (puntoSeleccionado != null)
            {
                HandBezier.MoverPunto(puntoSeleccionado.Value, e.Location);
                puntoSeleccionado = null;
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isGenerated) return;

            // Dibuja curva
            using (var pen = new Pen(Color.Blue, 2))
            {
                for (int i = 1; i < HandBezier.Curva.Count; i++)
                    e.Graphics.DrawLine(pen, HandBezier.Curva[i - 1], HandBezier.Curva[i]);
            }

            // Dibuja puntos de control
            foreach (var p in HandBezier.PuntosControl)
            {
                e.Graphics.FillEllipse(Brushes.Red, p.X - 5, p.Y - 5, 10, 10);
                e.Graphics.DrawEllipse(Pens.Black, p.X - 5, p.Y - 5, 10, 10);
            }

            if (isGenerated && HandBezier.Grado >= 2 && mostrarLineasGuia)
            {
                // Dibujar casco convexo
                using (var pen = new Pen(Color.Red, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                {
                    for (int i = 0; i < HandBezier.PuntosControl.Count - 1; i++)
                    {
                        e.Graphics.DrawLine(pen, HandBezier.PuntosControl[i], HandBezier.PuntosControl[i + 1]);
                    }
                }

                //Dibujar líenas de Casteljau
                float t = (float)trbVel.Value / trbVel.Maximum;
                var niveles = HandBezier.GetLineasIntermedias(t);

                Color[] colores = { Color.Orange, Color.Purple, Color.DarkCyan }; // un color por nivel

                for (int nivel = 0; nivel < niveles.Count; nivel++)
                {
                    using (var pen = new Pen(colores[nivel], 1))
                    {
                        var puntos = niveles[nivel];
                        for (int i = 0; i < puntos.Count - 1; i++)
                        {
                            e.Graphics.DrawLine(pen, puntos[i], puntos[i + 1]);
                        }
                    }
                }
            }

            // Dibuja punto animado en curva
            if (isGenerated)
            {
                float t = (float)trbVel.Value / trbVel.Maximum;
                var punto = Bezier.GetPoint(HandBezier.PuntosControl, t);
                e.Graphics.FillEllipse(Brushes.Green, punto.X - 4, punto.Y - 4, 8, 8);
                e.Graphics.DrawEllipse(Pens.Black, punto.X - 4, punto.Y -4, 8, 8);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lstGrado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un grado.");
                return;
            }

            int grado = lstGrado.SelectedIndex + 1;

            HandBezier.Generar(grado, picCanvas.Size);
            isGenerated = true;
            picCanvas.Invalidate();
            trbVel.Value = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!isGenerated)
            {
                MessageBox.Show("Debe generar primero una curva.");
                return;
            }
            animationTimer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (!isGenerated) return;

            if (goingForward)
            {
                if (trbVel.Value < trbVel.Maximum)
                    trbVel.Value++;
                else
                    goingForward = false;
            }
            else
            {
                if (trbVel.Value > trbVel.Minimum)
                    trbVel.Value--;
                else
                    goingForward = true;
            }

            picCanvas.Invalidate();
        }

        private void trbVel_MouseDown(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void btnToggleGuias_Click(object sender, EventArgs e)
        {
            mostrarLineasGuia = !mostrarLineasGuia;
            btnToggleGuias.Text = mostrarLineasGuia ? "Quitar líneas guía" : "Agregar líneas guía";
            picCanvas.Invalidate();
        }
    }
}
