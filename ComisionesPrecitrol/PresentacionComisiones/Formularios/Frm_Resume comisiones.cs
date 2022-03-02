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

namespace PrecentacionComisiones.Formularios
{
    public partial class Frm_Resume_comisiones : Form
    {
        Negocios_Comision Comision = new Negocios_Comision();
        Negocio_Empleados Empleaodos = new Negocio_Empleados();
        private void Cargar_Comision(string[] Dato_Busqueda)
        {
            try
            {
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Comision.Cobranza(Dato_Busqueda);
                // Gv_Datos.AutoGenerateColumns = false;
                Gv_Comision.DataSource = Cargar_Datos.Tables[0];

                Gv_Comision.Columns[0].Width = 30;
                Gv_Comision.Columns[1].Width = 230;
                Gv_Comision.Columns[2].Width = 230;
                Gv_Comision.Columns[3].Width = 110;
                Gv_Comision.Columns[4].Width = 80;
                Gv_Comision.Columns[5].Width = 60;
                Gv_Comision.Columns[6].Width = 60;
                Gv_Comision.Columns[7].Width = 60;//Cambio Angel


                //Tamaño de cada columna
                Gv_Comision.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                Gv_Comision.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                Gv_Comision.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                Gv_Comision.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                Gv_Comision.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                Gv_Comision.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                Gv_Comision.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Gv_Comision.GridColor = Color.BlueViolet;
                this.Gv_Comision.BorderStyle = BorderStyle.Fixed3D;
                this.Gv_Comision.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                this.Gv_Comision.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                this.Gv_Comision.DefaultCellStyle.ForeColor = Color.Blue;

               // Variable donde almacenaremos el resultado de la sumatoria.
                double sumatoria_Base = 0;
                double sumatoria_Comision = 0;

                //Método con el que recorreremos todas las filas de nuestro Datagridview
                foreach (DataGridViewRow row in Gv_Comision.Rows)
                {
                    //Aquí seleccionaremos la columna que contiene los datos numericos.
                    //sumatoria_Base += Convert.ToDouble(row.Cells[5].Value);
                    //sumatoria_Comision += Convert.ToDouble(row.Cells[6].Value);
                    sumatoria_Base += Convert.ToDouble(row.Cells[7].Value);
                    sumatoria_Comision += Convert.ToDouble(row.Cells[8].Value);

                }

                label1.Text="Base Total: " + sumatoria_Base;
                label2.Text = "Total Comision: " + sumatoria_Comision;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Frm_Resume_comisiones()
        {
            InitializeComponent();
        }

        private void Frm_Resume_comisiones_Load(object sender, EventArgs e)
        {
            string[] dato = { "Comision_Todos" };
            Cargar_Comision(dato);
            button1.Enabled = false;
            textBox1.Enabled = false;

     
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string[] dato = { "Comision_Todos" };
            Cargar_Comision(dato);
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string[] dato = { "Comision_Sucursal","QUITO" };
            Cargar_Comision(dato);
            button1.Enabled = false;
            textBox1.Enabled = false;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string[] dato = { "Comision_Sucursal", "GUAYAQUIL" };
            Cargar_Comision(dato);
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string[] dato = { "Comision_Sucursal", "MANTA" };
            Cargar_Comision(dato);
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dato = { "Comision_Empleado", textBox1.Text };
            Cargar_Comision(dato);
        }
    }
}
