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

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
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

        public FormPedidos(int empleadoId, char opcion) : this()
        {
            this.empleadoIdValidado = empleadoId;
            opcionInsertarOModificar = opcion;
        }

        private void FormPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();            
        }

        private void btSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormBusquedaCliente formBuscarCliente = new FormBusquedaCliente();
            formBuscarCliente.Owner = this;
            this.Hide();
            formBuscarCliente.ShowDialog();
            cliente = formBuscarCliente?.GetCliente();
            if (cliente != null)
                tbCliente.Text = cliente.ContactName + " (" + cliente.CompanyName + ")";
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            ConfigurarFormatoFechasInicial();
            if (opcionInsertarOModificar == 'i')
                btFinalizarPedido.Text = "Crear Pedido";
            else if (opcionInsertarOModificar == 'm')
            {
                btFinalizarPedido.Text = "Modificar Pedido";
            }

            RellenarComboBoxTipoEnvio();
            tbIva.Text = Gestion.IVA.ToString();
        }

        private void RellenarComboBoxTipoEnvio()
        {
            ICollection<Shipper> shippers = Gestion.ListadoShippers();
            foreach(Shipper s in shippers)
            {                
                cbShipVia.Items.Add(s.ShipperId + ". " + s.CompanyName);                
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
                    Mensaje.MostrarProcesoFinalizadoCorrectamente("Pedido con Id " + orderId, ", inserción");

                    VaciarCampos();
                }
                else if (opcionInsertarOModificar == 'm')
                {

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
                productos?.Add(producto);
                dataGridView1.Rows.Add(producto.ProductId, producto.ProductName, producto.UnitPrice, 1, 0);
            }
            CalcularTotales();
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
        }

        private void btBorrarPedido_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Owner.Show();
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
                int cantidad = Convert.ToInt32(dr.Cells["Cantidad"].Value);
                decimal descuento = (precio * cantidad) * Convert.ToInt32(dr.Cells["Descuento"].Value) / 100;
                decimal total = (precio * cantidad) - descuento;                
                Gestion.TotalSinIva += precio * cantidad - descuento;               
                tbTotalSinIva.Text = Gestion.TotalSinIva.ToString("N2");
                tbTotal.Text = Gestion.TotalPedido.ToString();
            }
        }
    }
}
