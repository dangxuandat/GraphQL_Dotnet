using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL_DotNet.Entities;

public class Account
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Type is required")]
    public TypeOfAccount Type { get; set; }
    public string Description { get; set; }

    [ForeignKey("OwnerId")]
    public Guid OwnerId { get; set; }
    public Owner Owner { get; set; }
}

public enum TypeOfAccount
{
    Cash,
    Savings,
    Expense,
    Income
}