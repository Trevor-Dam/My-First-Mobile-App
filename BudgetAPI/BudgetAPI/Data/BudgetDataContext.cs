using Microsoft.EntityFrameworkCore;
using BudgetAPI.Models;

namespace BudgetAPI.Data
{
    public class BudgetDataContext : DbContext
    {
        public DbSet<Users> User { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User Id=postgres.wpwcsyytjzygluchnxtx;Password=$t1n3Tr3v0r1023;Server=aws-0-eu-central-1.pooler.supabase.com;Port=5432;Database=postgres;");
        }
    }
}
