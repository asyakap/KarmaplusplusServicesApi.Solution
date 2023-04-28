using Microsoft.EntityFrameworkCore;
using Karmaplusplus.Models;

namespace Karmaplusplus.Models
{
  public class KarmaplusplusContext : DbContext
  {
    public DbSet<Service> Services { get; set; }

    public KarmaplusplusContext(DbContextOptions<KarmaplusplusContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Service>()
        .HasData(
          new Service { ServiceId = 1, Service = "lesson", Description = "Free English lessons", email = "english.lessons@gmail.com", ZipCode = 98052 },
          new Service { ServiceId = 2, Service = "haircut", Description = "Free haircuts for men, women and children", email = "free.haircuts@gmail.com", ZipCode = 98040 },
          new Service { ServiceId = 3, Service = "babysitting", Description = "Free babysitting for single mothers at your home", email = "free.babysitting@gmail.com", ZipCode = 98033 }
        );
    }
  }
}