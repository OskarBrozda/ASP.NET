using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Lab_3___App.Models;

public class Contact
{
    [HiddenInput] 
    public int Id { get; set; }
    
    [HiddenInput]
    [Display(Name = "Utworzono")]
    public DateTime Created { get; set; }

    [Required(ErrorMessage = "Proszę podać imię!")]
    [Display(Name = "Imię")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Proszę podać nazwisko!")]
    [Display(Name = "Nazwisko")]
    public string Surname { get; set; }

    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
    [Required(ErrorMessage = "Proszę podać poprawny email!")]
    [Display(Name = "Email")]
    [EmailAddress]
    public string Email { get; set; }

    [RegularExpression("[0-9]{3,15}")]
    [Required(ErrorMessage = "Proszę podać poprawny numer telefonu!")]
    [Display(Name = "Numer telefonu")]
    [Phone]
    public string Phone { get; set; }

    [Display(Name = "Notatka")]
    public string? Note { get; set; }

    [Display(Name = "Priorytet")]
    public Data.Priority Priority { get; set; }

    [Required(ErrorMessage = "Pole \"Data urodzenia\" jest wymagane!")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data urodzenia")]
    [CustomValidation(typeof(Contact), "ValidateBirthDate")]
    public DateTime BirthDate { get; set; }
    
    
    public static ValidationResult ValidateBirthDate(DateTime birthDate, ValidationContext validationContext)
    {
        return birthDate > DateTime.Now
            ? new ValidationResult("Data urodzenia nie może być z przyszłości.", new[] { validationContext.MemberName })
            : ValidationResult.Success;
    }
}