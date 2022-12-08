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
    /// Clase Employee.
    /// Version 1.0
    /// <autor>Javier Giménez</autor> 
    /// </summary>
    [Index("LastName", Name = "LastName")]
    [Index("PostalCode", Name = "PostalCode")]    
    public partial class Employee : IComparable<Employee>
    {       
        /// <summary>
        /// Clave primaria del empleado.
        /// </summary>
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        /// <summary>
        /// Apellido del empleado con longitud máxima de 20 caracteres
        /// </summary>
        [StringLength(20)]
        public string LastName { get; set; } = null!;
        /// <summary>
        /// Nombre del empleado con longitud máxima de 10 caracteres
        /// </summary>
        [StringLength(10)]
        public string FirstName { get; set; } = null!;
        /// <summary>
        /// Cargo del empleado con longitud máxima de 30 caracteres
        /// </summary>
        [StringLength(30)]
        public string? Title { get; set; }
        /// <summary>
        /// Título de cortesía con longitud máxima de 25 caracteres
        /// </summary>
        [StringLength(25)]
        public string? TitleOfCourtesy { get; set; }
        /// <summary>
        /// Fecha de nacimiento del empleado
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Fecha de contratación del empleado
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
        /// <summary>
        /// Dirección de residencia del empleado con longitud máxima de 60 caracteres
        /// </summary>
        [StringLength(60)]
        public string? Address { get; set; }
        /// <summary>
        /// Ciudad de residencia del empleado con longitud máxima de 15 caracteres
        /// </summary>
        [StringLength(15)]
        public string? City { get; set; }
        /// <summary>
        /// Provincia de residencia del empleado con longitud máxima de 15 caracteres
        /// </summary>
        [StringLength(15)]
        public string? Region { get; set; }
        /// <summary>
        /// Código postal de residencia del empleado con longitud máxima de 10 caracteres
        /// </summary>
        [StringLength(10)]
        public string? PostalCode { get; set; }
        /// <summary>
        /// País de residencia del empleado con longitud máxima de 15 caracteres
        /// </summary>
        [StringLength(15)]
        public string? Country { get; set; }
        /// <summary>
        /// Teléfono personal del empleado con longitud máxima de 24 caracteres
        /// </summary>
        [StringLength(24)]
        public string? HomePhone { get; set; }
        /// <summary>
        /// Extensión para el teléfono del empleado con longitud máxima de 4 caracteres
        /// </summary>
        [StringLength(4)]
        public string? Extension { get; set; }
        /// <summary>
        /// Foto personal para identificar al empleado
        /// </summary>
        [Column(TypeName = "image")]
        public byte[]? Photo { get; set; }
        /// <summary>
        /// Información adicional del empleado
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// Identificador del empleado supervisor
        /// </summary>
        public int? ReportsTo { get; set; }
        /// <summary>
        /// Ruta de acceso a la foto del empleado con longitud máxima de 255 caracteres
        /// </summary>
        [StringLength(255)]
        public string? PhotoPath { get; set; }

        /// <summary>
        /// Clave ajena a Employees para enlazar los reportes al supervisor
        /// </summary>
        [ForeignKey("ReportsTo")]
        [InverseProperty("InverseReportsToNavigation")]
        public virtual Employee? ReportsToNavigation { get; set; }
        /// <summary>
        /// Propiedad inversa para gestionar los reportes al supervisor
        /// </summary>
        [InverseProperty("ReportsToNavigation")]        
        public virtual ICollection<Employee>? InverseReportsToNavigation { get; set; }
        /// <summary>
        /// Colección con los pedidos realizados por el empleado
        /// </summary>
        [InverseProperty("Employee")]
        public virtual ICollection<Order>? Orders { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Employee()
        {
            InverseReportsToNavigation = new HashSet<Employee>();
            Orders = new HashSet<Order>();
        }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="employeeId">Id de empleado</param>
        /// <param name="lastName">Apellido del empleado</param>
        /// <param name="firstName">Nombre del empleado</param>
        /// <param name="title">Cargo del empleado</param>
        /// <param name="titleOfCourtesy">Título de cortesía (Mr., Ms., Dr. Mrs.)</param>
        /// <param name="birthDate">Año de nacimiento del empleado</param>
        /// <param name="hireDate">Año de contratación del empleado</param>
        /// <param name="address">Dirección del empleado</param>
        /// <param name="city">Ciudad de residencia del empleado</param>
        /// <param name="region">Provincia de residencia del empleado</param>
        /// <param name="postalCode">Código postal de residencia del empleado</param>
        /// <param name="country">País de residencia del empleado</param>
        /// <param name="homePhone">Télefono personal del empleado</param>
        /// <param name="extension">Extensión del teléfono del empleado</param>
        /// <param name="photo">Foto identificación del empleado</param>
        /// <param name="notes">Información adicional del empleado</param>
        /// <param name="photoPath">Ruta de acceso a la foto del empleado</param>
        /// <param name="reportsTo">Empleado supervisor del empleado</param>
        public Employee(int employeeId, string lastName, string firstName, 
            string? title, string? titleOfCourtesy, DateTime? birthDate, 
            DateTime? hireDate, string? address, string? city, string? region, 
            string? postalCode, string? country, string? homePhone, 
            string? extension, byte[]? photo, string? notes, string? photoPath,
            int reportsTo)
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
            PhotoPath = photoPath;
            ReportsTo = reportsTo;
        }

        /// <summary>
        /// Constructor con los parámetros obligatorios
        /// </summary>
        /// <param name="employeeId">Código de identificación del empleado</param>
        /// <param name="lastName">Apellido del empleado</param>
        /// <param name="firstName">Nombre del empleado</param>
        public Employee(int employeeId, string lastName, string firstName)
            :this(employeeId, lastName, firstName, null, null, null, null, null, null, null,
                 null, null, null, null, null, null, null, -1)
        { }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="e">Empleado del que se realiza la copia</param>
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

        /// <summary>
        /// Método de comparación.
        /// La interfaz IComparable exige la implementación de un método CompareTo.
        /// Se realiza la ordenación por Firstname y después por Lastname
        /// </summary>
        /// <param name="otro">Segundo empleado para realizar la comparación</param>
        /// <returns>-1 si el empleado actual es menor que el recibido por parámetro, 
        /// 0 si los dos empleados son iguales o 1 si el empleado actual es mayor que el recibido por parámetro</returns>
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

        /// <summary>
        /// Sobrecarga del método ToString.
        /// </summary>
        /// <returns>Una cadena de texto con todos los datos del empleado separados por #</returns>
        public override string ToString()
        {
            return EmployeeId + "#" + LastName + "#" + FirstName
                + "#" + Title + "#" + TitleOfCourtesy + "#" + BirthDate
                + "#" + HireDate + "#" + Address + "#" + City + "#" + Region
                + "#" + PostalCode + "#" + Country + "#" + HomePhone
                + "#" + Extension + "#" + Photo + "#" + Notes;
        }

        /// <summary>
        /// Destructor
        /// </summary>
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
