using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares1.Clases
{
    public class VideoClip
    {
        public int VideoClipId { get; set; }
        public string Url { get; set; }
        // Relacion 0-N con RegistroAlarma
        public int RegistroAlarmaId { get; set; }
        public virtual RegistroAlarma RegistroAlarma { get; set; }
    }
}
