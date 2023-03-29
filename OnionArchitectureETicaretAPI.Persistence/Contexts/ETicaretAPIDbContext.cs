using Microsoft.EntityFrameworkCore;
using OnionArchitectureETicaretAPI.Domain.Entities;
using OnionArchitectureETicaretAPI.Domain.Entities.Common;

namespace OnionArchitectureETicaretAPI.Persistence.Contexts;

public class ETicaretAPIDbContext : DbContext
{
    public ETicaretAPIDbContext(DbContextOptions options) : base(options)
    { }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker
            .Entries<BaseEntity>();

        foreach (var data in datas)
        {
            switch (data.State)
            {
                case EntityState.Added:
                    data.Entity.CreatedDate = DateTime.Now;
                    break;
                case EntityState.Modified:
                    data.Entity.UpdatedDate = DateTime.Now;
                    break;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}