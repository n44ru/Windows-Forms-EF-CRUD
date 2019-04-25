namespace Ares1.Forms
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProcedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alarmasToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // alarmasToolStripMenuItem
            // 
            this.alarmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralesToolStripMenuItem,
            this.camarasToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.tiposDeProcedimientosToolStripMenuItem,
            this.listaNegraToolStripMenuItem});
            this.alarmasToolStripMenuItem.Name = "alarmasToolStripMenuItem";
            this.alarmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alarmasToolStripMenuItem.Text = "Alarmas";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registrosToolStripMenuItem.Text = "Registros";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // tiposDeProcedimientosToolStripMenuItem
            // 
            this.tiposDeProcedimientosToolStripMenuItem.Name = "tiposDeProcedimientosToolStripMenuItem";
            this.tiposDeProcedimientosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.tiposDeProcedimientosToolStripMenuItem.Text = "Tipos de Procedimientos";
            this.tiposDeProcedimientosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeProcedimientosToolStripMenuItem_Click);
            // 
            // listaNegraToolStripMenuItem
            // 
            this.listaNegraToolStripMenuItem.Name = "listaNegraToolStripMenuItem";
            this.listaNegraToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listaNegraToolStripMenuItem.Text = "Lista negra";
            this.listaNegraToolStripMenuItem.Click += new System.EventHandler(this.listaNegraToolStripMenuItem_Click);
            // 
            // centralesToolStripMenuItem
            // 
            this.centralesToolStripMenuItem.Name = "centralesToolStripMenuItem";
            this.centralesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.centralesToolStripMenuItem.Text = "Centrales";
            this.centralesToolStripMenuItem.Click += new System.EventHandler(this.centralesToolStripMenuItem_Click);
            // 
            // camarasToolStripMenuItem
            // 
            this.camarasToolStripMenuItem.Name = "camarasToolStripMenuItem";
            this.camarasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.camarasToolStripMenuItem.Text = "Camaras";
            this.camarasToolStripMenuItem.Click += new System.EventHandler(this.camarasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProcedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNegraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camarasToolStripMenuItem;
    }
}