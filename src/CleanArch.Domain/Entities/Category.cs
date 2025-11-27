using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        // Navegação 1:N -> Products
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
