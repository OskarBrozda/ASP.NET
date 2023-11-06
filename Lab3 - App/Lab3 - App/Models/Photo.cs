using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace Lab3___App.Models
{
    public class Photo
    {
        [HiddenInput]
        public int Id { get; set; }


        [Display(Name = "Data i godzina")]
        public DateTime Date_time { get; set; }


        [Required(ErrorMessage = "Proszę podać opis.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Długość opisu powinna mieścić sie między 3, a 100 znaków.")]
        [Display(Name = "Opis")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Proszę podać nazwę aparatu.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Nazwa aparatu powinna mieścić sie między 3, a 100 znaków.")]
        [Display(Name = "Model aparatu")] 
        public string Camera { get; set; }


        [Required(ErrorMessage = "Proszę podać autora zdjęcia.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Imię i nazwisko autora powinno mieścić sie między 3, a 100 znaków.")]
        [Display(Name = "Imię i nazwisko autora")] 
        public string Author { get; set; }


        [Display(Name = "Rozdzielczość")] 
        public Definition Definition { get; set; }


        [Display(Name = "Format")] 
        public Format Format { get; set; }
    }
}
