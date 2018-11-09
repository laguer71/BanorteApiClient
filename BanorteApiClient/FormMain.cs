using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace Banorte.Adquiriente.Api
{
   public partial class FormMain : Form
   {
      private UserSetting userSetting;

      public FormMain()
      {
         InitializeComponent();
      }

      public string ClientSecret { get { return textClientSecret.Text; } }
      private string ClientId { get { return textClientId.Text; } }
      private string ApiHost { get { return textHost.Text; } }
      private string Context { get { return textContext.Text; } }
      private string Scope { get { return "pagos:transacciones"; } }
      public string Audience { get { return "https://" + ApiHost; } }
      public string UrlDestino { get { return Audience + Context; } }
      public string JwtResponseType { get { return "token"; } }
      public ArrayList operaciones { get; } = new ArrayList();

      private void buttonPrivateKeyFile_Click(object sender, EventArgs e)
      {
         KeyFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         KeyFileDialog.FileName = textPrivateKeyFile.Text;
         var result = KeyFileDialog.ShowDialog();
         if (result == DialogResult.OK)
         {
            textPrivateKeyFile.Text = KeyFileDialog.FileName;
         }
      }

      private IPayloadUserInterface PayloadUserInterface
      {
         get
         {
            return splitRequestResponse.Panel1.Controls[comboOperacion.SelectedIndex] as IPayloadUserInterface;
         }
      }

      private void Form_Load(object sender, EventArgs e)
      {
         userSetting = new UserSetting();
         textClientSecret.DataBindings.Add(new Binding(nameof(textClientSecret.Text), userSetting, nameof(userSetting.ClientSecret)));
         textClientId.DataBindings.Add(new Binding(nameof(textClientId.Text), userSetting, nameof(userSetting.ClientId)));
         textContext.DataBindings.Add(new Binding(nameof(textContext.Text), userSetting, nameof(userSetting.ContextName)));
         textHost.DataBindings.Add(new Binding(nameof(textHost.Text), userSetting, nameof(userSetting.ApiHost)));
         textPrivateKeyFile.DataBindings.Add(new Binding(nameof(textPrivateKeyFile.Text), userSetting, nameof(userSetting.PrivateKeyFilename)));
         splitRequest.DataBindings.Add(new Binding(nameof(splitRequest.Panel1Collapsed), userSetting, nameof(userSetting.HideJwtToken)));
         checkSaceOutput.DataBindings.Add(new Binding(nameof(checkSaceOutput.Checked), userSetting, nameof(userSetting.SaveRequestResponse)));
         operaciones.Add(new ApiEndpoint("Cancelación", "/ecommerce/v1/transacciones/cancelar-pago"));
         operaciones.Add(new ApiEndpoint("Devolución Referenciada", "/ecommerce/v1/transacciones/devolucion-referenciada"));
         operaciones.Add(new ApiEndpoint("Devolucion sin Restriccion", "/ecommerce/v1/transacciones/devolucion-sinrestriccion"));
         operaciones.Add(new ApiEndpoint("Posautorizar Pago", "/ecommerce/v1/transacciones/postautorizar-pago"));
         operaciones.Add(new ApiEndpoint("Preautorizar Pago", "/ecommerce/v1/transacciones/preautorizar-pago"));
         operaciones.Add(new ApiEndpoint("Preautorizar Promoción", "/ecommerce/v1/transacciones/preautorizar-promocion"));
         operaciones.Add(new ApiEndpoint("Reautorizar Pago", "/ecommerce/v1/transacciones/reautorizar-pago"));
         operaciones.Add(new ApiEndpoint("Reverso", "/ecommerce/v1/transacciones/reversar-pago"));
         operaciones.Add(new ApiEndpoint("Venta Forzada", "/ecommerce/v1/transacciones/venta-forzada"));
         operaciones.Add(new ApiEndpoint("Venta Normal", "/ecommerce/v1/transacciones/venta-normal"));
         operaciones.Add(new ApiEndpoint("Venta Promoción", "/ecommerce/v1/transacciones/venta-promocion"));
         operaciones.Add(new ApiEndpoint("Verificar Tarjetahabiente", "/ecommerce/v1/transacciones/tarjeta-habiente"));
         operaciones.Add(new ApiEndpoint("Verificar Transacción Previa", "/ecommerce/v1/transacciones/transaccion-previa"));
         comboOperacion.DataSource = operaciones;
         comboOperacion.DisplayMember = "Nombre";
         comboOperacion.ValueMember = "Url";
         comboOperacion.SelectedIndex = -1;
         tokenJWTToolStripMenuItem.Checked = !userSetting.HideJwtToken;
      }

      private void buttonPost_Click(object sender, EventArgs e)
      {
         var client = new ApiClient(ClientSecret, ClientId, ApiHost, Context, Scope, Audience, UrlDestino, textPrivateKeyFile.Text);
         var uri = new Uri(UrlDestino + comboOperacion.SelectedValue.ToString());
         var payload = textBody.Text;
         var stopwatch = new Stopwatch();

         textJwtToken.Text = "";
         textResponse.Text = "";

         UseWaitCursor = true;
         try
         {
            var x = JObject.Parse(textBody.Text);
            stopwatch.Start();

            toolStripStatusLabelTime.Text = "";
            var token = client.GetAuthToken();
            textJwtToken.Text = token.AccessToken;

            var result = client.LlamadaApi(uri, token, payload, checkSaceOutput.Checked);
            textResponse.Text = result;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Ocurrió un Error", MessageBoxButtons.OK);
            textResponse.Text = ex.Message;
         }
         finally
         {
            UseWaitCursor = false;
            stopwatch.Stop();
            toolStripStatusLabelTime.Text = "Tiempo: " + stopwatch.Elapsed.TotalSeconds + " (segundos)";

         }
      }

      private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
      {
         userSetting.Save();
      }

      private void textHost_TextChanged(object sender, EventArgs e)
      {
         textUrlUpdate();
      }

      private void textContext_TextChanged(object sender, EventArgs e)
      {
         textUrlUpdate();
      }

      private void comboOperacion_SelectedIndexChanged(object sender, EventArgs e)
      {
         //foreach (Control control in splitRequestResponse.Panel1.Controls)
         //{
         //   control.Visible = false;
         //   control.Enabled = false;
         //}
         //splitRequestResponse.Panel1.Controls[comboOperacion.SelectedIndex].Visible = true;
         //splitRequestResponse.Panel1.Controls[comboOperacion.SelectedIndex].Enabled = true;
         textUrlUpdate();
      }

      private void textUrlUpdate()
      {
         if (comboOperacion.SelectedIndex != -1)
         {
            textURL.Text = UrlDestino + comboOperacion.SelectedValue.ToString();
         }
         else
         {
            textURL.Text = string.Empty;
         }

      }

      private void tokenJWTToolStripMenuItem_Click(object sender, EventArgs e)
      {
         tokenJWTToolStripMenuItem.Checked = !tokenJWTToolStripMenuItem.Checked;
         userSetting.HideJwtToken = !tokenJWTToolStripMenuItem.Checked;
      }

      private void salirToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
