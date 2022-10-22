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

    [Index("CompanyName", Name = "CompanyName")]
    [Index("PostalCode", Name = "PostalCode")]
    public partial class Supplier
    {
        [Key]
        [Column("SupplierID")]
        public int SupplierId { get; set; }
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
        public string? HomePage { get; set; }

        [InverseProperty("Supplier")]
        public virtual ICollection<Product>? Products { get; set; }

        public Supplier()
        {
            Products = new HashSet<Product>();
        }


        // Constructor con todos los parámetros
        public Supplier(int supplierId, string companyName, string? contactName, 
            string? contactTitle, string? address, string? city, string? region, 
            string? postalCode, string? country, string? phone, string? fax, 
            string? homePage)
            :this()
        {
            SupplierId = supplierId;
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
            HomePage = homePage;
        }

        // Constructor con los parámetros obligatorios
        public Supplier(int supplierId, string companyName)
            :this(supplierId, companyName, null, null, null, null, null, null, null, null, null, null)
        { }

        public override string ToString()
        {
            return SupplierId + "#" + CompanyName + "#" + ContactName
                + "#" + ContactTitle + "#" + Address + "#" + City + "#" + Region
                + "#" + PostalCode + "#" + Country + "#" + Phone + "#" + Fax
                + "#" + HomePage;
        }

        ~Supplier()
        {
            if (Products != null)
                Products.Clear();
            Products = null;
        }
    }
}
