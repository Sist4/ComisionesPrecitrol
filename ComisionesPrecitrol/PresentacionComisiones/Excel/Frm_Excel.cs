using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel =Microsoft.Office.Interop.Excel;
using System.IO;

namespace PrecentacionComisiones.Excel
{
    public partial class Frm_Excel : Form
    {
        const string fileName = "C:\\Book1.xlsx";
        const string topLeft = "A1";
        const string bottomRight = "A4";
        const string graphTitle = "Graph Title";
        const string xAxis = "Time";
        const string yAxis = "Value";
        private void Cargar_Excel()
        {
            
         
               // Excel.Application xlApp = new Excel.Application();

          

        }
       
        public Frm_Excel()
        {
            InitializeComponent();
        }



        private void Frm_Excel_Load(object sender, EventArgs e)
        {

        }


    }
}
