using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Data.Entities;

[Table("photos")]
public class PhotoEntity
{
    [Key] public int PhotoId { get; set; }
    
    [Required] public DateTime Date_time { get; set; }

    [MaxLength(100)] [MinLength(3)] public string Description { get; set; }

    [MaxLength(100)] [MinLength(3)] [Required] public string Camera { get; set; }
    
    public int Definition { get; set; }
    
    public int Format { get; set; }
    
    public int AuthorId { get; set; }

    public string PhotoUrl { get; set; }
    public AuthorEntity? Authors { get; set; }
}