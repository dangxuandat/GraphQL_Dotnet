using GraphQL_DotNet.Entities;
using GraphQL_DotNet.Entities.Context;
namespace GraphQL_DotNet.GraphQL.GraphQLQueries;

public class AppQuery 
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Account> GetAccounts([Service] ApplicationContext context) => context.Accounts;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Owner> GetOwners([Service] ApplicationContext context) => context.Owners;
}