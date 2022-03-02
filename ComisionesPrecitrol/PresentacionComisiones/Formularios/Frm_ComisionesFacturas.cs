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
    public partial class Frm_ComisionesFacturas : Form
    {
        Negocios_Comision Comision = new Negocios_Comision();
        Negocio_Empleados Empleaodos = new Negocio_Empleados();
        //Cargar facturas pendientes

        private void Combo_empleado()
        {
            try
            {

                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Empleaodos.Cargar_EmpleadosComisiones();
                this.Cbx_Empleado.DisplayMember = "NOMBRE DEL EMPLEADO";
                this.Cbx_Empleado.ValueMember = "#";
                this.Cbx_Empleado.DataSource = Cargar_Datos.Tables[0];
                this.Cbx_Empleado.Text = "Seleccione el empleado";
                //this.Cbx_Empleado.AutoCompleteCustomSource = Autocomplete(Cargar_Datos);
                //this.Cbx_Empleado.AutoCompleteMode = AutoCompleteMode.Suggest;
                //this.Cbx_Empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        private void Cargar_FacturasPendientes(string[] consulta)
        {
            try
            {
                //estado CA= PARA LAS FACTURAS PENDIENTES *
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Comision.Cobranza(consulta);
           
                this.Cbx_Facturas.DataSource = Cargar_Datos.Tables[0];
              
                this.Cbx_Facturas.DisplayMember = "Cab_NFactura";
                this.Cbx_Facturas.ValueMember = "Cab_NFactura";
                this.Cbx_Facturas.Text = "Seleccione";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        //****************************
        private void Cargar_FacturaSeleccionada(string[] Dato_Busqueda)
        {
            try
            {
                Txt_NFactura.Text = "";
                Txt_RazonSocial.Text = "";
                Txt_Categoria.Text = "";
                Txt_Valor.Text = "";
                Txt_Fecha.Text = "";
                //this.GV_DetalleFacturas.DataSource = null;
                //this.GV_DetalleFacturas.Rows.Clear();
                //this.GV_DetalleFacturas.DataSource = this.GetNewValues();
                DataSet Dato_Factura = new DataSet();

                Dato_Factura = Comision.Cobranza(Dato_Busqueda);
                //GV_DetalleFacturas.DataSource = Dato_Factura.Tables[0];
                foreach (DataRow myReader in Dato_Factura.Tables[0].Rows)
                {
                

              


                    //DETALLE DE LA FACTURA
                    Txt_NFactura.Text = myReader[7].ToString();
                    Txt_RazonSocial.Text = myReader[8].ToString();
                    Txt_Categoria.Text = myReader[9].ToString();
                    Txt_Valor.Text = myReader[10].ToString();
                    Txt_Fecha.Text = myReader[11].ToString().Replace("0:00:00", "");
                }
              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Frm_ComisionesFacturas()
        {
            InitializeComponent();
        }

        private void Frm_ComisionesFacturas_Load(object sender, EventArgs e)
        {
            string[] Consultas_Facturas = {"*" };

            Cargar_FacturasPendientes(Consultas_Facturas);
            string[] C_Asignadas = { "Comision_Factura" };

            Cargar_Comision(C_Asignadas);
            Combo_empleado();
            Txt_NFactura.Text = "";
            Txt_RazonSocial.Text = "";
            Txt_Categoria.Text = "";
            Txt_Valor.Text = "";
            Txt_Fecha.Text = "";

        }

        private void Cbx_Facturas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbx_Facturas.SelectedIndex > 0)
            {
                //string[] Datos_Seleccionados = { "datos_Factura", Cbx_Facturas.Text };
                //Cargar_FacturaSeleccionada(Datos_Seleccionados);
                string[] Datos_Comision = { "detalle_Comision", Cbx_Facturas.SelectedValue.ToString() };
                Cargar_Comision(Datos_Comision);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string pago;
                if (cbx_PFactura.Checked == true)
                {
                    pago = "1";
                }
                else
                {
                    pago = "0";
                }
                string RESPUESTA = Comision.Insertar_ComisionesFactura(Cbx_Facturas.Text, Cbx_Empleado.SelectedValue.ToString(), Cbx_Comision.Text, "0", Txt_Valor.Text, Txt_VComision.Text, Txt_Observacion.Text, pago);
                MessageBox.Show("Comision Asignada");
                string[] Consultas_Facturas = { "*" };
                Cargar_FacturasPendientes(Consultas_Facturas);
                Combo_empleado();
                
                string[] C_Asignadas = { "Comision_Factura" };

                Cargar_Comision(C_Asignadas);
                Txt_NFactura.Text = "";
                Txt_RazonSocial.Text = "";
                Txt_Categoria.Text = "";
                Txt_Valor.Text = "";
                Txt_Fecha.Text = "";
                Txt_Observacion.Text = "";
                Txt_Valor.Text = "";
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString() );
            
            }
        }
    }
}
