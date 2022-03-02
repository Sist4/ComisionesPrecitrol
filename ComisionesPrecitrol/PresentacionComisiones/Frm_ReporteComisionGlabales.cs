using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegociosComisiones;
namespace PrecentacionComisiones
{
    public partial class Frm_ReporteComisionGlabales : Form
    {
        Negocios_Comision Comision = new Negocios_Comision();
        Negocio_Empleados Empleaodos = new Negocio_Empleados();

        private void reprorte(string [] datos)
        {


            string ruta = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "");
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            ruta = @"C:\Reportes_Comisiones\Rpt_ComisionesGlobales.rpt";
            DataSet dsDataSet = new DataSet();
            dsDataSet = Comision.Reporte_Comisiones(datos);
            DataTable dtDataTable = new DataTable(); //= Nothing
            dtDataTable = dsDataSet.Tables[0];
            ReportDocument reporte = new ReportDocument();
            reporte = new ReportDocument();
            reporte.Load(ruta);
            reporte.SetDataSource(dsDataSet.Tables[0]);
            //consulta para subinforme
            //string[] datos_c = { "Comision_gerenciav", Convert.ToString(Txt_Desde.Value) };
            //dsDataSet = Comision.Reporte_Comisiones(datos_c);
            //dtDataTable = new DataTable(); //= Nothing
            //dtDataTable = dsDataSet.Tables[0];
            //reporte = new ReportDocument();
            //reporte = new ReportDocument();
            ////reporte.Load(ruta);
            ////reporte.SetDataSource(dsDataSet.Tables[0]);


            //reporte.Load(@"C:\Reportes_Comisiones\Rpt_ComisionesGlobales.rpt");

            CrTables = reporte.Database.Tables;
            reporte.SetDatabaseLogon("sa", "Sistemas123*", "192.168.0.128\\METROLOGIA", "ComisionesPrecitrolV2");


            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Zoom(100);
            crystalReportViewer1.Refresh();

            //string ruta = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "");
            //TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            //ConnectionInfo crConnectionInfo = new ConnectionInfo();
            //Tables CrTables;
            //ruta = @"C:\Reportes_Comisiones\Rpt_ComisionesGlobales.rpt";
            //DataSet dsDataSet = new DataSet();
            //dsDataSet = Comision.Reporte_Comisiones(datos);
            //DataTable dtDataTable = new DataTable(); //= Nothing
            //dtDataTable = dsDataSet.Tables[0];
            //ReportDocument reporte = new ReportDocument();
            //reporte = new ReportDocument();
            //reporte.Load(ruta);
            //reporte.SetDataSource(dsDataSet.Tables[0]);
            ////consulta para subinforme
            ////string[] datos_c = { "Comision_gerenciav", Convert.ToString(Txt_Desde.Value) };
            ////dsDataSet = Comision.Reporte_Comisiones(datos_c);
            //// dtDataTable = new DataTable(); //= Nothing
            ////dtDataTable = dsDataSet.Tables[0];
            //// reporte = new ReportDocument();
            ////reporte = new ReportDocument();
            ////reporte.Load(ruta);
            ////reporte.SetDataSource(dsDataSet.Tables[0]);


            //reporte.Load(@"C:\Reportes_Comisiones\Rpt_ComisionesGlobales.rpt");
            
            //CrTables = reporte.Database.Tables;
            //reporte.SetDatabaseLogon("sa", "Sistemas123*", "192.168.9.223\\METROLOGIA", "ComisionesPrecitrolV2");


            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}
            //crystalReportViewer1.ReportSource = reporte;
            //crystalReportViewer1.Zoom(100);
            //crystalReportViewer1.Refresh();
        }
        public Frm_ReporteComisionGlabales()
        {
            InitializeComponent();
        }

        private void Combo_empleado()
        {
            try
            {

                //DataSet Cargar_Datos = new DataSet();
                //Cargar_Datos = Empleaodos.Cargar_EmpleadosComisiones();
                //this.Cbx_Empleado.DisplayMember = "NOMBRE DEL EMPLEADO";
                //this.Cbx_Empleado.ValueMember = "Emp_CodigoSafi";
                //this.Cbx_Empleado.DataSource = Cargar_Datos.Tables[0];
                //this.Cbx_Empleado.Text = "Seleccione el empleado";
                ////this.Cbx_Empleado.AutoCompleteCustomSource = Autocomplete(Cargar_Datos);
                ////this.Cbx_Empleado.AutoCompleteMode = AutoCompleteMode.Suggest;
                ////this.Cbx_Empleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] consulta = { "Comision global", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value) };
            reprorte(consulta);
            //if (checkBox1.Checked != true & checkBox2.Checked != true)
            //{
            //    string[] consulta = { "Comision global", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value) };
            //    reprorte(consulta);
            //}
            ////else if (checkBox1.Checked == true)
            ////{
            ////    string[] consulta = { "Empleado", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value),Cbx_Empleado.SelectedValue.ToString() };
            ////    reprorte(consulta);
            ////}
            ////else if (checkBox2.Checked == true)
            ////{
            ////    string[] consulta = { "Ciudad", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value), comboBox1.Text };
            ////    reprorte(consulta);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // //checkBox2.Checked = false;
           // if (checkBox1.Checked.Equals(true))
           // {
           //     Combo_empleado();
           //     checkBox2.Checked = false;
           //     comboBox1.Text = "Seleccione";
           //     comboBox1.Enabled = false;

           // }
           // else
            
           // {
           //     comboBox1.Text = "Seleccione";
           //     comboBox1.Enabled = false;
           //    // Cbx_Empleado.Items.Clear();
           //     checkBox2.Checked = false;
           //     checkBox1.Checked = false;
             
           //     Cbx_Empleado.DataSource = null;
           //     Cbx_Empleado.Items.Clear();
           // }
           //// checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked.Equals(true))
            //{
            //    comboBox1.Text = "Seleccione";
            //    checkBox1.Checked = false;
            //    checkBox2.Checked = true;
              
            //    comboBox1.Enabled = true;

            //}


        }
    }
}
