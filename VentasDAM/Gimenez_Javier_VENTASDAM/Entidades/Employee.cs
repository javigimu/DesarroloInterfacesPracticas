using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    /// <summary>
    /// <autor>Javier Giménez</autor>
    /// </summary>

    [Index("LastName", Name = "LastName")]
    [Index("PostalCode", Name = "PostalCode")]
    public partial class Employee : IComparable<Employee>
    {       
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [StringLength(20)]
        public string LastName { get; set; } = null!;
        [StringLength(10)]
        public string FirstName { get; set; } = null!;
        [StringLength(30)]
        public string? Title { get; set; }
        [StringLength(25)]
        public string? TitleOfCourtesy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
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
        public string? HomePhone { get; set; }
        [StringLength(4)]
        public string? Extension { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int? ReportsTo { get; set; }
        [StringLength(255)]
        public string? PhotoPath { get; set; }

        [ForeignKey("ReportsTo")]
        [InverseProperty("InverseReportsToNavigation")]
        public virtual Employee? ReportsToNavigation { get; set; }
        [InverseProperty("ReportsToNavigation")]
        public virtual ICollection<Employee>? InverseReportsToNavigation { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Order>? Orders { get; set; }

        public Employee()
        {
            InverseReportsToNavigation = new HashSet<Employee>();
            Orders = new HashSet<Order>();
        }
        
        // Constructor con todos los parámetros
        public Employee(int employeeId, string lastName, string firstName, 
            string? title, string? titleOfCourtesy, DateTime? birthDate, 
            DateTime? hireDate, string? address, string? city, string? region, 
            string? postalCode, string? country, string? homePhone, 
            string? extension, byte[]? photo, string? notes)
            :this()
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            TitleOfCourtesy = titleOfCourtesy;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            HomePhone = homePhone;
            Extension = extension;
            Photo = photo;
            Notes = notes;
        }        

        // Constructor con los parámetros obligatorios
        public Employee(int employeeId, string lastName, string firstName)
            :this(employeeId, lastName, firstName, null, null, null, null, null, null, null,
                 null, null, null, null, null, null)
        { }

        // Constructor de copia
        public Employee(Employee e)
        {
            EmployeeId = e.EmployeeId;
            LastName = e.LastName;
            FirstName = e.FirstName;
            Title = e.Title;
            TitleOfCourtesy = e.TitleOfCourtesy;
            BirthDate = e.BirthDate;
            HireDate = e.HireDate;
            Address = e.Address;
            City = e.City;
            Region = e.Region;
            PostalCode = e.PostalCode;
            Country = e.Country;
            HomePhone = e.HomePhone;
            Extension = e.Extension;

            if (e.Photo != null)
            {
                Photo = new byte[e.Photo.Length];
                for (int i = 0; i < e.Photo.Length; i++)
                    Photo[i] = e.Photo[i];
            }
            else
                Photo = null;

            if (e.InverseReportsToNavigation != null)
            {
                foreach (Employee emp in e.InverseReportsToNavigation)
                    InverseReportsToNavigation?.Add(emp);

            }

            if (e.Orders != null)
            {
                foreach (Order o in e.Orders)
                    Orders?.Add(o);
            }

            Notes = e.Notes;           
        }

        // Ordenado por Firstname y después por Lastname
        public int CompareTo(Employee? otro)
        {            
            int resultado = 0;

            if (FirstName.CompareTo(otro?.FirstName) < 0)
                resultado = -1;
            else if (FirstName.CompareTo(otro?.FirstName) > 0)
                resultado = 1;
            else
            {
                if (LastName.CompareTo(otro?.LastName) < 0)
                    resultado = -1;
                else if (LastName.CompareTo(otro?.LastName) > 0)
                    resultado = 1;
            }
            return resultado;
        }

        public override string ToString()
        {
            return EmployeeId + "#" + LastName + "#" + FirstName
                + "#" + Title + "#" + TitleOfCourtesy + "#" + BirthDate
                + "#" + HireDate + "#" + Address + "#" + City + "#" + Region
                + "#" + PostalCode + "#" + Country + "#" + HomePhone
                + "#" + Extension + "#" + Photo + "#" + Notes;
        }

        ~Employee()
        {
            if (Photo != null)
                Array.Clear(Photo);
            if (InverseReportsToNavigation != null)
                InverseReportsToNavigation.Clear();
            InverseReportsToNavigation = null;
            if (Orders != null)
                Orders.Clear();
            Orders = null;
        }
    }
}
