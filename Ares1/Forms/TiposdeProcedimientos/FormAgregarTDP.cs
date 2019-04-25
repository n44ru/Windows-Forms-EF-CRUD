using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ares1.Forms;

namespace Ares1.Forms.TiposdeProcedimientos
{
    public partial class FormAgregarTDP : Form
    {
        ModelContext db;
        int id;
        public FormAgregarTDP()
        {
            InitializeComponent();
            db = new ModelContext();
            tbNombreTDP.Focus();
            this.id = 0;
        }
        // Sobrecarga para Editar y Eliminar.
        public FormAgregarTDP(int id)
        {
            InitializeComponent();
            db = new ModelContext();
            btnEliminarTDP.Enabled = true;
            this.id = id;
            LLenarCampos(id);
        }
        private void btnGuardarTDP_Click(object sender, EventArgs e)
        {
            // Recoger Datos y Validar.
            string nombre = tbNombreTDP.Text.Trim();
            string descripcion = tbDescripcionTDP.Text.Trim();
            // Si id=0 entonces inserto, si id>0 entonces actualizo.
            if (ValidarControles())
            {
                if (id == 0)
                {
                    try
                    {
                        var tdp = new Clases.TipoProcedimiento { Nombre = nombre, Descripcion = descripcion };
                        db.TiposProcedimientos.Add(tdp);
                        db.SaveChanges();
                        MessageBox.Show(this, "Datos Guardados Correctamente.");
                        LimpiarControles();
                    }
                    catch
                    {
                        throw new Exception("Error de Conexión a la Base de Datos.");
                    }
                }
                else
                {
                    try
                    {
                        var tdp = ObtenerPorId(id);
                        tdp.Nombre = nombre;
                        tdp.Descripcion = descripcion;
                        db.SaveChanges();
                        MessageBox.Show(this, "Datos Guardados Correctamente.");
                    }
                    catch
                    {
                        throw new Exception("Error de Conexión a la Base de Datos.");
                    }
                }
            }
            
        }
        private void btnEliminarTDP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var tdp = ObtenerPorId(id);
                    db.TiposProcedimientos.Remove(tdp);
                    db.SaveChanges();
                    MessageBox.Show(this, "Datos Eliminados Correctamente.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Este procedimiento esta siendo usado por un Registro de Alarma.");
                }
                
            }
        }
        private void btnCancelarTDP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Métodos Utiles.
        private void LimpiarControles()
        {
            foreach (Control oControls in panelTipodeProcedimientos.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }
        }
        private void LLenarCampos(int id)
        {
            var tdp = ObtenerPorId(id);
            tbNombreTDP.Text = tdp.Nombre;
            tbDescripcionTDP.Text = tdp.Descripcion;
        }
        private Clases.TipoProcedimiento ObtenerPorId(int id)
        {
            return db.TiposProcedimientos.Find(id);
        }
        private bool ValidarControles()
        {
            foreach (Control oControls in panelTipodeProcedimientos.Controls)
            {
                if (oControls is TextBox)
                {
                    if (oControls.Text.Trim() == "")
                    {
                        MessageBox.Show(this, "Existen datos sin Llenar.");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
