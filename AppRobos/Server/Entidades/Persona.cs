using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppRobos.Server.Entidades {
    public partial class Persona {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
