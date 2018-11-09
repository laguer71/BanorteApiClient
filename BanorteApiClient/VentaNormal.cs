using System.Collections.Generic;

namespace Banorte.Adquiriente.Api
{
   public class VentaNormal
   {
      public readonly string tipoDeOperacion = "realizar-venta-normal";
      public Datos datos = new Datos();
 
      public class Datos
      {
         public string idTerminal = "";
         public decimal importeTotal = 0.0m;
         public string modoVenta = "";
         public string numeroReferencia = "";
         public string numeroPlastico = "";
         public long periodoExpiracion = 0;
         public string modoEntrada = "";
         public Eci eci = new Eci();
         public IList<DescripcionProducto> descripcionProductos = new List<DescripcionProducto>() { new DescripcionProducto() };
      }

      public class Eci
      {
         public string codigoSeguridad = "";
      }

      public class DescripcionProducto
      {
         public long numeroProducto = 0;
         public string producto = "";
         public long cantidad = 0;
         public decimal precioUnitario = 0.0m;
      }
   }
}
