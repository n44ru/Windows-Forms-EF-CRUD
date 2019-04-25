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

namespace Ares1.Forms.Camaras
{
    public partial class FormCamaras : Form
    {
        ModelContext db;
        public FormCamaras()
        {
            InitializeComponent();
            db = new ModelContext();
        }
        private void FormListaNegra_Activated(object sender, EventArgs e)
        {
            dgvRefrescar();
        }
        public void dgvRefrescar()
        {
            dgvCamaras.DataSource = db.Camaras.ToList();
            // Mostrar el Nombre de las Relaciones de Camaras.
            for (int i = 0; i < db.Camaras.ToList().Count(); i++)
            {
                var item = db.Camaras.ToList();
                if (item[i].ZonaAlarma != null)
                {
                    dgvCamaras.Rows[i].Cells["Central"].Value = item[i].ZonaAlarma.Central.Nombre;
                    dgvCamaras.Rows[i].Cells["Zona"].Value = item[i].ZonaAlarma.Nombre;
                }
                else
                {
                    dgvCamaras.Rows[i].Cells["Central"].Value = "No Asociado.";
                    dgvCamaras.Rows[i].Cells["Zona"].Value = "No Asociado.";
                }
                // Ver que tipo de camara es.
                if (item[i].TCamara.ToString() == "Control_de_acceso")
                    dgvCamaras.Rows[i].Cells["TDCamara"].Value = "Control de Acceso";
                else dgvCamaras.Rows[i].Cells["TDCamara"].Value = "Visualización";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarCamaras fac = new FormAgregarCamaras();
            fac.Show();
        }

        private void dgvCamaras_DoubleClick_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCamaras.CurrentRow.Cells[0].Value.ToString());
            FormAgregarCamaras fac = new FormAgregarCamaras(id, db);
            fac.Show();
        }
    }
}
