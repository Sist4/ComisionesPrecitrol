using NegociosComisiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrecentacionComisiones.Formularios;

namespace PrecentacionComisiones.Formularios
{
    public partial class Frm_LoginV2 : Form
    {
        Negocios_Usuarios Usurio = new Negocios_Usuarios();
        public Frm_LoginV2()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = Usurio.Consulta_Usuarios(Txt_Usu.Text, Txt_pass.Text);
                if (respuesta.Equals(true))
                {
                    MessageBox.Show("Bienvenidos Usuario: " + Txt_Usu.Text, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Frm_PantallaPrincipal frm = new Frm_PantallaPrincipal();
                    frm.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Clave Incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_LoginV2_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
