using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PhotoApp.Models;

public class Photo
{
    [HiddenInput]
    public int PhotoId { get; set; }


    [Required(ErrorMessage = "Pole jest wymagane!")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data i godzina wykonania")]
    [CustomValidation(typeof(Photo), "ValidateDateTime")]
    public DateTime Date_time { get; set; }

    
    [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Długość opisu powinna mieścić sie między 3, a 100 znaków.")]
    [Required(ErrorMessage = "Proszę podać opis zdjęcia.")]
    [Display(Name = "Opis")]
    public string Description { get; set; }


    [Required(ErrorMessage = "Proszę podać model aparatu.")]
    [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Nazwa aparatu powinna mieścić sie między 3, a 100 znaków.")]
    [Display(Name = "Model aparatu")] 
    public string Camera { get; set; }


    [Required(ErrorMessage = "Proszę podać autora zdjęcia.")]
    [Display(Name = "Imię i nazwisko autora")] 
    public int AuthorId { get; set; }
    
    
    [ValidateNever]
    public List<SelectListItem> Author{ get; set; }


    [Display(Name = "Rozdzielczość")] 
    public Definition Definition { get; set; }


    [Display(Name = "Format")] 
    public Format Format { get; set; }
    
    public static ValidationResult ValidateDateTime(DateTime date_time, ValidationContext validationContext)
    {
        return date_time > DateTime.Now
            ? new ValidationResult("Data nie może być z przyszłości.", new[] { validationContext.MemberName })
                : ValidationResult.Success;
    }
}