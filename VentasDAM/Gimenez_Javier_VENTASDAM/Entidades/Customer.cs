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
    
    [Index("City", Name = "City")]
    [Index("CompanyName", Name = "CompanyName")]
    [Index("PostalCode", Name = "PostalCode")]
    [Index("Region", Name = "Region")]
    public partial class Customer
    {       
        [Key]
        [Column("CustomerID")]
        [StringLength(5)]
        public string CustomerId { get; set; } = null!;
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [StringLength(30)]
        public string? ContactName { get; set; }
        [StringLength(30)]
        public string? ContactTitle { get; set; }
        [StringLength(60)]
        public string? Address { get; set; }
        [StringLength(15)]
        public string? City { get; set; }
        [StringLength(15)]
        public string? Region { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(15)]
        public string? Country { get; set; }
        [StringLength(24)]
        public string? Phone { get; set; }
        [StringLength(24)]
        public string? Fax { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Order>? Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        // Constructor con todos los parámetros
        public Customer(string customerId, string companyName, 
            string? contactName, string? contactTitle, string? address, 
            string? city, string? region, string? postalCode, string? country, 
            string? phone, string? fax)
            :this()
        {
            CustomerId = customerId;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
        }

        // Constructor con los parámetros obligatorios
        public Customer(string customerId, string companyName)
            :this(customerId, companyName, null, null, null, null, null, null, 
                 null, null, null)
        {

        }

        public override string ToString()
        {
           return CustomerId + "#" + CompanyName + "#" + ContactName +
                "#" + ContactTitle + "#" + Address + "#" + City + "#" + Region +
                "#" + PostalCode + "#" + Country + "#" + Phone + "#" + Fax;
        }

        ~Customer()
        {
            if (Orders != null)
                Orders.Clear();
            Orders = null;
        }
    }
}
