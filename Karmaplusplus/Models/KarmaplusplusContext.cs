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
          new Service { ServiceId = 1, UserId = "f9eb9311-a088-4b39-8c27-d92990b37433", ServiceName = "lesson", Description = "Free English lessons", Email = "english.lessons@gmail.com", ZipCode = "98052" },
          new Service { ServiceId = 2, UserId = "f9eb9311-a088-4b39-8c27-d92990b37433", ServiceName = "haircut", Description = "Free haircuts for men, women and children", Email = "free.haircuts@gmail.com", ZipCode = "98040" },
          new Service { ServiceId = 3, UserId = "f9eb9311-a088-4b39-8c27-d92990b37433", ServiceName = "babysitting", Description = "Free babysitting for single mothers at your home", Email = "free.babysitting@gmail.com", ZipCode = "98033" }
        );
    }
  }
}