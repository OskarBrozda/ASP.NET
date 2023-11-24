using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("contacts")]
public class ContactEntity
{
    [Key] public int ContactId { get; set; }

    [MaxLength(50)] [Required] public string Name { get; set; }

    [MaxLength(50)] [Required] public string Surname { get; set; }

    [MaxLength(50)] [Required] public string Email { get; set; }

    [MaxLength(12)] [MinLength(9)] public string Phone { get; set; }

    public string? Note { get; set; }

    public Priority Priority { get; set; }

    [Column("BirthDate")] public DateTime BirthDate { get; set; }

    public int OrganizationId { get; set; }
    public OrganizationEntity? Organization { get; set; }
}