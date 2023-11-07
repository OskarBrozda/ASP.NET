using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        [Column("id")]
        [Key]
        public int contactId { get; set; }


        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string first_name { get; set; }
        
        
        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string surname { get; set; }


        [Required]
        public DateTime birth_date { get; set; }
    }
}
