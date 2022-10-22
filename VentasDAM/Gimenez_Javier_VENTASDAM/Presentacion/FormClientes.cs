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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dataGridView1.DataSource = Gestion.ListadoClientes();
            // mostrar pedidos de un empleado
            // dataGridView1.DataSource = Gestion.ListarPedidosEmpleado(EmpleadoId);
        }

        // muestra los pedidos del cliente clickado
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string? clienteId = dataGridView1.Rows[dataGridView1.CurrentRow.Index]
               .Cells[0].Value.ToString();


            var pedidosCliente = Gestion.ListarPedidosCliente(clienteId);
            dataGridView1.DataSource = pedidosCliente;
            foreach (var pedido in pedidosCliente)
                MessageBox.Show(pedido.ToString());

                      
        }
    }
}
