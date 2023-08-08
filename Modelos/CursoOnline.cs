using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Modelos
{
    public class CursoOnline : Curso , ICurso
    {
        public string Plataforma { get; set; }
        public string URL { get; set; }

        public string FinalizarCurso(string nombre)
        {
            return $"Se ha finalizado el curso online de {nombre}";
        }

        public override string IniciarCurso(string nombre)
        {
            return $"Esta iniciando el curso {nombre} de manera online";
        }

        public string pasarLista(List<Alumno> alumnos)
        {
            string mensaje = "No existen alumnos";
            if (alumnos.Any())
            {
                mensaje = $"Se ha pasado lista de {alumnos.Count} alumnos en el curso online";
            }
            return mensaje;
        }
    }
}
