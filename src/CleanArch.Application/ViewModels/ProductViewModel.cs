using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 e 120 caracteres")]
        public string Name { get; set; } = null!;

        [StringLength(500, ErrorMessage = "Descrição pode ter até 500 caracteres")]
        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Preço inválido")]
        public decimal Price { get; set; }
    }
}
