using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Serie.Models
{
    public class Context : DbContext
    {
        public DbSet<Serie> Series { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SerieDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
