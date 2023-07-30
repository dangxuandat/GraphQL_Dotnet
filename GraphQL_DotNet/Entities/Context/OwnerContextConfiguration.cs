using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL_DotNet.Entities.Context;

public class OwnerContextConfiguration : IEntityTypeConfiguration<Owner>
{
    private Guid[] _ids;

    public OwnerContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }
    
    public void Configure(EntityTypeBuilder<Owner> builder)
    {
        builder
            .HasData(
                new Owner()
                {
                    Id = _ids[0],
                    Name = "John Doe",
                    Address = "John Doe's Address"
                },
                new Owner()
                {
                    Id = _ids[1],
                    Name = "Jane Doe",
                    Address = "Jane Doe's Address"
                }
            );
    }
}