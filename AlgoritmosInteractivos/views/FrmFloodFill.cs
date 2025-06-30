using AlgoritmosInteractivos.interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos.views
{
    public partial class FrmFloodFill : Form
    {
        private FloodFillHandler HandFloodFill;
        private static FrmFloodFill instance;
        private bool isFillMode = false;
        private List<CancellationTokenSource> activeFills = new List<CancellationTokenSource>();

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
            foreach (var cts in activeFills)
                cts.Cancel();
            activeFills.Clear();

            HandFloodFill.InitializeData(txtInRadius, trbVel);
            lblVelValue.Text = "3 ms";
            isFillMode = false;
            btnDraw.Focus();
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isFillMode)
            {
                if (!HandFloodFill.ReadData(txtInRadius))
                    return;

                HandFloodFill.RegisterCenter(e.Location);
                HandFloodFill.DrawCircle();
                return;
            }

            var cts = new CancellationTokenSource();
            activeFills.Add(cts);

            try
            {
                HandFloodFill.RegisterOrigin(e.Location);
                await HandFloodFill.FillFigure(Color.Green, trbVel.Value, cts.Token);
            }
            catch (OperationCanceledException) { }
            finally
            {
                activeFills.Remove(cts);
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            isFillMode = false;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            isFillMode = true;
        }
    }
}
