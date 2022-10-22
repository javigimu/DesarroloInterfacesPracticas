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
    /// <autor>Javier Giménez Muñoz</autor>
    /// </summary>
    public class OrderDetailADO : IDisposable
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        public OrderDetailADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        static public IList<OrderDetail> Listar()
        {
            using (var context = new NorthwindContext())
            {
                // Return the list of data from the database
                var data = context.OrderDetails.ToList();
                return data;
            }
        }

        // obtiene una lista de order detail asociados a un OrderId
        static public ICollection<OrderDetail> ListarOrderDetails(int orderId)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.OrderDetails
                            where st.OrderId == orderId
                            select st;

                return query.ToList();
            }
        }

        // devuelve un order detail para un pedido y un producto (PK)
        public OrderDetail? Listar(int orderId, int productId)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.OrderDetails
                            where st.OrderId == orderId && st.ProductId == productId
                            select st;

                return query.FirstOrDefault<OrderDetail>();
            }
        }

        public void Insertar(OrderDetail dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(OrderDetail modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(OrderDetail dato)
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
