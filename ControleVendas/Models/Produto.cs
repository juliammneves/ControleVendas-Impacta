using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricacao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string? Categoria { get; set;}
        public string? Fornecedor { get; set; }
    }
}
