using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_APP.Modelos;
using WPF_APP.Service;

namespace WPF_APP.DAO
{
    public class DAOCursos : ICursosservices
    {
        public Respuesta ActualizarProfesor(Curso profesor)
        {
            Respuesta respuesta = new Respuesta();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Cursos.Update(profesor);
                int resultado = db.SaveChanges();

                respuesta.Correcto = resultado > 0 ? true : false;
                return respuesta;
            }
        }

        public Respuesta CrearProfesor(Curso profesor)
        {
            Respuesta respuesta = new Respuesta();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Cursos.Add(profesor);
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
                var profesor = db.Cursos.Find(id);
                db.Cursos.Remove(profesor);
                int resultado = db.SaveChanges();
                respuesta.Correcto = resultado > 0 ? true : false;
                return respuesta;
            }

        }

        public List<Curso> ObtenerLista()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Cursos.ToList();
            }
        }

        public Curso ObtenerPorNombre(int nombre)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                return db.Cursos.FirstOrDefault(x => x.Id.Equals("nombre"));
            }
        }

        public Curso ObtenerPorId(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Cursos.Find(id);
            }
        }

        public Curso ObtenerProfesor(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                //db.Profesores.Where(x => x.Id == id).FirstOrDefault();
                return db.Cursos.Find(id);
                //return db.Profesores.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
