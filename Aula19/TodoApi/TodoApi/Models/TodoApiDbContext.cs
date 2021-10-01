using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoApiDbContext : DbContext
    {
        public DbSet<TodoItem> todoItem { get; set; }

        public TodoApiDbContext(DbContextOptions<TodoApiDbContext> options)
            : base(options)
        {
        }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
