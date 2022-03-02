using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecentacionComisiones
{
    public partial class Frm_Reportes : Form
    {
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "C:\\Users\\Sistemas\\Desktop\\Proyectos Precitrol\\Proyectos_Precitrol v2\\ComisionesV3" +
    "\\WindowsFormsApplication1\\PresentacionComisiones\\Reportes V2\\Rpt_ReporteFinal.rp" +
    "t";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1208, 586);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Frm_Reportes
            // 
            this.ClientSize = new System.Drawing.Size(1208, 586);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_Reportes";
            this.ResumeLayout(false);

        }
    }
}
