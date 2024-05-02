using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class NivelAcesso
    {
        public int NivelAcessoID { get; set; }

        [Display(Name = "Nível")]
        [Required]
        public string? Nivel { get; set; }
    }
}
