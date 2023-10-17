using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace Lab3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }


        [Required(ErrorMessage = "Proszę podać imię.")]
        [StringLength(maximumLength:100, MinimumLength = 3, ErrorMessage = "Długość imienia powinna mieścić sie między 3, a 100 znaków.")]
        public string Name { get; set; }


        [Required(ErrorMessage = " Proszę podać email.")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        public string Email { get; set; }


        [Phone(ErrorMessage = "Niepoprawny numer telefonu.")]
        public string? Phone { get; set; }


        public DateTime? Birth { get; set; }
    }
}
