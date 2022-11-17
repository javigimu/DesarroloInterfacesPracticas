using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public partial class FormBusquedaCliente : Form
    {
        ICollection<Customer>? clientes;
        DataTable? tablaClientes;
        DataView? vista;
        Customer? cliente;

        public FormBusquedaCliente()
        {
            InitializeComponent();            
        }

        public Customer? GetCliente()
        {
            return cliente;
        }

        private void FiltrarCliente()
        {
            if (tablaClientes != null)
            {
                tablaClientes.Rows.Clear();
                if (clientes != null)
                {
                    foreach (Customer cus in clientes)
                        tablaClientes.Rows.Add(cus.CustomerId, cus.ContactName, cus.CompanyName);

                    vista = new DataView(tablaClientes);
                    if (tbBuscarCliente.Text.Trim() != "")
                    {
                        vista.RowFilter = "Nombre like '%" + tbBuscarCliente.Text
                            + "%' or Nombre_Empresa like '%" + tbBuscarCliente.Text + "%'";
                       
                    }

                    dataGridViewBuscar.DataSource = vista;
                }
            }
        }

        private void FiltrarClientes(object sender, KeyEventArgs e)
        {
            FiltrarCliente();
        }

        private void CrearColumnasCliente()
        {
            clientes = Gestion.ListadoClientes();
            tablaClientes = new DataTable("Clientes");

            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Id_Cliente";
            column.ReadOnly = true;
            tablaClientes.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nombre";
            column.ReadOnly = true;
            tablaClientes.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nombre_Empresa";
            column.ReadOnly = true;
            tablaClientes.Columns.Add(column);

            dataGridViewBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CrearColumnas(object sender, EventArgs e)
        {
            CrearColumnasCliente();
            FiltrarCliente();
        }

        private void ConfirmarSeleccion(object sender, DataGridViewCellEventArgs e)
        {
            string? customerId = dataGridViewBuscar.Rows[dataGridViewBuscar.CurrentRow.Index]
                .Cells[0].Value.ToString();

            using (Gestion gestion = new Gestion())
            {
                if (customerId != null)
                    cliente = gestion.ObtenerCustomer(customerId);                
            }

            Close();
        }

        // closing -> muestra el formulario padre
        private void MostrarFormPadre(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cliente = null;
            Close();
        }

    }
}
