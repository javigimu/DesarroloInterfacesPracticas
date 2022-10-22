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

    public partial class Shipper
    {      
        [Key]
        [Column("ShipperID")]
        public int ShipperId { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [StringLength(24)]
        public string? Phone { get; set; }

        [InverseProperty("ShipViaNavigation")]
        public virtual ICollection<Order>? Orders { get; set; }

        public Shipper()
        {
            Orders = new HashSet<Order>();
        }
       

        // Constructor con todos los parámetros
        public Shipper(int shipperId, string companyName, string? phone)
            :this()
        {
            ShipperId = shipperId;
            CompanyName = companyName;
            Phone = phone;
        }

        // Constructor con los parámetros obligatorios
        public Shipper(int shipperId, string companyName)
            :this(shipperId, companyName, null)
        { }

        public override string ToString()
        {
            return ShipperId + "#" + CompanyName + "#" + Phone;
        }

        ~Shipper()
        {
            if (Orders != null)
                Orders.Clear();
            Orders = null;
        }
    }
}
