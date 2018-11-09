namespace Banorte.Adquiriente.Api
{
   public class VentaForzada
   {
      public string tipoDeOperacion { get { return "realizar-venta-forzada"; } }
      public Datos datos = new Datos();

      public class Datos
      {
         public string idTerminal = "";
         public decimal importeTotal = 0.0m;
         public string modoVenta = "";
         public string numeroControl = "";
         public string referenciaClienteDos = "";
         public string referenciaClienteUno = "";
         public string referenciaClienteTres = "";
         public string referenciaClienteCuatro = "";
         public string referenciaClienteCinco = "";
         public string numeroPlastico = "";
         public long periodoExpiracion = 0;
         public long codigoSeguridad = 0;
         public string modoEntrada = "";
         public string loteTransacciones = "";
         public string url = "";
         public string idioma = "";
         public string subAfiliacion = "";
         public string idAgregador = "";
         public string codigoAutorizacion = "";
      }
   }
}