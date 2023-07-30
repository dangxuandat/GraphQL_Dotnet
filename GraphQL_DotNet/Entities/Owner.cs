using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace GraphQL_DotNet.Entities;

public class Owner
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    public string Address { get; set; }
    
    [UseSorting]
    public ICollection<Account> Accounts { get; set; }
}