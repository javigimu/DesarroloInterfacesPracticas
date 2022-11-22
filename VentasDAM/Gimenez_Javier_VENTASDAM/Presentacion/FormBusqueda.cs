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
    /// Formulario para buscar un empleado
    /// </summary>
    public partial class FormBusqueda : Form
    {
        ICollection<Employee>? empleados;
        DataTable? tablaEmpleados;
        DataView? vista;
        Employee? empleado;
        bool esBorrado;

        public FormBusqueda(bool esBorrado)
        {
            InitializeComponent();
            this.esBorrado = esBorrado;
        }

        public Employee? GetEmpleado()
        {
            return empleado;
        }

        /// <summary>
        /// Filtra los empleados por nombre, apellido o Id de Empleado
        /// o muestra todos los empleados si no se establece un filtro
        /// </summary>
        private void FiltrarEmpleados()
        {
            if (tablaEmpleados != null)
            {
                tablaEmpleados.Rows.Clear();
                if (empleados != null)
                {
                    foreach (Employee emp in empleados)
                        tablaEmpleados.Rows.Add(emp.EmployeeId, emp.FirstName, emp.LastName);

                    vista = new DataView(tablaEmpleados);
                    if (tbTextoBuscar.Text.Trim() != "")
                    {
                        if (rbNombre.Checked)
                        {
                            vista.RowFilter = "Nombre like '%" + tbTextoBuscar.Text
                                + "%' or Apellido like '%" + tbTextoBuscar.Text + "%'";
                        }
                        else if (rbId.Checked)
                        {
                            vista.RowFilter = "Id_Empleado like '%" + tbTextoBuscar.Text
                                + "%'";
                        }
                    }

                    dataGridViewBuscar.DataSource = vista;
                }
            }
        }

        private void FiltrarEmpleados(object sender, KeyEventArgs e)
        {
            FiltrarEmpleados();
        }

        private void CambiarFiltrado(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        /// <summary>
        /// Crea un DataTable y sus columnas para mostrar los empleados
        /// </summary>
        private void CrearColumnasEmpleado()
        {
            empleados = Gestion.ListadoEmpleados();
            tablaEmpleados = new DataTable("Empleados");          

            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Id_Empleado";
            tablaEmpleados.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nombre";
            tablaEmpleados.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Apellido";
            tablaEmpleados.Columns.Add(column);
        }

        private void CrearColumnas(object sender, EventArgs e)
        {
            CrearColumnasEmpleado();
            FiltrarEmpleados();
        }

        private void ConfirmarSeleccion(object sender, DataGridViewCellEventArgs e)
        {
            int empleadoId = Convert.ToInt32(dataGridViewBuscar.Rows[dataGridViewBuscar.CurrentRow.Index]
                .Cells[0].Value.ToString());

            using (Gestion gestion = new Gestion())
            {
                empleado = gestion.ObtenerEmpleado(empleadoId);
            }

            if (empleado != null)
            {
                string aviso;
                if (esBorrado)
                    aviso = "Se va a eliminar el empleado, desea continuar?";
                else
                    aviso = "Confirme el usuario";

                DialogResult respuesta = Mensaje.ConfirmarSeleccion(empleado, aviso);
                if (respuesta == DialogResult.OK)
                {                    
                    Owner.Show();
                    Close();
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    empleado = null;
                }
            }
        }

        private void MostrarFormPadre(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
