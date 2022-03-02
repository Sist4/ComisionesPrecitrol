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

namespace Sistemas_Precitrol.Formularios
{
    public partial class Frm_Cobranza : Form
    {
        Negocios_Cabecera Cabecera = new Negocios_Cabecera();

        public Frm_Cobranza()
        {
            InitializeComponent();
        }
        private void LLenarGrid(string archivo, string hoja)
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
                    dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridView1.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                    // Bind the DataGridView controls to the BindingSource
                    // components and load the data from the database.
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1];
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                    txtArchivo.Text = dialog.FileName;
                    string hoja = txtHoja.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                    LLenarGrid(txtArchivo.Text, hoja); //se manda a llamar al metodo

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                    //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string ruc = row.Cells[0].Value.ToString();
                    string Razon_Social = row.Cells[1].Value.ToString();
                    string estado = row.Cells[3].Value.ToString();
                    string Recibo_Cobro = row.Cells[5].Value.ToString();//Aumentar el reiibo de cobro

                    string fecha_emision = row.Cells[6].Value.ToString();

                    string fecha_Vencimineto = row.Cells[7].Value.ToString();
                    string N_Factura = row.Cells[8].Value.ToString();//Numero de fuctura
                    string Razon_Social2 = row.Cells[9].Value.ToString();
                    string valor = row.Cells[11].Value.ToString();
                    //string ruc = row.Cells[0].Value.ToString();
                    //string Razon_Social = row.Cells[1].Value.ToString();
                    //string estado = row.Cells[2].Value.ToString();
                    //string fecha_emision = row.Cells[5].Value.ToString();
                    //string fecha_Vencimineto = row.Cells[6].Value.ToString();
                    //string N_Factura = row.Cells[7].Value.ToString();
                    //string Razon_Social2 = row.Cells[8].Value.ToString();
                    //string valor = row.Cells[9].Value.ToString();
                    if (Razon_Social2.Equals("www.safi.com.ec") | Razon_Social2.Equals("EmpresaRegistra"))
                    {
                    }
                    else
                    {
                        int resultado = Cabecera.Insertas_Cabecera(N_Factura, estado, fecha_emision, fecha_Vencimineto, Razon_Social, Razon_Social2, valor, ruc, Recibo_Cobro);
                    }



                }
                MessageBox.Show("Informacion Cargada DE Facturación");
        

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
