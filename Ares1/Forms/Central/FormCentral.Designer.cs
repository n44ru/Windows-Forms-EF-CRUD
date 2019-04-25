namespace Ares1.Forms.Central
{
    partial class FormCentral
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
            this.dgvCentrales = new System.Windows.Forms.DataGridView();
            this.centralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregarCentral = new System.Windows.Forms.Button();
            this.listaNegraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centralIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPhraseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaAlarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentrales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCentrales
            // 
            this.dgvCentrales.AllowUserToAddRows = false;
            this.dgvCentrales.AllowUserToDeleteRows = false;
            this.dgvCentrales.AutoGenerateColumns = false;
            this.dgvCentrales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentrales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.centralIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.iPDataGridViewTextBoxColumn1,
            this.puertoDataGridViewTextBoxColumn1,
            this.passPhraseDataGridViewTextBoxColumn1,
            this.accessCodeDataGridViewTextBoxColumn1,
            this.descripciónDataGridViewTextBoxColumn1,
            this.zonaAlarmaDataGridViewTextBoxColumn});
            this.dgvCentrales.DataSource = this.centralBindingSource;
            this.dgvCentrales.Location = new System.Drawing.Point(12, 40);
            this.dgvCentrales.Name = "dgvCentrales";
            this.dgvCentrales.ReadOnly = true;
            this.dgvCentrales.Size = new System.Drawing.Size(719, 229);
            this.dgvCentrales.TabIndex = 2;
            this.dgvCentrales.DoubleClick += new System.EventHandler(this.dgvCentrales_DoubleClick);
            // 
            // centralBindingSource
            // 
            this.centralBindingSource.DataSource = typeof(Ares1.Clases.Central);
            // 
            // btnAgregarCentral
            // 
            this.btnAgregarCentral.Location = new System.Drawing.Point(656, 275);
            this.btnAgregarCentral.Name = "btnAgregarCentral";
            this.btnAgregarCentral.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCentral.TabIndex = 3;
            this.btnAgregarCentral.Text = "Agregar";
            this.btnAgregarCentral.UseVisualStyleBackColor = true;
            this.btnAgregarCentral.Click += new System.EventHandler(this.btnAgregarCentral_Click);
            // 
            // listaNegraBindingSource
            // 
            this.listaNegraBindingSource.DataSource = typeof(Ares1.Clases.ListaNegra);
            // 
            // centralIdDataGridViewTextBoxColumn
            // 
            this.centralIdDataGridViewTextBoxColumn.DataPropertyName = "CentralId";
            this.centralIdDataGridViewTextBoxColumn.HeaderText = "CentralId";
            this.centralIdDataGridViewTextBoxColumn.Name = "centralIdDataGridViewTextBoxColumn";
            this.centralIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.centralIdDataGridViewTextBoxColumn.Visible = false;
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
            // passPhraseDataGridViewTextBoxColumn1
            // 
            this.passPhraseDataGridViewTextBoxColumn1.DataPropertyName = "PassPhrase";
            this.passPhraseDataGridViewTextBoxColumn1.HeaderText = "PassPhrase";
            this.passPhraseDataGridViewTextBoxColumn1.Name = "passPhraseDataGridViewTextBoxColumn1";
            this.passPhraseDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // accessCodeDataGridViewTextBoxColumn1
            // 
            this.accessCodeDataGridViewTextBoxColumn1.DataPropertyName = "AccessCode";
            this.accessCodeDataGridViewTextBoxColumn1.HeaderText = "AccessCode";
            this.accessCodeDataGridViewTextBoxColumn1.Name = "accessCodeDataGridViewTextBoxColumn1";
            this.accessCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripciónDataGridViewTextBoxColumn1
            // 
            this.descripciónDataGridViewTextBoxColumn1.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn1.Name = "descripciónDataGridViewTextBoxColumn1";
            this.descripciónDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // zonaAlarmaDataGridViewTextBoxColumn
            // 
            this.zonaAlarmaDataGridViewTextBoxColumn.DataPropertyName = "ZonaAlarma";
            this.zonaAlarmaDataGridViewTextBoxColumn.HeaderText = "ZonaAlarma";
            this.zonaAlarmaDataGridViewTextBoxColumn.Name = "zonaAlarmaDataGridViewTextBoxColumn";
            this.zonaAlarmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zonaAlarmaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 417);
            this.Controls.Add(this.btnAgregarCentral);
            this.Controls.Add(this.dgvCentrales);
            this.Name = "FormCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrales";
            this.Activated += new System.EventHandler(this.FormListaNegra_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentrales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNegraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource listaNegraBindingSource;
        private System.Windows.Forms.BindingSource centralBindingSource;
        private System.Windows.Forms.DataGridView dgvCentrales;
        private System.Windows.Forms.Button btnAgregarCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPhraseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaAlarmaDataGridViewTextBoxColumn;
    }
}