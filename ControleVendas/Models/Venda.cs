using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        
        [Required]
        public int FuncionarioID { get; set;}

        [Required]
        public int ClienteID { get; set;}

        [Display(Name = "Data da venda")]
        [Required]
        public DateTime DataVenda { get; set; }

        [Display(Name = "Total da venda")]
        public decimal TotalVenda { get; set; }

        [Display(Name = "Método de pagamento")]
        public string? MetodoPagamento { get; set; }

        [Display(Name = "Status da entrega")]
        [Required]
        public string? StatusEntrega { get; set; }
    }
}
