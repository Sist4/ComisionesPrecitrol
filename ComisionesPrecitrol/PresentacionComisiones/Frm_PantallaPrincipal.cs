using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PrecentacionComisiones.Formularios;
using Sistemas_Precitrol.Formularios;
using PrecentacionComisiones.Pruebas;
using PrecentacionComisiones.Formularios.Reportes_Formularios;

namespace PrecentacionComisiones
{
    public partial class Frm_PantallaPrincipal : Form
    {
        public Frm_PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Comision());

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Empleados());
          //  Pln_Reportes.Visible = false;
        }

        private void Frm_PantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void cobranzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Cobranza());

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Facturacion());

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ComisionesFacturas());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeCobranzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReporteCobranza());
            
        }

        private void reporteDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReporteComisionesEmpleados());
        }

        private void reporteDeComisionesGlobalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReporteComisionesGlobales());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_CobranzaM ());

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_DetalleM());

        }
    }
}
