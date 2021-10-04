using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTeste.Models
{
    public class JWTTesteDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public JWTTesteDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
