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
    public partial class FormCentral : Form
    {
        ModelContext db;
        public FormCentral()
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
            dgvCentrales.DataSource = db.Centrales.ToList();
        }

        private void dgvCentrales_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCentrales.CurrentRow.Cells[0].Value.ToString());
            FormAgregarCentral fac = new FormAgregarCentral(id, db);
            fac.Show();
        }

        private void btnAgregarCentral_Click(object sender, EventArgs e)
        {
            FormAgregarCentral formAgregar = new FormAgregarCentral(db);
            formAgregar.Show();
        }
    }
}
