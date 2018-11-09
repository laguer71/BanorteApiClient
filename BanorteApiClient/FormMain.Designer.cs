namespace Banorte.Adquiriente.Api
{
   partial class FormMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.labelResponse = new System.Windows.Forms.Label();
         this.labelPayload = new System.Windows.Forms.Label();
         this.labelJwtToken = new System.Windows.Forms.Label();
         this.textJwtToken = new System.Windows.Forms.RichTextBox();
         this.groupParametros = new System.Windows.Forms.GroupBox();
         this.checkSaceOutput = new System.Windows.Forms.CheckBox();
         this.buttonPost = new System.Windows.Forms.Button();
         this.labelClientSecret = new System.Windows.Forms.Label();
         this.textClientSecret = new System.Windows.Forms.TextBox();
         this.labelClientId = new System.Windows.Forms.Label();
         this.textClientId = new System.Windows.Forms.TextBox();
         this.labelHost = new System.Windows.Forms.Label();
         this.textHost = new System.Windows.Forms.TextBox();
         this.labelContext = new System.Windows.Forms.Label();
         this.textContext = new System.Windows.Forms.TextBox();
         this.labelPrivateKeyFile = new System.Windows.Forms.Label();
         this.textPrivateKeyFile = new System.Windows.Forms.TextBox();
         this.buttonPrivateKeyFile = new System.Windows.Forms.Button();
         this.KeyFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.labelURL = new System.Windows.Forms.Label();
         this.textURL = new System.Windows.Forms.TextBox();
         this.labelOperacion = new System.Windows.Forms.Label();
         this.comboOperacion = new System.Windows.Forms.ComboBox();
         this.statusMain = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
         this.splitRequestResponse = new System.Windows.Forms.SplitContainer();
         this.splitRequest = new System.Windows.Forms.SplitContainer();
         this.layoutJwtToken = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.layoutPayload = new System.Windows.Forms.TableLayoutPanel();
         this.textBody = new System.Windows.Forms.RichTextBox();
         this.layoutResponse = new System.Windows.Forms.TableLayoutPanel();
         this.textResponse = new System.Windows.Forms.RichTextBox();
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tokenJWTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ventaNormal = new Banorte.Adquiriente.Api.VentaNormalControl();
         this.ventaForzada = new Banorte.Adquiriente.Api.VentaForzadaControl();
         this.groupParametros.SuspendLayout();
         this.statusMain.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitRequestResponse)).BeginInit();
         this.splitRequestResponse.Panel1.SuspendLayout();
         this.splitRequestResponse.Panel2.SuspendLayout();
         this.splitRequestResponse.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitRequest)).BeginInit();
         this.splitRequest.Panel1.SuspendLayout();
         this.splitRequest.Panel2.SuspendLayout();
         this.splitRequest.SuspendLayout();
         this.layoutJwtToken.SuspendLayout();
         this.layoutPayload.SuspendLayout();
         this.layoutResponse.SuspendLayout();
         this.menuStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // labelResponse
         // 
         this.labelResponse.Location = new System.Drawing.Point(3, 0);
         this.labelResponse.Name = "labelResponse";
         this.labelResponse.Size = new System.Drawing.Size(100, 20);
         this.labelResponse.TabIndex = 0;
         this.labelResponse.Text = "&Response";
         // 
         // labelPayload
         // 
         this.labelPayload.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelPayload.Location = new System.Drawing.Point(3, 0);
         this.labelPayload.Name = "labelPayload";
         this.labelPayload.Size = new System.Drawing.Size(389, 20);
         this.labelPayload.TabIndex = 0;
         this.labelPayload.Text = "&Body:";
         // 
         // labelJwtToken
         // 
         this.labelJwtToken.Location = new System.Drawing.Point(0, 0);
         this.labelJwtToken.Name = "labelJwtToken";
         this.labelJwtToken.Size = new System.Drawing.Size(100, 23);
         this.labelJwtToken.TabIndex = 0;
         // 
         // textJwtToken
         // 
         this.textJwtToken.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textJwtToken.Location = new System.Drawing.Point(3, 23);
         this.textJwtToken.Name = "textJwtToken";
         this.textJwtToken.Size = new System.Drawing.Size(389, 92);
         this.textJwtToken.TabIndex = 0;
         this.textJwtToken.Text = "";
         // 
         // groupParametros
         // 
         this.groupParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupParametros.Controls.Add(this.checkSaceOutput);
         this.groupParametros.Controls.Add(this.buttonPost);
         this.groupParametros.Controls.Add(this.labelClientSecret);
         this.groupParametros.Controls.Add(this.textClientSecret);
         this.groupParametros.Controls.Add(this.labelClientId);
         this.groupParametros.Controls.Add(this.textClientId);
         this.groupParametros.Controls.Add(this.labelHost);
         this.groupParametros.Controls.Add(this.textHost);
         this.groupParametros.Controls.Add(this.labelContext);
         this.groupParametros.Controls.Add(this.textContext);
         this.groupParametros.Controls.Add(this.labelPrivateKeyFile);
         this.groupParametros.Controls.Add(this.textPrivateKeyFile);
         this.groupParametros.Controls.Add(this.buttonPrivateKeyFile);
         this.groupParametros.Location = new System.Drawing.Point(12, 12);
         this.groupParametros.MaximumSize = new System.Drawing.Size(776, 100);
         this.groupParametros.MinimumSize = new System.Drawing.Size(656, 100);
         this.groupParametros.Name = "groupParametros";
         this.groupParametros.Size = new System.Drawing.Size(776, 100);
         this.groupParametros.TabIndex = 0;
         this.groupParametros.TabStop = false;
         this.groupParametros.Text = "Parametros del API";
         // 
         // checkSaceOutput
         // 
         this.checkSaceOutput.AutoSize = true;
         this.checkSaceOutput.Location = new System.Drawing.Point(481, 73);
         this.checkSaceOutput.Name = "checkSaceOutput";
         this.checkSaceOutput.Size = new System.Drawing.Size(152, 17);
         this.checkSaceOutput.TabIndex = 12;
         this.checkSaceOutput.Text = "Salvar Request/Response";
         this.checkSaceOutput.UseVisualStyleBackColor = true;
         // 
         // buttonPost
         // 
         this.buttonPost.Location = new System.Drawing.Point(399, 69);
         this.buttonPost.Name = "buttonPost";
         this.buttonPost.Size = new System.Drawing.Size(75, 23);
         this.buttonPost.TabIndex = 11;
         this.buttonPost.Text = "&POST";
         this.buttonPost.UseVisualStyleBackColor = true;
         this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
         // 
         // labelClientSecret
         // 
         this.labelClientSecret.AutoSize = true;
         this.labelClientSecret.Location = new System.Drawing.Point(7, 25);
         this.labelClientSecret.Name = "labelClientSecret";
         this.labelClientSecret.Size = new System.Drawing.Size(67, 13);
         this.labelClientSecret.TabIndex = 0;
         this.labelClientSecret.Text = "Client &Secret";
         // 
         // textClientSecret
         // 
         this.textClientSecret.Location = new System.Drawing.Point(92, 19);
         this.textClientSecret.Name = "textClientSecret";
         this.textClientSecret.Size = new System.Drawing.Size(268, 20);
         this.textClientSecret.TabIndex = 1;
         // 
         // labelClientId
         // 
         this.labelClientId.AutoSize = true;
         this.labelClientId.Location = new System.Drawing.Point(7, 48);
         this.labelClientId.Name = "labelClientId";
         this.labelClientId.Size = new System.Drawing.Size(45, 13);
         this.labelClientId.TabIndex = 2;
         this.labelClientId.Text = "Client &Id";
         // 
         // textClientId
         // 
         this.textClientId.Location = new System.Drawing.Point(92, 45);
         this.textClientId.Name = "textClientId";
         this.textClientId.Size = new System.Drawing.Size(268, 20);
         this.textClientId.TabIndex = 3;
         // 
         // labelHost
         // 
         this.labelHost.Location = new System.Drawing.Point(366, 22);
         this.labelHost.Name = "labelHost";
         this.labelHost.Size = new System.Drawing.Size(50, 23);
         this.labelHost.TabIndex = 4;
         this.labelHost.Text = "&Host:";
         // 
         // textHost
         // 
         this.textHost.Location = new System.Drawing.Point(422, 19);
         this.textHost.Name = "textHost";
         this.textHost.Size = new System.Drawing.Size(200, 20);
         this.textHost.TabIndex = 5;
         this.textHost.TextChanged += new System.EventHandler(this.textHost_TextChanged);
         // 
         // labelContext
         // 
         this.labelContext.Location = new System.Drawing.Point(366, 43);
         this.labelContext.Name = "labelContext";
         this.labelContext.Size = new System.Drawing.Size(50, 23);
         this.labelContext.TabIndex = 6;
         this.labelContext.Text = "Conte&xt";
         // 
         // textContext
         // 
         this.textContext.Location = new System.Drawing.Point(422, 45);
         this.textContext.Name = "textContext";
         this.textContext.Size = new System.Drawing.Size(200, 20);
         this.textContext.TabIndex = 7;
         this.textContext.TextChanged += new System.EventHandler(this.textContext_TextChanged);
         // 
         // labelPrivateKeyFile
         // 
         this.labelPrivateKeyFile.Location = new System.Drawing.Point(7, 71);
         this.labelPrivateKeyFile.Name = "labelPrivateKeyFile";
         this.labelPrivateKeyFile.Size = new System.Drawing.Size(79, 23);
         this.labelPrivateKeyFile.TabIndex = 8;
         this.labelPrivateKeyFile.Text = "&Llave Privada";
         // 
         // textPrivateKeyFile
         // 
         this.textPrivateKeyFile.Location = new System.Drawing.Point(92, 71);
         this.textPrivateKeyFile.Name = "textPrivateKeyFile";
         this.textPrivateKeyFile.Size = new System.Drawing.Size(271, 20);
         this.textPrivateKeyFile.TabIndex = 9;
         // 
         // buttonPrivateKeyFile
         // 
         this.buttonPrivateKeyFile.Location = new System.Drawing.Point(369, 69);
         this.buttonPrivateKeyFile.Name = "buttonPrivateKeyFile";
         this.buttonPrivateKeyFile.Size = new System.Drawing.Size(24, 23);
         this.buttonPrivateKeyFile.TabIndex = 10;
         this.buttonPrivateKeyFile.Text = "...";
         this.buttonPrivateKeyFile.Click += new System.EventHandler(this.buttonPrivateKeyFile_Click);
         // 
         // KeyFileDialog
         // 
         this.KeyFileDialog.DefaultExt = "pem";
         this.KeyFileDialog.FileName = "LlavePrivada.Pem";
         this.KeyFileDialog.Filter = "Llaves Privadas (*.pem)|*.pem|Archivos de Texto (*.txt)|*.txt|Todos los Archivos " +
    "(*.*)|*.*";
         // 
         // labelURL
         // 
         this.labelURL.AutoSize = true;
         this.labelURL.Location = new System.Drawing.Point(256, 119);
         this.labelURL.Name = "labelURL";
         this.labelURL.Size = new System.Drawing.Size(65, 13);
         this.labelURL.TabIndex = 1;
         this.labelURL.Text = "URI Destino";
         // 
         // textURL
         // 
         this.textURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textURL.Enabled = false;
         this.textURL.Location = new System.Drawing.Point(327, 116);
         this.textURL.Name = "textURL";
         this.textURL.Size = new System.Drawing.Size(461, 20);
         this.textURL.TabIndex = 2;
         // 
         // labelOperacion
         // 
         this.labelOperacion.AutoSize = true;
         this.labelOperacion.Location = new System.Drawing.Point(22, 119);
         this.labelOperacion.Name = "labelOperacion";
         this.labelOperacion.Size = new System.Drawing.Size(59, 13);
         this.labelOperacion.TabIndex = 3;
         this.labelOperacion.Text = "&Operación:";
         // 
         // comboOperacion
         // 
         this.comboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboOperacion.FormattingEnabled = true;
         this.comboOperacion.Location = new System.Drawing.Point(87, 116);
         this.comboOperacion.Name = "comboOperacion";
         this.comboOperacion.Size = new System.Drawing.Size(163, 21);
         this.comboOperacion.TabIndex = 4;
         this.comboOperacion.SelectedIndexChanged += new System.EventHandler(this.comboOperacion_SelectedIndexChanged);
         // 
         // statusMain
         // 
         this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime});
         this.statusMain.Location = new System.Drawing.Point(0, 428);
         this.statusMain.Name = "statusMain";
         this.statusMain.Size = new System.Drawing.Size(800, 22);
         this.statusMain.TabIndex = 5;
         this.statusMain.Text = "statusStrip1";
         // 
         // toolStripStatusLabelTime
         // 
         this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
         this.toolStripStatusLabelTime.Size = new System.Drawing.Size(0, 17);
         // 
         // splitRequestResponse
         // 
         this.splitRequestResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.splitRequestResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitRequestResponse.Location = new System.Drawing.Point(0, 143);
         this.splitRequestResponse.Name = "splitRequestResponse";
         // 
         // splitRequestResponse.Panel1
         // 
         this.splitRequestResponse.Panel1.Controls.Add(this.splitRequest);
         // 
         // splitRequestResponse.Panel2
         // 
         this.splitRequestResponse.Panel2.AutoScroll = true;
         this.splitRequestResponse.Panel2.Controls.Add(this.layoutResponse);
         this.splitRequestResponse.Size = new System.Drawing.Size(800, 282);
         this.splitRequestResponse.SplitterDistance = 397;
         this.splitRequestResponse.TabIndex = 6;
         // 
         // splitRequest
         // 
         this.splitRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitRequest.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitRequest.Location = new System.Drawing.Point(0, 0);
         this.splitRequest.Name = "splitRequest";
         this.splitRequest.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitRequest.Panel1
         // 
         this.splitRequest.Panel1.Controls.Add(this.layoutJwtToken);
         // 
         // splitRequest.Panel2
         // 
         this.splitRequest.Panel2.Controls.Add(this.layoutPayload);
         this.splitRequest.Size = new System.Drawing.Size(397, 282);
         this.splitRequest.SplitterDistance = 120;
         this.splitRequest.TabIndex = 0;
         // 
         // layoutJwtToken
         // 
         this.layoutJwtToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
         this.layoutJwtToken.Controls.Add(this.label1, 0, 0);
         this.layoutJwtToken.Controls.Add(this.textJwtToken, 0, 1);
         this.layoutJwtToken.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutJwtToken.Location = new System.Drawing.Point(0, 0);
         this.layoutJwtToken.Name = "layoutJwtToken";
         this.layoutJwtToken.RowCount = 2;
         this.layoutJwtToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.layoutJwtToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.layoutJwtToken.Size = new System.Drawing.Size(395, 118);
         this.layoutJwtToken.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(64, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Token J&WT";
         // 
         // layoutPayload
         // 
         this.layoutPayload.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
         this.layoutPayload.Controls.Add(this.labelPayload, 0, 0);
         this.layoutPayload.Controls.Add(this.textBody, 0, 1);
         this.layoutPayload.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutPayload.Location = new System.Drawing.Point(0, 0);
         this.layoutPayload.Name = "layoutPayload";
         this.layoutPayload.RowCount = 2;
         this.layoutPayload.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.layoutPayload.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.layoutPayload.Size = new System.Drawing.Size(395, 156);
         this.layoutPayload.TabIndex = 0;
         // 
         // textBody
         // 
         this.textBody.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBody.Location = new System.Drawing.Point(3, 23);
         this.textBody.Name = "textBody";
         this.textBody.Size = new System.Drawing.Size(389, 130);
         this.textBody.TabIndex = 0;
         this.textBody.Text = "";
         // 
         // layoutResponse
         // 
         this.layoutResponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 433F));
         this.layoutResponse.Controls.Add(this.labelResponse, 0, 0);
         this.layoutResponse.Controls.Add(this.textResponse, 0, 1);
         this.layoutResponse.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutResponse.Location = new System.Drawing.Point(0, 0);
         this.layoutResponse.Name = "layoutResponse";
         this.layoutResponse.RowCount = 2;
         this.layoutResponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.layoutResponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.layoutResponse.Size = new System.Drawing.Size(397, 280);
         this.layoutResponse.TabIndex = 0;
         // 
         // textResponse
         // 
         this.textResponse.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textResponse.Location = new System.Drawing.Point(3, 23);
         this.textResponse.Name = "textResponse";
         this.textResponse.Size = new System.Drawing.Size(427, 254);
         this.textResponse.TabIndex = 0;
         this.textResponse.Text = "";
         // 
         // menuStrip
         // 
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.verToolStripMenuItem});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Size = new System.Drawing.Size(800, 24);
         this.menuStrip.TabIndex = 7;
         this.menuStrip.Text = "menuStrip1";
         // 
         // archivoToolStripMenuItem
         // 
         this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
         this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
         this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
         this.archivoToolStripMenuItem.Text = "&Archivo";
         // 
         // salirToolStripMenuItem
         // 
         this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
         this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
         this.salirToolStripMenuItem.Text = "&Salir";
         this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem});
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
         this.editToolStripMenuItem.Text = "&Editar";
         // 
         // cortarToolStripMenuItem
         // 
         this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
         this.cortarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
         this.cortarToolStripMenuItem.Text = "Cortar";
         // 
         // copiarToolStripMenuItem
         // 
         this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
         this.copiarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
         this.copiarToolStripMenuItem.Text = "Copiar";
         // 
         // pegarToolStripMenuItem
         // 
         this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
         this.pegarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
         this.pegarToolStripMenuItem.Text = "Pegar";
         // 
         // verToolStripMenuItem
         // 
         this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tokenJWTToolStripMenuItem});
         this.verToolStripMenuItem.Name = "verToolStripMenuItem";
         this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
         this.verToolStripMenuItem.Text = "&Ver";
         // 
         // tokenJWTToolStripMenuItem
         // 
         this.tokenJWTToolStripMenuItem.Name = "tokenJWTToolStripMenuItem";
         this.tokenJWTToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
         this.tokenJWTToolStripMenuItem.Text = "Token JWT";
         this.tokenJWTToolStripMenuItem.Click += new System.EventHandler(this.tokenJWTToolStripMenuItem_Click);
         // 
         // ventaNormal
         // 
         this.ventaNormal.AutoScroll = true;
         this.ventaNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.ventaNormal.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ventaNormal.Location = new System.Drawing.Point(0, 0);
         this.ventaNormal.Name = "ventaNormal";
         this.ventaNormal.Size = new System.Drawing.Size(359, 280);
         this.ventaNormal.TabIndex = 0;
         // 
         // ventaForzada
         // 
         this.ventaForzada.AutoScroll = true;
         this.ventaForzada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.ventaForzada.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ventaForzada.Location = new System.Drawing.Point(0, 0);
         this.ventaForzada.Name = "ventaForzada";
         this.ventaForzada.Size = new System.Drawing.Size(359, 280);
         this.ventaForzada.TabIndex = 0;
         this.ventaForzada.Visible = false;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.splitRequestResponse);
         this.Controls.Add(this.statusMain);
         this.Controls.Add(this.menuStrip);
         this.Controls.Add(this.comboOperacion);
         this.Controls.Add(this.labelOperacion);
         this.Controls.Add(this.labelURL);
         this.Controls.Add(this.textURL);
         this.Controls.Add(this.groupParametros);
         this.MainMenuStrip = this.menuStrip;
         this.Name = "FormMain";
         this.Text = "Cliente API Adquiriente";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
         this.Load += new System.EventHandler(this.Form_Load);
         this.groupParametros.ResumeLayout(false);
         this.groupParametros.PerformLayout();
         this.statusMain.ResumeLayout(false);
         this.statusMain.PerformLayout();
         this.splitRequestResponse.Panel1.ResumeLayout(false);
         this.splitRequestResponse.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitRequestResponse)).EndInit();
         this.splitRequestResponse.ResumeLayout(false);
         this.splitRequest.Panel1.ResumeLayout(false);
         this.splitRequest.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitRequest)).EndInit();
         this.splitRequest.ResumeLayout(false);
         this.layoutJwtToken.ResumeLayout(false);
         this.layoutJwtToken.PerformLayout();
         this.layoutPayload.ResumeLayout(false);
         this.layoutResponse.ResumeLayout(false);
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupParametros;
      private System.Windows.Forms.Label labelClientSecret;
      private System.Windows.Forms.TextBox textClientSecret;
      private System.Windows.Forms.Label labelClientId;
      private System.Windows.Forms.TextBox textClientId;
      private System.Windows.Forms.Label labelHost;
      private System.Windows.Forms.TextBox textHost;
      private System.Windows.Forms.Label labelContext;
      private System.Windows.Forms.TextBox textContext;
      private System.Windows.Forms.Label labelPrivateKeyFile;
      private System.Windows.Forms.TextBox textPrivateKeyFile;
      private System.Windows.Forms.Button buttonPrivateKeyFile;
      private System.Windows.Forms.OpenFileDialog KeyFileDialog;
      private System.Windows.Forms.Label labelURL;
      private System.Windows.Forms.TextBox textURL;
      private System.Windows.Forms.Label labelOperacion;
      private System.Windows.Forms.ComboBox comboOperacion;
      private System.Windows.Forms.StatusStrip statusMain;
      private System.Windows.Forms.SplitContainer splitRequestResponse;
      private System.Windows.Forms.SplitContainer splitRequest;
      private System.Windows.Forms.RichTextBox textResponse;
      private System.Windows.Forms.RichTextBox textBody;
      private VentaNormalControl ventaNormal;
      private VentaForzadaControl ventaForzada;
      private System.Windows.Forms.Button buttonPost;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
      private System.Windows.Forms.TableLayoutPanel layoutPayload;
      private System.Windows.Forms.TableLayoutPanel layoutResponse;
      private System.Windows.Forms.TableLayoutPanel layoutJwtToken;
      private System.Windows.Forms.Label labelPayload;
      private System.Windows.Forms.Label labelResponse;
      private System.Windows.Forms.Label labelJwtToken;
      private System.Windows.Forms.RichTextBox textJwtToken;
      private System.Windows.Forms.MenuStrip menuStrip;
      private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tokenJWTToolStripMenuItem;
      private System.Windows.Forms.CheckBox checkSaceOutput;
   }
}