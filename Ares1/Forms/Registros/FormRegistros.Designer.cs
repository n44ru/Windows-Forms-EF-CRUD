namespace Ares1.Forms.Registros
{
    partial class FormRegistros
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
            this.components = new System.ComponentModel.Container();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.registroAlarmaIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAtiendeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguimientoProcedimientoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaSeguimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vecinoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimientodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaAlarmadgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoClipsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroAlarmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvVideoClips = new System.Windows.Forms.DataGridView();
            this.videoClipIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroAlarmaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroAlarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoClipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicioR = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.labelFinR = new System.Windows.Forms.Label();
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.labelResultadoR = new System.Windows.Forms.Label();
            this.cbSeguimientoR = new System.Windows.Forms.CheckBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.labelUsuarioR = new System.Windows.Forms.Label();
            this.cbTipoDeAlarma = new System.Windows.Forms.ComboBox();
            this.labelTipoAlarmaR = new System.Windows.Forms.Label();
            this.cbZonaAlarm = new System.Windows.Forms.ComboBox();
            this.labelZonaAlarmaR = new System.Windows.Forms.Label();
            this.labelFechaSegR = new System.Windows.Forms.Label();
            this.labelObsR = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.tbVecin = new System.Windows.Forms.TextBox();
            this.labelVecinoR = new System.Windows.Forms.Label();
            this.dtSegInicio = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtsegFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAlarmaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoClips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoClipBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.AutoGenerateColumns = false;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroAlarmaIdDataGridViewTextBoxColumn2,
            this.fechaRegistroDataGridViewTextBoxColumn1,
            this.usuarioAtiendeDataGridViewTextBoxColumn1,
            this.seguimientoProcedimientoDataGridViewCheckBoxColumn1,
            this.fechaSeguimientoDataGridViewTextBoxColumn1,
            this.resultadDataGridViewTextBoxColumn1,
            this.observacionesDataGridViewTextBoxColumn1,
            this.vecinoDataGridViewTextBoxColumn1,
            this.tipoProcedimientodgv,
            this.zonaAlarmadgv,
            this.videoClipsDataGridViewTextBoxColumn1});
            this.dgvRegistro.DataSource = this.registroAlarmaBindingSource;
            this.dgvRegistro.Location = new System.Drawing.Point(23, 303);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.Size = new System.Drawing.Size(803, 150);
            this.dgvRegistro.TabIndex = 4;
            // 
            // registroAlarmaIdDataGridViewTextBoxColumn2
            // 
            this.registroAlarmaIdDataGridViewTextBoxColumn2.DataPropertyName = "RegistroAlarmaId";
            this.registroAlarmaIdDataGridViewTextBoxColumn2.HeaderText = "RegistroAlarmaId";
            this.registroAlarmaIdDataGridViewTextBoxColumn2.Name = "registroAlarmaIdDataGridViewTextBoxColumn2";
            this.registroAlarmaIdDataGridViewTextBoxColumn2.ReadOnly = true;
            this.registroAlarmaIdDataGridViewTextBoxColumn2.Visible = false;
            // 
            // fechaRegistroDataGridViewTextBoxColumn1
            // 
            this.fechaRegistroDataGridViewTextBoxColumn1.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn1.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn1.Name = "fechaRegistroDataGridViewTextBoxColumn1";
            this.fechaRegistroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usuarioAtiendeDataGridViewTextBoxColumn1
            // 
            this.usuarioAtiendeDataGridViewTextBoxColumn1.DataPropertyName = "UsuarioAtiende";
            this.usuarioAtiendeDataGridViewTextBoxColumn1.HeaderText = "UsuarioAtiende";
            this.usuarioAtiendeDataGridViewTextBoxColumn1.Name = "usuarioAtiendeDataGridViewTextBoxColumn1";
            this.usuarioAtiendeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // seguimientoProcedimientoDataGridViewCheckBoxColumn1
            // 
            this.seguimientoProcedimientoDataGridViewCheckBoxColumn1.DataPropertyName = "SeguimientoProcedimiento";
            this.seguimientoProcedimientoDataGridViewCheckBoxColumn1.HeaderText = "SeguimientoProcedimiento";
            this.seguimientoProcedimientoDataGridViewCheckBoxColumn1.Name = "seguimientoProcedimientoDataGridViewCheckBoxColumn1";
            this.seguimientoProcedimientoDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // fechaSeguimientoDataGridViewTextBoxColumn1
            // 
            this.fechaSeguimientoDataGridViewTextBoxColumn1.DataPropertyName = "FechaSeguimiento";
            this.fechaSeguimientoDataGridViewTextBoxColumn1.HeaderText = "FechaSeguimiento";
            this.fechaSeguimientoDataGridViewTextBoxColumn1.Name = "fechaSeguimientoDataGridViewTextBoxColumn1";
            this.fechaSeguimientoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // resultadDataGridViewTextBoxColumn1
            // 
            this.resultadDataGridViewTextBoxColumn1.DataPropertyName = "Resultad";
            this.resultadDataGridViewTextBoxColumn1.HeaderText = "Resultad";
            this.resultadDataGridViewTextBoxColumn1.Name = "resultadDataGridViewTextBoxColumn1";
            this.resultadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn1
            // 
            this.observacionesDataGridViewTextBoxColumn1.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.Name = "observacionesDataGridViewTextBoxColumn1";
            this.observacionesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vecinoDataGridViewTextBoxColumn1
            // 
            this.vecinoDataGridViewTextBoxColumn1.DataPropertyName = "Vecino";
            this.vecinoDataGridViewTextBoxColumn1.HeaderText = "Vecino";
            this.vecinoDataGridViewTextBoxColumn1.Name = "vecinoDataGridViewTextBoxColumn1";
            this.vecinoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoProcedimientodgv
            // 
            this.tipoProcedimientodgv.HeaderText = "TipoProcedimiento";
            this.tipoProcedimientodgv.Name = "tipoProcedimientodgv";
            this.tipoProcedimientodgv.ReadOnly = true;
            // 
            // zonaAlarmadgv
            // 
            this.zonaAlarmadgv.HeaderText = "ZonaAlarma";
            this.zonaAlarmadgv.Name = "zonaAlarmadgv";
            this.zonaAlarmadgv.ReadOnly = true;
            // 
            // videoClipsDataGridViewTextBoxColumn1
            // 
            this.videoClipsDataGridViewTextBoxColumn1.DataPropertyName = "VideoClips";
            this.videoClipsDataGridViewTextBoxColumn1.HeaderText = "VideoClips";
            this.videoClipsDataGridViewTextBoxColumn1.Name = "videoClipsDataGridViewTextBoxColumn1";
            this.videoClipsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // registroAlarmaBindingSource
            // 
            this.registroAlarmaBindingSource.DataSource = typeof(Ares1.Clases.RegistroAlarma);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(23, 477);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 182);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvVideoClips);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video Clip";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvVideoClips
            // 
            this.dgvVideoClips.AllowUserToAddRows = false;
            this.dgvVideoClips.AllowUserToDeleteRows = false;
            this.dgvVideoClips.AutoGenerateColumns = false;
            this.dgvVideoClips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideoClips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoClipIdDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.registroAlarmaIdDataGridViewTextBoxColumn,
            this.registroAlarmaDataGridViewTextBoxColumn});
            this.dgvVideoClips.DataSource = this.videoClipBindingSource;
            this.dgvVideoClips.Location = new System.Drawing.Point(6, 17);
            this.dgvVideoClips.Name = "dgvVideoClips";
            this.dgvVideoClips.ReadOnly = true;
            this.dgvVideoClips.Size = new System.Drawing.Size(496, 128);
            this.dgvVideoClips.TabIndex = 0;
            // 
            // videoClipIdDataGridViewTextBoxColumn
            // 
            this.videoClipIdDataGridViewTextBoxColumn.DataPropertyName = "VideoClipId";
            this.videoClipIdDataGridViewTextBoxColumn.HeaderText = "VideoClipId";
            this.videoClipIdDataGridViewTextBoxColumn.Name = "videoClipIdDataGridViewTextBoxColumn";
            this.videoClipIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.videoClipIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registroAlarmaIdDataGridViewTextBoxColumn
            // 
            this.registroAlarmaIdDataGridViewTextBoxColumn.DataPropertyName = "RegistroAlarmaId";
            this.registroAlarmaIdDataGridViewTextBoxColumn.HeaderText = "RegistroAlarmaId";
            this.registroAlarmaIdDataGridViewTextBoxColumn.Name = "registroAlarmaIdDataGridViewTextBoxColumn";
            this.registroAlarmaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.registroAlarmaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // registroAlarmaDataGridViewTextBoxColumn
            // 
            this.registroAlarmaDataGridViewTextBoxColumn.DataPropertyName = "RegistroAlarma";
            this.registroAlarmaDataGridViewTextBoxColumn.HeaderText = "RegistroAlarma";
            this.registroAlarmaDataGridViewTextBoxColumn.Name = "registroAlarmaDataGridViewTextBoxColumn";
            this.registroAlarmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.registroAlarmaDataGridViewTextBoxColumn.Visible = false;
            // 
            // videoClipBindingSource
            // 
            this.videoClipBindingSource.DataSource = typeof(Ares1.Clases.VideoClip);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(18, 44);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // labelFechaInicioR
            // 
            this.labelFechaInicioR.AutoSize = true;
            this.labelFechaInicioR.Location = new System.Drawing.Point(19, 15);
            this.labelFechaInicioR.Name = "labelFechaInicioR";
            this.labelFechaInicioR.Size = new System.Drawing.Size(68, 13);
            this.labelFechaInicioR.TabIndex = 1;
            this.labelFechaInicioR.Text = "Fecha Inicio:";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(251, 44);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 2;
            // 
            // labelFinR
            // 
            this.labelFinR.AutoSize = true;
            this.labelFinR.Location = new System.Drawing.Point(248, 15);
            this.labelFinR.Name = "labelFinR";
            this.labelFinR.Size = new System.Drawing.Size(57, 13);
            this.labelFinR.TabIndex = 3;
            this.labelFinR.Text = "Fecha Fin:";
            // 
            // cbResult
            // 
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.cbResult.Location = new System.Drawing.Point(484, 43);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(121, 21);
            this.cbResult.TabIndex = 4;
            // 
            // labelResultadoR
            // 
            this.labelResultadoR.AutoSize = true;
            this.labelResultadoR.Location = new System.Drawing.Point(481, 15);
            this.labelResultadoR.Name = "labelResultadoR";
            this.labelResultadoR.Size = new System.Drawing.Size(58, 13);
            this.labelResultadoR.TabIndex = 5;
            this.labelResultadoR.Text = "Resultado:";
            // 
            // cbSeguimientoR
            // 
            this.cbSeguimientoR.AutoSize = true;
            this.cbSeguimientoR.Location = new System.Drawing.Point(646, 45);
            this.cbSeguimientoR.Name = "cbSeguimientoR";
            this.cbSeguimientoR.Size = new System.Drawing.Size(84, 17);
            this.cbSeguimientoR.TabIndex = 6;
            this.cbSeguimientoR.Text = "Seguimiento";
            this.cbSeguimientoR.UseVisualStyleBackColor = true;
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "admin"});
            this.cbUser.Location = new System.Drawing.Point(18, 111);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(121, 21);
            this.cbUser.TabIndex = 7;
            // 
            // labelUsuarioR
            // 
            this.labelUsuarioR.AutoSize = true;
            this.labelUsuarioR.Location = new System.Drawing.Point(19, 84);
            this.labelUsuarioR.Name = "labelUsuarioR";
            this.labelUsuarioR.Size = new System.Drawing.Size(46, 13);
            this.labelUsuarioR.TabIndex = 8;
            this.labelUsuarioR.Text = "Usuario:";
            // 
            // cbTipoDeAlarma
            // 
            this.cbTipoDeAlarma.FormattingEnabled = true;
            this.cbTipoDeAlarma.Location = new System.Drawing.Point(196, 111);
            this.cbTipoDeAlarma.Name = "cbTipoDeAlarma";
            this.cbTipoDeAlarma.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeAlarma.TabIndex = 9;
            // 
            // labelTipoAlarmaR
            // 
            this.labelTipoAlarmaR.AutoSize = true;
            this.labelTipoAlarmaR.Location = new System.Drawing.Point(193, 84);
            this.labelTipoAlarmaR.Name = "labelTipoAlarmaR";
            this.labelTipoAlarmaR.Size = new System.Drawing.Size(78, 13);
            this.labelTipoAlarmaR.TabIndex = 10;
            this.labelTipoAlarmaR.Text = "Tipo de Alarma";
            // 
            // cbZonaAlarm
            // 
            this.cbZonaAlarm.FormattingEnabled = true;
            this.cbZonaAlarm.Location = new System.Drawing.Point(369, 111);
            this.cbZonaAlarm.Name = "cbZonaAlarm";
            this.cbZonaAlarm.Size = new System.Drawing.Size(121, 21);
            this.cbZonaAlarm.TabIndex = 11;
            // 
            // labelZonaAlarmaR
            // 
            this.labelZonaAlarmaR.AutoSize = true;
            this.labelZonaAlarmaR.Location = new System.Drawing.Point(366, 84);
            this.labelZonaAlarmaR.Name = "labelZonaAlarmaR";
            this.labelZonaAlarmaR.Size = new System.Drawing.Size(67, 13);
            this.labelZonaAlarmaR.TabIndex = 12;
            this.labelZonaAlarmaR.Text = "Zona Alarma";
            // 
            // labelFechaSegR
            // 
            this.labelFechaSegR.AutoSize = true;
            this.labelFechaSegR.Location = new System.Drawing.Point(19, 155);
            this.labelFechaSegR.Name = "labelFechaSegR";
            this.labelFechaSegR.Size = new System.Drawing.Size(144, 13);
            this.labelFechaSegR.TabIndex = 14;
            this.labelFechaSegR.Text = "Fecha de Seguimiento Inicio:";
            // 
            // labelObsR
            // 
            this.labelObsR.AutoSize = true;
            this.labelObsR.Location = new System.Drawing.Point(491, 155);
            this.labelObsR.Name = "labelObsR";
            this.labelObsR.Size = new System.Drawing.Size(81, 13);
            this.labelObsR.TabIndex = 16;
            this.labelObsR.Text = "Observaciones:";
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(494, 180);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(100, 20);
            this.tbObs.TabIndex = 17;
            // 
            // tbVecin
            // 
            this.tbVecin.Location = new System.Drawing.Point(627, 180);
            this.tbVecin.Name = "tbVecin";
            this.tbVecin.Size = new System.Drawing.Size(100, 20);
            this.tbVecin.TabIndex = 18;
            // 
            // labelVecinoR
            // 
            this.labelVecinoR.AutoSize = true;
            this.labelVecinoR.Location = new System.Drawing.Point(624, 155);
            this.labelVecinoR.Name = "labelVecinoR";
            this.labelVecinoR.Size = new System.Drawing.Size(43, 13);
            this.labelVecinoR.TabIndex = 19;
            this.labelVecinoR.Text = "Vecino:";
            // 
            // dtSegInicio
            // 
            this.dtSegInicio.Location = new System.Drawing.Point(18, 180);
            this.dtSegInicio.Name = "dtSegInicio";
            this.dtSegInicio.Size = new System.Drawing.Size(200, 20);
            this.dtSegInicio.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtsegFin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtSegInicio);
            this.panel1.Controls.Add(this.labelVecinoR);
            this.panel1.Controls.Add(this.tbVecin);
            this.panel1.Controls.Add(this.tbObs);
            this.panel1.Controls.Add(this.labelObsR);
            this.panel1.Controls.Add(this.labelFechaSegR);
            this.panel1.Controls.Add(this.labelZonaAlarmaR);
            this.panel1.Controls.Add(this.cbZonaAlarm);
            this.panel1.Controls.Add(this.labelTipoAlarmaR);
            this.panel1.Controls.Add(this.cbTipoDeAlarma);
            this.panel1.Controls.Add(this.labelUsuarioR);
            this.panel1.Controls.Add(this.cbUser);
            this.panel1.Controls.Add(this.cbSeguimientoR);
            this.panel1.Controls.Add(this.labelResultadoR);
            this.panel1.Controls.Add(this.cbResult);
            this.panel1.Controls.Add(this.labelFinR);
            this.panel1.Controls.Add(this.dtFin);
            this.panel1.Controls.Add(this.labelFechaInicioR);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 222);
            this.panel1.TabIndex = 6;
            // 
            // dtsegFin
            // 
            this.dtsegFin.Location = new System.Drawing.Point(247, 180);
            this.dtsegFin.Name = "dtsegFin";
            this.dtsegFin.Size = new System.Drawing.Size(200, 20);
            this.dtsegFin.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha de Seguimiento Fin:";
            // 
            // btnBuscarRegistro
            // 
            this.btnBuscarRegistro.Location = new System.Drawing.Point(395, 252);
            this.btnBuscarRegistro.Name = "btnBuscarRegistro";
            this.btnBuscarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRegistro.TabIndex = 7;
            this.btnBuscarRegistro.Text = "Buscar";
            this.btnBuscarRegistro.UseVisualStyleBackColor = true;
            this.btnBuscarRegistro.Click += new System.EventHandler(this.btnBuscarRegistro_Click);
            // 
            // FormRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 671);
            this.Controls.Add(this.btnBuscarRegistro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvRegistro);
            this.Name = "FormRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.FormRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAlarmaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoClips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoClipBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource registroAlarmaBindingSource;
        private System.Windows.Forms.BindingSource videoClipBindingSource;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvVideoClips;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoClipIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroAlarmaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroAlarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label labelFechaInicioR;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label labelFinR;
        private System.Windows.Forms.ComboBox cbResult;
        private System.Windows.Forms.Label labelResultadoR;
        private System.Windows.Forms.CheckBox cbSeguimientoR;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label labelUsuarioR;
        private System.Windows.Forms.ComboBox cbTipoDeAlarma;
        private System.Windows.Forms.Label labelTipoAlarmaR;
        private System.Windows.Forms.ComboBox cbZonaAlarm;
        private System.Windows.Forms.Label labelZonaAlarmaR;
        private System.Windows.Forms.Label labelFechaSegR;
        private System.Windows.Forms.Label labelObsR;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.TextBox tbVecin;
        private System.Windows.Forms.Label labelVecinoR;
        private System.Windows.Forms.DateTimePicker dtSegInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtsegFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroAlarmaIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAtiendeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seguimientoProcedimientoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSeguimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vecinoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimientodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmadgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoClipsDataGridViewTextBoxColumn1;
    }
}