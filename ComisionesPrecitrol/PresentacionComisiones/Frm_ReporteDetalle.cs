using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using NegociosComisiones;
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

namespace PrecentacionComisiones
{
    public partial class Frm_ReporteDetalle : Form
    {
        Negocios_Detalle Detalle = new Negocios_Detalle(); 
        public Frm_ReporteDetalle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataSet Dato_Almacenado = new DataSet();
            //Dato_Almacenado = Detalle.Reporte_Cobranza(Txt_Desde.Value.Date.ToString("yyyy-MM-dd"), Txt_Hasta.Value.Date.ToString("yyyy-MM-dd"));


            string ruta = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "");
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            crConnectionInfo.ServerName = "192.168.0.128\\METROLOGIA";
            crConnectionInfo.DatabaseName = "ComisionesPrecitrolV2";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "Sistemas123*";

            ruta = @"C:\Reportes_Comisiones\Rpt_Detalle.rpt";
            DataSet dsDataSet = new DataSet();
            dsDataSet = Detalle.Reporte_Cobranza(Txt_Desde.Value.Date.ToString("yyyy-MM-dd"), Txt_Hasta.Value.Date.ToString("yyyy-MM-dd"));
            DataTable dtDataTable = new DataTable(); //= Nothing
            dtDataTable = dsDataSet.Tables[0];
            ReportDocument reporte = new ReportDocument();
            // ReportDocument reporte = new ReportDocument();
            reporte.Load(ruta);
            reporte.SetDataSource(dsDataSet.Tables[0]);
            CrTables = reporte.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Zoom(100);
            crystalReportViewer1.Refresh();


         
        }
    }
}
