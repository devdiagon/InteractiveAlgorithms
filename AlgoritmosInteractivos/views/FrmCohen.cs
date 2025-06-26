using AlgoritmosInteractivos.interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace AlgoritmosInteractivos.views
{
    public partial class FrmCohen : Form
    {
        private CohenHandler HandCohen;
        private static FrmCohen instance;

        private Point pIni;
        private Point pEnd;
        private int clicks = 0;
        private int lineClicks = 0;

        public static FrmCohen GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCohen();
            }
            return instance;
        }
        private FrmCohen()
        {
            InitializeComponent();

            HandCohen = new CohenHandler(picCanvas);
            HandCohen.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandCohen.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf);
            clicks = 0;
            lineClicks = 0;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (clicks > 1 && lineClicks == -1)
            {
                MessageBox.Show("Limpie la pantalla para volver a iniciar");
                return;
            }

            if (clicks > 1 && lineClicks == 0)
            {
                pIni = e.Location;

                lineClicks++;
                return;
            }

            if (clicks > 1 && lineClicks == 1)
            {
                pEnd = e.Location;
                HandCohen.SetLinePoints(pIni, pEnd);

                lineClicks = 0;
                return;
            }

            
            if (clicks == 0)
            {
                HandCohen.RegisterMinMaxPoint(txtInXi, txtInYi, e.Location, clicks);
            }

            if (clicks == 1)
            {
                HandCohen.RegisterMinMaxPoint(txtInXf, txtInYf, e.Location, clicks);
                HandCohen.ReorganizeMinMaxDisplay(txtInXi, txtInYi, txtInXf, txtInYf);
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
            HandCohen.CutLines();
            lineClicks = -1;
        }
    }
}
