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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// Crea un gráfico circular con los datos de los productos por categoría
    /// </summary>
    public partial class FormGraficoProductoCategoria : Form
    {
        public FormGraficoProductoCategoria()
        {
            InitializeComponent();
        }

        private void FormGraficoProductoCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void FormGraficoProductoCategoria_Load(object sender, EventArgs e)
        {
            LLenarGrafico();
        }

        /// <summary>
        /// Lleno el gráfico con los datos de los productos por categoría
        /// </summary>
        private void LLenarGrafico()
        {
            ICollection<Category>? categorias = Gestion.ListadoCategorias();
            ICollection<Product>? productos = Gestion.ListadoProductos();

            Dictionary<string, int> productosPorCategoria = new Dictionary<string, int>();
            if (productos != null && categorias != null)
            {
                foreach (Product p in productos)
                {
                    foreach (Category c in categorias)
                    {                    
                        if (p.CategoryId == c.CategoryId)
                        {
                            if (productosPorCategoria.ContainsKey(c.CategoryName))
                                productosPorCategoria[c.CategoryName]++;
                            else
                                productosPorCategoria.Add(c.CategoryName, 1);
                        }
                    } 
                }
            }


            //AddXY value in chart1 in series named as Productos_Categoria

            chart1.ChartAreas[0].AxisY.Title = "Cantidad de Productos";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Roboto", 11, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.Title = "Categoría";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Roboto", 11, FontStyle.Bold);
            // Intervalo a 1 para que aparezcan todos los id de los clientes
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series["Productos_Categoria"].IsValueShownAsLabel = true;
            foreach (KeyValuePair<string, int> dato in productosPorCategoria)
            {
                chart1.Series["Productos_Categoria"].Points.AddXY(dato.Key, dato.Value);
            }

            //chart title  
            chart1.Titles.Add("Productos por Categoría Chart");
        }
    }
}
