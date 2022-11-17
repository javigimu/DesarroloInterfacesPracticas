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

    public partial class FormProductos : Form
    {
        private ICollection<Category>? categorias;
        private ICollection<Product>? productos;
        Product? producto;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void CargarCategorias(object sender, EventArgs e)
        {
            categorias = Gestion.ListadoCategorias();
            foreach(Category categoria in categorias)
            {
                Image? imagenCategoria = byteArrayToImage(categoria.Picture);

                dataGridViewCategorias.Rows.Add(categoria.CategoryId, categoria.CategoryName,
                    categoria.Description, imagenCategoria);
            }
        }

        public Image? byteArrayToImage(byte[]? imagenEnBytes)
        {
            if (imagenEnBytes != null)
            {
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image? img = (Image?)converter.ConvertFrom(imagenEnBytes);
                return img;
            }
            return null;
        }

        private void MostrarProductos(object sender, DataGridViewCellEventArgs e)
        {
            int categoriaId = Convert.ToInt32(dataGridViewCategorias.Rows[dataGridViewCategorias.CurrentRow.Index]
                .Cells[0].Value.ToString());
            MostrarProductos(categoriaId);
        }

        private void MostrarProductos(int categoriaId)
        {
            dataGridViewProductos.Rows.Clear();

            if (categoriaId == -1)
                productos = Gestion.ListadoProductos();
            else           
                productos = Gestion.ListadoProductosPorCategoria(categoriaId);
           
            MostrarProductos(productos);
        }

        private void MostrarProductos(ICollection<Product> productos)
        {
            if (productos != null)
            {
                foreach (Product producto in productos)
                {
                    dataGridViewProductos.Rows.Add(producto.CategoryId, producto.ProductId,
                        producto.ProductName);
                }
            }
        }

        private void MostrarProducto(object sender, DataGridViewCellEventArgs e)
        {
            int productoId = Convert.ToInt32(dataGridViewProductos.Rows[dataGridViewProductos.CurrentRow.Index]
                .Cells[1].Value.ToString());
            using (Gestion gestion = new Gestion())
            {
                producto = gestion.ObtenerProduct(productoId);
                if (producto != null)
                {
                    tbNombre.Text = producto.ProductName;
                    tbCantidadPorUnidad.Text = producto.QuantityPerUnit;
                    tbNivelRepedidos.Text = producto.ReorderLevel.ToString();
                    tbDiscontinuo.Text = producto.Discontinued.ToString();
                    tbUnidadesStock.Text = producto.UnitsInStock.ToString();
                    tbUnidadesPedido.Text = producto.UnitsOnOrder.ToString();
                    tbPrecio.Text = producto.UnitPrice.ToString();
                }
            }            
        }

        private void FormatearPrecio(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = '.';
        }

        private void btActualizarPrecio_Click(object sender, EventArgs e)
        {
            using (Gestion gestion = new Gestion())
            {
                if (producto != null)
                {
                    producto.UnitPrice = Convert.ToDecimal(tbPrecio.Text, new CultureInfo("en-US"));
                    gestion.ActualizarProducto(producto);
                    Mensaje.MostrarProcesoFinalizadoCorrectamente("Actualizar", "precio");
                    productos = Gestion.ListadoProductos();
                    int categoriaId = Convert.ToInt32(dataGridViewCategorias.Rows[dataGridViewCategorias.CurrentRow.Index]
                        .Cells[0].Value.ToString());
                    MostrarProductos(categoriaId);
                }
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void FiltrarProductosPorNombre(object sender, KeyEventArgs e)
        {
            List<Product> productosFiltrados = new List<Product>();
            if (productos != null)
            {
                foreach (Product p in productos)
                {
                    if (p.ProductName.ToLower().Contains(tbFiltradoNombre.Text.ToLower()))
                        productosFiltrados.Add(p);
                }

                dataGridViewProductos.Rows.Clear();
                MostrarProductos(productosFiltrados);
            }
            
        }

        private void FormProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
