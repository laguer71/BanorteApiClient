using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banorte.Adquiriente.Api
{
   public partial class VentaNormalControl : UserControl, IPayloadUserInterface
   {
      public VentaNormalControl()
      {
         InitializeComponent();
      }

      public string Endpoint()
      {
         return "/ecommerce/v1/transacciones/venta-normal";
      }

      public string Payload()
      {
         var descProductos = new List<VentaNormal.DescripcionProducto>();
         VentaNormal.DescripcionProducto producto;

         producto = NewMethod(numeroProducto1, 1, cantidad1, producto1, precioUnitario1);
         if (null != producto) { descProductos.Add(producto); }

         producto = NewMethod(numeroProducto2, 2, cantidad2, producto2, precioUnitario2);
         if (null != producto) { descProductos.Add(producto); }

         producto = NewMethod(numeroProducto3, 3, cantidad3, producto3, precioUnitario3);
         if (null != producto) { descProductos.Add(producto); }

         producto = NewMethod(numeroProducto4, 4, cantidad4, producto4, precioUnitario4);
         if (null != producto) { descProductos.Add(producto); }

         producto = NewMethod(numeroProducto5, 5, cantidad5, producto5, precioUnitario5);
         if (null != producto) { descProductos.Add(producto); }

         producto = NewMethod(numeroProducto6, 6, cantidad6, producto6, precioUnitario6);
         if (null != producto) { descProductos.Add(producto); }

         var ventaNormal = new VentaNormal()
         {
            datos = new VentaNormal.Datos()
            {
               idTerminal = textIdTerminal.Text,
               importeTotal = Convert.ToDecimal(textImporteTotal.Text),
               modoVenta = textModoVenta.Text,
               numeroReferencia = textNumeroReferencia.Text,
               numeroPlastico = textNumeroPlastico.Text,
               periodoExpiracion = Convert.ToInt64(textPeriodoExpiracion.Text),
               modoEntrada = textModoEntrada.Text,
               eci = new VentaNormal.Eci()
               {
                  codigoSeguridad = textCodigoSeguridad.Text
               },
               descripcionProductos = descProductos
            }
         };

         return JsonConvert.SerializeObject(ventaNormal);
      }

      private VentaNormal.DescripcionProducto NewMethod(CheckBox numeroProducto, int idx, TextBox cantidad, TextBox producto, TextBox precioUnitario)
      {
         if (numeroProducto.Checked)
         {
            var prod = new VentaNormal.DescripcionProducto()
            {
               numeroProducto = idx,
               cantidad = Convert.ToInt64(cantidad.Text),
               producto = producto.Text,
               precioUnitario = Convert.ToDecimal(precioUnitario.Text)
            };

            return prod;
         }

         return null;
      }

      private void numeroProducto1_CheckedChanged(object sender, EventArgs e)
      {
         toggle(numeroProducto1, producto1, cantidad1, precioUnitario1);
      }

      private void numeroProducto2_CheckedChanged(object sender, EventArgs e)
      {
         toggle(numeroProducto2, producto2, cantidad2, precioUnitario2);
      }

      private void numeroProducto3_CheckedChanged(object sender, EventArgs e)
      {
         toggle(numeroProducto3, producto3, cantidad3, precioUnitario3);
      }

      private void numeroProducto4_CheckedChanged(object sender, EventArgs e)
      {
         toggle(numeroProducto4, producto4, cantidad4, precioUnitario4);
      }

      private void numeroProducto5_CheckedChanged(object sender, EventArgs e)
      {
         toggle(numeroProducto5, producto5, cantidad5, precioUnitario5);
      }

      private void numeroProducto6_CheckedChanged(object sender, EventArgs e)
      {
         toggle(numeroProducto6, producto6, cantidad6, precioUnitario6);
      }

      private void toggle(CheckBox check, TextBox producto, TextBox cantidad, TextBox precio)
      {
         producto.Enabled = check.Checked;
         cantidad.Enabled = check.Checked;
         precio.Enabled = check.Checked;
      }
   }
}
