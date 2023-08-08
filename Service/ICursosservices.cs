using WPF_APP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Service
{
    public interface ICursosservices
    {
        List<Curso> ObtenerLista();
        Respuesta CrearProfesor(Curso profesor);
        Respuesta ActualizarProfesor(Curso profesor);
        Curso ObtenerProfesor(int id);
        Respuesta EliminarProfesor(int id);
        Curso ObtenerPorNombre(int nombre);
    }
}
