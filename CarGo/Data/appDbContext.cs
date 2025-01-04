using CarGo.Models;
using Microsoft.EntityFrameworkCore;
namespace CarGo.Data;
public class appDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Inspection> Inspections { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Tracking> Tracking { get; set; }
    public DbSet<TransportCompany> TransportCompanies { get; set; }
    public DbSet<Image> Images { get; set; }

    public appDbContext(DbContextOptions<appDbContext> options) : base(options)
    {
    }

    
}
