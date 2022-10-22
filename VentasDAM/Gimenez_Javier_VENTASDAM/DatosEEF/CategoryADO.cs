using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEEF
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class CategoryADO : IDisposable 
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        public CategoryADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        static public IList<Category> Listar()
        {
            using (var context = new NorthwindContext())
            {
                // Return the list of data from the database
                var data = context.Categories.ToList();
                return data;
            }
        }

        public Category? Listar(int ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Categories
                            where st.CategoryId == ID
                            select st;

                var categoria = query.FirstOrDefault<Category>();
                return categoria;
            }
        }

        public void Insertar(Category dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Category modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Category dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Liberar recursos no manejados como ficheros, conexiones a bd, etc.
            }

            disposed = true;
        }
    }
}
