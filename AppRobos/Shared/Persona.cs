using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRobos.Shared {
    public class Persona {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Provincia { get; set; }
        public string ObjetoRobado { get; set; }
        public double PrecioObjetoRobado { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}

