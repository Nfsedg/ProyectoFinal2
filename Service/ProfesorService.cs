
using Microsoft.Extensions.Logging;
using WPF_APP.DAO;
using WPF_APP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.Service
{
    public class ProfesorService : IProfesorService
    {
        private readonly DAOProfesor dAOProfesor = new DAOProfesor();
        private ILogger<ProfesorService> _logger;

        public ProfesorService(ILogger<ProfesorService> logger)
        {
            _logger = logger;
        }
        public Respuesta ActualizarProfesor(Profesor profesor)
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

        public Respuesta CrearProfesor(Profesor profesor)
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
                if (id!= 0)
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

        public List<Profesor> ObtenerLista()
        {
            List<Profesor> profesores = new List<Profesor>();

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

        public Profesor ObtenerPorNombre(string nombre)
        {
            Profesor profesor = new Profesor();

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

        public Profesor ObtenerProfesor(int id)
        {
            Profesor profesor = new Profesor();

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

        public Profesor ObtenerPorId(int id)
        {
            Profesor profesor = new Profesor();

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
