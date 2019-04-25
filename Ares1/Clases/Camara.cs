using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ares1.Clases
{
    public class Camara
    {
        public int CamaraId { get; set; }
        public string Nombre { get; set; }
        public string IP { get; set; }
        public string Puerto { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public string Url_Rstp { get; set; }
        public enum TipoCamara
        {
            Control_de_acceso,
            Visualizacion
        }
        public TipoCamara TCamara { get; set; }
        public int? ZonaAlarmaId { get; set; }
        public virtual Clases.ZonaAlarma ZonaAlarma { get; set; }
    }
}
