namespace Ares1.Forms.Camaras
{
    partial class FormCamaras
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
            this.dgvCamaras = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.camaraBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.camaraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.centralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaNegraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camaraIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Central = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlRstpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDCamara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaAlarmaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaAlarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamaras
            // 
            this.dgvCamaras.AllowUserToAddRows = false;
            this.dgvCamaras.AllowUserToDeleteRows = false;
            this.dgvCamaras.AutoGenerateColumns = false;
            this.dgvCamaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamaras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.camaraIdDataGridViewTextBoxColumn1,
            this.Central,
            this.Zona,
            this.nombreDataGridViewTextBoxColumn1,
            this.iPDataGridViewTextBoxColumn1,
            this.puertoDataGridViewTextBoxColumn1,
            this.usuarioDataGridViewTextBoxColumn1,
            this.passDataGridViewTextBoxColumn1,
            this.urlRstpDataGridViewTextBoxColumn1,
            this.TDCamara,
            this.zonaAlarmaIdDataGridViewTextBoxColumn,
            this.zonaAlarmaDataGridViewTextBoxColumn});
            this.dgvCamaras.DataSource = this.camaraBindingSource2;
            this.dgvCamaras.Location = new System.Drawing.Point(12, 60);
            this.dgvCamaras.Name = "dgvCamaras";
            this.dgvCamaras.ReadOnly = true;
            this.dgvCamaras.Size = new System.Drawing.Size(707, 274);
            this.dgvCamaras.TabIndex = 3;
            this.dgvCamaras.DoubleClick += new System.EventHandler(this.dgvCamaras_DoubleClick_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(740, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // camaraBindingSource2
            // 
            this.camaraBindingSource2.DataSource = typeof(Ares1.Clases.Camara);
            // 
            // camaraBindingSource1
            // 
            this.camaraBindingSource1.DataSource = typeof(Ares1.Clases.Camara);
            // 
            // centralBindingSource
            // 
            this.centralBindingSource.DataSource = typeof(Ares1.Clases.Central);
            // 
            // listaNegraBindingSource
            // 
            this.listaNegraBindingSource.DataSource = typeof(Ares1.Clases.ListaNegra);
            // 
            // camaraBindingSource
            // 
            this.camaraBindingSource.DataSource = typeof(Ares1.Clases.Camara);
            // 
            // camaraIdDataGridViewTextBoxColumn1
            // 
            this.camaraIdDataGridViewTextBoxColumn1.DataPropertyName = "CamaraId";
            this.camaraIdDataGridViewTextBoxColumn1.HeaderText = "CamaraId";
            this.camaraIdDataGridViewTextBoxColumn1.Name = "camaraIdDataGridViewTextBoxColumn1";
            this.camaraIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.camaraIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Central
            // 
            this.Central.HeaderText = "Central";
            this.Central.Name = "Central";
            this.Central.ReadOnly = true;
            // 
            // Zona
            // 
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            this.Zona.ReadOnly = true;
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
            // TDCamara
            // 
            this.TDCamara.HeaderText = "Tipo de Camara";
            this.TDCamara.Name = "TDCamara";
            this.TDCamara.ReadOnly = true;
            // 
            // zonaAlarmaIdDataGridViewTextBoxColumn
            // 
            this.zonaAlarmaIdDataGridViewTextBoxColumn.DataPropertyName = "ZonaAlarmaId";
            this.zonaAlarmaIdDataGridViewTextBoxColumn.HeaderText = "ZonaAlarmaId";
            this.zonaAlarmaIdDataGridViewTextBoxColumn.Name = "zonaAlarmaIdDataGridViewTextBoxColumn";
            this.zonaAlarmaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.zonaAlarmaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // zonaAlarmaDataGridViewTextBoxColumn
            // 
            this.zonaAlarmaDataGridViewTextBoxColumn.DataPropertyName = "ZonaAlarma";
            this.zonaAlarmaDataGridViewTextBoxColumn.HeaderText = "ZonaAlarma";
            this.zonaAlarmaDataGridViewTextBoxColumn.Name = "zonaAlarmaDataGridViewTextBoxColumn";
            this.zonaAlarmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zonaAlarmaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormCamaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 406);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCamaras);
            this.Name = "FormCamaras";
            this.Text = "Camaras";
            this.Activated += new System.EventHandler(this.FormListaNegra_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource listaNegraBindingSource;
        private System.Windows.Forms.BindingSource centralBindingSource;
        private System.Windows.Forms.BindingSource camaraBindingSource;
        private System.Windows.Forms.BindingSource camaraBindingSource1;
        private System.Windows.Forms.DataGridView dgvCamaras;
        private System.Windows.Forms.BindingSource camaraBindingSource2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaraIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Central;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlRstpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDCamara;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmaDataGridViewTextBoxColumn;
    }
}