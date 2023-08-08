using Microsoft.EntityFrameworkCore;
using WPF_APP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Profesor> Profesores { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=;Initial Catalog=WPF;Integrated Security=True");
        }
    }
}
