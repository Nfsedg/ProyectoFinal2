using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Modelos
{
    public class CursoPresencial : Curso , ICurso
    {
        

        public string Aula { get; set; }

        public CursoPresencial()
        {
            
        }
        public CursoPresencial(string aula)
        {
            this.Aula = aula;
        }

        public override string IniciarCurso(string nombre)
        {
            return $"Esta iniciando el curso {nombre} de manera preciencial";
        }

        public string pasarLista(List<Alumno> alumnos)
        {
            string mensaje = "No existen alumnos";
            if (alumnos!= null && alumnos.Any())
            {
                mensaje = $"Se ha pasado lista de {alumnos.Count} alumnos en el curso online";
            }
            return mensaje;
        }

        public string FinalizarCurso(string nombre)
        {
            return $"Se ha finalizado el curso presencial de {nombre}";
        }
    }
}
