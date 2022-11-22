using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Clase utilizada para realizar los informes
    /// <autor>Javier Giménez</autor>
    /// </summary>
    public class ElementosInforme
    {
        public int PedidoId { get; set; }
        public string ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public DateTime FechaPedido { get; set; }
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }
        public decimal TotalSinIva => (PrecioUnidad - (PrecioUnidad * (decimal)Descuento / 100)) * Cantidad;
        public int IVA { get; set; }
        public decimal Total { get; set; }
    }
}
