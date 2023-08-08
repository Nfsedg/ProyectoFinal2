using WPF_APP.Modelos;
using WPF_APP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP.DAO
{
    public class DAOProfesor : IProfesorService
    {
        public Respuesta ActualizarProfesor(Profesor profesor)
        {
            Respuesta respuesta = new Respuesta();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Profesores.Update(profesor);
                int resultado = db.SaveChanges();

                respuesta.Correcto = resultado > 0 ? true : false;
                return respuesta;
            }
        }

        public Respuesta CrearProfesor(Profesor profesor)
        {
            Respuesta respuesta = new Respuesta();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Profesores.Add(profesor);
                int resultado = db.SaveChanges();
                respuesta.Correcto = resultado > 0 ? true : false;
                return respuesta;
            }
        }

        public Respuesta EliminarProfesor(int id)
        {
            Respuesta respuesta = new Respuesta();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var profesor = db.Profesores.Find(id);
                db.Profesores.Remove(profesor);
                int resultado = db.SaveChanges();
                respuesta.Correcto = resultado > 0 ? true : false;
                return respuesta;
            }
        
        }

        public List<Profesor> ObtenerLista()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Profesores.ToList();
            }
        }

        public Profesor ObtenerPorNombre(string nombre)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                return db.Profesores.FirstOrDefault(x => x.Nombre.Equals("nombre"));
            }
        }

        public Profesor ObtenerPorId(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Profesores.Find(id);
            }
        }

        public Profesor ObtenerProfesor(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                //db.Profesores.Where(x => x.Id == id).FirstOrDefault();
                return db.Profesores.Find(id);
                //return db.Profesores.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
