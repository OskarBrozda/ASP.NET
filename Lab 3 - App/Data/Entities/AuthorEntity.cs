using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("authors")]
public class AuthorEntity
{
    [Key] public int AuthorId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string? Note { get; set; }
    public Address Address { get; set; }
    public ISet<PhotoEntity> Photos { get; set; }
}