using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Modelos
{
    public class Profesor : Persona
    {
        public string NumEMpleado { get; set; }
        public string Especializacion { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }   
    }
}
