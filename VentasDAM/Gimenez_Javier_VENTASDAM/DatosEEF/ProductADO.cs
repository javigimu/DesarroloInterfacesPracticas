using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEEF
{
    public class ProductADO : IDisposable
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        public ProductADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        static public IList<Product> Listar()
        {
            using (var context = new NorthwindContext())
            {
                // Return the list of data from the database
                var data = context.Products.ToList();
                return data;
            }
        }

        static public Product? Listar(int ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Products
                            where st.ProductId == ID
                            select st;

                var producto = query.FirstOrDefault<Product>();
                return producto;
            }
        }

        public void Insertar(Product dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Product modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Product dato)
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
