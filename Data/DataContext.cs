using Microsoft.EntityFrameworkCore;

namespace ASPNET6_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<RpgCharacter> RpgCharacters => Set<RpgCharacter>();
    }
}