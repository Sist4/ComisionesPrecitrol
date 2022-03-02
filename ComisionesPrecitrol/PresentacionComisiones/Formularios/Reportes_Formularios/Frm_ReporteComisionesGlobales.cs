using System;
using System.Collections.Generic;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegociosComisiones;

namespace PrecentacionComisiones.Formularios.Reportes_Formularios
{
    public partial class Frm_ReporteComisionesGlobales : Form
    {
        Negocios_Comision Comision = new Negocios_Comision();
        Negocio_Empleados Empleaodos = new Negocio_Empleados();

        private void reprorte(string[] datos)
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
            reporte.SetDatabaseLogon("sa", "Sistemas123*", @"192.168.0.128\Metrologia", "ComisionesPrecitrolV2");


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
        public Frm_ReporteComisionesGlobales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] consulta = { "Comision global", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value) };
            reprorte(consulta);
        }
    }
}
