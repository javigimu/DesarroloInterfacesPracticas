using Modelos;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// Crea un gráfico de barras con la cantidad de pedidos por cliente
    /// </summary>
    public partial class FormGraficoClientePedido : Form
    {
        public FormGraficoClientePedido()
        {
            InitializeComponent();
        }

        private void FormGraficoClientePedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void FormGraficoClientePedido_Load(object sender, EventArgs e)
        {
            LLenarGrafico();
        }

        /// <summary>
        /// Llena el gráfico con los datos de los pedidos por cliente
        /// </summary>
        private void LLenarGrafico()
        {
            ICollection<Order>? pedidos = Gestion.ListarPedidos();
            Dictionary<string, int> pedidosPorCliente = new Dictionary<string, int>();
            if (pedidos != null)
            {               
                foreach(Order o in pedidos)
                {
                    if (o.CustomerId != null)
                    {
                        if (pedidosPorCliente.ContainsKey(o.CustomerId))
                            pedidosPorCliente[o.CustomerId]++;
                        else
                            pedidosPorCliente.Add(o.CustomerId, 1);
                    }
                }
            }

            //AddXY value in chart1 in series named as Pedidos Cliente

            chart1.ChartAreas[0].AxisY.Title = "Cantidad de pedidos";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Roboto", 11, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.Title = "Clientes";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Roboto", 11, FontStyle.Bold);
            // Intervalo a 1 para que aparezcan todos los id de los clientes
            chart1.ChartAreas[0].AxisX.Interval = 1;
            foreach (KeyValuePair<string, int> dato in pedidosPorCliente)
            {
                chart1.Series["Pedidos Cliente"].Points.AddXY(dato.Key, dato.Value);
            }

            //chart title  
            chart1.Titles.Add("Pedidos por Cliente Chart");
        }
    }
}
