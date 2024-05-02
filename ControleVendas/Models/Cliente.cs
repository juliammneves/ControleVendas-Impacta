using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        public int NivelAcessoID { get; set; } = 4;

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Sobrenome { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefone deve conter 11 digitos")]
        public string? Telefone { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve conter 11 digitos")]
        public string? CPF { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres.")]
        public string? Senha { get; set; }

        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "Estado deve conter 2 digitos")]
        public string? Estado { get; set; }

        [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve conter 8 digitos")]
        public string? CEP { get; set; }
    }
}
