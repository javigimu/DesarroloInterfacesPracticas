using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    [Index("CategoryId", Name = "CategoriesProducts")]
    [Index("CategoryId", Name = "CategoryID")]
    [Index("ProductName", Name = "ProductName")]
    [Index("SupplierId", Name = "SupplierID")]
    [Index("SupplierId", Name = "SuppliersProducts")]
    public partial class Product
    {
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Column("SupplierID")]
        public int? SupplierId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(20)]
        public string? QuantityPerUnit { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Products")]
        public virtual Category? Category { get; set; }
        [ForeignKey("SupplierId")]
        [InverseProperty("Products")]
        public virtual Supplier? Supplier { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
       
        // Constructor con todos los parámetros
        public Product(int productId, string productName, int? supplierId, 
            int? categoryId, string? quantityPerUnit, decimal? unitPrice, 
            short? unitsInStock, short? unitsOnOrder, short? reorderLevel, 
            bool discontinued)
            :this()
        {
            ProductId = productId;
            ProductName = productName;
            SupplierId = supplierId;
            CategoryId = categoryId;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
        }

        // Constructor con los parámetros obligatorios
        // Por defecto le asigno un precio unitario de 1
        public Product(int productId, string productName, int supplierId,
            int categoryId)
            :this(productId, productName, supplierId, categoryId, null, 1, 0, 0, 0, false)
        { }

        public override string ToString()
        {
            return ProductId + "#" + ProductName + "#" + SupplierId
                + "#" + CategoryId + "#" + QuantityPerUnit + "#" + UnitPrice
                + "#" + UnitsInStock + "#" + UnitsOnOrder + "#" + ReorderLevel
                + "#" + Discontinued;
        }

        ~Product()
        {
            if (OrderDetails != null)
                OrderDetails.Clear();
            OrderDetails = null;
        }
    }
}
