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
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace PrecentacionComisiones.Formularios.Reportes_Formularios
{
    public partial class Frm_ReporteComisionesEmpleados : Form
    {
        Negocios_Comision Comision = new Negocios_Comision();
        Negocio_Empleados Empleaodos = new Negocio_Empleados();


        public void Envio_Informacion(string codigo, string email_empleado, string Nombre_Empresa, string Metrelogo, string Empleado)
        {
            // Dim ConexionSql As New SqlConnection()

            // Replace sender@example.com with your "From" address.
            // This address must be verified with Amazon SES.
            string FROM = "precitrol@outlook.com";
            string FROMNAME = "Precitrol";
            // Replace recipient@example.com with a "To" address. If your account
            // is still in the sandbox, this address must be verified.
            string T = email_empleado;
            // Replace smtp_username with your Amazon SES SMTP user name.
            string SMTP_USERNAME = "precitrolsist4@precitrol.com";
            // Replace smtp_password with your Amazon SES SMTP user name.
            string SMTP_PASSWORD = "Sistemas123";
            // (Optional) the name of a configuration set to use for this message.
            // If you comment out this line, you also need to remove or comment out
            // the "X-SES-CONFIGURATION-SET" header below.
            string CONFIGSET = "ConfigSet";
            // If you're using Amazon SES in a region other than EE.UU. Oeste (Oregón),
            // replace email-smtp.us-west-2.amazonaws.com with the Amazon SES SMTP
            // endpoint in the appropriate AWS Region.
            string HOST = "smtp-mail.outlook.com";
            // The port you will connect to on the Amazon SES SMTP endpoint. We
            // are choosing port 587 because we will use STARTTLS to encrypt
            // the connection.
            int PORT = 587;
            double Total = 0d;
            // The subject line of the email
            string SUBJECT = "Sistema de Comisiones";
            var fecha = DateTime.Now;
            // The body of the email
            string BODY = "<h1>Estimado(a).</h1>" + "<p>" + Empleado + "<p>" + "<p>  PRECISION Y CONTROL PRECITROL S.A. RUC: 1791359038001 le comunica por este medio que el detalle comisiones de su Rol de Pagos ha sido generado</h1> con éxito el " + fecha + ". Se encuentra disponible como adjunto para su visualización y descarga. Para cualquier consulta comunicarse con Contabilidad. </p>" + "<br>" + "<table  border='1px' cellpadding='5' cellspacing='0' style='border: solid 1px Silver; font-size: x-small;' >" + "<tr>" + "<tr>" + "<th>Fecha de Cobro</th>" + "<th>Reporte de Trabajo</th>" + "<th>Factura</th>" + "<th>Cliente</th>" + "<th>Base de Comision</th>" + "<th>Total</th>" + "</tr>"; // DetC_BaseComision as "B"c,DetC_TotalComision as "T"c
            var Dato_Almacenado = new DataSet();
            string consulta = "";
            try
            {

                // generamos la consulta
                //consulta = "select NumBpr as  '#',MarBpr as 'MARCA',ModBpr AS 'MODELO',SerBpr AS 'SERIE',DesBpr AS 'DESCRIPCION',ClaBpr AS 'CLASE' from Balxpro where IdeBpr='" + codigo + "' order by convert(int,NumBpr)";
                consulta = "select top 10 Cab_FEmision,Det_NTrabajo,Cab_NFactura,Cab_RazonSocial,DetC_BaseComision,DetC_TotalComision from V_Comision";
                using (var ConexionSql = new SqlConnection(@"data source= 192.168.0.128\Metrologia; initial catalog = ComisionesPrecitrolV2; user id = sa; password = Sistemas123*"))
                {
                    ConexionSql.Open();
                    var Comando_Sql = new SqlCommand(consulta, ConexionSql);
                    var Adaptador_Sql = new SqlDataAdapter(Comando_Sql);
                    // ccn.Open()
                    Adaptador_Sql.Fill(Dato_Almacenado);
                    ConexionSql.Close();
                }

                foreach (DataRow dr in Dato_Almacenado.Tables[0].Rows)
                {

                    // Envio_Informacion(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                    BODY += "<tr>" + "<td>" + dr[0].ToString() + "</td>" + "<td>" + dr[1].ToString() + "</td>" + "<td>" + dr[2].ToString() + "</td>" + "<td>" + dr[3].ToString() + "</td>" + "<td>" + dr[4].ToString() + "</td>" + "<td>" + dr[5].ToString() + "</td>" + "</tr>";
                    Total = Total + 1d;
                }
            }
            finally
            {
                // If ConexionSql IsNot Nothing AndAlso ConexionSql.State <> ConnectionState.Closed Then
                // ConexionSql.Close()

                // End If

            }

            // & "<tr>"
            // & "</tr>"
            BODY += "</table>";
            BODY += "</h2>Numero de Blz: </h2>" + Total;
            BODY += "</br>";
            BODY += "<p>Metrologo asignado: " + Metrelogo + " </p>";
            BODY += "</br>";
            BODY += "<p>Creado por: " + Empleado + " </p>";

            // Create and build a new MailMessage object
            var message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(FROM, FROMNAME);
            message.To.Add(new MailAddress(T));
            message.Subject = SUBJECT;
            message.Body = BODY;
            // Comment or delete the next line if you are not using a configuration set
            message.Headers.Add("X-SES-CONFIGURATION-SET", CONFIGSET);
            using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Pass SMTP credentials
                client.Credentials = new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);
                // Enable SSL encryption
                client.EnableSsl = true;
                // Try to send the message. Show status in console.
                try
                {
                    Console.WriteLine("Attempting to send email...");
                    client.Send(message);
                    Console.WriteLine("Email sent!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The email was not sent.");
                    Console.WriteLine("Error message: " + ex.Message);
                }
            }
        }


        private void envio_Correo(string Empleados)
        { 
        try
         {
            //Verificamos si existe los reportes         
             string ruta = @"C:\Reportes_Comisiones\PDF";
                 //¿existe la Ruta?
             if (Directory.Exists(ruta))
             {
                 //La carpeta si existe empesamos agenerar los reportes 



             }
             else
             {
                 //Generamos la carpeta llamada reportes 
                 Directory.CreateDirectory(@"C:\Reportes_Comisiones\PDF");

             }





         }
            catch(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        
        
        }




        private void reprorte_Correo(string[] datos,string Nombre)
        {

            string ruta = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "");
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            crConnectionInfo.ServerName = "192.168.0.128\\METROLOGIA";
            crConnectionInfo.DatabaseName = "ComisionesPrecitrolV2";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "Sistemas123*";

            ruta = @"C:\Reportes_Comisiones\Rpt_ComisionEmpleados.rpt";
            DataSet dsDataSet = new DataSet();
            dsDataSet = Comision.Reporte_Comisiones(datos);
            DataTable dtDataTable = new DataTable(); //= Nothing
            dtDataTable = dsDataSet.Tables[0];
            ReportDocument reporte = new ReportDocument();
            reporte = new ReportDocument();
            reporte.Load(ruta);
            reporte.SetDataSource(dsDataSet.Tables[0]);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
            if (File.Exists(ruta + @"\" + Nombre + ".pdf"))
                File.Delete(ruta + @"\" + Nombre + ".pdf");
            reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ruta + @"\" + Nombre + ".pdf");
           
        }











        private void reprorte(string[] datos)
        {

            string ruta = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "");
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;
            crConnectionInfo.ServerName = "192.168.0.128\\METROLOGIA";
            crConnectionInfo.DatabaseName = "ComisionesPrecitrolV2";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "Sistemas123*";

            ruta = @"C:\Reportes_Comisiones\Rpt_ComisionEmpleados.rpt";
            DataSet dsDataSet = new DataSet();
            dsDataSet = Comision.Reporte_Comisiones(datos);
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
            crystalReportViewer1.Zoom(100);
            crystalReportViewer1.Refresh();
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
        public Frm_ReporteComisionesEmpleados()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox2.Checked = false;
            if (checkBox1.Checked.Equals(true))
            {
                Combo_empleado();
                checkBox2.Checked = false;
                comboBox1.Text = "Seleccione";
                comboBox1.Enabled = false;

            }
            else
            {
                comboBox1.Text = "Seleccione";
                comboBox1.Enabled = false;
                // Cbx_Empleado.Items.Clear();
                checkBox2.Checked = false;
                checkBox1.Checked = false;

                Cbx_Empleado.DataSource = null;
                Cbx_Empleado.Items.Clear();
            }
            // checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked.Equals(true))
            {
                comboBox1.Text = "Seleccione";
                checkBox1.Checked = false;
                checkBox2.Checked = true;

                comboBox1.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true & checkBox2.Checked != true)
            {
                string[] consulta = { "*", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value) };
                reprorte(consulta);
            }
            else if (checkBox1.Checked == true)
            {
                string[] consulta = { "Empleado", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value), Cbx_Empleado.SelectedValue.ToString() };
                reprorte(consulta);
            }
            else if (checkBox2.Checked == true)
            {
                string[] consulta = { "Ciudad", Convert.ToString(Txt_Desde.Value), Convert.ToString(Txt_Hasta.Value), comboBox1.Text };
                reprorte(consulta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Envio_Informacion("1", "angel.aucancela1993@gmail.com", "", "", "");
        }
    }
}
