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
    /// Formulario de búsqueda de productos
    /// </summary>
    public partial class FormBusquedaProducto : Form
    {
        Product? producto;
        ICollection<Product>? productos;
        DataTable? tablaProductos;
        DataView? vista;

        public FormBusquedaProducto()
        {
            InitializeComponent();
        }

        public Product? GetProducto()
        {
            return producto;
        }

        private void FormBusquedaProducto_Load(object sender, EventArgs e)
        {
            CrearTablaProductos();
            CargarTablaProductos();
        }

        /// <summary>
        /// Creo un DataTable para los productos y sus columnas
        /// </summary>
        private void CrearTablaProductos()
        {
            productos = Gestion.ListadoProductos();

            tablaProductos = new DataTable("Productos");
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Id_Producto";            
            tablaProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nombre";
            tablaProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = "Precio_Unidad";
            tablaProductos.Columns.Add(column);

            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarTablaProductos()
        {
            FiltrarProductos();
        }

        /// <summary>
        /// Filtra los productos por nombre o los muestra todos si no se establece un filtro
        /// </summary>
        private void FiltrarProductos()
        {
            if (tablaProductos != null)
            {
                tablaProductos.Rows.Clear();
                if (productos != null)
                {
                    foreach (Product p in productos)
                        tablaProductos.Rows.Add(p.ProductId, p.ProductName, p.UnitPrice);

                    vista = new DataView(tablaProductos);
                    if (tbNombre.Text.Trim() != "")
                    {
                        vista.RowFilter = "Nombre like '%" + tbNombre.Text + "%'";
                    }

                    dataGridViewProductos.DataSource = vista;
                }
            }
        }

        private void FormBusquedaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void tbNombre_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarProductos();
        }

        private void AnyadirProducto()
        {
            int productId = Convert.ToInt32(dataGridViewProductos.Rows[dataGridViewProductos.CurrentRow.Index]
               .Cells[0].Value.ToString());

            using (Gestion gestion = new Gestion())
            {
                producto = gestion.ObtenerProduct(productId);
            }

            Close();
        }


        private void btAnyadir_Click(object sender, EventArgs e)
        {
            AnyadirProducto();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnyadirProducto();
        }

        private void cancelarYSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AnyadirProducto();
        }
    }
}
