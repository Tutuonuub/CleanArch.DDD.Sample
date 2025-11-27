using System.ComponentModel.DataAnnotations;
using CleanArch.Application.Validations;

namespace CleanArch.Application.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 e 100 caracteres")]
        [NotOnlyWhiteSpace(ErrorMessage = "Nome não pode ser apenas espaços")]
        public string Name { get; set; } = null!;
    }
}
