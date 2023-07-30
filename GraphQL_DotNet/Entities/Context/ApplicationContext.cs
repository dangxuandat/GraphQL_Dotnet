using Microsoft.EntityFrameworkCore;

namespace GraphQL_DotNet.Entities.Context;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), };

        modelBuilder.ApplyConfiguration(new OwnerContextConfiguration(ids));
        modelBuilder.ApplyConfiguration(new AccountContextConfiguration(ids));
    }

    public DbSet<Owner> Owners { get; set; }
    public DbSet<Account> Accounts { get; set; }
}