namespace Ares1.Forms.ListaNegra
{
    partial class FormListaNegra
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
            this.listaNegraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListaNegra1 = new System.Windows.Forms.DataGridView();
            this.listaNegraIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarListaNegra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNegra1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaNegraBindingSource
            // 
            this.listaNegraBindingSource.DataSource = typeof(Ares1.Clases.ListaNegra);
            // 
            // dgvListaNegra1
            // 
            this.dgvListaNegra1.AllowUserToAddRows = false;
            this.dgvListaNegra1.AllowUserToDeleteRows = false;
            this.dgvListaNegra1.AutoGenerateColumns = false;
            this.dgvListaNegra1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaNegra1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listaNegraIdDataGridViewTextBoxColumn1,
            this.matriculaDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.colorDataGridViewTextBoxColumn1,
            this.observacionesDataGridViewTextBoxColumn1});
            this.dgvListaNegra1.DataSource = this.listaNegraBindingSource;
            this.dgvListaNegra1.Location = new System.Drawing.Point(12, 12);
            this.dgvListaNegra1.Name = "dgvListaNegra1";
            this.dgvListaNegra1.ReadOnly = true;
            this.dgvListaNegra1.Size = new System.Drawing.Size(554, 274);
            this.dgvListaNegra1.TabIndex = 2;
            this.dgvListaNegra1.DoubleClick += new System.EventHandler(this.dgvListaNegra1_DoubleClick);
            // 
            // listaNegraIdDataGridViewTextBoxColumn1
            // 
            this.listaNegraIdDataGridViewTextBoxColumn1.DataPropertyName = "ListaNegraId";
            this.listaNegraIdDataGridViewTextBoxColumn1.HeaderText = "ListaNegraId";
            this.listaNegraIdDataGridViewTextBoxColumn1.Name = "listaNegraIdDataGridViewTextBoxColumn1";
            this.listaNegraIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.listaNegraIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // matriculaDataGridViewTextBoxColumn1
            // 
            this.matriculaDataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn1.Name = "matriculaDataGridViewTextBoxColumn1";
            this.matriculaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn1
            // 
            this.marcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn1.Name = "marcaDataGridViewTextBoxColumn1";
            this.marcaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn1
            // 
            this.modeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.Name = "modeloDataGridViewTextBoxColumn1";
            this.modeloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn1
            // 
            this.colorDataGridViewTextBoxColumn1.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn1.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
            this.colorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn1
            // 
            this.observacionesDataGridViewTextBoxColumn1.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.Name = "observacionesDataGridViewTextBoxColumn1";
            this.observacionesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnAgregarListaNegra
            // 
            this.btnAgregarListaNegra.Location = new System.Drawing.Point(594, 123);
            this.btnAgregarListaNegra.Name = "btnAgregarListaNegra";
            this.btnAgregarListaNegra.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarListaNegra.TabIndex = 3;
            this.btnAgregarListaNegra.Text = "Agregar";
            this.btnAgregarListaNegra.UseVisualStyleBackColor = true;
            this.btnAgregarListaNegra.Click += new System.EventHandler(this.btnAgregarListaNegra_Click);
            // 
            // FormListaNegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 298);
            this.Controls.Add(this.btnAgregarListaNegra);
            this.Controls.Add(this.dgvListaNegra1);
            this.Name = "FormListaNegra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elementos en la Lista Negra";
            this.Activated += new System.EventHandler(this.FormListaNegra_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNegra1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource listaNegraBindingSource;
        private System.Windows.Forms.DataGridView dgvListaNegra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaNegraIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAgregarListaNegra;
    }
}