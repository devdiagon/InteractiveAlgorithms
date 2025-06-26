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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AlgoritmosInteractivos.views
{
    public partial class FrmBresCir : Form
    {
        private BresCirHandler HandBresCir;
        private static FrmBresCir instance;
        private int r;

        public static FrmBresCir GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBresCir();
            }
            return instance;
        }
        private FrmBresCir()
        {
            InitializeComponent();
            HandBresCir = new BresCirHandler(picCanvas);
            HandBresCir.InitializeData(txtInRadius, trbVel);
        }

        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);

            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandBresCir.InitializeData(txtInRadius, trbVel);
            lblVelValue.Text = "3 ms";
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!HandBresCir.ReadData(txtInRadius))
                return;

            HandBresCir.RegisterCenter(e.Location);
            HandBresCir.ComputeCircle();
            await HandBresCir.DrawCircle(trbVel.Value);
        }
    }
}
