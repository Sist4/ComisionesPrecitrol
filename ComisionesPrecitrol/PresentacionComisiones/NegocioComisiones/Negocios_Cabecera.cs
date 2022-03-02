using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosComisiones;

namespace NegociosComisiones
{
   public class Negocios_Cabecera
    {
        Datos_Cabecera Cabecera = new Datos_Cabecera();

        public int Insertas_Cabecera(string Cab_NFactura, string Cab_Estado, string Cab_FEmision, string Cab_FVencimiento, string Cab_RazonSocial, string Cab_RazonSocial2, string Cab_Valor, string Cab_Ruc, string Recibo_Cobro)
        {
            return Cabecera.Insertas_Cabecera(Cab_NFactura, Cab_Estado, Cab_FEmision, Cab_FVencimiento, Cab_RazonSocial, Cab_RazonSocial2, Cab_Valor, Cab_Ruc, Recibo_Cobro);
        }

        public bool Consulta_Factura(string NFactura)
        {
            return Cabecera.Consulta_Factura(NFactura);
        }

        public bool Consulta_FacturaM(string Cab_NFactura)
        {
            return Cabecera.Consulta_FacturaM(Cab_NFactura);

        }
    }
}

