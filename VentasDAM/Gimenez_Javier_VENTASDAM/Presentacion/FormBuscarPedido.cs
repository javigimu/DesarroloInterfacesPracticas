using DatosEEF;
using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class FormBuscarPedido : Form
    {
        ICollection<Order>? pedidos;
        DataTable? tablaPedidos;
        DataView? vista;
        Order? pedido;
        Customer? cliente;
        DateTime? fechaPedido;

        public FormBuscarPedido()
        {
            InitializeComponent();
        }

        public Order? GetPedido()
        {
            return pedido;
        }

        /// <summary>
        /// Crea el DataTable y sus columnas
        /// </summary>
        private void CrearColumnas()
        {
            pedidos = Gestion.ListarPedidos();
            tablaPedidos = new DataTable("Pedidos");

            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Id_Pedido";
            tablaPedidos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Id_Cliente";
            tablaPedidos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nombre_Cliente";
            tablaPedidos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Empresa_Cliente";
            tablaPedidos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Fecha_Pedido";
            tablaPedidos.Columns.Add(column);            
        }

        private void FormBuscarPedido_Load(object sender, EventArgs e)
        {
            CrearColumnas();
            FiltrarPedidos();
        }

        /// <summary>
        /// Muestra los datos filtrados por Id de Cliente y/o por Fecha de Pedido
        /// Si no se establece un filtro muestra todos los pedidos
        /// </summary>
        private void FiltrarPedidos()
        {
            if (tablaPedidos != null)
            {
                tablaPedidos.Rows.Clear();
                if (pedidos != null)
                {
                    foreach (Order o in pedidos)
                    {
                        Customer? c = null;
                        using (Gestion gestion = new Gestion())
                        {
                            if (o.CustomerId != null)
                                c = gestion.ObtenerCustomer(o.CustomerId);
                        }
                            tablaPedidos.Rows.Add(o.OrderId, o.CustomerId, 
                                c?.ContactName, c?.CompanyName, o.OrderDate);
                    }

                    DateTime? fechaPedido = dtpFechaBusqueda.Value; 
                    vista = new DataView(tablaPedidos);

                    if (cbFecha.Checked && cbCliente.Checked)
                    {
                        vista.RowFilter = "Id_Cliente like '%"
                            + cliente?.CustomerId + "%' and " +
                            "Fecha_Pedido like '%" +
                            fechaPedido?.ToString("dd/MM/yyyy") + "%'";
                    }
                    else if (cbCliente.Checked)
                    {
                        vista.RowFilter = "Id_Cliente like '%"
                            + cliente?.CustomerId + "%'";
                    }
                    else if (cbFecha.Checked)
                    {
                        vista.RowFilter = "Fecha_Pedido like '%"
                            + fechaPedido?.ToString("dd/MM/yyyy") + "%'";
                    }    

                    dataGridViewPedidos.DataSource = vista;                    
                }
            }
        }

        private void FormBuscarPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            FormBusquedaCliente formBuscarCliente = new FormBusquedaCliente();
            formBuscarCliente.Owner = this;
            this.Hide();
            formBuscarCliente.ShowDialog();
            Customer? clienteSeleccionado = formBuscarCliente.GetCliente();
            if (clienteSeleccionado != null)
                cliente = formBuscarCliente.GetCliente();
            cbCliente.Checked = true;
            FiltrarPedidos();
        }

        private void dtpFechaBusqueda_ValueChanged(object sender, EventArgs e)
        {
            fechaPedido = dtpFechaBusqueda.Value;
            cbFecha.Checked = true;
            FiltrarPedidos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            FiltrarPedidos();
        }

        private void SeleccionarPedido()
        {
            if (dataGridViewPedidos.CurrentRow != null)
            {
                int pedidoId = Convert.ToInt32(dataGridViewPedidos.Rows[dataGridViewPedidos.CurrentRow.Index]
                    .Cells[0].Value);

                using (Gestion gestion = new Gestion())
                {
                    pedido = gestion.ObtenerPedido(pedidoId);
                }
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            SeleccionarPedido();
            Close();
        }

        private void dataGridViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarPedido();
            Close();
        }

        private void cbCliente_CheckStateChanged(object sender, EventArgs e)
        {
            if (cliente != null)
                FiltrarPedidos();
        }

        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPedidos();
        }
    }
}
