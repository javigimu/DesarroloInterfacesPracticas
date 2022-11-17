using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>

    [Index("CustomerId", Name = "CustomerID")]
    [Index("CustomerId", Name = "CustomersOrders")]
    [Index("EmployeeId", Name = "EmployeeID")]
    [Index("EmployeeId", Name = "EmployeesOrders")]
    [Index("OrderDate", Name = "OrderDate")]
    [Index("ShipPostalCode", Name = "ShipPostalCode")]
    [Index("ShippedDate", Name = "ShippedDate")]
    [Index("ShipVia", Name = "ShippersOrders")]
    public partial class Order
    {       
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("CustomerID")]
        [StringLength(5)]
        public string? CustomerId { get; set; }
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }
        [StringLength(40)]
        public string? ShipName { get; set; }
        [StringLength(60)]
        public string? ShipAddress { get; set; }
        [StringLength(15)]
        public string? ShipCity { get; set; }
        [StringLength(15)]
        public string? ShipRegion { get; set; }
        [StringLength(10)]
        public string? ShipPostalCode { get; set; }
        [StringLength(15)]
        public string? ShipCountry { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Orders")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("EmployeeId")]
        [InverseProperty("Orders")]
        public virtual Employee? Employee { get; set; }
        [ForeignKey("ShipVia")]
        [InverseProperty("Orders")]
        public virtual Shipper? ShipViaNavigation { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
       

        // Constructor con todos los parámetros
        public Order(int orderId, string? customerId, int? employeeId, 
            DateTime? orderDate, DateTime? requiredDate, DateTime? shippedDate, 
            int? shipVia, decimal? freight, string? shipName, string? shipAddress, 
            string? shipCity, string? shipRegion, string? shipPostalCode, 
            string? shipCountry)
            :this()
        {
            OrderId = orderId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipVia = shipVia;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
        }

        // Constructor con los parámetros obligatorios
        public Order(int orderId, string customerId, int employeeId)
            :this (orderId, customerId , employeeId, null, null, null, null, 
                 0, null, null, null,null, null, null)
        { }
        

        // Constructor de copia
        public Order(Order o)
        {
            OrderId = o.OrderId;
            CustomerId = o.CustomerId;
            EmployeeId = o.EmployeeId;
            OrderDate = o.OrderDate;
            RequiredDate = o.RequiredDate;
            ShippedDate = o.ShippedDate;
            ShipVia = o.ShipVia;
            Freight = o.Freight;
            ShipName = o.ShipName;
            ShipAddress = o.ShipAddress;
            ShipCity = o.ShipCity;
            ShipRegion = o.ShipRegion;
            ShipPostalCode = o.ShipPostalCode;
            ShipCountry = o.ShipCountry;      
            if (o.OrderDetails != null)
            {
                foreach (OrderDetail od in o.OrderDetails)
                {
                    OrderDetails?.Add(od);
                }
            }
        }

        public override string ToString()
        {
            String texto = OrderId + "#" + CustomerId + "#" + EmployeeId
                + "#" + OrderDate + "#" + RequiredDate + "#" + ShippedDate
                + "#" + ShipVia + "#" + Freight + "#" + ShipName + "#" + ShipAddress
                + "#" + ShipCity + "#" + ShipRegion + "#" + ShipPostalCode
                + "#" + ShipCountry + "#OrderDetails: ";
            
            if (OrderDetails != null)
            {
                foreach (OrderDetail od in OrderDetails)
                    texto += od.ToString() + "#";
            }

            return texto;
        }

        ~Order()
        {
            if (OrderDetails != null)
                OrderDetails.Clear();
            OrderDetails = null;
        }
    }
}
