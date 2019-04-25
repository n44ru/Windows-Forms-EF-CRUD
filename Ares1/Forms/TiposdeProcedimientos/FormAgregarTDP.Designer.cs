namespace Ares1.Forms.TiposdeProcedimientos
{
    partial class FormAgregarTDP
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
            this.panelTipodeProcedimientos = new System.Windows.Forms.Panel();
            this.tbDescripcionTDP = new System.Windows.Forms.TextBox();
            this.labelDescripcionTDP = new System.Windows.Forms.Label();
            this.tbNombreTDP = new System.Windows.Forms.TextBox();
            this.labelNombreTDP = new System.Windows.Forms.Label();
            this.btnGuardarTDP = new System.Windows.Forms.Button();
            this.btnEliminarTDP = new System.Windows.Forms.Button();
            this.btnCancelarTDP = new System.Windows.Forms.Button();
            this.panelTipodeProcedimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTipodeProcedimientos
            // 
            this.panelTipodeProcedimientos.Controls.Add(this.tbDescripcionTDP);
            this.panelTipodeProcedimientos.Controls.Add(this.labelDescripcionTDP);
            this.panelTipodeProcedimientos.Controls.Add(this.tbNombreTDP);
            this.panelTipodeProcedimientos.Controls.Add(this.labelNombreTDP);
            this.panelTipodeProcedimientos.Location = new System.Drawing.Point(12, 32);
            this.panelTipodeProcedimientos.Name = "panelTipodeProcedimientos";
            this.panelTipodeProcedimientos.Size = new System.Drawing.Size(200, 215);
            this.panelTipodeProcedimientos.TabIndex = 5;
            // 
            // tbDescripcionTDP
            // 
            this.tbDescripcionTDP.Location = new System.Drawing.Point(13, 138);
            this.tbDescripcionTDP.Name = "tbDescripcionTDP";
            this.tbDescripcionTDP.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcionTDP.TabIndex = 3;
            // 
            // labelDescripcionTDP
            // 
            this.labelDescripcionTDP.AutoSize = true;
            this.labelDescripcionTDP.Location = new System.Drawing.Point(14, 106);
            this.labelDescripcionTDP.Name = "labelDescripcionTDP";
            this.labelDescripcionTDP.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcionTDP.TabIndex = 2;
            this.labelDescripcionTDP.Text = "Descripción:";
            // 
            // tbNombreTDP
            // 
            this.tbNombreTDP.Location = new System.Drawing.Point(13, 43);
            this.tbNombreTDP.Name = "tbNombreTDP";
            this.tbNombreTDP.Size = new System.Drawing.Size(100, 20);
            this.tbNombreTDP.TabIndex = 1;
            // 
            // labelNombreTDP
            // 
            this.labelNombreTDP.AutoSize = true;
            this.labelNombreTDP.Location = new System.Drawing.Point(14, 11);
            this.labelNombreTDP.Name = "labelNombreTDP";
            this.labelNombreTDP.Size = new System.Drawing.Size(47, 13);
            this.labelNombreTDP.TabIndex = 0;
            this.labelNombreTDP.Text = "Nombre:";
            // 
            // btnGuardarTDP
            // 
            this.btnGuardarTDP.Location = new System.Drawing.Point(296, 38);
            this.btnGuardarTDP.Name = "btnGuardarTDP";
            this.btnGuardarTDP.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTDP.TabIndex = 6;
            this.btnGuardarTDP.Text = "Guardar";
            this.btnGuardarTDP.UseVisualStyleBackColor = true;
            this.btnGuardarTDP.Click += new System.EventHandler(this.btnGuardarTDP_Click);
            // 
            // btnEliminarTDP
            // 
            this.btnEliminarTDP.Enabled = false;
            this.btnEliminarTDP.Location = new System.Drawing.Point(296, 117);
            this.btnEliminarTDP.Name = "btnEliminarTDP";
            this.btnEliminarTDP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTDP.TabIndex = 7;
            this.btnEliminarTDP.Text = "Eliminar";
            this.btnEliminarTDP.UseVisualStyleBackColor = true;
            this.btnEliminarTDP.Click += new System.EventHandler(this.btnEliminarTDP_Click);
            // 
            // btnCancelarTDP
            // 
            this.btnCancelarTDP.Location = new System.Drawing.Point(296, 200);
            this.btnCancelarTDP.Name = "btnCancelarTDP";
            this.btnCancelarTDP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTDP.TabIndex = 8;
            this.btnCancelarTDP.Text = "Cancelar";
            this.btnCancelarTDP.UseVisualStyleBackColor = true;
            this.btnCancelarTDP.Click += new System.EventHandler(this.btnCancelarTDP_Click);
            // 
            // FormAgregarTDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 339);
            this.Controls.Add(this.btnCancelarTDP);
            this.Controls.Add(this.btnEliminarTDP);
            this.Controls.Add(this.btnGuardarTDP);
            this.Controls.Add(this.panelTipodeProcedimientos);
            this.Name = "FormAgregarTDP";
            this.Text = "Agregar Tipos de Procedimientos";
            this.panelTipodeProcedimientos.ResumeLayout(false);
            this.panelTipodeProcedimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTipodeProcedimientos;
        private System.Windows.Forms.TextBox tbDescripcionTDP;
        private System.Windows.Forms.Label labelDescripcionTDP;
        private System.Windows.Forms.TextBox tbNombreTDP;
        private System.Windows.Forms.Label labelNombreTDP;
        private System.Windows.Forms.Button btnGuardarTDP;
        private System.Windows.Forms.Button btnEliminarTDP;
        private System.Windows.Forms.Button btnCancelarTDP;
    }
}