using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleVendas.Models;

namespace ControleVendas.Data
{
    public class ControleVendasDbContext : DbContext
    {
        public ControleVendasDbContext (DbContextOptions<ControleVendasDbContext> options)
            : base(options)
        {
        }

        public DbSet<ControleVendas.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<ControleVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<ControleVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<ControleVendas.Models.Venda> Venda { get; set; } = default!;
        public DbSet<ControleVendas.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<ControleVendas.Models.ItensVenda> ItensVenda { get; set; } = default!;
    }
}
