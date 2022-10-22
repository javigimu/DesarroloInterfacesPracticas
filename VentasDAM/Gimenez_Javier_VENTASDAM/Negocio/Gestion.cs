using DatosEEF;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Modelos;
using System.Net.Http.Headers;

namespace Negocio
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class Gestion : IDisposable
    {
        private List<Employee>? Empleados { get; set; }
        private List<Order>? Pedidos { get; set; }

        // Flag: Se ha llamado a Dispose?
        bool disposed;

        #region "constructores y metodos basicos"
        public Gestion()
        {
            Empleados = new List<Employee>();
            Pedidos = new List<Order>();
            disposed = false;
        }

        // Constructor de copia
        public Gestion(Gestion g)
        {
            if (g.Empleados != null)
            {
                foreach (Employee empleado in g.Empleados)
                    Empleados?.Add(empleado);
            }
            else
            {
                Empleados = new List<Employee>();
            }

            if (g.Pedidos != null)
            {
                foreach (Order pedido in g.Pedidos)
                    Pedidos?.Add(pedido);
            }
            else
            {
                Pedidos = new List<Order>();
            }

            disposed = g.disposed;
        }
        
        public override string ToString()
        {
            string texto = "Empleados: ";

            if (Empleados != null)
            {
                for (int i = 0; i < Empleados.Count(); i++)
                {
                    if (i == Empleados.Count - 1)
                        texto += Empleados[i].ToString();
                    else
                        texto += Empleados[i].ToString() + ", ";
                }
            }

            texto += "#Pedidos: ";
            if (Pedidos != null)
            {
                for (int i = 0; i < Pedidos.Count(); i++)
                {
                    if (i == Pedidos.Count - 1)
                        texto += Pedidos[i].ToString();
                    else
                        texto += Pedidos[i].ToString() + ", ";
                }
            }

            return texto;
        }
        #endregion

        #region "pedidos"
        // Obtiene todos los pedidos
        static public IList<Order> ListarPedidos()
        {
            return OrderADO.Listar();
        }

        // DatosPedido con los datos de la tabla Order incluyendo sus orderDetails        
        static public Order? DatosPedido(int orderId)
        {
            // devuelve todos los datos de un pedido
            // se incluyen los orderDetails y los datos del producto
            var data = OrderADO.Listar(orderId);
            if (data != null)
            {
                var orderDetails = OrderDetailADO.ListarOrderDetails(orderId);
                if (orderDetails != null)
                {
                    foreach (OrderDetail detail in orderDetails)
                    {
                        var producto = ProductADO.Listar(detail.ProductId);
                        detail.Product = producto;
                        if (data.OrderDetails == null)
                            data.OrderDetails = new HashSet<OrderDetail>();
                        data.OrderDetails.Add(detail);
                    }                    
                }
            }

            return data;         
        }

        // Devuelve un pedido
        public Order? ObtenerPedido(int orderId)
        {
            var data = OrderADO.Listar(orderId);
            return data;
        }        

        // Insertar Order
        public void InsertarOrder(Order o)
        {
            using (OrderADO oAdo = new OrderADO())
            {
                o.OrderId = 0;
                oAdo.Insertar(o);
            }
        }

        // Actualizar Order
        public void ActualizarOrder(Order o)
        {
            using (OrderADO oAdo = new OrderADO())
            {
                oAdo.Actualizar(o);
            }
        }

        // Borrar Order
        public void BorrarOrder(Order o)
        {
            using (OrderADO oAdo = new OrderADO())
            {
                oAdo.Borrar(o);
            }
        }

        #endregion

        #region "OrderDetail"

        // Obtiene los datos de un order detail por su clave primaria        
        public OrderDetail? ObtenerOrderDetail(int orderId, int productId)
        {
            OrderDetail? orderDetail;
            using (OrderDetailADO odAdo = new OrderDetailADO())
            {
                orderDetail = odAdo.Listar(orderId, productId);
                
            }
            return orderDetail;
        }

        // Lista todos los orderDetails de un pedido
        public ICollection<OrderDetail>? ListarOrderDetails(int orderId)
        {
            return OrderDetailADO.ListarOrderDetails(orderId);
        }
    
        // Insertar Order Detail
        public void InsertarOrderDetail(OrderDetail od)
        {
            using (OrderDetailADO odAdo = new OrderDetailADO())
            {
                odAdo.Insertar(od);
            }
        }

        // Actualizar Order Detail
        public void ActualizarOrderDetail(OrderDetail od)
        {
            using (OrderDetailADO odAdo = new OrderDetailADO())
            {
                odAdo.Actualizar(od);
            }
        }

        // Borrar Order Detail
        public void BorrarOrderDetail(OrderDetail od)
        {
            using (OrderDetailADO odAdo = new OrderDetailADO())
            {
                odAdo.Borrar(od);
            }
        }
        #endregion

        #region "productos"

        // Listado de productos
        static public ICollection<Product> ListadoProductos()
        {
            return ProductADO.Listar();
        }

        // Obtener un producto
        public Product? ObtenerProduct(int productId)
        {
            return ProductADO.Listar(productId);
        }

        // Insertar producto
        public void InsertarProduct(Product p)
        {
            using (ProductADO pAdo = new ProductADO())
            {
                p.ProductId = 0;
                pAdo.Insertar(p);
            }
        }

        // Actualizar Producto
        public void ActualizarProducto(Product p)
        {
            using (ProductADO pAdo = new ProductADO())
            {
                pAdo.Actualizar(p);
            }
        }

        // Borrar Producto
        public void BorrarProducto(Product p)
        {
            using (ProductADO pAdo = new ProductADO())
            {
                pAdo.Borrar(p);
            }
        }

        #endregion

        #region "empleados"
        // Obtiene todos los empleados
        static public ICollection<Employee> ListadoEmpleados()
        {
            return EmployeeADO.Listar();
        }

        // Devuelve todos los pedidos realizados por un empleado        
        static public ICollection<Order>? ListarPedidosBasicoEmpleado(int EmployeeID)
        {
            // devuelve los pedidos del empleado
            var data = EmployeeADO.ListarPedidos(EmployeeID);

            return data;
        }
        

        // Lista todos los pedidos realizados por un empleado con los detalles obtenidos
        // en DatosPedido
        static public ICollection<Order> ListarPedidosEmpleado(int employeeId)
        {
            // devuelve los pedidos de un empleado desde DatosPedido
            List<int> listaPedidosEmpleado = EmployeeADO.ListarPedidosId(employeeId);
            ICollection<Order> listaPedidos = new List<Order>();

            foreach (int orderId in listaPedidosEmpleado)
            {
                Order? pedido = DatosPedido(orderId);
                if (pedido != null)
                    listaPedidos.Add(pedido);
            }                

            return listaPedidos;
        }

        // Obtener datos de un empleado
        public Employee? ObtenerEmpleado(int employeeId)
        {
            return EmployeeADO.Listar(employeeId);
        }


        // Insertar Empleado
        public void InsertarEmployee(Employee e)
        {
            using (EmployeeADO eAdo = new EmployeeADO())
            {
                e.EmployeeId = 0;
                eAdo.Insertar(e);
            }
        }

        // Actualizar Empleado
        public void ActualizarEmployee(Employee e)
        {
            using (EmployeeADO eAdo = new EmployeeADO())
            {
                eAdo.Actualizar(e);
            }
        }

        // Borrar Empleado
        public void BorrarEmployee(Employee e)
        {
            using (EmployeeADO eAdo = new EmployeeADO())
            {
                eAdo.Borrar(e);
            }
        }

        #endregion


        #region "clientes"
        // Obtiene todos los clienes
        static public ICollection<Customer> ListadoClientes()
        {
            return CustomerADO.Listar();
        }


        // Obtiene todos los pedidos de un cliente, llamando a la función Datos Pedido
        // Devuelve la consulta en la tabla Order        
        static public ICollection<Order> ListarPedidosCliente(string? customerId)
        {
            List<int> listaPedidosCliente = CustomerADO.ListarPedidos(customerId);
            ICollection<Order> listaPedidos = new List<Order>();

            foreach (int orderId in listaPedidosCliente)
            {
                Order? pedido = DatosPedido(orderId);
                if (pedido != null)
                    listaPedidos.Add(pedido);
            }

            return listaPedidos;
        }

        // Obtener datos de un cliente
        public Customer? ObtenerCustomer(string custormerId)
        {
            Customer? customer;
            using (CustomerADO customerADO = new CustomerADO())
            {
                customer = customerADO.Listar(custormerId);
            }
            return customer;
        }

        // Insertar cliente
        public void InsertarCustomer(Customer c)
        {
            using (CustomerADO cAdo = new CustomerADO())
            {                
                cAdo.Insertar(c);
            }
        }

        // Actualizar cliente
        public void ActualizarCustomer(Customer c)
        {
            using (CustomerADO cAdo = new CustomerADO())
            {
                cAdo.Actualizar(c);
            }
        }

        // Borrar cliente
        public void BorrarCustomer(Customer c)
        {
            using (CustomerADO cAdo = new CustomerADO())
            {
                cAdo.Borrar(c);
            }
        }

        #endregion

        #region "categorias"

        // Obtiene todas las categorias
        static public ICollection<Category> ListadoCategorias()
        {
            return CategoryADO.Listar();
        }

        // Obtiene los datos de una categoria
        public Category? ObtenerCategory(int categoryId)
        {
            Category? category;
            using (CategoryADO categoryADO = new CategoryADO())
            {
                category = categoryADO.Listar(categoryId);
            }
            return category;
        }

        // Insertar categoria
        public void InsertarCategory(Category c)
        {
            using (CategoryADO cAdo = new CategoryADO())
            {
                c.CategoryId = 0;
                cAdo.Insertar(c);
            }
        }

        // Actualizar categoria
        public void ActualizarCategoria(Category c)
        {
            using (CategoryADO cAdo = new CategoryADO())
            {
                cAdo.Actualizar(c);
            }
        }

        // Borrar categoria
        public void BorrarCategory(Category c)
        {
            using (CategoryADO cAdo = new CategoryADO())
            {
                cAdo.Borrar(c);
            }
        }

        #endregion

        #region "shippers"
        // Obtiene todos los shippers
        static public ICollection<Shipper> ListadoShippers()
        {
            return ShipperADO.Listar();
        }

        // Obtiene los datos de un shipper
        public Shipper? ObtenerShipper(int shipperId)
        {
            Shipper? shipper;
            using (ShipperADO shipperADO = new ShipperADO())
            {
                shipper = shipperADO.Listar(shipperId);
            }
            return shipper;
        }

        // Insertar shipper
        public void InsertarShipper(Shipper s)
        {
            using (ShipperADO sAdo = new ShipperADO())
            {
                s.ShipperId = 0;
                sAdo.Insertar(s);
            }
        }

        // Actualizar shipper
        public void ActualizarShipper(Shipper s)
        {
            using (ShipperADO sAdo = new ShipperADO())
            {
                sAdo.Actualizar(s);
            }
        }

        // Borrar shipper
        public void BorrarShipper(Shipper s)
        {
            using (ShipperADO sAdo = new ShipperADO())
            {
                sAdo.Borrar(s);
            }
        }

        #endregion

        #region "supplier"

        // Obtiene todos los supplier
        static public ICollection<Supplier> ListadoSupliers()
        {
            return SupplierADO.Listar();
        }

        // Obtiene los datos de un supplier
        public Supplier? ObtenerSupplier(int supplierId)
        {
            Supplier? supplier;
            using (SupplierADO supplierADO = new SupplierADO())
            {
                supplier = supplierADO.Listar(supplierId);
            }
            return supplier;
        }

        // Insertar supplier
        public void InsertarSupplier(Supplier s)
        {
            using (SupplierADO sAdo = new SupplierADO())
            {
                s.SupplierId = 0;
                sAdo.Insertar(s);
            }
        }

        // Actualizar supplier
        public void ActualizarSupplier(Supplier s)
        {
            using (SupplierADO sAdo = new SupplierADO())
            {
                sAdo.Actualizar(s);
            }
        }

        // Borrar supplier
        public void BorrarSupplier(Supplier s)
        {
            using (SupplierADO sAdo = new SupplierADO())
            {
                sAdo.Borrar(s);
            }
        }

        #endregion

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

        ~Gestion()
        {
            Dispose(false);
            if (Empleados != null)
                Empleados.Clear();
            Empleados = null;
            if (Pedidos != null)
                Pedidos.Clear();
            Pedidos = null;
        }
    }
}