using GraphQL_DotNet.Entities;

namespace GraphQL_DotNet.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAll();
}