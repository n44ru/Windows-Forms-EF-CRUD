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

namespace Ares1.Forms.ListaNegra
{
    public partial class FormAgregarListaNegra : Form
    {
        ModelContext db;
        int id;
        public FormAgregarListaNegra()
        {
            InitializeComponent();
            db = new ModelContext();
            tbMatriculaLN.Focus();
            this.id = 0;
        }
        // Sobrecarga para Editar y Eliminar.
        public FormAgregarListaNegra(int id)
        {
            InitializeComponent();
            db = new ModelContext();
            btnEliminaLN.Enabled = true;
            this.id = id;
            LLenarCampos(id);
        }
        private void btnGuardarLN_Click(object sender, EventArgs e)
        {
            // Recoger Datos y Validar.
            string matricula = tbMatriculaLN.Text.Trim();
            string marca = tbMarcaLN.Text.Trim();
            string modelo = tbModeloLN.Text.Trim();
            string color = tbColorLN.Text.Trim();
            string observaciones = rtbObs.Text.Trim();
            if (ValidarControles())
            {
                // Si id=0 entonces inserto, si id>0 entonces actualizo.
                if (id == 0)
                {
                    try
                    {
                        var listanegra = new Clases.ListaNegra { Matricula = matricula, Marca = marca, Modelo = modelo, Color = color, Observaciones = observaciones };
                        db.ListasNegras.Add(listanegra);
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
                        var listanegraactualizar = ObtenerPorId(id);
                        listanegraactualizar.Matricula = matricula;
                        listanegraactualizar.Marca = marca;
                        listanegraactualizar.Modelo = modelo;
                        listanegraactualizar.Color = color;
                        listanegraactualizar.Observaciones = observaciones;
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

        private void btnEliminaLN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var listanegramodificar = ObtenerPorId(id);
                db.ListasNegras.Remove(listanegramodificar);
                db.SaveChanges();
                MessageBox.Show(this, "Datos Eliminados Correctamente.");
                this.Close();
            }
        }

        private void btnCancelarLN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Métodos Utiles.
        private void LimpiarControles()
        {
            foreach (Control oControls in panelListaNegra.Controls)
            {
                if (oControls is TextBox || oControls is RichTextBox)
                {
                    oControls.Text = "";
                }
            }
        }
        private void LLenarCampos(int id)
        {
            var listanegramodificar = ObtenerPorId(id);
            tbMatriculaLN.Text = listanegramodificar.Matricula;
            tbMarcaLN.Text = listanegramodificar.Marca;
            tbModeloLN.Text = listanegramodificar.Modelo;
            tbColorLN.Text = listanegramodificar.Color;
            rtbObs.Text = listanegramodificar.Observaciones;
        }
        private Clases.ListaNegra ObtenerPorId(int id)
        {
            return db.ListasNegras.Find(id);
        }
        private bool ValidarControles()
        {
            foreach (Control oControls in panelListaNegra.Controls)
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
