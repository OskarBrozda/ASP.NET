using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("organizations")]
public class OrganizationEntity
{
    [Key] public int OrganizationId { get; set; }
    public string? Description { get; set; }
    public string Title { get; set; }
    public long Regon { get; set; }
    public long Nip { get; set; }
    public Address Address { get; set; }
    public ISet<ContactEntity> Contacts { get; set; }
}