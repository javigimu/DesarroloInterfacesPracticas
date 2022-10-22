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

    [Index("CategoryName", Name = "CategoryName")]
    public partial class Category
    {       
        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Picture { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Product>? Products { get; set; }
       
        public Category()
        {
            Products = new HashSet<Product>();
        }

        // Constructor con todos los parámetros
        public Category(int categoryId, string categoryName, string? description, byte[]? picture)
            :this()
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }

        // Constructor con los parámetros obligatorios
        public Category(int categoryId, string categoryName)
            :this(categoryId, categoryName, null, null)
        {

        }
        
        public override string ToString()
        {
            return CategoryId + "#" + CategoryName + "#" + Description + "#" +
                Picture;
        }

        ~Category()
        {
            if (Picture != null)
                Array.Clear(Picture);
            Picture = null;
            if (Products != null)
                Products.Clear();
            Products = null;
        }
    }
}
