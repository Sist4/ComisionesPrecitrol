using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegociosComisiones;
namespace PrecentacionComisiones.Formularios
{
    public partial class Frm_Comision : Form
    {
        Negocios_Comision Comision = new Negocios_Comision();
        Negocio_Empleados Empleaodos = new Negocio_Empleados();
        private bool _canUpdate = true;
        private bool _needUpdate = false;

        private void HandleTextChanged(List<string> dataSource)
        {
            var text = Cbx_Empleado.Text;

            if (dataSource.Count() > 0)
            {
                Cbx_Empleado.DataSource = dataSource;

                var sText = Cbx_Empleado.Items[0].ToString();
                Cbx_Empleado.SelectionStart = text.Length;
                Cbx_Empleado.SelectionLength = sText.Length - text.Length;
                Cbx_Empleado.DroppedDown = true;


                return;
            }
            else
            {
                Cbx_Empleado.DroppedDown = false;
                Cbx_Empleado.SelectionStart = text.Length;
            }
        }
        private void UpdateData()
        {
            if (Cbx_Empleado.Text.Length > 1)
            {
                //List<string> searchData = Search.GetData(Cbx_Empleado.Text);
              //  HandleTextChanged(searchData);
            }
        } 

        private void Combo_empleado()
        {
            try
            {

                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Empleaodos.Cargar_EmpleadosComisiones();
                  this.Cbx_Empleado.DisplayMember = "NOMBRE DEL EMPLEADO";
                  this.Cbx_Empleado.ValueMember = "Emp_CodigoSafi";
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
        private void Cargar_FacturaSeleccionada(string[] Dato_Busqueda)
        {
            try
            {
                Txt_NFactura.Text = "";
                Txt_RazonSocial.Text = "";
                Txt_Categoria.Text = "";
                Txt_Valor.Text = "";
                Txt_Fecha.Text = "";
                this.GV_DetalleFacturas.DataSource = null;
                this.GV_DetalleFacturas.Rows.Clear();
                //this.GV_DetalleFacturas.DataSource = this.GetNewValues();
                DataSet Dato_Factura = new DataSet();

                Dato_Factura = Comision.Cobranza(Dato_Busqueda);
                //GV_DetalleFacturas.DataSource = Dato_Factura.Tables[0];
                
                GV_DetalleFacturas.AutoGenerateColumns = false;
                foreach (DataRow myReader in Dato_Factura.Tables[0].Rows)
                {
                    int renglon = this.GV_DetalleFacturas.Rows.Add();
                   
                    
                    GV_DetalleFacturas.Rows[renglon].Cells["Det_Codigo"].Value = myReader[0].ToString();
                    GV_DetalleFacturas.Rows[renglon].Cells["Descripcion"].Value = myReader[1].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["Cantidad"].Value = myReader[2].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["PrecUnitario"].Value = myReader[3].ToString();
                    GV_DetalleFacturas.Rows[renglon].Cells["V_Neto"].Value = myReader[4].ToString();
                    GV_DetalleFacturas.Rows[renglon].Cells["Comentario"].Value = myReader[12].ToString();

                    //GV_DetalleFacturas.Rows[renglon].Cells["Iva"].Value = myReader[5].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["Total"].Value = myReader[6].ToString();


                    if (myReader[9].ToString().Equals("MOVILIZACION TECNICOS PRECITROL"))
                    {
                        GV_DetalleFacturas.Rows[renglon].DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
                        GV_DetalleFacturas.Rows[renglon].Cells[0].ReadOnly = true;
                        GV_DetalleFacturas.Rows[renglon].Cells[1].ReadOnly = true;
                        GV_DetalleFacturas.Rows[renglon].Cells[2].ReadOnly = true;
                        GV_DetalleFacturas.Rows[renglon].Cells[3].ReadOnly = true;
                        //GV_DetalleFacturas.Rows[renglon].Cells[4].ReadOnly = true;
                        //GV_DetalleFacturas.Rows[renglon].Cells[5].ReadOnly = true;
                        //GV_DetalleFacturas.Rows[renglon].Cells[6].ReadOnly = true;

                    }
                    else
                    {
                        GV_DetalleFacturas.Rows[renglon].Cells[1].ReadOnly = true;
                        GV_DetalleFacturas.Rows[renglon].Cells[2].ReadOnly = true;
                        GV_DetalleFacturas.Rows[renglon].Cells[3].ReadOnly = true;
                        //GV_DetalleFacturas.Rows[renglon].Cells[4].ReadOnly = true;
                        //GV_DetalleFacturas.Rows[renglon].Cells[5].ReadOnly = true;
                        //GV_DetalleFacturas.Rows[renglon].Cells[6].ReadOnly = true;



                       
                    }


                    //DETALLE DE LA FACTURA
                    Txt_NFactura.Text = myReader[7].ToString();
                    Txt_RazonSocial.Text = myReader[8].ToString();
                    Txt_Categoria.Text = myReader[9].ToString();
                    Txt_Valor.Text = myReader[10].ToString();
                    Txt_Fecha.Text = myReader[11].ToString().Replace("0:00:00","");
                }
                GV_DetalleFacturas.Columns[0].Width = 30;
                GV_DetalleFacturas.Columns[1].Width = 30;
                GV_DetalleFacturas.Columns[2].Width = 230;
                GV_DetalleFacturas.Columns[3].Width = 60;
                //GV_DetalleFacturas.Columns[4].Width = 60;
                //GV_DetalleFacturas.Columns[5].Width = 60;
                //GV_DetalleFacturas.Columns[6].Width = 60;
                GV_DetalleFacturas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                GV_DetalleFacturas.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                GV_DetalleFacturas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


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
        private void Cargar_FacturaSelecionadaAsignada(string[] Dato_Busqueda)
        {
            try
            {
                Txt_NFactura.Text = "";
                Txt_RazonSocial.Text = "";
                Txt_Categoria.Text = "";
                Txt_Valor.Text = "";
                Txt_Fecha.Text = "";
                this.GV_DetalleFacturas.DataSource = null;
                this.GV_DetalleFacturas.Rows.Clear();
                //this.GV_DetalleFacturas.DataSource = this.GetNewValues();
                DataSet Dato_Factura = new DataSet();

                Dato_Factura = Comision.Comisiones_Asignadas(Dato_Busqueda);
                //GV_DetalleFacturas.DataSource = Dato_Factura.Tables[0];

                GV_DetalleFacturas.AutoGenerateColumns = false;
                foreach (DataRow myReader in Dato_Factura.Tables[0].Rows)
                {
                    int renglon = this.GV_DetalleFacturas.Rows.Add();

                    GV_DetalleFacturas.Rows[renglon].Cells["Det_Codigo"].Value = myReader[0].ToString();
                    GV_DetalleFacturas.Rows[renglon].Cells["Descripcion"].Value = myReader[1].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["Cantidad"].Value = myReader[2].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["PrecUnitario"].Value = myReader[3].ToString();
                    GV_DetalleFacturas.Rows[renglon].Cells["V_Neto"].Value = myReader[4].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["Iva"].Value = myReader[5].ToString();
                    //GV_DetalleFacturas.Rows[renglon].Cells["Total"].Value = myReader[6].ToString();
                    //DETALLE DE LA FACTURA
                    Txt_NFactura.Text = myReader[7].ToString();
                    Txt_RazonSocial.Text = myReader[8].ToString();
                    Txt_Categoria.Text = myReader[9].ToString();
                    Txt_Valor.Text = myReader[10].ToString();
                    Txt_Fecha.Text = myReader[11].ToString().Replace("0:00:00", "");
                }
                GV_DetalleFacturas.Columns[0].Width = 30;
                GV_DetalleFacturas.Columns[1].Width = 30;
                //GV_DetalleFacturas.Columns[2].Width = 230;
                //GV_DetalleFacturas.Columns[3].Width = 60;
                GV_DetalleFacturas.Columns[3].Width = 60;
                //GV_DetalleFacturas.Columns[5].Width = 60;
                //GV_DetalleFacturas.Columns[6].Width = 60;
                GV_DetalleFacturas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                GV_DetalleFacturas.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                GV_DetalleFacturas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Cargar_AsignadasTabla(string[] Dato_Busqueda)
        {
            try
            {
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Comision.Comisiones_Asignadas(Dato_Busqueda);
                // Gv_Datos.AutoGenerateColumns = false;
                Gv_Comision.DataSource = Cargar_Datos.Tables[0];

                Gv_Comision.Columns[0].Width = 30;
                Gv_Comision.Columns[1].Width = 100;
                Gv_Comision.Columns[2].Width = 100;
                Gv_Comision.Columns[3].Width = 110;
                Gv_Comision.Columns[4].Width = 80;
                Gv_Comision.Columns[5].Width = 60;
                Gv_Comision.Columns[6].Width = 60;
                //Gv_Comision.Columns[7].Width = 60;//Cambio angel

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

        private void Cargar_FacturasAsignada(string[] consulta)
        {
            try
            {
                treeView2.Nodes.Clear();
                TreeNode nodo;
                // string[] consulta = { "*" };
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Comision.Comisiones_Asignadas(consulta);
                DataTable oTablaCli = Cargar_Datos.Tables[0];
                //DataRow RegistroCli= new DataRow() ;
                nodo = this.treeView2.Nodes.Add("Facturacion Precitrol");
                foreach (DataRow RegistroCli in oTablaCli.Rows)
                {
                    //agrego el nodo en el segundo nivel
                    String centro = RegistroCli[1].ToString();
                    nodo = treeView2.Nodes.Add((RegistroCli[0].ToString()));

                }


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
                treeView1.Nodes.Clear();               
                TreeNode nodo;
               // string[] consulta = { "*" };
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Comision.Cobranza(consulta);
                DataTable oTablaCli = Cargar_Datos.Tables[0];
                //DataRow RegistroCli= new DataRow() ;
                nodo = this.treeView1.Nodes.Add("Facturacion Precitrol");
                foreach (DataRow RegistroCli in oTablaCli.Rows)
                {
                    //agrego el nodo en el segundo nivel
                    String centro = RegistroCli[1].ToString();
                    nodo = treeView1.Nodes.Add((RegistroCli[0].ToString()));
                 
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public Frm_Comision()
        {
            InitializeComponent();
        }

        private void Frm_Comision_Load(object sender, EventArgs e)
        {
            string[] consulta = { "*" };
            Cargar_FacturasPendientes(consulta);
            Cargar_FacturasAsignada(consulta);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.Nodes.Count > 0)
            //{
            GV_DetalleFacturas.Enabled = true;
                TreeNode node = treeView1.SelectedNode;
                string text = node.Text;
                string[] Datos_Seleccionados = { "datos_Factura", text };
                string[] Datos_Comision = { "detalle_Comision", text };

                Cargar_FacturaSeleccionada(Datos_Seleccionados);
                Cargar_Comision(Datos_Comision);
                Combo_empleado();
                //MessageBox.Show(text);
            //}
        }

        private void GV_DetalleFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int row_index = e.RowIndex;
            //    for (int i = 0; i < GV_DetalleFacturas.RowCount; i++)
            //    {
            //        if (row_index != i)
            //        {
            //            GV_DetalleFacturas.Rows[i].Cells[0].Value = false;
            //        }
            //    }

            //    if (e.ColumnIndex == GV_DetalleFacturas.Columns[0].Index)
            //    {
            //        GV_DetalleFacturas.EndEdit();
            //       //MessageBox.Show(( GV_DetalleFacturas.Rows[e.RowIndex].Cells[1].Value.ToString()));
            //        Txt_ItemSeleccionado.Text = GV_DetalleFacturas.Rows[e.RowIndex].Cells[1].Value.ToString();
            //        Cbx_Empleado.Focus();
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta="";

                DataGridViewCheckBoxCell oCell;
                foreach (DataGridViewRow row in GV_DetalleFacturas.Rows)
                {
                    oCell = row.Cells["Column1"] as DataGridViewCheckBoxCell;
                    bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                    if (true == bChecked)
                    {
                       // string  prueba = (row.Cells[0].Value.ToString());
                        //MessageBox.Show(row.Cells[1].Value.ToString());
                        respuesta = Comision.Insertar_Comisiones(row.Cells[1].Value.ToString(), Txt_NFactura.Text, Cbx_Empleado.SelectedValue.ToString(), Cbx_TipoComision.Text, Txt_Porcentaje.Text, Txt_Observacion.Text,"");


                    }
                }




               // string respuesta = Comision.Insertar_Comisiones(Txt_ItemSeleccionado.Text, Txt_NFactura.Text, Cbx_Empleado.SelectedValue.ToString(), Cbx_TipoComision.Text, Txt_Porcentaje.Text,Txt_Observacion.Text);



                if (respuesta != (""))
                {
                    string[] Datos_Factura = { "datos_Factura", Txt_NFactura.Text };

                    //Cargar_FacturaSeleccionada(Datos_Comision);
                    if (respuesta.Equals("No aplica"))
                    {
                        MessageBox.Show("El empleado no aplica la comision:" + Cbx_TipoComision.Text + " revise nuevamente el tipo de comision y vuelva a intetarlo");


                    }
                    else if (respuesta.Equals("COMPLETADO"))
                    {
                        MessageBox.Show("se Agenerado el 100% de la comision del Item : " + Txt_ItemSeleccionado.Text + " de la factura: " + Txt_NFactura.Text);
                        MessageBox.Show("Transaccion exitosa de la Factura: " + Txt_NFactura.Text);
                        string[] consulta = { "*" };
                        Cargar_FacturasPendientes(consulta);
                        //treeView1.Nodes.Remove(treeView1.SelectedNode);
                        string[] Datos_Factura2 = { "datos_Factura", "" };
                        Cargar_FacturaSeleccionada(Datos_Factura2);
                        Cbx_Empleado.Text = "Seleccione Empleado";
                        Cbx_TipoComision.Text = "Seleccione";
                        Txt_Porcentaje.Text = "";
                        Txt_Observacion.Text = "";




                    }

                    else if (respuesta.Equals("100"))
                    {
                        MessageBox.Show("se Agenerado el 100% de la comision del Item : " + Txt_ItemSeleccionado.Text + " de la factura: " + Txt_NFactura.Text);
                        Cargar_FacturaSeleccionada(Datos_Factura);
                        Cbx_Empleado.Text = "Seleccione Empleado";
                        Cbx_TipoComision.Text = "Seleccione";
                        Txt_Porcentaje.Text = "";
                        Txt_Observacion.Text = "";


                    }
                    else
                    {
                        Cbx_Empleado.Text = "Seleccione Empleado";
                        Cbx_TipoComision.Text = "Seleccione";
                        Txt_Porcentaje.Text = "";
                        Txt_Observacion.Text = "";

                    }
                    string[] Datos_Comision = { "detalle_Comision", Txt_NFactura.Text };
                    Cargar_Comision(Datos_Comision);
                    string[] Datos_Comision2 = { "*" };

                    Cargar_FacturasAsignada(Datos_Comision2);
                }
                else
                {
                    MessageBox.Show("No se Asignado Ningun ITEM");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string[] consulta = { "*" };
                Cargar_FacturasPendientes(consulta);
            }
            else
            {
                //textBox1.Text = "";
                //textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                string[] consulta = { "Consulta_Ciudad", "QUITO" };
                Cargar_FacturasPendientes(consulta);
            }
            else
            {
                //textBox1.Text = "";
                //textBox1.Enabled = false;
                //Btn_Buscar.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                string[] consulta = { "Consulta_Ciudad", "GUAYAQUIL" };
                Cargar_FacturasPendientes(consulta);
            }
            else
            {
                //textBox1.Text = "";
                //textBox1.Enabled = false;
                //Btn_Buscar.Enabled = false;

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                string[] consulta = { "Consulta_Ciudad", "MANTA" };
                Cargar_FacturasPendientes(consulta);
            }
            else
            {
                //textBox1.Text = "";
                //textBox1.Enabled = false;
                //Btn_Buscar.Enabled = false;

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton5.Checked == true)
            //{
            //    Btn_Buscar.Enabled = true;

            //    textBox1.Enabled = true;
            //    textBox1.Text = "";
            //    textBox1.Focus();

            //}
            //else
            //{
            //    textBox1.Text = "";
            //    textBox1.Enabled = false;
            //}
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")
            //{
            //    string[] consulta = { "Consulta_Varios", textBox1.Text };
            //    Cargar_FacturasPendientes(consulta);
            //}
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GV_DetalleFacturas.Enabled = false;
            TreeNode node = treeView2.SelectedNode;
            string text = node.Text;
            string[] Datos_Seleccionados = { "datos_Factura", text };
            string[] Datos_Comision = { "detalle_Comision", text };

            //Cargar_FacturasAsignada(Datos_Seleccionados);
            Cargar_FacturaSelecionadaAsignada(Datos_Seleccionados);
            Cargar_AsignadasTabla(Datos_Comision);
            //Combo_empleado();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                string[] consulta = { "*" };
                Cargar_FacturasAsignada(consulta);
            }
            else
            {
                //textBox2.Text = "";
                //textBox2.Enabled = false;
                //button1.Enabled = false;

            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                string[] consulta = { "Consulta_Ciudad", "QUITO" };
                Cargar_FacturasAsignada(consulta);
            }
            else
            {
                //textBox2.Text = "";
                //textBox2.Enabled = false;
                //button1.Enabled = false;
            }

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                string[] consulta = { "Consulta_Ciudad", "GUAYAQUIL" };
                Cargar_FacturasAsignada(consulta);
            }
            else
            {
                //textBox2.Text = "";
                //textBox2.Enabled = false;
                //button1.Enabled = false;

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                string[] consulta = { "Consulta_Ciudad", "MANTA" };
                Cargar_FacturasAsignada(consulta);
            }
            else
            {
                //textBox2.Text = "";
                //textBox2.Enabled = false;
                //button1.Enabled = false;

            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox2.Text != "")
            //{
            //    string[] consulta = { "Consulta_Varios", textBox1.Text };
            //    Cargar_FacturasAsignada(consulta);
            //}
        }

        private void Gv_Comision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gv_Comision_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Gv_Comision.Rows[e.RowIndex].Selected = true;
                //this.Index = e.RowIndex;
                this.Gv_Comision.CurrentCell = this.Gv_Comision.Rows[e.RowIndex].Cells[7];
                this.contextMenuStrip1.Show(this.Gv_Comision, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seguro que desea Eliminar el registro", "confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (GV_DetalleFacturas.Enabled == true)//si la grilla esta activa
                {
                    string respuesta = Comision.Eliminar_Comisiones(Txt_NFactura.Text, Gv_Comision.CurrentRow.Cells[7].Value.ToString(), Gv_Comision.CurrentRow.Cells[0].Value.ToString());
                    string[] Datos_Seleccionados = { "datos_Factura", Txt_NFactura.Text };
                    string[] Datos_Comision = { "detalle_Comision", Txt_NFactura.Text };
                    string[] consulta = { "*" };
                    //Cargar_FacturasPendientes(consulta);
                    //Cargar_FacturasAsignada(consulta);
                    Cargar_FacturaSeleccionada(Datos_Seleccionados);
                    Cargar_Comision(Datos_Comision);
                    Combo_empleado();
                }
                else
                {
                    string respuesta = Comision.Eliminar_Comisiones(Txt_NFactura.Text, Gv_Comision.CurrentRow.Cells[7].Value.ToString(), Gv_Comision.CurrentRow.Cells[0].Value.ToString());
                    string[] Datos_Seleccionados = { "datos_Factura", "" };
                    string[] Datos_Comision = { "detalle_Comision", ""};
                    string[] consulta = { "*" };
                    Cargar_FacturasPendientes(consulta);
                    Cargar_FacturasAsignada(consulta);
                    Cargar_FacturaSeleccionada(Datos_Seleccionados);
                    Cargar_Comision(Datos_Comision);
                    Combo_empleado();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Resume_comisiones Form1 = new Frm_Resume_comisiones();
            Form1.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Observacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_Resume_comisiones Form1 = new Frm_Resume_comisiones();
            Form1.Show();
        }
    }
}
