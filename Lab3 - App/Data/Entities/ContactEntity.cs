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
        public int ContactId { get; set; }


        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string First_name { get; set; }
        
        
        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string Surname { get; set; }


        [Required]
        public DateTime Birth_date { get; set; }


        public OrganizationEntity Organization { get; set; }

        public int? OrganizationId { get; set; }
    }
}
