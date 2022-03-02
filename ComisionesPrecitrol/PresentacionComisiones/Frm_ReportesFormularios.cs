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
    public partial class Frm_ReportesFormularios : Form
    {
        Negocios_Porcentaje Participacion = new Negocios_Porcentaje();

        private void reprorte(string [] datos)
        {

            string ruta = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "");
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            crConnectionInfo.ServerName = "192.168.0.128\\METROLOGIA";
            crConnectionInfo.DatabaseName = "ComisionesPrecitrolV2";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "Sistemas123*";

            ruta = @"C:\Reportes_Comisiones\Rpt_ParticipacionV3.rpt";
            DataSet dsDataSet = new DataSet();
            dsDataSet = Participacion.Porcentajes_Participacion(datos);
            DataTable dtDataTable = new DataTable(); //= Nothing
            dtDataTable = dsDataSet.Tables[0];
            ReportDocument reporte = new ReportDocument();
            reporte = new ReportDocument();
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
            crystalReportViewer1.Zoom(75);
            crystalReportViewer1.Refresh();
        }
        public Frm_ReportesFormularios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] consulta = {Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value) };
            reprorte(consulta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
