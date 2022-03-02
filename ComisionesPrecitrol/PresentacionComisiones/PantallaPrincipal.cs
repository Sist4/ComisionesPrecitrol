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
namespace PrecentacionComisiones
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        ////private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam, int lparam );
        private void BtnSlider_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 56;
            }
            else
            {
                MenuVertical.Width = 250;    
            }
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRestaurar.Visible = true;
            IconoMaximizar.Visible = false;
        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoRestaurar.Visible = false;
            IconoMaximizar.Visible = true ;
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle,0x112,0xf012,0);

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
        private void Btn_Empleado_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Empleados());
            Pln_Reportes.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Usuarios ());
            Pln_Reportes.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Comision());
            Pln_Reportes.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Cobranza());
            Pln_Reportes.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Facturacion());
            Pln_Reportes.Visible = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AbrirFormPanel(new Frm_Reportes());
            if (Pln_Reportes.Visible == true)
            {
                Pln_Reportes.Visible = false;
            }
            else
            {
                Pln_Reportes.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_Participacion());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReportesFormularios());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReporteComision());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Pruebas_comisiones());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReporteComisionGlabales());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ReporteDetalle());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_ComisionesFacturas());
        }
    }
}
