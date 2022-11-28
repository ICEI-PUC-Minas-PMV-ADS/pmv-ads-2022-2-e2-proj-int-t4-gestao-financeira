using Gestão_Financeira.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestão_Financeira.Data

{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<TransacaoModel> Transacoes { get; set; }
        public DbSet<ReservaEmergencialModel> ReservasEmergenciais { get; set; }
        public DbSet<PlanejamentoCompraModel> PlanejamentosCompras { get; set; }
        public DbSet<ItemModel> Itens { get; set; }
        public DbSet<ObjetivoFinanceiroModel> ObjetivosFinanceiros { get; set; }
        public DbSet<DespesaComumModel> DespesasComuns { get; set; }
        public DbSet<DespesaVariavelModel> DespesasVariaveis { get; set; }
    }
}
