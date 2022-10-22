using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEEF
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class EmployeeADO : IDisposable
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        public EmployeeADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        static public IList<Employee> Listar()
        {
            using (var context = new NorthwindContext())
            {
                // Return the list of data from the database
                var data = context.Employees.ToList();  
                
                SortedSet<Employee> set = new SortedSet<Employee>(data);
                return set.ToList();
                //return data;
            }
        }

        // Listar datos de un empleado
        static public Employee? Listar(int ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Employees
                            where st.EmployeeId == ID
                            select st;

                var empleado = query.FirstOrDefault<Employee>();
                return empleado;
            }
        }

        // Lista todos los OrderId de un empleado
        static public List<int> ListarPedidosId(int ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.EmployeeId == ID
                            select st.OrderId;

                var pedidos = query.ToList();
                return pedidos;
            }
        }

        // Lista todos los pedidos de un empleado
        static public ICollection<Order>? ListarPedidos(int ID)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.EmployeeId == ID
                            select st;

                var pedidos = query.ToList();
                return pedidos;
            }
        }

        public void Insertar(Employee dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Employee modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Employee dato)
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
