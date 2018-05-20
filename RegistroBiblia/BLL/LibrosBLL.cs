using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroBiblia.DAL;
using RegistroBiblia.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistroBiblia.BLL
{
    public class LibrosBLL
    {
        public static bool Guardar(Libros Libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Libro.Add(Libro)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static  bool Modificar(Libros Libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Libro).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Libros libro = contexto.Libro.Find(id);
                if(libro!=null)
                {
                    contexto.Libro.Remove(libro);

                    if (contexto.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                }
                
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Libros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Libros libro = new Libros();
            try
            {
                libro = contexto.Libro.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return libro;

        }

        public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> Libros = new List<Libros>();
            Contexto contexto = new Contexto();
            try
            {
                Libros = contexto.Libro.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Libros;
        }
    }
}
