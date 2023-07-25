using Microsoft.EntityFrameworkCore;


namespace LinkKisaltmaa.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<TBLLink>TBLLink { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NIRVANA\SQLEXPRESS;Database=LinkKisaltma;Trusted_Connection=true;encrypt=false");
        }
    }
}
