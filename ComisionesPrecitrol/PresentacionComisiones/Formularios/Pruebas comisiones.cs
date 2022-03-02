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
    public partial class Pruebas_comisiones : Form
    {
        NegociosComision_V2 comision = new NegociosComision_V2();
        Negocios_Comision COMI = new Negocios_Comision();
        public Pruebas_comisiones()
        {
            InitializeComponent();
        }
        private void cargarComsion()
        {
            string cambiar_estado=COMI.Modificamos_EstadoMovilizacion();
            DataSet cargara_datos = new DataSet();
            cargara_datos = comision.Cargar_ComisionesEmpleados();
            foreach (DataRow row in cargara_datos.Tables[0].Rows)
            {
                string N_Factura = row[1].ToString();
                string detalle_Factura = row[19].ToString();
                string descripcionPorcentaje = row[7].ToString();
                string Tipo = row[9].ToString();
                if (Tipo != "MATERIALES")
                {
                    if (descripcionPorcentaje != "C.ASIGNAR")
                    {
                        string[] arr = descripcionPorcentaje.Split(new[] { "C." }, StringSplitOptions.None);
                        int CONTAR = arr.Length;
                        for (int i = 0; i < CONTAR; i++)
                        {
                            if (arr[i] != (""))
                            {
                                string[] arr1 = arr[i].Split(new[] { " " }, StringSplitOptions.None);
                                String res = COMI.Insertar_Comisiones(detalle_Factura, N_Factura, arr1[0], Tipo, arr1[1].Replace("%", ""), "", arr1[0]);
                            }
                       }

                    }
                }
                else
                {
                    String res = COMI.Insertar_Comisiones(detalle_Factura, N_Factura, "PC", Tipo, "100", "", "PC");
                
                }
        }
//            MessageBox.Show("Termine");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarComsion();
        }
    }
}
