namespace Ares1.Forms.ZonasAlarmas
{
    partial class FormAgregarZonas
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
            this.camaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProcedimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelZonas = new System.Windows.Forms.Panel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescZonas = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labelNombreZonas = new System.Windows.Forms.Label();
            this.btnGuardarZonas = new System.Windows.Forms.Button();
            this.btnEliminarZonas = new System.Windows.Forms.Button();
            this.buttonCancelarZonas = new System.Windows.Forms.Button();
            this.tabZonas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCamaras = new System.Windows.Forms.DataGridView();
            this.camaraIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlRstpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCamaraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaAlarmaIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaAlarmaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCamaras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProcedimientoBindingSource)).BeginInit();
            this.panelZonas.SuspendLayout();
            this.tabZonas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).BeginInit();
            this.SuspendLayout();
            // 
            // camaraBindingSource
            // 
            this.camaraBindingSource.DataSource = typeof(Ares1.Clases.Camara);
            // 
            // tipoProcedimientoBindingSource
            // 
            this.tipoProcedimientoBindingSource.DataSource = typeof(Ares1.Clases.TipoProcedimiento);
            // 
            // panelZonas
            // 
            this.panelZonas.Controls.Add(this.tbDescripcion);
            this.panelZonas.Controls.Add(this.labelDescZonas);
            this.panelZonas.Controls.Add(this.tbNombre);
            this.panelZonas.Controls.Add(this.labelNombreZonas);
            this.panelZonas.Location = new System.Drawing.Point(27, 32);
            this.panelZonas.Name = "panelZonas";
            this.panelZonas.Size = new System.Drawing.Size(246, 238);
            this.panelZonas.TabIndex = 7;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(29, 112);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(152, 20);
            this.tbDescripcion.TabIndex = 3;
            // 
            // labelDescZonas
            // 
            this.labelDescZonas.AutoSize = true;
            this.labelDescZonas.Location = new System.Drawing.Point(26, 96);
            this.labelDescZonas.Name = "labelDescZonas";
            this.labelDescZonas.Size = new System.Drawing.Size(63, 13);
            this.labelDescZonas.TabIndex = 2;
            this.labelDescZonas.Text = "Descripción";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(29, 54);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(152, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // labelNombreZonas
            // 
            this.labelNombreZonas.AutoSize = true;
            this.labelNombreZonas.Location = new System.Drawing.Point(26, 38);
            this.labelNombreZonas.Name = "labelNombreZonas";
            this.labelNombreZonas.Size = new System.Drawing.Size(47, 13);
            this.labelNombreZonas.TabIndex = 0;
            this.labelNombreZonas.Text = "Nombre:";
            // 
            // btnGuardarZonas
            // 
            this.btnGuardarZonas.Location = new System.Drawing.Point(320, 83);
            this.btnGuardarZonas.Name = "btnGuardarZonas";
            this.btnGuardarZonas.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarZonas.TabIndex = 8;
            this.btnGuardarZonas.Text = "Guardar";
            this.btnGuardarZonas.UseVisualStyleBackColor = true;
            this.btnGuardarZonas.Click += new System.EventHandler(this.btnGuardarZonas_Click);
            // 
            // btnEliminarZonas
            // 
            this.btnEliminarZonas.Location = new System.Drawing.Point(320, 145);
            this.btnEliminarZonas.Name = "btnEliminarZonas";
            this.btnEliminarZonas.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarZonas.TabIndex = 9;
            this.btnEliminarZonas.Text = "Eliminar";
            this.btnEliminarZonas.UseVisualStyleBackColor = true;
            this.btnEliminarZonas.Click += new System.EventHandler(this.btnEliminarZonas_Click);
            // 
            // buttonCancelarZonas
            // 
            this.buttonCancelarZonas.Location = new System.Drawing.Point(320, 201);
            this.buttonCancelarZonas.Name = "buttonCancelarZonas";
            this.buttonCancelarZonas.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarZonas.TabIndex = 10;
            this.buttonCancelarZonas.Text = "Cancelar";
            this.buttonCancelarZonas.UseVisualStyleBackColor = true;
            this.buttonCancelarZonas.Click += new System.EventHandler(this.buttonCancelarZonas_Click);
            // 
            // tabZonas
            // 
            this.tabZonas.Controls.Add(this.tabPage1);
            this.tabZonas.Location = new System.Drawing.Point(12, 298);
            this.tabZonas.Name = "tabZonas";
            this.tabZonas.SelectedIndex = 0;
            this.tabZonas.Size = new System.Drawing.Size(493, 184);
            this.tabZonas.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCamaras);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Camaras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCamaras
            // 
            this.dgvCamaras.AllowUserToAddRows = false;
            this.dgvCamaras.AllowUserToDeleteRows = false;
            this.dgvCamaras.AutoGenerateColumns = false;
            this.dgvCamaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamaras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.camaraIdDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.iPDataGridViewTextBoxColumn1,
            this.puertoDataGridViewTextBoxColumn1,
            this.usuarioDataGridViewTextBoxColumn1,
            this.passDataGridViewTextBoxColumn1,
            this.urlRstpDataGridViewTextBoxColumn1,
            this.tCamaraDataGridViewTextBoxColumn1,
            this.zonaAlarmaIdDataGridViewTextBoxColumn1,
            this.zonaAlarmaDataGridViewTextBoxColumn1});
            this.dgvCamaras.DataSource = this.camaraBindingSource;
            this.dgvCamaras.Location = new System.Drawing.Point(6, 5);
            this.dgvCamaras.Name = "dgvCamaras";
            this.dgvCamaras.ReadOnly = true;
            this.dgvCamaras.Size = new System.Drawing.Size(473, 150);
            this.dgvCamaras.TabIndex = 0;
            this.dgvCamaras.DoubleClick += new System.EventHandler(this.dgvCamaras_DoubleClick);
            // 
            // camaraIdDataGridViewTextBoxColumn1
            // 
            this.camaraIdDataGridViewTextBoxColumn1.DataPropertyName = "CamaraId";
            this.camaraIdDataGridViewTextBoxColumn1.HeaderText = "CamaraId";
            this.camaraIdDataGridViewTextBoxColumn1.Name = "camaraIdDataGridViewTextBoxColumn1";
            this.camaraIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.camaraIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iPDataGridViewTextBoxColumn1
            // 
            this.iPDataGridViewTextBoxColumn1.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn1.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn1.Name = "iPDataGridViewTextBoxColumn1";
            this.iPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // puertoDataGridViewTextBoxColumn1
            // 
            this.puertoDataGridViewTextBoxColumn1.DataPropertyName = "Puerto";
            this.puertoDataGridViewTextBoxColumn1.HeaderText = "Puerto";
            this.puertoDataGridViewTextBoxColumn1.Name = "puertoDataGridViewTextBoxColumn1";
            this.puertoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            this.usuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn1
            // 
            this.passDataGridViewTextBoxColumn1.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn1.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn1.Name = "passDataGridViewTextBoxColumn1";
            this.passDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urlRstpDataGridViewTextBoxColumn1
            // 
            this.urlRstpDataGridViewTextBoxColumn1.DataPropertyName = "Url_Rstp";
            this.urlRstpDataGridViewTextBoxColumn1.HeaderText = "Url_Rstp";
            this.urlRstpDataGridViewTextBoxColumn1.Name = "urlRstpDataGridViewTextBoxColumn1";
            this.urlRstpDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tCamaraDataGridViewTextBoxColumn1
            // 
            this.tCamaraDataGridViewTextBoxColumn1.DataPropertyName = "TCamara";
            this.tCamaraDataGridViewTextBoxColumn1.HeaderText = "TCamara";
            this.tCamaraDataGridViewTextBoxColumn1.Name = "tCamaraDataGridViewTextBoxColumn1";
            this.tCamaraDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // zonaAlarmaIdDataGridViewTextBoxColumn1
            // 
            this.zonaAlarmaIdDataGridViewTextBoxColumn1.DataPropertyName = "ZonaAlarmaId";
            this.zonaAlarmaIdDataGridViewTextBoxColumn1.HeaderText = "ZonaAlarmaId";
            this.zonaAlarmaIdDataGridViewTextBoxColumn1.Name = "zonaAlarmaIdDataGridViewTextBoxColumn1";
            this.zonaAlarmaIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zonaAlarmaIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // zonaAlarmaDataGridViewTextBoxColumn1
            // 
            this.zonaAlarmaDataGridViewTextBoxColumn1.DataPropertyName = "ZonaAlarma";
            this.zonaAlarmaDataGridViewTextBoxColumn1.HeaderText = "ZonaAlarma";
            this.zonaAlarmaDataGridViewTextBoxColumn1.Name = "zonaAlarmaDataGridViewTextBoxColumn1";
            this.zonaAlarmaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zonaAlarmaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // btnAgregarCamaras
            // 
            this.btnAgregarCamaras.Location = new System.Drawing.Point(511, 374);
            this.btnAgregarCamaras.Name = "btnAgregarCamaras";
            this.btnAgregarCamaras.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCamaras.TabIndex = 12;
            this.btnAgregarCamaras.Text = "Agregar";
            this.btnAgregarCamaras.UseVisualStyleBackColor = true;
            this.btnAgregarCamaras.Click += new System.EventHandler(this.btnAgregarCamaras_Click);
            // 
            // FormAgregarZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 507);
            this.Controls.Add(this.btnAgregarCamaras);
            this.Controls.Add(this.tabZonas);
            this.Controls.Add(this.buttonCancelarZonas);
            this.Controls.Add(this.btnEliminarZonas);
            this.Controls.Add(this.btnGuardarZonas);
            this.Controls.Add(this.panelZonas);
            this.Name = "FormAgregarZonas";
            this.Text = "Agregar Zonas";
            this.Activated += new System.EventHandler(this.FormAgregarZonas_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProcedimientoBindingSource)).EndInit();
            this.panelZonas.ResumeLayout(false);
            this.panelZonas.PerformLayout();
            this.tabZonas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource camaraBindingSource;
        private System.Windows.Forms.BindingSource tipoProcedimientoBindingSource;
        private System.Windows.Forms.Panel panelZonas;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label labelDescZonas;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelNombreZonas;
        private System.Windows.Forms.Button btnGuardarZonas;
        private System.Windows.Forms.Button btnEliminarZonas;
        private System.Windows.Forms.Button buttonCancelarZonas;
        private System.Windows.Forms.TabControl tabZonas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAgregarCamaras;
        private System.Windows.Forms.DataGridView dgvCamaras;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaraIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlRstpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCamaraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmaIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmaDataGridViewTextBoxColumn1;
    }
}