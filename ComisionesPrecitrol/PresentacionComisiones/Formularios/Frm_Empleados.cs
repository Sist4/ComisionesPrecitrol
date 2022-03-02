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
    public partial class Frm_Empleados : Form
    {
        Negocio_Empleados Empleados = new Negocio_Empleados();

        private void Cargar_EmpleadosComisiones()
        {
            try
            {
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Empleados.Cargar_EmpleadosComisiones();
                // Gv_Datos.AutoGenerateColumns = false;
                GV_Empleados.DataSource = Cargar_Datos.Tables[0];
                //Tamaño de cada columna
                GV_Empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                GV_Empleados.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

               // GV_Empleados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                GV_Empleados.Columns[0].Width = 30;
                GV_Empleados.Columns[1].Width = 150;
                GV_Empleados.Columns[2].Width = 65;
                GV_Empleados.Columns[3].Width = 65;
                GV_Empleados.Columns[4].Width = 65;
                GV_Empleados.Columns[5].Width = 70;
                GV_Empleados.Columns[6].Width = 70;
                GV_Empleados.Columns[7].Width = 70;
                GV_Empleados.Columns[8].Width = 80;
                GV_Empleados.Columns[9].Width = 70;
                GV_Empleados.Columns[10].Width = 70;
                GV_Empleados.Columns[11].Width = 70;
                GV_Empleados.Columns[12].Width = 70;
                GV_Empleados.Columns[13].Width = 70;
                GV_Empleados.Columns[14].Width = 70;
                GV_Empleados.Columns[15].Width = 70;
                GV_Empleados.Columns[16].Width = 70;
                GV_Empleados.Columns[17].Width = 70;
                GV_Empleados.Columns[18].Width = 70;
                GV_Empleados.Columns[19].Width = 70;
                // this.GV_Empleados.BorderStyle = BorderStyle.Fixed3D;
                this.GV_Empleados.GridColor = Color.BlueViolet;
                this.GV_Empleados.BorderStyle = BorderStyle.Fixed3D;
                this.GV_Empleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                this.GV_Empleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                GV_Empleados.Columns[0].ReadOnly = true;
                GV_Empleados.Columns[1].ReadOnly = true;
                GV_Empleados.Columns[2].ReadOnly = true;
                GV_Empleados.Columns[3].ReadOnly = true;
                GV_Empleados.Columns[4].ReadOnly = true;
                GV_Empleados.Columns[5].ReadOnly = true;
                GV_Empleados.Columns[6].ReadOnly = true;
                GV_Empleados.Columns[7].ReadOnly = true;
                GV_Empleados.Columns[8].ReadOnly = true;
                GV_Empleados.Columns[9].DefaultCellStyle.BackColor = Color.YellowGreen;
                GV_Empleados.Columns[10].DefaultCellStyle.BackColor = Color.YellowGreen;
                GV_Empleados.Columns[11].DefaultCellStyle.BackColor = Color.YellowGreen;
                GV_Empleados.Columns[12].DefaultCellStyle.BackColor = Color.YellowGreen;

                GV_Empleados.Columns[13].DefaultCellStyle.BackColor = Color.Yellow;
                GV_Empleados.Columns[14].DefaultCellStyle.BackColor = Color.Yellow;
                GV_Empleados.Columns[15].DefaultCellStyle.BackColor = Color.Yellow;
                GV_Empleados.Columns[16].DefaultCellStyle.BackColor = Color.Yellow;


                GV_Empleados.Columns[17].DefaultCellStyle.BackColor = Color.SeaShell ;
                GV_Empleados.Columns[18].DefaultCellStyle.BackColor = Color.SeaShell;
                GV_Empleados.Columns[19].DefaultCellStyle.BackColor = Color.SeaShell;
                //this.GV_Empleados.DefaultCellStyle.BackColor = Color.LightYellow;

                //this.GV_Empleados.DefaultCellStyle.ForeColor = Color.DarkViolet;

                // configurar el estilo predeterminado del DataGridView

                // para que divida el texto de las celdas en varias líneas

                //this.GV_Empleados.DefaultCellStyle.WrapMode = DataGridViewTriState.True;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
          //  Limpiar_Cajas();
           

            Txt_Codigo.Text = Empleados.Codigo_Empleado().ToString();
            Txt_Codigo.ForeColor = Color.DimGray;
            Txt_Nombre.Enabled = true;
            Cbx_Ciudad.Enabled = true;
            Txt_Sueldo.Enabled = true;
            Cbx_ComisionFija.Enabled = true;
            Cbx_ManodeObra.Enabled = true;
            Cbx_Metrologia.Enabled = true;
            Cbx_Respuesto.Enabled = true;
            Cbx_Software.Enabled = true;
            Txt_Nombre.Focus();
            Btn_Nuevo.Enabled = false;
            Btn_Aceptar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            //AREA D QUITO
            CBX_TotalMOUIO.Enabled = true;
            CBX_TotalMetrologiaUIO.Enabled = true;
            CBX_TotalRepuestosUIO.Enabled = true;
            CBX_TotalSWUIO.Enabled = true;
            Txt_TotalMOUIO.Text = "";
            Txt_TotalMetrologiaUIO.Text = "";
            Txt_TotalRepuestosUIO.Text = "";
            Txt_TotalSWUIO.Text = "";
            //Area de GYE
            //AREA D QUITO
            CBX_TotalMOGYE.Enabled = true;
            CBX_TotalMetrologiaGYE.Enabled = true;
            CBX_TotalRepuestosGYE.Enabled = true;
            CBX_TotalSWGYE.Enabled = true;

            Txt_TotalMOGYE.Text = "";
            Txt_TotalMetrologiaGYE.Text = "";
            Txt_TotalRepuestosGYE.Text = "";
            Txt_TotalSWGYE.Text = "";
            //AREA D Manta

            CBX_TotalMOMTA.Enabled = true;
            CBX_TotalMetrologiaMTA.Enabled = true;
            CBX_TotalRepuestosMTA.Enabled = true;
       

            Txt_TotalMOMTA.Text = "";
            Txt_TotalMetrologiaMTA.Text = "";
            Txt_TotalRepuestosMTA.Text = "";




        }

        private void Txt_Codigo_Enter(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "CODIGO")
            {
                Txt_Codigo.Text = "";
                Txt_Codigo.ForeColor = Color.Black;
            }
        }

        private void Txt_Codigo_Leave(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                Txt_Codigo.Text = "CODIGO";
                Txt_Codigo.ForeColor = Color.DimGray;
            }
        }

        private void Txt_Nombre_Enter(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text == "NOMBRE DEL EMPLEADO")
            {
                Txt_Nombre.Text = "";
                Txt_Nombre.ForeColor = Color.Black;
            }
        }

        private void Txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text == "")
            {
                Txt_Nombre.Text = "NOMBRE DEL EMPLEADO";
                Txt_Nombre.ForeColor = Color.DimGray;
            }
        }

        private void Txt_Sueldo_Enter(object sender, EventArgs e)
        {
            if (Txt_Sueldo.Text == "INGRESE EL SUELDO")
            {
                Txt_Sueldo.Text = "";
                Txt_Sueldo.ForeColor = Color.Black;
            }
        
        }

        private void Txt_Sueldo_Leave(object sender, EventArgs e)
        {
            if (Txt_Sueldo.Text == "")
            {
                Txt_Sueldo.Text = "INGRESE EL SUELDO";
                Txt_Sueldo.ForeColor = Color.DimGray ;
            }
        }

        private void Cbx_ComisionFija_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbx_ComisionFija.Checked == true)
            {
                Txt_ComisionFija.Enabled = true;
                Txt_ComisionFija.Text = "";
                Txt_ComisionFija.Focus();
            }
            else
            {
                Txt_ComisionFija.Enabled = false;
                Txt_ComisionFija.Text = "";
            }
        }

        private void Cbx_ManodeObra_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbx_ManodeObra.Checked == true)
            {
                Txt_ManodeObra.Enabled = true;
                Txt_ManodeObra.Text = "";
                Txt_ManodeObra.Focus();
            }
            else
            {
                Txt_ManodeObra.Enabled = false;
                Txt_ManodeObra.Text = "";
            }
        }

        private void Cbx_Respuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbx_Respuesto.Checked == true)
            {
                Txt_Repuesto.Enabled = true;
                Txt_Repuesto.Text = "";
                Txt_Repuesto.Focus();
            }
            else
            {
                Txt_Repuesto.Enabled = false;
                Txt_Repuesto.Text = "";
            }
        }

        private void Cbx_Software_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbx_Software.Checked == true)
            {
                Txt_Software.Enabled = true;
                Txt_Software.Text = "";
                Txt_Software.Focus();
            }
            else
            {
                Txt_Software.Enabled = false;
                Txt_Software.Text = "";
            }
        }

        private void Cbx_Metrologia_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cbx_Metrologia.Checked == true)
            {
                Txt_Metrologia.Enabled = true;
                Txt_Metrologia.Text = "";
                Txt_Metrologia.Focus();
            }
            else
            {
                Txt_Metrologia.Enabled = false;
                Txt_Metrologia.Text = "";
            }
        }

        private void CBX_TotalMOUIO_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalMOUIO.Checked==true)
            {
                Txt_TotalMOUIO.Enabled = true;
                Txt_TotalMOUIO.Text = "";
                Txt_TotalMOUIO.Focus();
            }
            else
            {
                Txt_TotalMOUIO.Enabled = false;
                Txt_TotalMOUIO.Text = "";
            }
        }

        private void CBX_TotalMetrologiaUIO_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalMetrologiaUIO.Checked == true)
            {
                Txt_TotalMetrologiaUIO.Enabled = true;
                Txt_TotalMetrologiaUIO.Text = "";
                Txt_TotalMetrologiaUIO.Focus();
            }
            else
            {
                Txt_TotalMetrologiaUIO.Enabled = false;
                Txt_TotalMetrologiaUIO.Text = "";
            }
        }

        private void CBX_TotalRepuestosUIO_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalRepuestosUIO.Checked == true)
            {
                Txt_TotalRepuestosUIO.Enabled = true;
                Txt_TotalRepuestosUIO.Text = "";
                Txt_TotalRepuestosUIO.Focus();
            }
            else
            {
                Txt_TotalRepuestosUIO.Enabled = false;
                Txt_TotalRepuestosUIO.Text = "";
            }
        }

        private void CBX_TotalSWUIO_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalSWUIO.Checked == true)
            {
                Txt_TotalSWUIO.Enabled = true;
                Txt_TotalSWUIO.Text = "";
                Txt_TotalSWUIO.Focus();
            }
            else
            {
                Txt_TotalSWUIO.Enabled = false;
                Txt_TotalSWUIO.Text = "";
            }

        }

        private void CBX_TotalMOGYE_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalMOGYE.Checked == true)
            {
                Txt_TotalMOGYE.Enabled = true;
                Txt_TotalMOGYE.Text = "";
                Txt_TotalMOGYE.Focus();
            }
            else
            {
                Txt_TotalMOGYE.Enabled = false;
                Txt_TotalMOGYE.Text = "";
            }
        }

        private void CBX_TotalMetrologiaGYE_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalMetrologiaGYE.Checked == true)
            {
                Txt_TotalMetrologiaGYE.Enabled = true;
                Txt_TotalMetrologiaGYE.Text = "";
                Txt_TotalMetrologiaGYE.Focus();
            }
            else
            {
                Txt_TotalMetrologiaGYE.Enabled = false;
                Txt_TotalMetrologiaGYE.Text = "";
            }
        }

        private void CBX_TotalRepuestosGYE_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalRepuestosGYE.Checked == true)
            {
                Txt_TotalRepuestosGYE.Enabled = true;
                Txt_TotalRepuestosGYE.Text = "";
                Txt_TotalRepuestosGYE.Focus();
            }
            else
            {
                Txt_TotalRepuestosGYE.Enabled = false;
                Txt_TotalRepuestosGYE.Text = "";
            }
        }

        private void CBX_TotalSWGYE_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalSWGYE.Checked == true)
            {
                Txt_TotalSWGYE.Enabled = true;
                Txt_TotalSWGYE.Text = "";
                Txt_TotalSWGYE.Focus();
            }
            else
            {
                Txt_TotalSWGYE.Enabled = false;
                Txt_TotalSWGYE.Text = "";
            }
        }

        private void CBX_TotalMOMTA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalMOMTA.Checked == true)
            {
                Txt_TotalMOMTA.Enabled = true;
                Txt_TotalMOMTA.Text = "";
                Txt_TotalMOMTA.Focus();
            }
            else
            {
                Txt_TotalMOMTA.Enabled = false;
                Txt_TotalMOMTA.Text = "";
            }
        }

        private void CBX_TotalMetrologiaMTA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalMetrologiaMTA.Checked == true)
            {
                Txt_TotalMetrologiaMTA.Enabled = true;
                Txt_TotalMetrologiaMTA.Text = "";
                Txt_TotalMetrologiaMTA.Focus();
            }
            else
            {
                Txt_TotalMetrologiaMTA.Enabled = false;
                Txt_TotalMetrologiaMTA.Text = "";
            }
        }

        private void CBX_TotalRepuestosMTA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_TotalRepuestosMTA.Checked == true)
            {
                Txt_TotalRepuestosMTA.Enabled = true;
                Txt_TotalRepuestosMTA.Text = "";
                Txt_TotalRepuestosMTA.Focus();
            }
            else
            {
                Txt_TotalRepuestosMTA.Enabled = false;
                Txt_TotalRepuestosMTA.Text = "";
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {


            if (Txt_Correo.Text != "" | Txt_Correo.Text != "INGRESE EL CORREO")
            {
                int respuesta = Empleados.Insertar_Empleados(Txt_Codigo.Text, Txt_Nombre.Text, Cbx_Ciudad.Text, Txt_Sueldo.Text, Txt_ComisionFija.Text, (Convert.ToDouble(Txt_ManodeObra.Text) / 100).ToString(), (Convert.ToDouble(Txt_Repuesto.Text) / 100).ToString(), (Convert.ToDouble(Txt_Software.Text) / 100).ToString(), (Convert.ToDouble(Txt_Metrologia.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalMOUIO.Text) / 100).ToString()
                                                 , (Convert.ToDouble(Txt_TotalMetrologiaUIO.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalRepuestosUIO.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalSWUIO.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalMOGYE.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalMetrologiaGYE.Text) / 100).ToString()
                                                 , (Convert.ToDouble(Txt_TotalRepuestosGYE.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalSWGYE.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalMOMTA.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalMetrologiaMTA.Text) / 100).ToString(), (Convert.ToDouble(Txt_TotalRepuestosMTA.Text) / 100).ToString()
                                                 , "A", Txt_SafiCodigo.Text, Txt_Correo.Text);
                if (respuesta == 1)
                {
                    MessageBox.Show("¡ Transaccion Exitosa !");
                    Txt_Nombre.Enabled = false;
                    Cbx_Ciudad.Enabled = false;
                    Txt_Sueldo.Enabled = false;
                    Cbx_ComisionFija.Enabled = false;
                    Cbx_ManodeObra.Enabled = false;
                    Cbx_Metrologia.Enabled = false;
                    Cbx_Respuesto.Enabled = false;
                    Cbx_Software.Enabled = false;
                    Cbx_ComisionFija.Checked = false;
                    Cbx_ManodeObra.Checked = false;
                    Cbx_Metrologia.Checked = false;
                    Cbx_Respuesto.Checked = false;
                    Cbx_Software.Checked = false;
                    Txt_Codigo.Text = "";
                    Txt_Nombre.Text = "";
                    Cbx_Ciudad.Text = "SELECCIONE LA CIUDAD";
                    Txt_Sueldo.Text = "";
                    Txt_ComisionFija.Text = "";
                    Txt_ManodeObra.Text = "";
                    Txt_Repuesto.Text = "";
                    Txt_Software.Text = "";
                    Txt_Metrologia.Text = "";


                    Btn_Nuevo.Enabled = true;
                    Btn_Aceptar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    //AREA D QUITO
                    CBX_TotalMOUIO.Enabled = false;
                    CBX_TotalMetrologiaUIO.Enabled = false;
                    CBX_TotalRepuestosUIO.Enabled = false;
                    CBX_TotalSWUIO.Enabled = false;
                    Txt_TotalMOUIO.Text = "";
                    Txt_TotalMetrologiaUIO.Text = "";
                    Txt_TotalRepuestosUIO.Text = "";
                    Txt_TotalSWUIO.Text = "";
                    //Area de GYE
                    //AREA D QUITO
                    CBX_TotalMOGYE.Enabled = false;
                    CBX_TotalMetrologiaGYE.Enabled = false;
                    CBX_TotalRepuestosGYE.Enabled = false;
                    CBX_TotalSWGYE.Enabled = false;

                    Txt_TotalMOGYE.Text = "";
                    Txt_TotalMetrologiaGYE.Text = "";
                    Txt_TotalRepuestosGYE.Text = "";
                    Txt_TotalSWGYE.Text = "";
                    //AREA D Manta

                    CBX_TotalMOMTA.Enabled = false;
                    CBX_TotalMetrologiaMTA.Enabled = false;
                    CBX_TotalRepuestosMTA.Enabled = false;


                    Txt_TotalMOMTA.Text = "";
                    Txt_TotalMetrologiaMTA.Text = "";
                    Txt_TotalRepuestosMTA.Text = "";
                    Cargar_EmpleadosComisiones();
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN CORREO");
            }
                
                                                      
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Cargar_EmpleadosComisiones();
        }


        bool blnAjustarCeldas = true;
        private void GV_Empleados_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void GV_Empleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.GV_Empleados.Rows[e.RowIndex].Selected = true;
                //this.Index = e.RowIndex;
                this.GV_Empleados.CurrentCell = this.GV_Empleados.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.GV_Empleados, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Seguro que desea Modificar al Empleado: " + GV_Empleados.CurrentRow.Cells[1].Value.ToString(), "confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Btn_Nuevo.Enabled = false;
                    Btn_Aceptar.Enabled = true;
                    Btn_Cancelar.Enabled = true;
                    this.Txt_Codigo.Enabled = false;
                    this.Txt_Nombre.Enabled = true;
                    this.Cbx_Ciudad.Enabled = true;
                    this.Txt_Sueldo.Enabled = true;
                    //Datos del empleado
                    this.Txt_Codigo.Text = GV_Empleados.CurrentRow.Cells[0].Value.ToString();
                    this.Txt_Nombre.Text = GV_Empleados.CurrentRow.Cells[1].Value.ToString();
                    this.Cbx_Ciudad.Text = GV_Empleados.CurrentRow.Cells[2].Value.ToString();
                    this.Txt_Sueldo.Text = GV_Empleados.CurrentRow.Cells[3].Value.ToString();
                    //Datos de las comisiones por empleado
                    this.Txt_ComisionFija.Text = GV_Empleados.CurrentRow.Cells[4].Value.ToString();
                    this.Txt_ManodeObra.Text = GV_Empleados.CurrentRow.Cells[5].Value.ToString();
                    this.Txt_Repuesto.Text = GV_Empleados.CurrentRow.Cells[6].Value.ToString();
                    this.Txt_Software.Text = GV_Empleados.CurrentRow.Cells[7].Value.ToString();
                    this.Txt_Metrologia.Text = GV_Empleados.CurrentRow.Cells[8].Value.ToString();
                    //Datos de la comision QUITO
                    Txt_TotalMOUIO.Text = GV_Empleados.CurrentRow.Cells[9].Value.ToString();
                    Txt_TotalMetrologiaUIO.Text = GV_Empleados.CurrentRow.Cells[10].Value.ToString();
                    Txt_TotalRepuestosUIO.Text = GV_Empleados.CurrentRow.Cells[11].Value.ToString();
                    Txt_TotalSWUIO.Text = GV_Empleados.CurrentRow.Cells[12].Value.ToString();
                    //FIN QUITO
                    //inicio guayaquil
                    Txt_TotalMOGYE.Text = GV_Empleados.CurrentRow.Cells[13].Value.ToString();
                    Txt_TotalMetrologiaGYE.Text = GV_Empleados.CurrentRow.Cells[14].Value.ToString();
                    Txt_TotalRepuestosGYE.Text = GV_Empleados.CurrentRow.Cells[15].Value.ToString();
                    Txt_TotalSWGYE.Text = GV_Empleados.CurrentRow.Cells[16].Value.ToString();
                    //fin guayaquil
                    Txt_TotalMOMTA.Text = GV_Empleados.CurrentRow.Cells[17].Value.ToString();
                    Txt_TotalMetrologiaMTA.Text = GV_Empleados.CurrentRow.Cells[18].Value.ToString();
                    Txt_TotalRepuestosMTA.Text = GV_Empleados.CurrentRow.Cells[19].Value.ToString();
                    Txt_SafiCodigo.Text = GV_Empleados.CurrentRow.Cells[20].Value.ToString();
                   
                    //-------------------------Comisiones fijas verificamos si deben estar activas
                    if (Txt_ComisionFija.Text !=  ("0"))
                    {
                        Cbx_ComisionFija.Checked = true;
                    }
                    else
                    {
                        Cbx_ComisionFija.Checked = false;
                    }
                    if (Txt_ManodeObra.Text != ("0"))
                    {
                        Cbx_ManodeObra.Checked = true;
                    }
                    else
                    {
                        Cbx_ManodeObra.Checked = false;
                    }

                    if ( Txt_Repuesto.Text != ("0"))
                    {
                        Cbx_Respuesto.Checked = true;
                    }
                    else
                    {
                        Cbx_Respuesto.Checked = false;
                    }

                    if (Txt_Software.Text != ("0"))
                    {
                        Cbx_Software.Checked = true;
                    }
                    else
                    {
                        Cbx_Software.Checked = false;
                    }

                    if ( Txt_Metrologia.Text != ("0"))
                    {
                        Cbx_Metrologia.Checked = true;
                    }
                    else
                    {
                        Cbx_Metrologia.Checked = false;
                    }
                    //-----------------
                    if ( Txt_TotalMOUIO.Text != ("0"))
                    {
                        CBX_TotalMOUIO.Checked = true;
                    }
                    else
                    {
                        CBX_TotalMOUIO.Checked = false;
                    }

                    if ( Txt_TotalMetrologiaUIO.Text != ("0"))
                    {
                        CBX_TotalMetrologiaUIO.Checked = true;
                    }
                    else
                    {
                        CBX_TotalMetrologiaUIO.Checked = false;
                    }


                    if ( Txt_TotalRepuestosUIO.Text != ("0"))
                    {
                        CBX_TotalRepuestosUIO.Checked = true;
                    }
                    else
                    {
                        CBX_TotalRepuestosUIO.Checked = false;
                    }

                    if (Txt_TotalSWUIO.Text != ("0"))
                    {
                        CBX_TotalSWUIO.Checked = true;
                    }
                    else
                    {
                        CBX_TotalSWUIO.Checked = false;
                    }
                    //-----------------------AREA GUAYAQUIL---------------------------
                    if ( Txt_TotalMOGYE.Text != "0")
                    {
                        CBX_TotalMOGYE.Checked = true;
                    }
                    else
                    {
                        CBX_TotalMOGYE.Checked = false;
                    }

                    if ( Txt_TotalMetrologiaGYE.Text != ("0"))
                    {
                        CBX_TotalMetrologiaGYE.Checked = true;
                    }
                    else
                    {
                        CBX_TotalMetrologiaGYE.Checked = false;
                    }


                    if (Txt_TotalRepuestosGYE.Text != ("0"))
                    {
                        CBX_TotalRepuestosGYE.Checked = true;
                    }
                    else
                    {
                        CBX_TotalRepuestosGYE.Checked = false;
                    }

                    if ( Txt_TotalSWGYE.Text != ("0"))
                    {
                        CBX_TotalSWGYE.Checked = true;
                    }
                    else
                    {
                        CBX_TotalSWGYE.Checked = false;
                    }
                    //------------------------------------------------------------------------

                    if (Txt_TotalMOMTA.Text != ("0"))
                    {
                        CBX_TotalMOMTA.Checked = true;
                    }
                    else
                    {
                        CBX_TotalMOMTA.Checked = false;
                    }

                    if (Txt_TotalMetrologiaMTA.Text != ("0"))
                    {
                        CBX_TotalMetrologiaMTA.Checked = true;
                    }
                    else
                    {
                        CBX_TotalMetrologiaMTA.Checked = false;
                    }


                    if ( Txt_TotalRepuestosMTA.Text != ("0"))
                    {
                        CBX_TotalRepuestosMTA.Checked = true;
                       
                    }
                    else
                    {
                        CBX_TotalRepuestosMTA.Checked = false;
                    }

                  
                    //------------------------------------------------------------------------

                    Txt_TotalMOUIO.Text = GV_Empleados.CurrentRow.Cells[9].Value.ToString();
                    Txt_TotalMetrologiaUIO.Text = GV_Empleados.CurrentRow.Cells[10].Value.ToString();
                    Txt_TotalRepuestosUIO.Text = GV_Empleados.CurrentRow.Cells[11].Value.ToString();
                    Txt_TotalSWUIO.Text = GV_Empleados.CurrentRow.Cells[4].Value.ToString();

                    this.Txt_ComisionFija.Text = GV_Empleados.CurrentRow.Cells[4].Value.ToString();
                    this.Txt_ManodeObra.Text = GV_Empleados.CurrentRow.Cells[5].Value.ToString();
                    this.Txt_Repuesto.Text = GV_Empleados.CurrentRow.Cells[6].Value.ToString();
                    this.Txt_Software.Text = GV_Empleados.CurrentRow.Cells[7].Value.ToString();
                    this.Txt_Metrologia.Text = GV_Empleados.CurrentRow.Cells[8].Value.ToString();
                    //area de quito
                    Txt_TotalMOUIO.Text = GV_Empleados.CurrentRow.Cells[9].Value.ToString(); 
                    Txt_TotalMetrologiaUIO.Text = GV_Empleados.CurrentRow.Cells[10].Value.ToString(); 
                    Txt_TotalRepuestosUIO.Text = GV_Empleados.CurrentRow.Cells[11].Value.ToString(); 
                    Txt_TotalSWUIO.Text =  GV_Empleados.CurrentRow.Cells[12].Value.ToString();
                    //fin de la area de quito
                    Txt_TotalMOGYE.Text = GV_Empleados.CurrentRow.Cells[13].Value.ToString();
                    Txt_TotalMetrologiaGYE.Text = GV_Empleados.CurrentRow.Cells[14].Value.ToString();
                    Txt_TotalRepuestosGYE.Text = GV_Empleados.CurrentRow.Cells[15].Value.ToString();
                    Txt_TotalSWGYE.Text = GV_Empleados.CurrentRow.Cells[16].Value.ToString();
                    Txt_TotalMOMTA.Text = GV_Empleados.CurrentRow.Cells[17].Value.ToString();
                    Txt_TotalMetrologiaMTA.Text = GV_Empleados.CurrentRow.Cells[18].Value.ToString();
                    Txt_TotalRepuestosMTA.Text = GV_Empleados.CurrentRow.Cells[19].Value.ToString();




                    this.Txt_Codigo.ForeColor = Color.Black;
                    this.Txt_Nombre.ForeColor = Color.Black;
                    Txt_Sueldo.ForeColor = Color.Black;
                    Cbx_ComisionFija.Enabled = true;
                    Cbx_ManodeObra.Enabled = true;
                    Cbx_Metrologia.Enabled = true;
                    Cbx_Respuesto.Enabled = true;
                    Cbx_Software.Enabled = true;
                    CBX_TotalMOUIO.Enabled = true;
                    CBX_TotalMetrologiaUIO.Enabled = true;
                    CBX_TotalRepuestosUIO.Enabled = true;
                    CBX_TotalSWUIO.Enabled = true;
                    //Area de GYE
                    //AREA D QUITO
                    CBX_TotalMOGYE.Enabled = true;
                    CBX_TotalMetrologiaGYE.Enabled = true;
                    CBX_TotalRepuestosGYE.Enabled = true;
                    CBX_TotalSWGYE.Enabled = true;

                    //AREA D Manta

                    CBX_TotalMOMTA.Enabled = true;
                    CBX_TotalMetrologiaMTA.Enabled = true;
                    CBX_TotalRepuestosMTA.Enabled = true;







                    //// getting the id by index of row.  
                    //int result = 1;
                    //if (result == 1)
                    //{
                    //    MessageBox.Show("Record Deleted Successfully");

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Record not Deleted....Please try again.");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Txt_Nombre.Enabled = false;
            Cbx_Ciudad.Enabled = false;
            Txt_Sueldo.Enabled = false;
            Cbx_ComisionFija.Enabled = false;
            Cbx_ManodeObra.Enabled = false;
            Cbx_Metrologia.Enabled = false;
            Cbx_Respuesto.Enabled = false;
            Cbx_Software.Enabled = false;
            Txt_Nombre.Focus();
            Btn_Nuevo.Enabled = true;
            Btn_Aceptar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            //AREA D QUITO
            CBX_TotalMOUIO.Enabled = false;
            CBX_TotalMetrologiaUIO.Enabled = false;
            CBX_TotalRepuestosUIO.Enabled = false;
            CBX_TotalSWUIO.Enabled = false;
            Txt_TotalMOUIO.Text = "";
            Txt_TotalMetrologiaUIO.Text = "";
            Txt_TotalRepuestosUIO.Text = "";
            Txt_TotalSWUIO.Text = "";
            //Area de GYE
            //AREA D QUITO
            CBX_TotalMOGYE.Enabled = false;
            CBX_TotalMetrologiaGYE.Enabled = false;
            CBX_TotalRepuestosGYE.Enabled = false;
            CBX_TotalSWGYE.Enabled = false;

            Txt_TotalMOGYE.Text = "";
            Txt_TotalMetrologiaGYE.Text = "";
            Txt_TotalRepuestosGYE.Text = "";
            Txt_TotalSWGYE.Text = "";
            //AREA D Manta

            CBX_TotalMOMTA.Enabled = false;
            CBX_TotalMetrologiaMTA.Enabled = false;
            CBX_TotalRepuestosMTA.Enabled = false;


            Txt_TotalMOMTA.Text = "";
            Txt_TotalMetrologiaMTA.Text = "";
            Txt_TotalRepuestosMTA.Text = "";
        }
    }
}
