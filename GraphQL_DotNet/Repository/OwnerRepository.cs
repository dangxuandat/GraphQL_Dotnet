using GraphQL_DotNet.Contracts;
using GraphQL_DotNet.Entities;
using GraphQL_DotNet.Entities.Context;

namespace GraphQL_DotNet.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly ApplicationContext _context;

    public OwnerRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Owner> GetAll() => _context.Owners.ToList();
}