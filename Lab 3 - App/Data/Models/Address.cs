using System.ComponentModel.DataAnnotations;

namespace Data;

public class Address
{
    [Display(Name = "Ulica")]
    [Required(ErrorMessage = "Proszę podać ulicę!")]
    public string Street { get; set; }
    
    [Display(Name = "Numer domu")]
    [Required(ErrorMessage = "Proszę podać numer domu!")]
    public string HomeNr { get; set; }
    
    [Display(Name = "Numer mieszkania")]
    public int? ApartamentNr { get; set; }

    [RegularExpression("[0-9]{2}-[0-9]{3}", ErrorMessage = "Błędny format")]
    [Display(Name = "Kod pocztowy")]
    [Required(ErrorMessage = "Proszę podać kod pocztowy!")]
    public string PostalCode { get; set; }
    
    [RegularExpression("[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+", ErrorMessage = "Błędny format")]
    [Display(Name = "Miasto")]
    [Required(ErrorMessage = "Proszę podać miasto!")]
    public string City { get; set; }
    
    [RegularExpression("[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+", ErrorMessage = "Błędny format")]
    [Display(Name = "Region")]
    [Required(ErrorMessage = "Proszę podać region!")]
    public string Region { get; set; }
    
    [RegularExpression("[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+", ErrorMessage = "Błędny format")]
    [Display(Name = "Kraj")]
    [Required(ErrorMessage = "Proszę podać kraj!")]
    public string Country { get; set; }
}