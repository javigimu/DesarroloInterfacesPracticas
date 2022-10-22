using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();            
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            MostrarPedidos();
        }

        private void MostrarPedidos()
        {
            dataGridView1.DataSource = Gestion.ListarPedidos();
            // mostrar pedidos de un empleado
            // dataGridView1.DataSource = Gestion.ListarPedidosEmpleado(EmpleadoId);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pedidoId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index]
               .Cells[0].Value.ToString());

            var pedido = Gestion.DatosPedido(pedidoId);
            MessageBox.Show("Pedido: " + pedido.ToString());
            // Lista de Pedidos
            List<Order> orders = new List<Order>();
            orders.Add(pedido);
            //dataGridView1.DataSource = orders;
        }
    }
}
