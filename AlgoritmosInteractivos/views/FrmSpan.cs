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
    public partial class FrmSpan : Form
    {
        private SpanFillHandler HandSpanFill;
        private static FrmSpan instance;
        private bool isFillMode = false;
        private List<CancellationTokenSource> activeFills = new List<CancellationTokenSource>();

        public static FrmSpan GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSpan();
            }
            return instance;
        }
        private FrmSpan()
        {
            InitializeComponent();
            HandSpanFill = new SpanFillHandler(picCanvas);
            HandSpanFill.InitializeData(txtInRadius, trbVel);
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

            HandSpanFill.InitializeData(txtInRadius, trbVel);
            lblVelValue.Text = "3 ms";
            isFillMode = false;
            btnDraw.Focus();
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isFillMode)
            {
                if (!HandSpanFill.ReadData(txtInRadius))
                    return;

                HandSpanFill.RegisterCenter(e.Location);
                HandSpanFill.DrawCircle();
                return;
            }

            var cts = new CancellationTokenSource();
            activeFills.Add(cts);

            try
            {
                HandSpanFill.RegisterOrigin(e.Location);
                await HandSpanFill.FillFigure(Color.Chocolate, trbVel.Value, cts.Token);
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
