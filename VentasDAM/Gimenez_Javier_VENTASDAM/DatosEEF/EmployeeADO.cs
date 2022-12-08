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
    /// Clase EmployeeADO.
    /// Clase que gestiona las operaciones necesarias en la base de datos para los empleados.
    /// <see cref="Employee"/>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class EmployeeADO : IDisposable
    {
        // Flag: Se ha llamado a Dispose?
        bool disposed;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EmployeeADO()
        {
            disposed = false;
        }

        // Métodos CRUD (Listar, Insertar, Actualizar, Borrar)
        /// <summary>
        /// Obtiene de la base de datos el listado completo de empleados
        /// </summary>
        /// <returns>Lista de empleados</returns>
        /// <example>Muestra como se obtiene una lista de la tabla Employees desde el contexto NorthwindContext
        /// <code>var data = context.Employees.ToList()</code>
        /// </example>
        /// <remarks>
        /// Obtención de una lista de <see cref="Employee"/> independiente del tipo de base de datos.
        /// Obtiene la lista de empleados ordenados por <see cref="Employee.FirstName"/> 
        /// y <see cref="Employee.LastName"/></remarks>
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

        /// <summary>
        /// Obtiene los datos de un empleado
        /// </summary>
        /// <param name="ID">Identificador del empleado: EmployeeId</param>
        /// <returns>Un objeto empleado</returns>
        /// <example>Muestra como se obtiene un <see cref="Employee"/> con <see cref="Employee.EmployeeId"/> 5
        /// <code>
        /// var query = from st in context.Employees
        ///     where st.EmployeeId == 5
        ///     select st;
        /// </code>
        /// </example>
        /// <remarks>
        /// Obtención de un <see cref="Employee"/> independiente del tipo de base de datos.
        /// Si no se encuentra el Id de empleado devuelve null, sino obtiene todos los datos del objeto.
        /// <see cref="Employee"/> de la base de datos</remarks>
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

        /// <summary>
        /// Obtiene todos los Id de pedido de un empleado
        /// </summary>
        /// <param name="ID">Identificador del empleado: EmployeeId</param>
        /// <returns>Lista de Id de pedidos</returns>
        /// <see cref="Order"/>
        /// <example>Muestra de cómo obtener el listado de todos los <see cref="Order.OrderId"/> del empleado <see cref="Employee"/> 5
        /// <code>
        /// var query = from st in context.Orders
        ///     where st.EmployeeId == 5
        ///     select st.OrderId
        /// </code>
        /// </example>
        /// <remarks>
        /// Obtención de Lista de <see cref="Order.OrderId"/> independiente del tipo de base de datos.
        /// El método debe recibir un <see cref="Employee.EmployeeId"/> existente o devolverá una lista vacía.
        /// </remarks>
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

        /// <summary>
        /// Obtiene una colección con todos los pedidos completos de un empleado
        /// </summary>
        /// <param name="ID">Identificador del empleado: EmployeeId</param>
        /// <returns>Colección de pedidos de un empleado</returns>
        /// <see cref="Order"/>
        /// /// <example>Muestra de cómo obtener el listado de todos los <see cref="Order"/> del <see cref="Employee.EmployeeId"/> 5
        /// <code>
        /// var query = from st in context.Orders
        ///     where st.EmployeeId == 5
        ///     select st
        /// </code>
        /// </example>
        /// <remarks>
        /// Obtención de pedidos independiente del tipo de base de datos.
        /// El método debe recibir un <see cref="Employee.EmployeeId"/> existente o devolverá null.
        /// </remarks>
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

        /// <summary>
        /// Inserta un nuevo empleado en la base de datos
        /// </summary>
        /// <param name="dato">Nuevo empleado</param>
        /// <example>Muestra de inserción de un <see cref="Employee"/> empleado en la base de datos
        /// <code>
        /// context.Entry(empleado).State = EntityState.Added;
        /// context.SaveChanges();
        /// </code>
        /// </example>
        /// <remarks>
        /// Inserción de un <see cref="Employee"/> en la base de datos independiente del tipo de base de datos
        /// </remarks>
        public void Insertar(Employee dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Actualiza un empleado existente en la base de datos
        /// </summary>
        /// <param name="modificado">Empleado a modificar</param>
        /// <example>Muestra de actualización de un <see cref="Employee"/> empleado
        /// <code>
        /// context.Entry(empleado).State = EntityState.Modified;
        /// context.SaveChanges();
        /// </code>
        /// </example>
        /// <remarks>
        /// Actualización de un <see cref="Employee"/> independiente del tipo de la base de datos.
        /// </remarks>
        public void Actualizar(Employee modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Borra un empleado de la base de datos
        /// </summary>
        /// <param name="dato">Empleado a borrar</param>
        public void Borrar(Employee dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Implementación de Dispose para liberar recursos
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Implementación protegida del método Dispose
        /// </summary>
        /// <param name="disposing">Booleano que indica se ha llamado a Dispose</param>
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
