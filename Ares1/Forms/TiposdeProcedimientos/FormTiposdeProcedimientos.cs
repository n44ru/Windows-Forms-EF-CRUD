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
    public partial class FormTiposdeProcedimientos : Form
    {
        ModelContext db;
        public FormTiposdeProcedimientos()
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
            dgvTDP.DataSource = db.TiposProcedimientos.ToList();
        }
        private void btnTDP_Click(object sender, EventArgs e)
        {
            FormAgregarTDP formAgregarTDP = new FormAgregarTDP();
            formAgregarTDP.Show();
        }

        private void dgvTDP_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(dgvTDP.CurrentRow.Cells[0].Value.ToString());
            FormAgregarTDP formTDP = new FormAgregarTDP(id);
            formTDP.Show();
        }
    }
}
