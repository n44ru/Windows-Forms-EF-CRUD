using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ares1.Clases
{
    public class TipoProcedimiento
    {
        public int TipoProcedimientoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
