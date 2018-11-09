using System.Configuration;

namespace Banorte.Adquiriente.Api
{
   public class UserSetting : ApplicationSettingsBase
   {
      [UserScopedSetting]
      [DefaultSettingValue("gHx9E3iG729DHl8G")]
      public string ClientSecret
      {
         get { return (string)this[nameof(ClientSecret)]; }
         set { this[nameof(ClientSecret)] = value; }
      }

      [UserScopedSetting]
      [DefaultSettingValue("YLNMenKA836d6kdQd9AjVa9qPbXqLlQM")]
      public string ClientId
      {
         get { return (string)this[nameof(ClientId)]; }
         set { this[nameof(ClientId)] = value; }
      }

      [UserScopedSetting]
      [DefaultSettingValue("api-cert.banorte.com")]
      public string ApiHost
      {
         get { return (string)this[nameof(ApiHost)]; }
         set { this[nameof(ApiHost)] = value; }
      }

      [UserScopedSetting]
      [DefaultSettingValue("/cert")]
      public string ContextName
      {
         get { return (string)this[nameof(ContextName)]; }
         set { this[nameof(ContextName)] = value; }
      }

      [UserScopedSetting]
      [DefaultSettingValue("LlavePrivada.pem")]
      public string PrivateKeyFilename
      {
         get { return (string)this[nameof(PrivateKeyFilename)]; }
         set { this[nameof(PrivateKeyFilename)] = value; }
      }

      [UserScopedSetting]
      [DefaultSettingValue("true")]
      public bool HideJwtToken
      {
         get { return (bool)this[nameof(HideJwtToken)]; }
         set { this[nameof(HideJwtToken)] = value; }
      }

      [UserScopedSetting]
      [DefaultSettingValue("true")]
      public bool SaveRequestResponse
      {
         get { return (bool)this[nameof(SaveRequestResponse)]; }
         set { this[nameof(SaveRequestResponse)] = value; }
      }
   }
}
