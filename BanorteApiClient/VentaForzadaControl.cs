using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Banorte.Adquiriente.Api
{
   public partial class VentaForzadaControl : UserControl, IPayloadUserInterface
   {
      public VentaForzadaControl()
      {
         InitializeComponent();
      }

      public string Endpoint()
      {
         return "/ecommerce/v1/transacciones/venta-forzada";
      }

      public string Payload()
      {
         var ventaForazada = new VentaForzada()
         {
            datos = new VentaForzada.Datos()
            {
               idTerminal = textIdTerminal.Text,
               importeTotal = Convert.ToDecimal(textImporteTotal.Text),
               modoVenta = textModoVenta.Text,
               numeroControl = textNumeroControl.Text,
               referenciaClienteDos = textReferenciaClienteDos.Text,
               referenciaClienteUno = textReferenciaClienteUno.Text,
               referenciaClienteTres = textReferenciaClienteTres.Text,
               referenciaClienteCuatro = textReferenciaClienteCuatro.Text,
               referenciaClienteCinco = textReferenciaClienteCinco.Text,
               numeroPlastico = textNumeroPlastico.Text,
               periodoExpiracion = Convert.ToInt64(textPeriodoExpiracion.Text),
               codigoSeguridad = Convert.ToInt64(textCodigoSeguridad.Text),
               modoEntrada = textModoEntrada.Text,
               loteTransacciones = textLoteTransacciones.Text,
               url = textUrl.Text,
               idioma = textIdioma.Text,
               subAfiliacion = textSubAfiliacion.Text,
               idAgregador = textIdAgregador.Text,
               codigoAutorizacion = textCodigoAutorizacion.Text
            }
         };

         return JsonConvert.SerializeObject(ventaForazada);
      }
   }
}
