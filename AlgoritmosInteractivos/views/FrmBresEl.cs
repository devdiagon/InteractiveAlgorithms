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
    public partial class FrmBresEl : Form
    {
        private BresElHandler HandBresEl;
        private static FrmBresEl instance;

        public static FrmBresEl GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBresEl();
            }
            return instance;
        }
        private FrmBresEl()
        {
            InitializeComponent();
            HandBresEl = new BresElHandler(picCanvas);
            HandBresEl.InitializeData(txtInA, txtInB, trbVel);
        }

        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);

            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HandBresEl.InitializeData(txtInA, txtInB, trbVel);
            lblVelValue.Text = "3 ms";
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!HandBresEl.ReadData(txtInA, txtInB))
                return;

            HandBresEl.RegisterCenter(e.Location);
            HandBresEl.ComputeCircle();
            await HandBresEl.DrawCircle(trbVel.Value);
        }
    }
}
