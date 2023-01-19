using Domain.Entitis;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Date;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    
      
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<Company>().HasData(
            new List<Company>()
            {
                new Company(1, "Google"),
                new Company(2, "Apple"),
                new Company(3, "Amazon"),
                new Company(4, "Facebook"),
            });

        modelBuilder.Entity<User>().HasData(
            new List<User>()
            {
                new User(1, "John Doe", 1),
                new User(2, "Jane Doe", 2),
                new User(3, "John Smith", 2),
                new User(4, "Jane Smith", 3),
                new User(5, "John Appleseed", 3),
            }
        );

        base.OnModelCreating(modelBuilder);
    }
}