using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Modelos
{
    public interface ICurso
    {
        public string pasarLista(List<Alumno> alumnos);
        public string FinalizarCurso(string nombre);
    }
}
