namespace Banorte.Adquiriente.Api
{
   public class ApiEndpoint
   {
      public string Nombre { get; }
      public string Url { get; }

      public ApiEndpoint(string nombre, string url)
      {
         Nombre = nombre;
         Url = url;
      }
   }
}
