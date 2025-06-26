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
    public partial class FrmFloodFill : Form
    {
        private BresCirHandler HandBresCir;
        private FloodFillHandler HandFloodFill;
        private static FrmFloodFill instance;
        private bool isFillMode = false;
        private int r;

        public static FrmFloodFill GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmFloodFill();
            }
            return instance;
        }
        private FrmFloodFill()
        {
            InitializeComponent();
            HandBresCir = new BresCirHandler(picCanvas);
            HandFloodFill = new FloodFillHandler(picCanvas);
            HandFloodFill.InitializeData(txtInRadius, trbVel);
        }

        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);

            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandFloodFill.InitializeData(txtInRadius, trbVel);
            lblVelValue.Text = "3 ms";
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isFillMode)
            {
                if (!HandBresCir.ReadData(txtInRadius))
                    return;

                HandBresCir.RegisterCenter(e.Location);
                HandBresCir.ComputeCircle();
                await HandBresCir.DrawCircle(0);
                return;
            }

            HandFloodFill.RegisterOrigin(e.Location);
            await HandFloodFill.FillFigure(Color.Green, trbVel.Value);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            isFillMode = false;
            HandBresCir.picCanvas = HandFloodFill.picCanvas;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            isFillMode = true;
            HandFloodFill.picCanvas = HandBresCir.picCanvas;
        }
    }
}
