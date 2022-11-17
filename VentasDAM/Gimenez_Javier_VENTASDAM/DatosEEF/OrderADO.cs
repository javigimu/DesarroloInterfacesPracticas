using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEEF
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class OrderADO : IDisposable
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        public OrderADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        static public IList<Order> Listar()
        {
            using (var context = new NorthwindContext())
            {
                // Return the list of data from the database
                var data = context.Orders.ToList();
                return data;
            }
        }
        static public Order? Listar(int ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.OrderId == ID
                            select st;

                var orden = query.FirstOrDefault<Order>();
                return orden;
            }
        }

        // Lista todos los pedidos de un empleado
        public IList<Order> ListarPedidosEmpleado(int employeedID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.EmployeeId == employeedID
                            select st;
                var pedidos = query.ToList();
                return pedidos;
            }
        }

        public void Insertar(Order dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();                
            }
        }

        public void Actualizar(Order modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Order dato)
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
