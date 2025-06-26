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
    public partial class FrmBres : Form
    {
        private BresHandler HandBres;
        private static FrmBres instance;
        private int clicks = 0;
        private bool drawedLine = false;

        public static FrmBres GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBres();
            }
            return instance;
        }
        private FrmBres()
        {
            InitializeComponent();
            dgvPoints.Columns.Add("X", "X");
            dgvPoints.Columns.Add("Y", "Y");

            HandBres = new BresHandler(picCanvas);
            HandBres.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf, trbVel, dgvPoints);
        }


        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);
            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandBres.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf, trbVel, dgvPoints);
            lblVelValue.Text = "50 ms";
            clicks = 0;
            drawedLine = false;
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawedLine)
            {
                MessageBox.Show("Limpie la pantalla para volver a iniciar");
                return;
            }

            if (clicks == 0)
            {
                HandBres.RegisterPoint(txtInXi, txtInYi, e.Location, clicks);
            }

            if (clicks == 1)
            {
                HandBres.RegisterPoint(txtInXf, txtInYf, e.Location, clicks);
                HandBres.ComputeLine();
                HandBres.SetDGVPoints(dgvPoints);
                await HandBres.DrawLine(trbVel.Value);
                drawedLine = true;
            }

            clicks++;
        }
    }
}
