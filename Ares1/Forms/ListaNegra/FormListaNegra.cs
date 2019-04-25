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
    public partial class FormListaNegra : Form
    {
        ModelContext db;
        public FormListaNegra()
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
            db = new ModelContext();
            dgvListaNegra1.DataSource = db.ListasNegras.ToList();
        }
        private void btnAgregarListaNegra_Click(object sender, EventArgs e)
        {
            FormAgregarListaNegra formAgregar = new FormAgregarListaNegra();
            formAgregar.Show();
        }

        private void dgvListaNegra1_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListaNegra1.CurrentRow.Cells[0].Value.ToString());
            FormAgregarListaNegra ln = new FormAgregarListaNegra(id);
            ln.Show();
        }
    }
}
