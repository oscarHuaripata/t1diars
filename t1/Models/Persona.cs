using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace t1.Models
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime  fechaNac{ get; set; }
        public string DNI { get; set; }
        public string genero { get; set; }
        public int idCiudad { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
       

        public List<Ciudad> Ciudad { get; set; }

    }
}
