using NegociosComisiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecentacionComisiones.Formularios.Reportes_Formularios
{
    public partial class Frm_DetalleM : Form
    {

        Negocios_DetalleM detalle = new Negocios_DetalleM();
        Negocios_Cabecera Cabecera = new Negocios_Cabecera();
        //NegociosComision_V2 comision = new NegociosComision_V2();
        //Negocios_Comision COMI = new Negocios_Comision();
        public Frm_DetalleM()
        {
            InitializeComponent();
        }



        private void LLenarGrid2(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridview2.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridview2.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                    // Bind the DataGridView controls to the BindingSource
                    // components and load the data from the database.
                    dataGridview2.CurrentCell = dataGridview2.Rows[dataGridview2.RowCount - 1].Cells[1];
                    dataGridview2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                //solo los archivos excel

                dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

                dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

                //si al seleccionar el archivo damos Ok
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //el nombre del archivo sera asignado al textbox
                    txtArchivo2.Text = dialog.FileName;
                    string hoja = txtHoja2.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                    LLenarGrid2(txtArchivo2.Text, hoja); //se manda a llamar al metodo

                    dataGridview2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                    //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridview2.Rows)
                {
                    //string Comentario = row.Cells[7].Value.ToString();
                    //string Cab_NFactura = row.Cells[20].Value.ToString();//Codigo se debe filtrar
                    //string det_OTrabajo = row.Cells[12].Value.ToString();
                    //string D_DETALLE = row.Cells[8].Value.ToString();
                    //string Categoria = row.Cells[9].Value.ToString();
                    //string Cantidad = row.Cells[15].Value.ToString();
                    //string Precio_Unitario = row.Cells[16].Value.ToString();
                    //string V_neto = row.Cells[17].Value.ToString();
                    //string V_Iva = row.Cells[18].Value.ToString();
                    //string V_total = row.Cells[19].Value.ToString();
                    string Tipo = row.Cells[0].Value.ToString();//obtenemos el tipo si es nota NC NO SE SUBE A LA BD
                    string DATOS_ADICIONALES = row.Cells[6].Value.ToString();//COMENTARIO LUGAR DE DONDE SE FACTURO SI ESTA VACIO SE MANDA EN BLANCO SI NO SE MAND LA UBICACION
                    string Comentario = row.Cells[7].Value.ToString();//ya esta
                    string Cab_NFactura = row.Cells[26].Value.ToString();//Codigo se debe filtrar
                    string det_OTrabajo = row.Cells[14].Value.ToString();
                    string D_DETALLE = row.Cells[10].Value.ToString();
                    string Categoria = row.Cells[11].Value.ToString();
                    string Cantidad = row.Cells[17].Value.ToString();
                    string Precio_Unitario = row.Cells[18].Value.ToString();
                    string V_neto = row.Cells[21].Value.ToString();
                    string V_Iva = row.Cells[24].Value.ToString();
                    string V_total = row.Cells[25].Value.ToString();
                    string C_costo = row.Cells[35].Value.ToString();//Aumentar en la tabla de talle




                    if (Cabecera.Consulta_FacturaM(Cab_NFactura) == true && Tipo != ("NC"))
                    {
                        //if (Convert.ToDouble(V_total) < 0)
                        //{
                        int resultado = detalle.Insertas_Detalle("0", Cab_NFactura, det_OTrabajo, D_DETALLE, Categoria, Comentario, Cantidad.Replace(",", ""), Precio_Unitario.Replace(",", ""), V_neto.Replace(",", ""), V_Iva.Replace(",", ""), V_total.Replace(",", ""), C_costo, DATOS_ADICIONALES);
                        //}
                    }



                }
                MessageBox.Show("Informacion Cargada, Asigando Comisiones A empleados");

               /// cargarComsion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


    }
}
