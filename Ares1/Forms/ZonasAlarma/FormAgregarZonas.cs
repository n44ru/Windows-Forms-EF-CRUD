using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ares1.Forms.ZonasAlarmas
{
    public partial class FormAgregarZonas : Form
    {
        ModelContext db;
        Clases.Central central_padre;
        Clases.ZonaAlarma zona;
        bool datos_insertados;
        int id;
        public FormAgregarZonas(Clases.Central central_padre, ModelContext db)
        {
            InitializeComponent();
            this.db = db;
            this.central_padre = central_padre;
            tbNombre.Focus();
            datos_insertados = false;
        }
        public FormAgregarZonas(int id, ModelContext db)
        {
            InitializeComponent();
            this.db = db;
            LLenarCampos(id);
            this.id = id;
            datos_insertados = true;
        }
        private void FormAgregarZonas_Activated(object sender, EventArgs e)
        {
            if (zona != null)
            {
                dgvCamaras.DataSource = zona.Camara.ToList();
            }
        }
        private void LLenarCampos(int id)
        {
            zona = ObtenerPorId(id);
            tbNombre.Text = zona.Nombre;
            tbDescripcion.Text = zona.Descripcion;
            dgvCamaras.DataSource = zona.Camara.ToList();
        }
        private Clases.ZonaAlarma ObtenerPorId(int id)
        {
            return db.ZonasAlarmas.Find(id);
        }

        private void btnGuardarZonas_Click(object sender, EventArgs e)
        {
            // Recoger Datos y Validar.
            string nombre = tbNombre.Text.Trim();
            string desc = tbDescripcion.Text.Trim();
            if (ValidarControles())
            {
                if (id == 0)
                {
                    try
                    {
                        zona = new Clases.ZonaAlarma();
                        zona.Nombre = nombre;
                        zona.Descripcion = desc;
                        zona.Central = central_padre;
                        db.ZonasAlarmas.Add(zona);
                        db.SaveChanges();
                        MessageBox.Show(this, "Datos Guardados Correctamente.");
                        datos_insertados = true;
                        btnGuardarZonas.Enabled = false;
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
                        zona.Nombre = nombre;
                        zona.Descripcion = desc;
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

        private void btnEliminarZonas_Click(object sender, EventArgs e)
        {
            try
            {
                db.ZonasAlarmas.Remove(zona);
                db.SaveChanges();
                MessageBox.Show(this, "Datos Eliminados Correctamente.");
                this.Close();
            }
            catch
            {
                throw new Exception("Error de Conexión a la Base de Datos.");
            }
        }

        private void buttonCancelarZonas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCamaras_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCamaras.CurrentRow.Cells[0].Value.ToString());
            Forms.Camaras.FormAgregarCamaras cam = new Camaras.FormAgregarCamaras(id, db);
            cam.Show();
        }

        private void btnAgregarCamaras_Click(object sender, EventArgs e)
        {
            if (ValidarControles())
            {
                if (datos_insertados)
                {
                    Forms.Camaras.FormAgregarCamaras fac = new Camaras.FormAgregarCamaras(zona, db);
                    fac.Show();
                }
                else
                {
                    MessageBox.Show(this, "Debe Guardar la Zona para poder Asociar una Cámara.");
                }
            }
        }
        // Métodos Utiles.
        private void LimpiarControles()
        {
            foreach (Control oControls in panelZonas.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }
        }
        // Validar Controles
        private bool ValidarControles()
        {
            foreach (Control oControls in panelZonas.Controls)
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
