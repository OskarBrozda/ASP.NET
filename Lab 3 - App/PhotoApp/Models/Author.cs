using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PhotoApp.Models;

public class Author
{
    [HiddenInput] public int AuthorId { get; set; }
    
    [RegularExpression("[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+", ErrorMessage = "Błędny format")]
    [Required(ErrorMessage = "Proszę podać imię!")]
    [Display(Name = "Imię")]
    public string Name { get; set; }

    [RegularExpression("[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+", ErrorMessage = "Błędny format")]
    [Required(ErrorMessage = "Proszę podać nazwisko!")]
    [Display(Name = "Nazwisko")]
    public string Surname { get; set; }

    [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Błędny format")]
    [Required(ErrorMessage = "Proszę podać poprawny email!")]
    [Display(Name = "Email")]
    [EmailAddress]
    public string Email { get; set; }
    
    [Display(Name = "Notatka")] public string? Note { get; set; }
    
    [Display(Name = "Adres")]
    public Data.Address Address { get; set; }
}