using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares1.Clases
{
    public class Central
    {
        public Central()
        {
            this.ZonaAlarma = new HashSet<ZonaAlarma>();
        }
        public int CentralId { get; set; }
        public string Nombre { get; set; }
        public string IP { get; set; }
        public string Puerto { get; set; }
        public string PassPhrase { get; set; }
        public string AccessCode { get; set; }
        public string Descripción { get; set; }
        // Relacion 0-N con ZonaAlarma
        public virtual ICollection<ZonaAlarma> ZonaAlarma { get; set; }
    }
}
