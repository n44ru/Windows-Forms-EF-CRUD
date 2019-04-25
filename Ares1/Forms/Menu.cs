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

namespace Ares1.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void centralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central.FormCentral fc = new Central.FormCentral();
            fc.Show();
        }

        private void camarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camaras.FormCamaras fac = new Camaras.FormCamaras();
            fac.Show();

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.FormRegistros fr = new Registros.FormRegistros();
            fr.Show();
        }

        private void tiposDeProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposdeProcedimientos.FormTiposdeProcedimientos ftp = new TiposdeProcedimientos.FormTiposdeProcedimientos();
            ftp.Show();
        }

        private void listaNegraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaNegra.FormListaNegra ln = new ListaNegra.FormListaNegra();
            ln.Show();

        }
    }
}
