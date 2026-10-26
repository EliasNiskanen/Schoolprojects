using Microsoft.EntityFrameworkCore;

namespace MVCPhones.Data;
public class PhonesContext : DbContext
{
    public PhonesContext(DbContextOptions<PhonesContext> options)
           : base(options)
    {
    }

    public DbSet<Phone> Phones { get; set; } = null!;
}