using Microsoft.EntityFrameworkCore;
using Std_ID_200579494.Models;

namespace Std_ID_200579494.Views.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IConfiguration _config { get; set; }
        public ApplicationDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }
        public DbSet<Student> Students { get; set; }
    }


}

