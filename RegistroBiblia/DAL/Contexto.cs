using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegistroBiblia.Entidades;

namespace RegistroBiblia.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Libros> Libro { get; set; }
        
        public Contexto() : base("ConStr")
        { }
    }
}
