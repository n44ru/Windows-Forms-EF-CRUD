namespace Ares1.Forms.Central
{
    partial class FormAgregarCentral
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
            this.zonaAlarmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProcedimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCentral = new System.Windows.Forms.Panel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcionCentral = new System.Windows.Forms.Label();
            this.tbAccess = new System.Windows.Forms.TextBox();
            this.labelAccessCentral = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.labelPassCentral = new System.Windows.Forms.Label();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.labelPuertoCentral = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.labelIpCentral = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labelNombreCentral = new System.Windows.Forms.Label();
            this.btnAgregarCentral = new System.Windows.Forms.Button();
            this.tabCentral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvZonas = new System.Windows.Forms.DataGridView();
            this.zonaAlarmaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnGuardarCentral = new System.Windows.Forms.Button();
            this.btnEliminarCentral = new System.Windows.Forms.Button();
            this.btnCancelarCentral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zonaAlarmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProcedimientoBindingSource)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.tabCentral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zonaAlarmaBindingSource
            // 
            this.zonaAlarmaBindingSource.DataSource = typeof(Ares1.Clases.ZonaAlarma);
            // 
            // camaraBindingSource
            // 
            this.camaraBindingSource.DataSource = typeof(Ares1.Clases.Camara);
            // 
            // tipoProcedimientoBindingSource
            // 
            this.tipoProcedimientoBindingSource.DataSource = typeof(Ares1.Clases.TipoProcedimiento);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.tbDescripcion);
            this.panelCentral.Controls.Add(this.labelDescripcionCentral);
            this.panelCentral.Controls.Add(this.tbAccess);
            this.panelCentral.Controls.Add(this.labelAccessCentral);
            this.panelCentral.Controls.Add(this.tbPass);
            this.panelCentral.Controls.Add(this.labelPassCentral);
            this.panelCentral.Controls.Add(this.tbPuerto);
            this.panelCentral.Controls.Add(this.labelPuertoCentral);
            this.panelCentral.Controls.Add(this.tbIp);
            this.panelCentral.Controls.Add(this.labelIpCentral);
            this.panelCentral.Controls.Add(this.tbNombre);
            this.panelCentral.Controls.Add(this.labelNombreCentral);
            this.panelCentral.Location = new System.Drawing.Point(31, 40);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(249, 332);
            this.panelCentral.TabIndex = 9;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(31, 274);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(127, 20);
            this.tbDescripcion.TabIndex = 11;
            // 
            // labelDescripcionCentral
            // 
            this.labelDescripcionCentral.AutoSize = true;
            this.labelDescripcionCentral.Location = new System.Drawing.Point(28, 258);
            this.labelDescripcionCentral.Name = "labelDescripcionCentral";
            this.labelDescripcionCentral.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcionCentral.TabIndex = 10;
            this.labelDescripcionCentral.Text = "Descripción:";
            // 
            // tbAccess
            // 
            this.tbAccess.Location = new System.Drawing.Point(33, 230);
            this.tbAccess.Name = "tbAccess";
            this.tbAccess.Size = new System.Drawing.Size(125, 20);
            this.tbAccess.TabIndex = 9;
            // 
            // labelAccessCentral
            // 
            this.labelAccessCentral.AutoSize = true;
            this.labelAccessCentral.Location = new System.Drawing.Point(30, 214);
            this.labelAccessCentral.Name = "labelAccessCentral";
            this.labelAccessCentral.Size = new System.Drawing.Size(70, 13);
            this.labelAccessCentral.TabIndex = 8;
            this.labelAccessCentral.Text = "AccessCode:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(33, 182);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(125, 20);
            this.tbPass.TabIndex = 7;
            // 
            // labelPassCentral
            // 
            this.labelPassCentral.AutoSize = true;
            this.labelPassCentral.Location = new System.Drawing.Point(30, 166);
            this.labelPassCentral.Name = "labelPassCentral";
            this.labelPassCentral.Size = new System.Drawing.Size(66, 13);
            this.labelPassCentral.TabIndex = 6;
            this.labelPassCentral.Text = "PassPhrase:";
            // 
            // tbPuerto
            // 
            this.tbPuerto.Location = new System.Drawing.Point(33, 134);
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(125, 20);
            this.tbPuerto.TabIndex = 5;
            // 
            // labelPuertoCentral
            // 
            this.labelPuertoCentral.AutoSize = true;
            this.labelPuertoCentral.Location = new System.Drawing.Point(30, 118);
            this.labelPuertoCentral.Name = "labelPuertoCentral";
            this.labelPuertoCentral.Size = new System.Drawing.Size(41, 13);
            this.labelPuertoCentral.TabIndex = 4;
            this.labelPuertoCentral.Text = "Puerto:";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(31, 86);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(127, 20);
            this.tbIp.TabIndex = 3;
            // 
            // labelIpCentral
            // 
            this.labelIpCentral.AutoSize = true;
            this.labelIpCentral.Location = new System.Drawing.Point(28, 70);
            this.labelIpCentral.Name = "labelIpCentral";
            this.labelIpCentral.Size = new System.Drawing.Size(20, 13);
            this.labelIpCentral.TabIndex = 2;
            this.labelIpCentral.Text = "IP:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(31, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(127, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // labelNombreCentral
            // 
            this.labelNombreCentral.AutoSize = true;
            this.labelNombreCentral.Location = new System.Drawing.Point(28, 22);
            this.labelNombreCentral.Name = "labelNombreCentral";
            this.labelNombreCentral.Size = new System.Drawing.Size(47, 13);
            this.labelNombreCentral.TabIndex = 0;
            this.labelNombreCentral.Text = "Nombre:";
            // 
            // btnAgregarCentral
            // 
            this.btnAgregarCentral.Location = new System.Drawing.Point(536, 495);
            this.btnAgregarCentral.Name = "btnAgregarCentral";
            this.btnAgregarCentral.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCentral.TabIndex = 10;
            this.btnAgregarCentral.Text = "Agregar";
            this.btnAgregarCentral.UseVisualStyleBackColor = true;
            this.btnAgregarCentral.Click += new System.EventHandler(this.btnAgregarCentral_Click);
            // 
            // tabCentral
            // 
            this.tabCentral.Controls.Add(this.tabPage1);
            this.tabCentral.Location = new System.Drawing.Point(27, 400);
            this.tabCentral.Name = "tabCentral";
            this.tabCentral.SelectedIndex = 0;
            this.tabCentral.Size = new System.Drawing.Size(490, 188);
            this.tabCentral.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvZonas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zonas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvZonas
            // 
            this.dgvZonas.AllowUserToAddRows = false;
            this.dgvZonas.AllowUserToDeleteRows = false;
            this.dgvZonas.AutoGenerateColumns = false;
            this.dgvZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zonaAlarmaIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.centralIdDataGridViewTextBoxColumn,
            this.centralDataGridViewTextBoxColumn,
            this.tipoProcedimientoDataGridViewTextBoxColumn,
            this.camaraDataGridViewTextBoxColumn});
            this.dgvZonas.DataSource = this.zonaAlarmaBindingSource;
            this.dgvZonas.Location = new System.Drawing.Point(6, 6);
            this.dgvZonas.Name = "dgvZonas";
            this.dgvZonas.ReadOnly = true;
            this.dgvZonas.Size = new System.Drawing.Size(438, 150);
            this.dgvZonas.TabIndex = 0;
            this.dgvZonas.DoubleClick += new System.EventHandler(this.dgvZonas_DoubleClick_1);
            // 
            // zonaAlarmaIdDataGridViewTextBoxColumn
            // 
            this.zonaAlarmaIdDataGridViewTextBoxColumn.DataPropertyName = "ZonaAlarmaId";
            this.zonaAlarmaIdDataGridViewTextBoxColumn.HeaderText = "ZonaAlarmaId";
            this.zonaAlarmaIdDataGridViewTextBoxColumn.Name = "zonaAlarmaIdDataGridViewTextBoxColumn";
            this.zonaAlarmaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.zonaAlarmaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centralIdDataGridViewTextBoxColumn
            // 
            this.centralIdDataGridViewTextBoxColumn.DataPropertyName = "CentralId";
            this.centralIdDataGridViewTextBoxColumn.HeaderText = "CentralId";
            this.centralIdDataGridViewTextBoxColumn.Name = "centralIdDataGridViewTextBoxColumn";
            this.centralIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.centralIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // centralDataGridViewTextBoxColumn
            // 
            this.centralDataGridViewTextBoxColumn.DataPropertyName = "Central";
            this.centralDataGridViewTextBoxColumn.HeaderText = "Central";
            this.centralDataGridViewTextBoxColumn.Name = "centralDataGridViewTextBoxColumn";
            this.centralDataGridViewTextBoxColumn.ReadOnly = true;
            this.centralDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoProcedimientoDataGridViewTextBoxColumn
            // 
            this.tipoProcedimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoProcedimiento";
            this.tipoProcedimientoDataGridViewTextBoxColumn.HeaderText = "TipoProcedimiento";
            this.tipoProcedimientoDataGridViewTextBoxColumn.Name = "tipoProcedimientoDataGridViewTextBoxColumn";
            this.tipoProcedimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProcedimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // camaraDataGridViewTextBoxColumn
            // 
            this.camaraDataGridViewTextBoxColumn.DataPropertyName = "Camara";
            this.camaraDataGridViewTextBoxColumn.HeaderText = "Camara";
            this.camaraDataGridViewTextBoxColumn.Name = "camaraDataGridViewTextBoxColumn";
            this.camaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.camaraDataGridViewTextBoxColumn.Visible = false;
            // 
            // centralBindingSource
            // 
            this.centralBindingSource.DataSource = typeof(Ares1.Clases.Central);
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(400, 75);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(75, 23);
            this.btnConexion.TabIndex = 12;
            this.btnConexion.Text = "Probar Conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // btnGuardarCentral
            // 
            this.btnGuardarCentral.Location = new System.Drawing.Point(400, 127);
            this.btnGuardarCentral.Name = "btnGuardarCentral";
            this.btnGuardarCentral.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCentral.TabIndex = 13;
            this.btnGuardarCentral.Text = "Guardar";
            this.btnGuardarCentral.UseVisualStyleBackColor = true;
            this.btnGuardarCentral.Click += new System.EventHandler(this.btnGuardarCentral_Click);
            // 
            // btnEliminarCentral
            // 
            this.btnEliminarCentral.Enabled = false;
            this.btnEliminarCentral.Location = new System.Drawing.Point(400, 197);
            this.btnEliminarCentral.Name = "btnEliminarCentral";
            this.btnEliminarCentral.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCentral.TabIndex = 14;
            this.btnEliminarCentral.Text = "Eliminar";
            this.btnEliminarCentral.UseVisualStyleBackColor = true;
            this.btnEliminarCentral.Click += new System.EventHandler(this.btnEliminarCentral_Click);
            // 
            // btnCancelarCentral
            // 
            this.btnCancelarCentral.Location = new System.Drawing.Point(400, 254);
            this.btnCancelarCentral.Name = "btnCancelarCentral";
            this.btnCancelarCentral.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCentral.TabIndex = 15;
            this.btnCancelarCentral.Text = "Cancelar";
            this.btnCancelarCentral.UseVisualStyleBackColor = true;
            this.btnCancelarCentral.Click += new System.EventHandler(this.btnCancelarCentral_Click);
            // 
            // FormAgregarCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 633);
            this.Controls.Add(this.btnCancelarCentral);
            this.Controls.Add(this.btnEliminarCentral);
            this.Controls.Add(this.btnGuardarCentral);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.tabCentral);
            this.Controls.Add(this.btnAgregarCentral);
            this.Controls.Add(this.panelCentral);
            this.Name = "FormAgregarCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Central";
            this.Activated += new System.EventHandler(this.FormAgregarZonas_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.zonaAlarmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProcedimientoBindingSource)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.tabCentral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource camaraBindingSource;
        private System.Windows.Forms.BindingSource tipoProcedimientoBindingSource;
        private System.Windows.Forms.BindingSource zonaAlarmaBindingSource;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label labelDescripcionCentral;
        private System.Windows.Forms.TextBox tbAccess;
        private System.Windows.Forms.Label labelAccessCentral;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label labelPassCentral;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.Label labelPuertoCentral;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Label labelIpCentral;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelNombreCentral;
        private System.Windows.Forms.Button btnAgregarCentral;
        private System.Windows.Forms.TabControl tabCentral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvZonas;
        private System.Windows.Forms.BindingSource centralBindingSource;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnGuardarCentral;
        private System.Windows.Forms.Button btnEliminarCentral;
        private System.Windows.Forms.Button btnCancelarCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaraDataGridViewTextBoxColumn;
    }
}