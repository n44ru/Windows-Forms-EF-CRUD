using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ares1.Forms.Camaras
{
    public partial class FormAgregarCamaras : Form
    {
        Clases.ZonaAlarma zona_padre;
        ModelContext db;
        Clases.Camara camara;
        int id;
        public FormAgregarCamaras(Clases.ZonaAlarma zonas, ModelContext db)
        {
            InitializeComponent();
            tbNombre.Focus();
            this.zona_padre = zonas;
            this.db = db;
            this.id = 0;
        }
        // Sobrecarga para Editar y Eliminar.
        public FormAgregarCamaras(int id, ModelContext db)
        {
            InitializeComponent();
            btnEliminarCamara.Enabled = true;
            this.db = db;
            this.id = id;
            LLenarCampos(id);
        }
        // Sobrecarga para cuando quieres agregar sin Iniciar desde Central
        public FormAgregarCamaras()
        {
            InitializeComponent();
            db = new ModelContext();
            labelZonaAlarma.Visible = true;
            chbRelacion.Enabled = true;
            chbRelacion.Visible = true;
            // Checkbox para la relacion.
            cbZonaAlarma.Visible = true;
            //
            cbZonaAlarma.DataSource = db.ZonasAlarmas.ToList();
            cbZonaAlarma.DisplayMember = "Nombre";
            cbZonaAlarma.ValueMember = "ZonaAlarmaId";
        }
        private void btnGuardarCamara_Click(object sender, EventArgs e)
        {
            // Recoger Datos y Validar.
            string nombre = tbNombre.Text.Trim();
            string ip = tbIp.Text.Trim();
            string puerto = tbPuerto.Text.Trim();
            string usuario = tbUsuario.Text.Trim();
            string pass = tbPassword.Text.Trim();
            string url = tbUrl.Text.Trim();
            string tipocamara = cbTipodeCamara.Text.Trim();
            var tipo_camara = Clases.Camara.TipoCamara.Control_de_acceso;
            if (tipocamara == "Visualización")
                tipo_camara = Clases.Camara.TipoCamara.Visualizacion;
            //Si estoy creando sin Iniciar desde central o sea desde el Menu Alarmas
            if (cbZonaAlarma.Enabled)
            {
                zona_padre = db.ZonasAlarmas.Find(cbZonaAlarma.SelectedValue);
            }
            else
            {
                zona_padre = null;
            }
            if (ValidarControles())
            {
                if (id == 0)
                {
                    try
                    {
                        camara = new Clases.Camara { Nombre = nombre, IP = ip, Puerto = puerto, Usuario = usuario, Pass = pass, Url_Rstp = url, TCamara = tipo_camara};
                    if (zona_padre != null)
                    {
                        camara.ZonaAlarma = zona_padre;
                    }
                        db.Camaras.Add(camara);
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
                        camara = ObtenerPorId(id);
                        camara.Nombre = nombre;
                        camara.IP = ip;
                        camara.Puerto = puerto;
                        camara.Usuario = usuario;
                        camara.Pass = pass;
                        camara.Url_Rstp = url;
                        camara.TCamara = tipo_camara;
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

        private void btnEliminarCamara_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                camara = ObtenerPorId(id);
                db.Camaras.Remove(camara);
                db.SaveChanges();
                MessageBox.Show(this, "Datos Eliminados Correctamente.");
                this.Close();
            }
        }

        private void btnCancelarCamara_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbRelacion_Click(object sender, EventArgs e)
        {
            if (chbRelacion.Checked)
            {
                labelZonaAlarma.Enabled = true;
                cbZonaAlarma.Enabled = true;
            }
            else
            {
                labelZonaAlarma.Enabled = false;
                cbZonaAlarma.Enabled = false;
            }
        }

        // Métodos Utiles.
        private void LimpiarControles()
        {
            foreach (Control oControls in panelCamaras.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }
        }
        private bool ValidarControles()
        {
            foreach (Control oControls in panelCamaras.Controls)
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
            camara = ObtenerPorId(id);
            tbNombre.Text = camara.Nombre;
            tbIp.Text = camara.IP;
            tbPuerto.Text = camara.Puerto;
            tbUsuario.Text = camara.Usuario;
            tbPassword.Text = camara.Pass;
            tbUrl.Text = camara.Url_Rstp;
            if (camara.TCamara == Clases.Camara.TipoCamara.Control_de_acceso)
            {
                cbTipodeCamara.SelectedIndex = cbTipodeCamara.FindStringExact("Control de acceso");
            }
            else
            {
                cbTipodeCamara.SelectedIndex = cbTipodeCamara.FindStringExact("Visualización");
            }
        }
        private Clases.Camara ObtenerPorId(int id)
        {
            return db.Camaras.Find(id);
        }
    }
}
