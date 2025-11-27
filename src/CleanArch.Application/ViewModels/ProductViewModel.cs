using System.ComponentModel.DataAnnotations;
using CleanArch.Application.Validations;

namespace CleanArch.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 e 120 caracteres")]
        [NotOnlyWhiteSpace(ErrorMessage = "Nome não pode ser apenas espaços")]
        public string Name { get; set; } = null!;

        [StringLength(500, ErrorMessage = "Descrição pode ter até 500 caracteres")]
        [MaxWords(50, ErrorMessage = "Descrição não pode conter mais de 50 palavras")]
        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Preço inválido")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatória")]
        public int CategoryId { get; set; }

        // Somente leitura na UI (opcional)
        public string? CategoryName { get; set; }
    }
}
