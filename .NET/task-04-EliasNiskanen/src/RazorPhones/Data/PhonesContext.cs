using Microsoft.EntityFrameworkCore;

namespace RazorPhones.Data;
public class PhonesContext : DbContext
{
    public PhonesContext(DbContextOptions<PhonesContext> options)
           : base(options)
    {
    }

    public DbSet<Phone> Phones { get; set; } = null!;
}