namespace Ares1.Forms.TiposdeProcedimientos
{
    partial class FormTiposdeProcedimientos
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
            this.dgvTDP = new System.Windows.Forms.DataGridView();
            this.tipoProcedimientoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTDP = new System.Windows.Forms.Button();
            this.camaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaNegraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProcedimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTDP
            // 
            this.dgvTDP.AllowUserToAddRows = false;
            this.dgvTDP.AllowUserToDeleteRows = false;
            this.dgvTDP.AutoGenerateColumns = false;
            this.dgvTDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoProcedimientoIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvTDP.DataSource = this.tipoProcedimientoBindingSource;
            this.dgvTDP.Location = new System.Drawing.Point(12, 24);
            this.dgvTDP.Name = "dgvTDP";
            this.dgvTDP.ReadOnly = true;
            this.dgvTDP.Size = new System.Drawing.Size(458, 168);
            this.dgvTDP.TabIndex = 2;
            this.dgvTDP.DoubleClick += new System.EventHandler(this.dgvTDP_DoubleClick);
            // 
            // tipoProcedimientoIdDataGridViewTextBoxColumn
            // 
            this.tipoProcedimientoIdDataGridViewTextBoxColumn.DataPropertyName = "TipoProcedimientoId";
            this.tipoProcedimientoIdDataGridViewTextBoxColumn.HeaderText = "TipoProcedimientoId";
            this.tipoProcedimientoIdDataGridViewTextBoxColumn.Name = "tipoProcedimientoIdDataGridViewTextBoxColumn";
            this.tipoProcedimientoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProcedimientoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProcedimientoBindingSource
            // 
            this.tipoProcedimientoBindingSource.DataSource = typeof(Ares1.Clases.TipoProcedimiento);
            // 
            // btnTDP
            // 
            this.btnTDP.Location = new System.Drawing.Point(507, 94);
            this.btnTDP.Name = "btnTDP";
            this.btnTDP.Size = new System.Drawing.Size(75, 23);
            this.btnTDP.TabIndex = 3;
            this.btnTDP.Text = "Agregar";
            this.btnTDP.UseVisualStyleBackColor = true;
            this.btnTDP.Click += new System.EventHandler(this.btnTDP_Click);
            // 
            // camaraBindingSource
            // 
            this.camaraBindingSource.DataSource = typeof(Ares1.Clases.Camara);
            // 
            // listaNegraBindingSource
            // 
            this.listaNegraBindingSource.DataSource = typeof(Ares1.Clases.ListaNegra);
            // 
            // FormTiposdeProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 232);
            this.Controls.Add(this.btnTDP);
            this.Controls.Add(this.dgvTDP);
            this.Name = "FormTiposdeProcedimientos";
            this.Text = "Tipos de Procedimientos";
            this.Activated += new System.EventHandler(this.FormListaNegra_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProcedimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource listaNegraBindingSource;
        private System.Windows.Forms.BindingSource camaraBindingSource;
        private System.Windows.Forms.BindingSource tipoProcedimientoBindingSource;
        private System.Windows.Forms.DataGridView dgvTDP;
        private System.Windows.Forms.Button btnTDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimientoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}