using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_APP.DAO;
using WPF_APP.Modelos;

namespace WPF_APP.Service
{
    public class CursosServices : ICursosservices
    {
        private readonly DAOCursos dAOProfesor = new DAOCursos();
        private ILogger<CursosServices> _logger;

        public CursosServices(ILogger<CursosServices> logger)
        {
            _logger = logger;
        }
        public Respuesta ActualizarProfesor(Curso profesor)
        {
            int resultado = 0;
            Respuesta respuesta = new Respuesta();
            try
            {
                if (profesor != null)
                {
                    respuesta = dAOProfesor.ActualizarProfesor(profesor);
                    if (respuesta.Correcto)
                    {
                        respuesta.Mensaje = $"La actualización del profesor {profesor.Nombre} se realizó de manera correcta";
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return respuesta;
        }

        public Respuesta CrearProfesor(Curso profesor)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                if (profesor != null)
                {
                    respuesta = dAOProfesor.CrearProfesor(profesor);
                    if (respuesta.Correcto)
                    {
                        respuesta.Mensaje = $"La creación del profesor {profesor.Nombre} se realizó de manera correcta";
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return respuesta;
        }

        public Respuesta EliminarProfesor(int id)
        {
            Respuesta respuesta = new Respuesta();

            try
            {
                if (id != 0)
                {
                    respuesta = dAOProfesor.EliminarProfesor(id);
                    if (respuesta.Correcto)
                    {
                        respuesta.Mensaje = $" se eliminó el registro de manera correcta";
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return respuesta;
        }

        public List<Curso> ObtenerLista()
        {
            List<Curso> profesores = new List<Curso>();

            try
            {
                profesores = dAOProfesor.ObtenerLista();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return profesores;
        }

        public Curso ObtenerPorNombre(int nombre)
        {
            Curso profesor = new Curso();

            try
            {
                profesor = dAOProfesor.ObtenerPorNombre(nombre);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return profesor;
        }

        public Curso ObtenerProfesor(int id)
        {
            Curso profesor = new Curso();

            try
            {
                profesor = dAOProfesor.ObtenerProfesor(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return profesor;
        }

        public Curso ObtenerPorId(int id)
        {
            Curso profesor = new Curso();

            try
            {
                profesor = dAOProfesor.ObtenerPorId(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return profesor;
        }
    }
}
