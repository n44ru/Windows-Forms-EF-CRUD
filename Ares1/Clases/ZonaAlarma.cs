using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares1.Clases
{
    public class ZonaAlarma
    {
        public ZonaAlarma()
        {
            this.Camara = new HashSet<Camara>();
        }
        public int ZonaAlarmaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        // Relacion 0-N con Centrales
        public int CentralId { get; set; }
        public virtual Clases.Central Central { get; set; }
        // Relacion 1-1 con TipoProcedimiento
        public virtual TipoProcedimiento TipoProcedimiento { get; set; }
        // Relacion 0-N con Camara
        public virtual ICollection<Camara> Camara { get; set; }
    }
}
