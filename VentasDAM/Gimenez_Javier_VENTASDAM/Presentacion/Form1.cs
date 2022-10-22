using Negocio;
using Modelos;

namespace Presentacion
{
    public partial class Form1 : Form, IDisposable
    {
        private Form formPedidos;       
        private Form formEmpleados;
        private Form formClientes;

        public Form1()
        {
            InitializeComponent();
        }

        #region "listados"
        private void btListarPedidos_Click(object sender, EventArgs e)
        {            
            // Listar pedidos en formPedidos
            formPedidos = new FormPedidos();
            formPedidos.ShowDialog();
        }

        private void btListarEmpleados_Click(object sender, EventArgs e)
        {           
            // Listar empleados en FormEmpleados
            formEmpleados = new FormEmpleados();
            formEmpleados.ShowDialog();
        }

        private void btListarClientes_Click(object sender, EventArgs e)
        {            
            // Listar clientes en FormClientes
            formClientes = new FormClientes();
            formClientes.ShowDialog();
        }
        #endregion

        #region "inserciones"
        private void btInsertarOrder_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarOrder(new Order(2, "ANTON", 2, 2));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
            
        }

        private void btInsertarOrderDetail_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarOrderDetail(new OrderDetail(10248, 1, 10, 1, 0));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }

        private void btInsertarProduct_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarProduct(new Product(5, "producto de prueba", 1, 1));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }

        private void btInsertarCustomer_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarCustomer(new Customer("JAVI", "Mi Empresa"));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }

        private void btInsertarEmployee_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarEmployee(new Employee(5, "gimenez", "javier"));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }

        private void btInsertarCategory_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarCategory(new Category(5, "Mi categoria"));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }

        private void btInsertarShipper_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarShipper(new Shipper(5, "Mi shipper name"));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }

        private void btInsertarSupplier_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                gestion.InsertarSupplier(new Supplier(2, "Empresa suminstradora"));
                Mensaje.MostrarProcesoFinalizadoCorrectamente();
            }
        }
        #endregion

        #region "actualizaciones"
        private void btActualizarOrder_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Order? order = gestion.ObtenerPedido(11082);
                if (order != null)
                {
                    order.ShipName = "Mi casa";
                    gestion.ActualizarOrder(order);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarOrderDetail_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                OrderDetail? order = gestion.ObtenerOrderDetail(10248, 1);
                if (order != null)
                {
                    order.Quantity = 20;
                    gestion.ActualizarOrderDetail(order);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarProduct_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Product? product = gestion.ObtenerProduct(80);
                if (product != null)
                {
                    product.ProductName = "Prueba actualizacion";
                    gestion.ActualizarProducto(product);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarCustomer_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Customer? customer = gestion.ObtenerCustomer("ANTON");
                if (customer != null)
                {
                    customer.ContactName = "Antonin";
                    gestion.ActualizarCustomer(customer);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarEmployee_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Employee? employee = gestion.ObtenerEmpleado(10);
                if (employee != null)
                {
                    employee.Title = "Ingeniero";
                    gestion.ActualizarEmployee(employee);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarCategory_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Category? category = gestion.ObtenerCategory(9);
                if (category != null)
                {
                    category.Description = "Mi categoria de prueba";
                    gestion.ActualizarCategoria(category);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarShipper_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Shipper? shipper = gestion.ObtenerShipper(4);
                if (shipper != null)
                {
                    shipper.CompanyName = "Mi nueva company";
                    gestion.ActualizarShipper(shipper);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btActualizarSupplier_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Supplier? supplier = gestion.ObtenerSupplier(30);
                if (supplier != null)
                {
                    supplier.ContactName = "Mi nuevo nombre de contacto";
                    gestion.ActualizarSupplier(supplier);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }
        #endregion

        #region "borrados"

        private void btBorrarOrder_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Order? order = gestion.ObtenerPedido(11082);
                if (order != null)
                {
                    gestion.BorrarOrder(order);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarOrderDetail_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                OrderDetail? orderDetail = gestion.ObtenerOrderDetail(10248, 1);
                if (orderDetail != null)
                {
                    gestion.BorrarOrderDetail(orderDetail);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarProduct_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Product? product = gestion.ObtenerProduct(80);
                if (product != null)
                {
                    gestion.BorrarProducto(product);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarCustomer_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Customer? customer = gestion.ObtenerCustomer("JAVI");
                if (customer != null)
                {
                    gestion.BorrarCustomer(customer);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarEmployee_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Employee? employee = gestion.ObtenerEmpleado(10);
                if (employee != null)
                {
                    gestion.BorrarEmployee(employee);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarCategory_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Category? category = gestion.ObtenerCategory(9);
                if (category != null)
                {
                    gestion.BorrarCategory(category);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarShipper_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Shipper? shipper = gestion.ObtenerShipper(4);
                if (shipper != null)
                {
                    gestion.BorrarShipper(shipper);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }

        private void btBorrarSupplier_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                Supplier? supplier = gestion.ObtenerSupplier(30);
                if (supplier != null)
                {
                    gestion.BorrarSupplier(supplier);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente();
                }
            }
        }
        #endregion
    }
}