using GraphQL_DotNet.Contracts;
using GraphQL_DotNet.Entities.Context;

namespace GraphQL_DotNet.Repository;

public class AccountRepository : IAccountRepository
{
    private readonly ApplicationContext _context;

    public AccountRepository(ApplicationContext context)
    {
        _context = context;
    }
}