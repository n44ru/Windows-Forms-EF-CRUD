namespace Ares1.Forms.Camaras
{
    partial class FormAgregarCamaras
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
            this.panelCamaras = new System.Windows.Forms.Panel();
            this.cbZonaAlarma = new System.Windows.Forms.ComboBox();
            this.labelZonaAlarma = new System.Windows.Forms.Label();
            this.cbTipodeCamara = new System.Windows.Forms.ComboBox();
            this.labelTipodeCamara = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.labelUrlCamaras = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPasswordCamaras = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuarioCamaras = new System.Windows.Forms.Label();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.labelPuertoCamaras = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.labelIpCamaras = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labelNombreCamaras = new System.Windows.Forms.Label();
            this.btnGuardarCamara = new System.Windows.Forms.Button();
            this.btnEliminarCamara = new System.Windows.Forms.Button();
            this.btnCancelarCamara = new System.Windows.Forms.Button();
            this.chbRelacion = new System.Windows.Forms.CheckBox();
            this.panelCamaras.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamaras
            // 
            this.panelCamaras.Controls.Add(this.chbRelacion);
            this.panelCamaras.Controls.Add(this.cbZonaAlarma);
            this.panelCamaras.Controls.Add(this.labelZonaAlarma);
            this.panelCamaras.Controls.Add(this.cbTipodeCamara);
            this.panelCamaras.Controls.Add(this.labelTipodeCamara);
            this.panelCamaras.Controls.Add(this.tbUrl);
            this.panelCamaras.Controls.Add(this.labelUrlCamaras);
            this.panelCamaras.Controls.Add(this.tbPassword);
            this.panelCamaras.Controls.Add(this.labelPasswordCamaras);
            this.panelCamaras.Controls.Add(this.tbUsuario);
            this.panelCamaras.Controls.Add(this.labelUsuarioCamaras);
            this.panelCamaras.Controls.Add(this.tbPuerto);
            this.panelCamaras.Controls.Add(this.labelPuertoCamaras);
            this.panelCamaras.Controls.Add(this.tbIp);
            this.panelCamaras.Controls.Add(this.labelIpCamaras);
            this.panelCamaras.Controls.Add(this.tbNombre);
            this.panelCamaras.Controls.Add(this.labelNombreCamaras);
            this.panelCamaras.Location = new System.Drawing.Point(12, 12);
            this.panelCamaras.Name = "panelCamaras";
            this.panelCamaras.Size = new System.Drawing.Size(262, 450);
            this.panelCamaras.TabIndex = 5;
            // 
            // cbZonaAlarma
            // 
            this.cbZonaAlarma.Enabled = false;
            this.cbZonaAlarma.FormattingEnabled = true;
            this.cbZonaAlarma.Location = new System.Drawing.Point(19, 414);
            this.cbZonaAlarma.Name = "cbZonaAlarma";
            this.cbZonaAlarma.Size = new System.Drawing.Size(145, 21);
            this.cbZonaAlarma.TabIndex = 15;
            this.cbZonaAlarma.Visible = false;
            // 
            // labelZonaAlarma
            // 
            this.labelZonaAlarma.AutoSize = true;
            this.labelZonaAlarma.Enabled = false;
            this.labelZonaAlarma.Location = new System.Drawing.Point(16, 392);
            this.labelZonaAlarma.Name = "labelZonaAlarma";
            this.labelZonaAlarma.Size = new System.Drawing.Size(64, 13);
            this.labelZonaAlarma.TabIndex = 14;
            this.labelZonaAlarma.Text = "ZonaAlarma";
            this.labelZonaAlarma.Visible = false;
            // 
            // cbTipodeCamara
            // 
            this.cbTipodeCamara.FormattingEnabled = true;
            this.cbTipodeCamara.Items.AddRange(new object[] {
            "Control de acceso",
            "Visualización"});
            this.cbTipodeCamara.Location = new System.Drawing.Point(19, 324);
            this.cbTipodeCamara.Name = "cbTipodeCamara";
            this.cbTipodeCamara.Size = new System.Drawing.Size(145, 21);
            this.cbTipodeCamara.TabIndex = 13;
            // 
            // labelTipodeCamara
            // 
            this.labelTipodeCamara.AutoSize = true;
            this.labelTipodeCamara.Location = new System.Drawing.Point(16, 301);
            this.labelTipodeCamara.Name = "labelTipodeCamara";
            this.labelTipodeCamara.Size = new System.Drawing.Size(82, 13);
            this.labelTipodeCamara.TabIndex = 12;
            this.labelTipodeCamara.Text = "Tipo de Camara";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(19, 268);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(145, 20);
            this.tbUrl.TabIndex = 11;
            // 
            // labelUrlCamaras
            // 
            this.labelUrlCamaras.AutoSize = true;
            this.labelUrlCamaras.Location = new System.Drawing.Point(16, 252);
            this.labelUrlCamaras.Name = "labelUrlCamaras";
            this.labelUrlCamaras.Size = new System.Drawing.Size(48, 13);
            this.labelUrlCamaras.TabIndex = 10;
            this.labelUrlCamaras.Text = "Url_Rstp";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(19, 216);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // labelPasswordCamaras
            // 
            this.labelPasswordCamaras.AutoSize = true;
            this.labelPasswordCamaras.Location = new System.Drawing.Point(16, 200);
            this.labelPasswordCamaras.Name = "labelPasswordCamaras";
            this.labelPasswordCamaras.Size = new System.Drawing.Size(53, 13);
            this.labelPasswordCamaras.TabIndex = 8;
            this.labelPasswordCamaras.Text = "Password";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(19, 169);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(145, 20);
            this.tbUsuario.TabIndex = 7;
            // 
            // labelUsuarioCamaras
            // 
            this.labelUsuarioCamaras.AutoSize = true;
            this.labelUsuarioCamaras.Location = new System.Drawing.Point(16, 153);
            this.labelUsuarioCamaras.Name = "labelUsuarioCamaras";
            this.labelUsuarioCamaras.Size = new System.Drawing.Size(43, 13);
            this.labelUsuarioCamaras.TabIndex = 6;
            this.labelUsuarioCamaras.Text = "Usuario";
            // 
            // tbPuerto
            // 
            this.tbPuerto.Location = new System.Drawing.Point(19, 130);
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(145, 20);
            this.tbPuerto.TabIndex = 5;
            // 
            // labelPuertoCamaras
            // 
            this.labelPuertoCamaras.AutoSize = true;
            this.labelPuertoCamaras.Location = new System.Drawing.Point(16, 114);
            this.labelPuertoCamaras.Name = "labelPuertoCamaras";
            this.labelPuertoCamaras.Size = new System.Drawing.Size(38, 13);
            this.labelPuertoCamaras.TabIndex = 4;
            this.labelPuertoCamaras.Text = "Puerto";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(19, 82);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(145, 20);
            this.tbIp.TabIndex = 3;
            // 
            // labelIpCamaras
            // 
            this.labelIpCamaras.AutoSize = true;
            this.labelIpCamaras.Location = new System.Drawing.Point(16, 66);
            this.labelIpCamaras.Name = "labelIpCamaras";
            this.labelIpCamaras.Size = new System.Drawing.Size(17, 13);
            this.labelIpCamaras.TabIndex = 2;
            this.labelIpCamaras.Text = "IP";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(19, 30);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(145, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // labelNombreCamaras
            // 
            this.labelNombreCamaras.AutoSize = true;
            this.labelNombreCamaras.Location = new System.Drawing.Point(16, 14);
            this.labelNombreCamaras.Name = "labelNombreCamaras";
            this.labelNombreCamaras.Size = new System.Drawing.Size(47, 13);
            this.labelNombreCamaras.TabIndex = 0;
            this.labelNombreCamaras.Text = "Nombre:";
            // 
            // btnGuardarCamara
            // 
            this.btnGuardarCamara.Location = new System.Drawing.Point(294, 42);
            this.btnGuardarCamara.Name = "btnGuardarCamara";
            this.btnGuardarCamara.Size = new System.Drawing.Size(75, 29);
            this.btnGuardarCamara.TabIndex = 6;
            this.btnGuardarCamara.Text = "Guardar";
            this.btnGuardarCamara.UseVisualStyleBackColor = true;
            this.btnGuardarCamara.Click += new System.EventHandler(this.btnGuardarCamara_Click);
            // 
            // btnEliminarCamara
            // 
            this.btnEliminarCamara.Enabled = false;
            this.btnEliminarCamara.Location = new System.Drawing.Point(294, 93);
            this.btnEliminarCamara.Name = "btnEliminarCamara";
            this.btnEliminarCamara.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarCamara.TabIndex = 7;
            this.btnEliminarCamara.Text = "Eliminar";
            this.btnEliminarCamara.UseVisualStyleBackColor = true;
            this.btnEliminarCamara.Click += new System.EventHandler(this.btnEliminarCamara_Click);
            // 
            // btnCancelarCamara
            // 
            this.btnCancelarCamara.Location = new System.Drawing.Point(294, 153);
            this.btnCancelarCamara.Name = "btnCancelarCamara";
            this.btnCancelarCamara.Size = new System.Drawing.Size(77, 28);
            this.btnCancelarCamara.TabIndex = 8;
            this.btnCancelarCamara.Text = "Cancelar";
            this.btnCancelarCamara.UseVisualStyleBackColor = true;
            this.btnCancelarCamara.Click += new System.EventHandler(this.btnCancelarCamara_Click);
            // 
            // chbRelacion
            // 
            this.chbRelacion.AutoSize = true;
            this.chbRelacion.Enabled = false;
            this.chbRelacion.Location = new System.Drawing.Point(19, 363);
            this.chbRelacion.Name = "chbRelacion";
            this.chbRelacion.Size = new System.Drawing.Size(168, 17);
            this.chbRelacion.TabIndex = 9;
            this.chbRelacion.Text = "Pertenece a una Zona Alarma";
            this.chbRelacion.UseVisualStyleBackColor = true;
            this.chbRelacion.Visible = false;
            this.chbRelacion.Click += new System.EventHandler(this.chbRelacion_Click);
            // 
            // FormAgregarCamaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 474);
            this.Controls.Add(this.btnCancelarCamara);
            this.Controls.Add(this.btnEliminarCamara);
            this.Controls.Add(this.btnGuardarCamara);
            this.Controls.Add(this.panelCamaras);
            this.Name = "FormAgregarCamaras";
            this.Text = "Agregar Camara";
            this.panelCamaras.ResumeLayout(false);
            this.panelCamaras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCamaras;
        private System.Windows.Forms.Label labelTipodeCamara;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label labelUrlCamaras;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPasswordCamaras;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label labelUsuarioCamaras;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.Label labelPuertoCamaras;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Label labelIpCamaras;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelNombreCamaras;
        private System.Windows.Forms.ComboBox cbTipodeCamara;
        private System.Windows.Forms.Button btnGuardarCamara;
        private System.Windows.Forms.Button btnEliminarCamara;
        private System.Windows.Forms.Button btnCancelarCamara;
        private System.Windows.Forms.Label labelZonaAlarma;
        private System.Windows.Forms.ComboBox cbZonaAlarma;
        private System.Windows.Forms.CheckBox chbRelacion;
    }
}