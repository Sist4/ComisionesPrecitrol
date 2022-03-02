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
using NegociosComisiones;
namespace PrecentacionComisiones.Formularios
{
    public partial class Frm_Participacion : Form
    {
        Negocios_Porcentaje Participacion = new Negocios_Porcentaje();
        String Cab_NFactura ;
        String descripcionPorcentaje ;
        public Frm_Participacion()
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

        private void button4_Click(object sender, EventArgs e)
        {
           
            try
            {
                foreach (DataGridViewRow row in dataGridview2.Rows)
                {

                    string fecha = row.Cells[5].Value.ToString();//Fecha

                     Cab_NFactura = row.Cells[26].Value.ToString();//Codigo se debe filtrar
                     descripcionPorcentaje = row.Cells[14].Value.ToString();//Aqui se ubica el empelado
                    string D_DETALLE = row.Cells[10].Value.ToString();//detalle
                    string Categoria = row.Cells[11].Value.ToString();
                    string Cantidad = row.Cells[17].Value.ToString();
                    string Precio_Unitario = row.Cells[18].Value.ToString();
                    string V_neto = row.Cells[21].Value.ToString();
                    string V_Iva = row.Cells[24].Value.ToString();
                    string V_total = row.Cells[25].Value.ToString();
                    string Razon_Social = row.Cells[29].Value.ToString();//Codigo se debe filtrar

                    string C_costo = row.Cells[35].Value.ToString();//Aumentar en la tabla de talle

                  

                    if (Categoria != "MOVILIZACION TECNICOS PRECITROL")
                    {
                        if ((descripcionPorcentaje != "C.ASIGNAR") & (descripcionPorcentaje != ".") & (descripcionPorcentaje != "P.Comisionar") & (descripcionPorcentaje != "") & (Categoria.Equals("MANO DE OBRA SERVICIO TECNICO PROPIO")| Categoria.Equals("PROGRAMACION") | Categoria.Equals("METROLOGÍA")))
                        {
                            string[] arr = descripcionPorcentaje.Split(new[] { "C." }, StringSplitOptions.None);
                            int CONTAR = arr.Length;

                            for (int i = 0; i < CONTAR; i++)
                            {
                                // MessageBox.Show(CONTAR.ToString());
                                //   MessageBox.Show(arr[i]);
                                if (arr[i] != (""))
                                {
                                    string[] arr1 = arr[i].Split(new[] { " " }, StringSplitOptions.None);
                                    //arr1[0]=codigo del empleado
                                    //String res = COMI.Insertar_Comisiones(detalle_Factura, N_Factura, arr1[0], Tipo, arr1[1].Replace("%", ""), "", arr1[0]);
                                    if (arr1[0] != "HT.")
                                    {
                                        //CONTAMOS SI LOS DATOS SE CUMPLE MAS DE DOS
                                        int CONTAR_VARIABLE = arr1.Length;
                                        if (CONTAR_VARIABLE > 1)
                                        {
                                            int resultado = Participacion.Insertas_Porcentaje(Cab_NFactura, arr1[0], fecha, Categoria, arr1[1].Replace("%", ""), D_DETALLE, V_neto, C_costo, Razon_Social);
                                        }
                                        }

                                }


                            }

                        }
                    }
                    //aqui


                    //if (Cabecera.Consulta_Factura(Cab_NFactura) == true)
                    //{
                    //}



                }
                MessageBox.Show("Informacion Cargada, Asigando Comisiones A empleados");

             //   cargarComsion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + Cab_NFactura + "porcentaje ->" + descripcionPorcentaje);

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
    }
}
