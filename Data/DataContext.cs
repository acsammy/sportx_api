using sportx_api.Models;
using Microsoft.EntityFrameworkCore;

namespace sportx_api.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<PartnerPhones> PartnerPhones { get; set; }
  }
}