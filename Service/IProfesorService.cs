using WPF_APP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Service
{
    public interface IProfesorService
    {
        List<Profesor> ObtenerLista();
        Respuesta CrearProfesor(Profesor profesor);
        Respuesta ActualizarProfesor(Profesor profesor);
        Profesor ObtenerProfesor(int id);
        Respuesta EliminarProfesor(int id);
        Profesor ObtenerPorNombre(string nombre);
    }
}
