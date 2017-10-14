using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStoreDomainLibrary.Entities;
namespace SportStoreDomainLibrary.Concrete
{
  public class SportsStoreDbContext : DbContext
  {
    public SportsStoreDbContext() : base("SportsStoreConnection") { }

    public DbSet<Product> Products { get; set; }
  }
}
