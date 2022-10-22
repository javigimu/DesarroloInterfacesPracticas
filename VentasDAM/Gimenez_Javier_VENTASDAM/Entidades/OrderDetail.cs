using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>

    [Table("Order Details")]
    [Index("OrderId", Name = "OrderID")]
    [Index("OrderId", Name = "OrdersOrder_Details")]
    [Index("ProductId", Name = "ProductID")]
    [Index("ProductId", Name = "ProductsOrder_Details")]
    public partial class OrderDetail
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; } = null!;
        [ForeignKey("ProductId")]
        [InverseProperty("OrderDetails")]
        public virtual Product? Product { get; set; } = null!;


        // Constructor con todos los parámetros (son todos obligatorios)
        public OrderDetail(int orderId, int productId, decimal unitPrice, short quantity, float discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }       

        public override string ToString()
        {
            string texto = OrderId + "#" + ProductId + "#" + UnitPrice + "#" + Quantity
                + "#" + Discount;
            if (Product != null)
                texto += "#Product: " + Product.ToString();
            return texto;
        }

        ~OrderDetail()
        {
            Product = null;
        }
    }
}
