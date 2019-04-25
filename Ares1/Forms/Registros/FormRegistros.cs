using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ares1.Forms.Registros
{
    public partial class FormRegistros : Form
    {
        ModelContext db;
        public FormRegistros()
        {
            InitializeComponent();
            db = new ModelContext();

        }
        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = dtInicio.Value.Date;
            DateTime fechaFinal = dtFin.Value.Date;
            //
            bool seguimiento;
            if (cbSeguimientoR.Checked)
            {
                seguimiento = true;
            }
            else seguimiento = false;
            string resultado = cbResult.Text;
            var enume = Clases.RegistroAlarma.Resultado.Negativo;
            if (resultado == "Positivo")
            {
                enume = Clases.RegistroAlarma.Resultado.Positivo;
            }
            string usuario = cbUser.Text;
            DateTime fechaseguimientoInicio = dtSegInicio.Value.Date;
            DateTime fechaseguimientoFin = dtsegFin.Value.Date;
            string vecino = tbVecin.Text.Trim();
            string observaciones = tbObs.Text.Trim();
            //Relaciones
            object value = cbTipoDeAlarma.SelectedValue;
            int tipodealarma = int.Parse(value.ToString());
            object value2 = cbZonaAlarm.SelectedValue;
            int zonadealarma = int.Parse(value2.ToString());
            // Linq Query
            var queryResults = from r in db.RegistrosAlarmas
                               where r.FechaRegistro >= fechaInicial && r.FechaRegistro <= fechaFinal
                               && r.Resultad == enume
                               && r.TipoProcedimiento.TipoProcedimientoId == tipodealarma
                               && r.ZonaAlarma.ZonaAlarmaId == zonadealarma
                               && r.SeguimientoProcedimiento == seguimiento && r.UsuarioAtiende == usuario
                               && r.FechaSeguimiento >= fechaseguimientoInicio && r.FechaSeguimiento <= fechaseguimientoFin
                               && r.Vecino.Contains(vecino) && r.Observaciones.Contains(observaciones)
                               select r;
            dgvRegistro.DataSource = queryResults.ToList();
            //Llenar las relaciones
            if (queryResults.ToList().Count() > 0)
            {
                int i = 0;
                foreach (var item in queryResults.ToList())
                {
                    dgvRegistro.Rows[i].Cells["tipoProcedimientodgv"].Value = item.TipoProcedimiento.Nombre;
                    dgvRegistro.Rows[i].Cells["zonaAlarmadgv"].Value = item.ZonaAlarma.Nombre;
                    i++;
                }
            }
        }
        // Llenar los combobox con los datos de las clases al cargar el formulario.
        private void FormRegistros_Load(object sender, EventArgs e)
        {
            cbTipoDeAlarma.DataSource = db.TiposProcedimientos.ToList();
            cbTipoDeAlarma.DisplayMember = "Nombre";
            cbTipoDeAlarma.ValueMember = "TipoProcedimientoId";
            cbZonaAlarm.DataSource = db.ZonasAlarmas.ToList();
            cbZonaAlarm.DisplayMember = "Nombre";
            cbZonaAlarm.ValueMember = "ZonaAlarmaId";
        }
    }
}
