public class ApplicationDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    // Other configurations
}
