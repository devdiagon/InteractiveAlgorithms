using AlgoritmosInteractivos.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosInteractivos
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            FrmDDA frmDDA = FrmDDA.GetInstance();
            placeForm(frmDDA);
        }

        private void placeForm(Form formulario)
        {
            pnlWrapper.Controls.Clear();                       // Quita los formulario del panel
            formulario.TopLevel = false;                       // Evita que el fomrulario se abra como ventana independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Quita botones de minimizar, maximizar, cerrar y ajuste
            formulario.Dock = DockStyle.Fill;                  // El formulario se expande en el panel
            pnlWrapper.Controls.Add(formulario);               // Muestra el formulario en el panel
            formulario.Show();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDDA frmDDA = FrmDDA.GetInstance();
            placeForm(frmDDA);
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBres frmBres = FrmBres.GetInstance();
            placeForm(frmBres);
        }

        private void bresenhamCírculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresCir frmBresCir = FrmBresCir.GetInstance();
            placeForm(frmBresCir);
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFloodFill frmFloodFill = FrmFloodFill.GetInstance();
            placeForm(frmFloodFill);
        }

        private void cohenSutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCohen frmCohen = FrmCohen.GetInstance();
            placeForm(frmCohen);
        }

        private void sutherlandHodgmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuther frmSuther = FrmSuther.GetInstance();
            placeForm(frmSuther);
        }

        private void bresenhamElipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresEl frmBresEl = FrmBresEl.GetInstance();
            placeForm(frmBresEl);
        }

        private void spanFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSpan frmSpan = FrmSpan.GetInstance();
            placeForm(frmSpan);
        }
    }
}
