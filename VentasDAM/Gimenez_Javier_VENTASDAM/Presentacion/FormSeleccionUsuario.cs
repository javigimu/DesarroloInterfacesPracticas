using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class FormSeleccionUsuario : Form
    {
        public int EmpleadoSeleccionadoId { get; set; }

        public FormSeleccionUsuario()
        {
            InitializeComponent();
            EmpleadoSeleccionadoId = -1;
        }

        private void FormSeleccionUsuario_Load(object sender, EventArgs e)
        {
            ICollection<Employee>? empleados = Gestion.ListadoEmpleados();
            foreach (Employee emp in empleados)
            {
                dataGridView1.Rows.Add(emp.EmployeeId, emp.FirstName, emp.LastName,
                    emp.Title, emp.Photo);
            }
            //dataGridView1.DataSource = Gestion.ListadoEmpleados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int empleadoId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index]
                .Cells[0].Value.ToString());

            FormValidarUsuario fvu = new FormValidarUsuario(empleadoId);
            fvu.Owner = this;
            fvu.ShowDialog();
            if (fvu.ValidacionCorrecta)
            {
                EmpleadoSeleccionadoId = empleadoId;
                Owner.Show();
                Close();
            }
            else
            {
                Owner.Show();
            }
        }

        private void FormSeleccionUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
