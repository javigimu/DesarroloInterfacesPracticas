using Microsoft.Reporting.WinForms;
using Modelos;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class Informe
    {
        Order? pedido;
        public Informe(Order pedido)
        {
            this.pedido = pedido;
        }

        /// <summary>
        /// función para cargar los datos en ReportFactura.rql
        /// Los datos se obtienen desde la clase ElementosInforme
        /// y otros se obtienen desde la clase Gestion 
        /// </summary>
        /// <param name="report"></param>
        /// <param name="pedido"></param>
        public static void Load(LocalReport report, Order pedido)
        {
            Customer? cliente = null;
            using (Gestion gestion = new Gestion())
            {
                if (pedido.CustomerId != null)
                    cliente = gestion.ObtenerCustomer(pedido.CustomerId);
            }

            List<OrderDetail> listaOrderDetail = new List<OrderDetail>();
            if (pedido.OrderDetails != null)
            {
                listaOrderDetail = pedido.OrderDetails.ToList();                
            }

            List<ElementosInforme> listaInforme = new List<ElementosInforme>();
            foreach (OrderDetail od in listaOrderDetail)
            {
                Product? producto = od.Product;
                string nombreProducto = "";
                if (producto != null)
                {
                    nombreProducto = producto.ProductName;
                }
                listaInforme.Add(new ElementosInforme
                {
                    ProductoId = od.ProductId,
                    ProductoNombre = producto == null ? "" : producto.ProductName,
                    PrecioUnidad = od.UnitPrice,
                    Cantidad = od.Quantity,
                    Descuento = od.Discount * 100,
                    IVA = Gestion.IVA,
                    Total = Gestion.TotalPedido
                });
            }


            string? fechaPedido = pedido.OrderDate == null ? "Fecha pedido desconocida" : 
                pedido.OrderDate?.ToString("dd/MM/yyyy");     
            string? nombreCliente = cliente == null ? "Nombre Desconocido" : cliente?.ContactName;
            string? direccion = pedido.ShipAddress == null ? "Dirección desconocida" : pedido.ShipAddress;
            string? ciudad = pedido.ShipCity == null ? "Ciudad desconocida" : pedido.ShipCity;
            string? region = pedido.ShipRegion == null ? "Region desconocida" : pedido.ShipRegion;
            string? codigoPostal = pedido.ShipPostalCode == null ? "CP desconocido" : pedido.ShipPostalCode;

            Gestion.CalcularTotalesPedido(listaOrderDetail);
            decimal totalSinIVA = Gestion.TotalSinIva;
            decimal totalIVA = totalSinIVA * (decimal)(Gestion.IVA / 100.0);
            decimal total = totalSinIVA + totalIVA;
            Gestion.ResetearTotales();
            
            var parameters = new[] { new ReportParameter("PedidoId", pedido.OrderId.ToString()), 
                new ReportParameter("FechaFactura", DateTime.Now.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaPedido", fechaPedido),
                new ReportParameter("ClienteNombre", nombreCliente),
                new ReportParameter("ClienteDireccion", direccion),
                new ReportParameter("ClienteCiudad", ciudad),
                new ReportParameter("ClienteRegion", region),
                new ReportParameter("ClienteCodigoPostal", codigoPostal),
                new ReportParameter("TotalSinIva", totalSinIVA.ToString("N2")),
                new ReportParameter("TotalIva", totalIVA.ToString("N2")),
                new ReportParameter("TotalFactura", total.ToString("N2"))
            };
            using var fs = new FileStream("ReportFactura.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("DatosFactura", listaInforme));
            report.SetParameters(parameters);
            byte[] pdf = report.Render("PDF");
        }
    }
}
