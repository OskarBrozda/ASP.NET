using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace Lab3___App.Models
{
    public class Photo
    {
        [HiddenInput]
        public int Id { get; set; }


        [Required(ErrorMessage = "Proszę podać date oraz godzinę.")]
        public DateTime Date_time { get; set; }


        [Required(ErrorMessage = " Proszę podać opis.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Długość opisu powinna mieścić sie między 3, a 100 znaków.")]
        public string Description { get; set; }


        [Required(ErrorMessage = " Proszę podać nazwę aparatu.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Nazwa aparatu powinna mieścić sie między 3, a 100 znaków.")]
        public string Camera { get; set; }


        [Required(ErrorMessage = " Proszę podać autora zdjęcia.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Imię i nazwisko autora powinno mieścić sie między 3, a 100 znaków.")]
        public string Author { get; set; }


        [Required(ErrorMessage = " Proszę podać rozdzielczość.")]
        public string Definition { get; set; }


        [Required(ErrorMessage = " Proszę podać format zdjęcia.")]
        public string Format { get; set; }
    }
}
