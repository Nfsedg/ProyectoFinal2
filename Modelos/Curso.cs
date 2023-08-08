using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Modelos
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int NumHoras { get; set; }
        public string Matricula { get; set; }
        public string TipoCurso { get; set; }


        public virtual string IniciarCurso(string nombre) {

            return $"Se ha iniciado el nombre del curso {nombre}";
        }


        public string PasarLista()
        {
            return "Se pasó lista a todos";
        }

        public string PasarLista(List<string> nombres) {

            int numPersonas = 0;

            if (nombres.Count >= 0)
            {
                numPersonas = nombres.Count;
            }

            //if (Nombre.Any())
            //{
            //    numPersonas = nombres.Count;
            //}

            return $"Se pasó lista de {numPersonas} personas";
        }

        public string PasarLista(List<Alumno> alumnos) { 

            return $"Se pasó lista de {alumnos.Count} alumnos";
        }
    
    }
}
