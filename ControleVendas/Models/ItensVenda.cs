using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class ItensVenda
    {
        public int ItensVendaID { get; set; }

        [Required]
        public int VendaID { get; set; }

        [Required]
        public int ProdutoID { get; set; }
        
        [Required]
        public int Quantidade { get; set; }

        [Display(Name = "Preço de venda")]
        public decimal PrecoVenda { get; set; }
        public decimal Desconto { get; set; }
    }
}
