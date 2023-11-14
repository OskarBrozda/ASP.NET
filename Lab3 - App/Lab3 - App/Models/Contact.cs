using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Lab3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }


        [HiddenInput]
        public DateTime Created { get; set; }


        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }


        [Required(ErrorMessage = "Proszę podać imię.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Długość imienia powinna mieścić sie między 3, a 100 znaków.")]
        [Display(Name = "Imię")]
        public string first_name { get; set; }


        [Required(ErrorMessage = "Proszę podać nazwisko.")]
        [Display(Name = "Nazwisko")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Długość nazwiska powinna mieścić sie między 3, a 100 znaków.")]
        public string surname { get; set; }


        [Required(ErrorMessage = "Proszę podać date urodzenia.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        public DateTime birth_date { get; set; }


        [Display(Name = "Organizacja")]
        public int? OrganizationId {get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
