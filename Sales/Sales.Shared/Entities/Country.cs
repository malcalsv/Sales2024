using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "el campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} solo puede ser mayor de {1} caracteres")]
        public string Name { get; set; } = null!;

    }
}
