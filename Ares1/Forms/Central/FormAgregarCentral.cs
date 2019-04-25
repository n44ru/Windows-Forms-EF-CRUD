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

namespace Ares1.Forms.Central
{
    public partial class FormAgregarCentral : Form
    {
        ModelContext db;
        Clases.Central central;
        bool datos_insertados;
        //El id me sirve para saber si voy a insertar, actualizar o eliminar.
        int id;
        public FormAgregarCentral(ModelContext db)
        {
            InitializeComponent();
            this.db = db;
            tbNombre.Focus();
            this.id = 0;
            datos_insertados = false;
        }
        // Sobrecarga para Actualizar o Eliminar.
        public FormAgregarCentral(int id, ModelContext db)
        {
            InitializeComponent();
            this.db = db;
            LLenarCampos(id);
            this.id = id;
            datos_insertados = true;
            btnEliminarCentral.Enabled = true;
        }
        // Evento para actualizar el datagrid cuando la aplicacion tiene el Foco.
        private void FormAgregarZonas_Activated(object sender, EventArgs e)
        {
            if (central != null)
            {
                dgvZonas.DataSource = central.ZonaAlarma.ToList();
            }

        }
        private void btnAgregarCentral_Click(object sender, EventArgs e)
        {
            if (ValidarControles())
            {
                if (datos_insertados)
                {
                    ZonasAlarmas.FormAgregarZonas fac = new ZonasAlarmas.FormAgregarZonas(central, db);
                    fac.Show();
                }
                else
                {
                    MessageBox.Show(this, "Debe Guardar la Central para poder Asociar una Zona.");
                }

            }
        }

        private void dgvZonas_DoubleClick_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvZonas.CurrentRow.Cells[0].Value.ToString());
            ZonasAlarmas.FormAgregarZonas zal = new ZonasAlarmas.FormAgregarZonas(id, db);
            zal.Show();
        }

        private void btnGuardarCentral_Click(object sender, EventArgs e)
        {
            // Recoger Datos y Validar.
            string nombre = tbNombre.Text.Trim();
            string ip = tbIp.Text.Trim();
            string puerto = tbPuerto.Text.Trim();
            string pass = tbPass.Text.Trim();
            string access = tbAccess.Text.Trim();
            string desc = tbDescripcion.Text.Trim();
            if (ValidarControles())
            {
                if (id == 0)
                {
                    try
                    {
                        central = new Clases.Central();
                        central.Nombre = nombre;
                        central.IP = ip;
                        central.Puerto = puerto;
                        central.PassPhrase = pass;
                        central.AccessCode = access;
                        central.Descripción = desc;
                        db.Centrales.Add(central);
                        db.SaveChanges();
                        MessageBox.Show(this, "Datos Guardados Correctamente.");
                        datos_insertados = true;
                        btnGuardarCentral.Enabled = false;
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
                        central.Nombre = nombre;
                        central.IP = ip;
                        central.Puerto = puerto;
                        central.PassPhrase = pass;
                        central.AccessCode = access;
                        central.Descripción = desc;
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

        private void btnEliminarCentral_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.Centrales.Remove(central);
                    db.SaveChanges();
                    MessageBox.Show(this, "Datos Eliminados Correctamente.");
                    this.Close();
                }
                catch
                {
                    throw new Exception("Error de Conexión a la Base de Datos.");
                }
            }
        }

        private void btnCancelarCentral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En proceso.");
        }
        // Métodos Utiles.
        private void LimpiarControles()
        {
            foreach (Control oControls in panelCentral.Controls)
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
            foreach (Control oControls in panelCentral.Controls)
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
        private void LLenarCampos(int id)
        {
            central = ObtenerPorId(id);
            tbNombre.Text = central.Nombre;
            tbIp.Text = central.IP;
            tbPuerto.Text = central.Puerto;
            tbPass.Text = central.PassPhrase;
            tbAccess.Text = central.AccessCode;
            tbDescripcion.Text = central.Descripción;
        }
        private Clases.Central ObtenerPorId(int id)
        {
            return db.Centrales.Find(id);
        }
    }
}
