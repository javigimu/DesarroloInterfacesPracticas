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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            dataGridView1.DataSource = Gestion.ListadoEmpleados();
        }

        // muestra los pedidos del empleado clickado
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int empleadoId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index]
                .Cells[0].Value.ToString());

            dataGridView1.DataSource = Gestion.ListarPedidosEmpleado(empleadoId);
        }
    }
}
