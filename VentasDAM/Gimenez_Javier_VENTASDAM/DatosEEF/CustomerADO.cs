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
    public class CustomerADO : IDisposable
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        public CustomerADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        static public IList<Customer> Listar()
        {
            using (var context = new NorthwindContext())
            {
                // Return the list of data from the database
                var data = context.Customers.ToList();
                return data;
            }
        }

        public Customer? Listar(string ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Customers
                            where st.CustomerId == ID
                            select st;

                var cliente = query.FirstOrDefault<Customer>();
                return cliente;
            }
        }

        // Lista todos los OrderId de los pedidos de un cliente
        static public List<int> ListarPedidos(string? ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.CustomerId == ID
                            select st.OrderId;

                var pedidos = query.ToList();
                return pedidos;
            }
        }

        /* Lista todos los pedidos de un cliente
        static public ICollection<Order>? ListarPedidos(string ID)
        {
            using (var _context = new NorthwindContext())
            {
                var query = from st in _context.Customers
                            where st.CustomerId == ID
                            select st;

                var cliente = query.FirstOrDefault<Customer>();
                return cliente.Orders;
            }
        }
        */


        public void Insertar(Customer dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Customer modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Customer dato)
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
