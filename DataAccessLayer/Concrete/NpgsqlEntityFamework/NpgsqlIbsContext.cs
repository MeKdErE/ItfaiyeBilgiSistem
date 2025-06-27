
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgsqlEntityFamework
{
    public class NpgsqlIbsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql
                (
                    @"
                Host=127.0.0.1;
                Port=5432;
                Database=IBS;
                Username=postgres;
                Password=Mekdere.2025;
                Trust Server Certificate=true;
                CommandTimeout=30;
                Pooling=true;
                "
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
