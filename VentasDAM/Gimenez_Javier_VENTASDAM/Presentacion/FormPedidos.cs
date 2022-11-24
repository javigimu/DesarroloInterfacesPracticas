using DatosEEF;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// Formulario de gestión de pedidos
    /// </summary>
    public partial class FormPedidos : Form
    {
        private char opcionInsertarOModificar;
        Customer? cliente;
        int empleadoIdValidado;
        bool fechaPedidoSeleccionada;
        bool fechaRequeridaSeleccionada;
        bool fechaEnvioSeleccionada;
        ICollection<Product>? productos;
        Order? pedido;

        public FormPedidos()
        {
            InitializeComponent();
            InicializarBooleanosFecha();
            productos = new List<Product>();
        }

        private void InicializarBooleanosFecha()
        {
            fechaPedidoSeleccionada = false;
            fechaRequeridaSeleccionada = false;
            fechaEnvioSeleccionada = false;
        }

        /// <summary>
        /// Constructor con el id de empleado que realiza el pedido
        /// </summary>
        /// <param name="empleadoId"></param>
        /// <param name="opcion">Indica si es un nuevo pedido o una modificación</param>
        public FormPedidos(int empleadoId, char opcion) : this()
        {
            this.empleadoIdValidado = empleadoId;
            opcionInsertarOModificar = opcion;
        }

        private void FormPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Gestion.ResetearTotales();
            Owner.Show();            
        }

        /// <summary>
        /// Selección de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormBusquedaCliente formBuscarCliente = new FormBusquedaCliente();
            formBuscarCliente.Owner = this;
            this.Hide();
            formBuscarCliente.ShowDialog();
            cliente = formBuscarCliente?.GetCliente();
            if (cliente != null)
                tbCliente.Text = ObtenerDatosCliente(cliente);
        }

        /// <summary>
        /// Obtiene los datos del cliente en un string que mostraré en el textbox correspondiente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        private string ObtenerDatosCliente(Customer cliente)
        {
            return cliente.ContactName + " (" + cliente.CompanyName + ")";
        }

        /// <summary>
        /// Al cargar el formulario dejan las fechas en blanco y si es una modificación
        /// se muestra un formulario de búsqueda y se muestran los datos
        /// Si el usuario no selecciona un pedido, se vuelve al formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPedidos_Load(object sender, EventArgs e)
        {
            ConfigurarFormatoFechasInicial();
            if (opcionInsertarOModificar == 'i')
                btFinalizarPedido.Text = "Crear Pedido";
            else if (opcionInsertarOModificar == 'm')
            {
                FormBuscarPedido formBuscarPedido = new FormBuscarPedido();
                formBuscarPedido.Owner = this;
                this.Hide();
                formBuscarPedido.ShowDialog();
                pedido = formBuscarPedido.GetPedido();
                if (pedido != null)
                {
                    btFinalizarPedido.Text = "Modificar Pedido";
                    MostrarDatosPedido();
                }
                else
                {
                    Mensaje.MostrarErrorGenerico("No ha seleccionado ningún pedido");
                    Close();
                }
            }

            RellenarComboBoxTipoEnvio();
            tbIva.Text = Gestion.IVA.ToString();
        }

        /// <summary>
        /// Muestra todos los datos del pedido
        /// </summary>
        private void MostrarDatosPedido()
        {
            if (pedido != null)
            {
                lbPedidoId.Text = pedido.OrderId.ToString();
                lbPedidoId.Visible = true;
                lbTextoPedido.Visible = true;
                using (Gestion gestion = new Gestion())
                {
                    if (pedido.CustomerId != null)
                        cliente = gestion.ObtenerCustomer(pedido.CustomerId);
                }

                if (cliente != null)
                {
                    tbCliente.Text = ObtenerDatosCliente(cliente);                    
                }

                if (pedido.OrderDate != null)
                    dtpFechaPedido.Value = (DateTime)pedido.OrderDate;
                if (pedido.RequiredDate != null)
                    dtpFechaRequerida.Value = (DateTime)pedido.RequiredDate;
                if (pedido.ShippedDate != null)
                    dtpFechaEnvio.Value = (DateTime)pedido.ShippedDate;

                tbNombreEnvio.Text = pedido.ShipName;
                tbDireccion.Text = pedido.ShipAddress;
                tbCiudad.Text = pedido.ShipCity;
                tbRegion.Text = pedido.ShipRegion;

                RellenarComboBoxTipoEnvio();
                for (int i = 0; i < cbShipVia.Items.Count; i++)
                {
                    int? sv = Convert.ToInt32(cbShipVia.Items[i].ToString()?.Split('.')[0]);
                    if (sv == pedido.ShipVia)
                        cbShipVia.SelectedIndex = i;

                }

                tbPeso.Text = pedido.Freight.ToString();
                tbPais.Text = pedido.ShipCountry;

                // añado los order details
                using (Gestion gestion = new Gestion())
                {
                    ICollection<OrderDetail>? listaOD = gestion.ListarOrderDetails(pedido.OrderId);
                    if (listaOD != null)
                    {
                        productos = new List<Product>();
                        foreach (OrderDetail od in listaOD)
                        {
                            Product? producto = gestion.ObtenerProduct(od.ProductId);                            
                            if (producto != null)
                                productos.Add(producto);

                            dataGridView1.Rows.Add(od.ProductId, producto?.ProductName, od.UnitPrice, 
                                od.Quantity, od.Discount*100);
                        }
                    }
                }

                CalcularTotales();
            }
        }

        /// <summary>
        /// Rellena las opciones de tipo de envío extraidas de la tabla Shippers
        /// </summary>
        private void RellenarComboBoxTipoEnvio()
        {
            if (cbShipVia.Items.Count == 0)
            {
                ICollection<Shipper> shippers = Gestion.ListadoShippers();
                foreach (Shipper s in shippers)
                {
                    cbShipVia.Items.Add(s.ShipperId + ". " + s.CompanyName);
                }
            }           
        }

        private void ConfigurarFormatoFechasInicial()
        {
            dtpFechaPedido.Format = DateTimePickerFormat.Custom;
            dtpFechaPedido.CustomFormat = " ";
            dtpFechaEnvio.Format = DateTimePickerFormat.Custom;
            dtpFechaEnvio.CustomFormat = " ";
            dtpFechaRequerida.Format = DateTimePickerFormat.Custom;
            dtpFechaRequerida.CustomFormat = " ";
        }

        private void CambiarFormatoFecha(object sender, EventArgs e)
        {
            string dtpName = ((DateTimePicker)sender).Name;
            if (dtpName == "dtpFechaPedido")
            {
                dtpFechaPedido.CustomFormat = "yyyy/MM/dd";
                fechaPedidoSeleccionada = true;
            }
            else if (dtpName == "dtpFechaEnvio")
            {
                dtpFechaEnvio.CustomFormat = "yyyy/MM/dd";
                fechaEnvioSeleccionada = true;
            }
            else if (dtpName == "dtpFechaRequerida")
            {
                dtpFechaRequerida.CustomFormat = "yyyy/MM/dd";
                fechaRequeridaSeleccionada = true;
            }
        }

        /// <summary>
        /// Inserta los datos del pedido en Order y las líneas de cada producto en OrderDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFinalizarPedido_Click(object sender, EventArgs e)
        {
            string? customerId = cliente == null? null : cliente.CustomerId;
            int empleadoId = empleadoIdValidado;
            DateTime? fechaPedido = null;
            if (fechaPedidoSeleccionada)
                fechaPedido = dtpFechaPedido.Value;
            DateTime? fechaRequerida = null;
            if (fechaRequeridaSeleccionada)
                fechaRequerida = dtpFechaRequerida.Value;
            DateTime? fechaEnvio = null;
            if (fechaEnvioSeleccionada)
                fechaEnvio = dtpFechaEnvio.Value;

            int? shipVia = null;
            if (cbShipVia.SelectedIndex >= 0 && cbShipVia.SelectedItem != null)
            {
                string? numVia = null;
                numVia = cbShipVia.SelectedItem.ToString();
                if (numVia != null)
                {
                    int indicePunto = numVia.IndexOf('.');
                    shipVia = Convert.ToInt32(numVia.Substring(0, indicePunto));
                }                
            }

            decimal? peso = tbPeso.Text == "" ? null : Convert.ToDecimal(tbPeso.Text, new CultureInfo("en-US"));
            string? nombreEnvio = tbNombreEnvio.Text == "" ? null : tbNombreEnvio.Text;
            string? direccion = tbDireccion.Text == "" ? null : tbDireccion.Text;
            string? ciudad = tbCiudad.Text == "" ? null : tbCiudad.Text;
            string? region = tbRegion.Text == "" ? null : tbRegion.Text;
            string? codigoPostal = tbCodigoPostal.Text == "" ? null : tbCodigoPostal.Text;
            string? pais = tbPais.Text == "" ? null : tbPais.Text;
           

            using (Gestion gestion = new Gestion())
            {
                if (opcionInsertarOModificar == 'i')
                {
                    Order pedido = new Order(0, customerId, empleadoId, fechaPedido, fechaRequerida,
                        fechaEnvio, shipVia, peso, nombreEnvio, direccion, ciudad, region,
                        codigoPostal, pais);
                    int orderId = gestion.InsertarOrderYDevolverId(pedido);                    

                    if (productos != null)
                    {
                        foreach (DataGridViewRow dr in dataGridView1.Rows)
                        {
                            
                            OrderDetail od = new OrderDetail(orderId, Convert.ToInt32(dr.Cells["ProductId"].Value),
                                Convert.ToDecimal(dr.Cells["PrecioUnidad"].Value),
                                Convert.ToInt16(dr.Cells["Cantidad"].Value),
                                Convert.ToSingle(dr.Cells["Descuento"].Value)/100.0f);

                            gestion.InsertarOrderDetail(od);
                        }                        
                    }

                    Mensaje.MostrarProcesoFinalizadoCorrectamente("Pedido con Id " + orderId, ", inserción");
                    VaciarCampos();
                }
                else if (opcionInsertarOModificar == 'm')
                {
                    if (pedido != null)
                    {
                        Order pedidoModificado = new Order(pedido.OrderId, customerId, empleadoId, fechaPedido, fechaRequerida,
                            fechaEnvio, shipVia, peso, nombreEnvio, direccion, ciudad, region,
                            codigoPostal, pais);

                        gestion.ActualizarOrder(pedidoModificado);

                        if (productos != null)
                        {
                            List<Product> productosM = new List<Product>(productos);
                            foreach (DataGridViewRow dr in dataGridView1.Rows)
                            {
                                int productId = Convert.ToInt32(dr.Cells["ProductId"].Value);
                                OrderDetail od = new OrderDetail(pedido.OrderId, productId,
                                    Convert.ToDecimal(dr.Cells["PrecioUnidad"].Value),
                                    Convert.ToInt16(dr.Cells["Cantidad"].Value),
                                    Convert.ToSingle(dr.Cells["Descuento"].Value) / 100.0f);


                                if (gestion.ObtenerOrderDetail(pedido.OrderId, productId) != null)
                                    gestion.ActualizarOrderDetail(od);                                    
                                
                                else
                                    gestion.InsertarOrderDetail(od);

                                EliminarProductoDeLista(productosM, productId);
                            }

                            // borro de la base de datos los productos que se hayan eliminado del pedido original
                            foreach (Product p in productosM)
                            {
                                OrderDetail? od = gestion.ObtenerOrderDetail(pedido.OrderId, p.ProductId);
                                if (od != null)
                                {
                                    gestion.BorrarOrderDetail(od);                                    
                                }
                            }
                        }

                        Mensaje.MostrarProcesoFinalizadoCorrectamente("Pedido con Id " + pedido.OrderId, ", actualización");
                        VaciarCampos();
                    }
                }
            }
        }

        private void EliminarProductoDeLista(List<Product> productosM, int productId)
        {
            bool borrado = false;
            if (productos != null)
            {
                int i = 0;
                while (i < productos.Count && ! borrado)
                {
                    if (productosM[i].ProductId == productId)
                    {
                        productosM.RemoveAt(i);
                        borrado = true;
                    }
                    i++;
                }
            }
        }

        private void AnyadirProducto()
        {
            FormBusquedaProducto formBuscarProducto = new FormBusquedaProducto();
            formBuscarProducto.Owner = this;
            this.Hide();
            formBuscarProducto.ShowDialog();
            Product? producto = formBuscarProducto?.GetProducto();
            if (producto != null)
            {
                if (ComprobarProductoYaAnyadido(producto))
                {
                    Mensaje.MostrarErrorGenerico("El producto ya está añadido");
                }
                else
                {
                    productos?.Add(producto);
                    dataGridView1.Rows.Add(producto.ProductId, producto.ProductName, producto.UnitPrice, 1, 0);
                }
            }
            CalcularTotales();
        }

        private bool ComprobarProductoYaAnyadido(Product producto)
        {
            bool productoYaAnyadido = false;
            if (productos != null)
            {
                foreach (Product p in productos)
                {
                    if (p.ProductId == producto.ProductId)
                    {
                        productoYaAnyadido = true;
                    }
                }
            }
            return productoYaAnyadido;
        }


        private void EliminarProducto()
        {
            if (dataGridView1.CurrentRow != null)
            {
                int indiceProducto = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                int productId = Convert.ToInt32(dataGridView1.Rows[indiceProducto]
                    .Cells[0].Value.ToString());

                using (Gestion gestion = new Gestion())
                {
                    Product? producto = gestion.ObtenerProduct(productId);
                    if (producto != null)
                        productos?.Remove(producto);
                }

                dataGridView1.Rows.RemoveAt(indiceProducto);
                CalcularTotales();
            }
        }

        /// <summary>
        /// Vacía todos los datos del pedido
        /// </summary>
        private void VaciarCampos()
        {
            InicializarBooleanosFecha();
            ConfigurarFormatoFechasInicial();
            cliente = null;
            tbCliente.Text = "";
            cbShipVia.SelectedIndex = -1;
            tbPeso.Text = "";
            tbNombreEnvio.Text = "";
            tbDireccion.Text = "";
            tbCiudad.Text = "";
            tbRegion.Text = "";
            tbCodigoPostal.Text = "";
            tbPais.Text = "";

            tbTotalSinIva.Text = "";
            tbIva.Text = "";
            tbTotal.Text = "";

            dataGridView1.Rows.Clear();
            if (productos != null)
                productos.Clear();
        }

        private void btBorrarPedido_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void FormatearPrecio(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = '.';
        }

        private void tsmiAnyadirProducto_Click(object sender, EventArgs e)
        {
            AnyadirProducto();
        }

        private void btAnyadirProducto_Click(object sender, EventArgs e)
        {
            AnyadirProducto();
        }

        private void tsmiEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            Gestion.TotalSinIva = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                decimal precio = Convert.ToDecimal(dr.Cells["PrecioUnidad"].Value);
                short cantidad = Convert.ToInt16(dr.Cells["Cantidad"].Value);
                float descuento = (float)(precio * cantidad) * Convert.ToSingle(dr.Cells["Descuento"].Value) / 100.0f;
                decimal total = (precio * cantidad) - (decimal)descuento;                
                Gestion.TotalSinIva += precio * cantidad - (decimal)descuento;               
                tbTotalSinIva.Text = Gestion.TotalSinIva.ToString("N2");
                tbTotal.Text = Gestion.TotalPedido.ToString("N2");
            }
        }

        private void tbIva_Leave(object sender, EventArgs e)
        {
            Gestion.IVA = Convert.ToInt32(tbIva.Text);
            CalcularTotales();
        }
    }
}
