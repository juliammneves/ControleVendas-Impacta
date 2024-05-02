using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }

        [Required]
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefone deve conter 11 digitos")]
        public string? Telefone { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve conter 11 digitos")]
        public string? CPF { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres.")]
        public string? Senha { get; set; }

        [Required]
        [Display(Name = "Nível de acesso")]
        public int NivelAcesso { get; set; }

        [Display(Name = "Data de contratação")]
        [DataType(DataType.Date)]
        public DateTime DataContratacao { get; set; }
    }
}
