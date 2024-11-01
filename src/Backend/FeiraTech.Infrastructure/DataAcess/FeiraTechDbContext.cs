using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Infrastructure.DataAcess
{
    public class FeiraTechDbContext : DbContext
    {
        public FeiraTechDbContext(DbContextOptions<FeiraTechDbContext> options) : base(options)
        {
        }
        public DbSet<FeiraTech.Domain.Entity.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FeiraTechDbContext).Assembly);
        }

    }
}
