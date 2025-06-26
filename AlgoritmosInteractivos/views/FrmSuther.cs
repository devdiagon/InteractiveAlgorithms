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
    public partial class FrmSuther : Form
    {
        private SutherHandler HandSuther;
        private static FrmSuther instance;

        private int clicks = 0;
        private int maxPoints = 0;
        private bool cutPoligon = false;

        public static FrmSuther GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSuther();
            }
            return instance;
        }
        private FrmSuther()
        {
            InitializeComponent();

            HandSuther = new SutherHandler(picCanvas);
            HandSuther.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf, txtPolPoints);
            lblSetPoints.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandSuther.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf, txtPolPoints);
            clicks = 0;
            maxPoints = 0;
            cutPoligon = false;
            lblSetPoints.Text = "0";
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (cutPoligon)
            {
                MessageBox.Show("Limpie la pantalla para volver a iniciar");
                return;
            }

            if (clicks > 1 &&  maxPoints < 3)
            {
                MessageBox.Show("El número mínimo de puntos del polígono debe ser 3");
                return;
            }

            int plotedPoints = clicks - 2;

            if (clicks > 1 && plotedPoints < maxPoints)
            {
                HandSuther.AddPoint(e.Location.X, e.Location.Y, plotedPoints);

                clicks++;
                lblSetPoints.Text = (plotedPoints + 1).ToString();

                if (clicks - 2 == maxPoints)
                {
                    HandSuther.ClosePoligon(maxPoints - 1);
                }
                return;
            }


            if (clicks == 0)
            {
                HandSuther.RegisterMinMaxPoint(txtInXi, txtInYi, e.Location, clicks);
            }

            if (clicks == 1)
            {
                HandSuther.RegisterMinMaxPoint(txtInXf, txtInYf, e.Location, clicks);
                HandSuther.ReorganizeMinMaxDisplay(txtInXi, txtInYi, txtInXf, txtInYf);
            }

            clicks++;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (clicks < 1)
            {
                MessageBox.Show("Dibuje un cuadrilátero primero");
                return;
            }

            if ((clicks - 2) != maxPoints)
            {
                MessageBox.Show("Termine de ubicar todos lo puntos");
                return;
            }

            HandSuther.CutPoligon();
            cutPoligon = true;
        }

        private void txtPolPoints_TextChanged(object sender, EventArgs e)
        {
            string newText = ((TextBox)sender).Text;
            if (string.IsNullOrWhiteSpace(newText))
            {
                return;
            }

            maxPoints = int.Parse(newText);
        }

        private void txtPolPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (clicks > 3)
            {
                MessageBox.Show("Termine de dibujar el polígono");
                return;
            }

            // Permitir teclas de control (backspace, delete, etc.)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Solo permitir dígitos
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Rechazar el carácter
            }
        }
    }
}
