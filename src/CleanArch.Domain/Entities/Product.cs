using System;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // FK para Category (1:N)
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
