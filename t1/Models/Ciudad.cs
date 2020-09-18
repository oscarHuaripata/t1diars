using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace t1.Models
{
    public class Ciudad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int idPersona { get; set; }
        public Persona persona { get; set; }
    }
}
