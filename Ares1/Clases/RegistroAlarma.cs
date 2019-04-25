using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares1.Clases
{
    public class RegistroAlarma
    {
        public RegistroAlarma()
        {
                this.VideoClips = new HashSet<VideoClip>();
        }
        public int RegistroAlarmaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioAtiende { get; set; }
        public bool SeguimientoProcedimiento { get; set; }
        public DateTime FechaSeguimiento { get; set; }
        public enum Resultado
        {
            Positivo,
            Negativo
        }
        public Resultado Resultad { get; set; }
        public string Observaciones { get; set; }
        public string Vecino { get; set; }
        // Relacion 1-1 con TipoProcedimiento
        public virtual TipoProcedimiento TipoProcedimiento { get; set; }
        // Relacion 0-1 con ZonaAlarma
        public virtual ZonaAlarma ZonaAlarma { get; set; }
        // Relacion 0-N con VideoClip
        public virtual ICollection<VideoClip> VideoClips { get; set; }
    }
}
