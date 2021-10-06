using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MercadoAPI.Models
{
    public class MercadoAPIDbContext : DbContext
    {
        public MercadoAPIDbContext (DbContextOptions<MercadoAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Venda> Venda { get; set; }

        public DbSet<VendaItem> VendaItem { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach(var relationshitp in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationshitp.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        
    }
}
