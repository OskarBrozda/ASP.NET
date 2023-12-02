using System.ComponentModel.DataAnnotations;

namespace PhotoApp;

public enum Format
{
    [Display(Name = "JPEG")] JPEG = 1,
    [Display(Name = "JPG")] JPG = 2,
    [Display(Name = "PNG")] PNG = 3,
    [Display(Name = "GIF")] GIF = 4,
    [Display(Name = "SVG")] SVG = 5,
    [Display(Name = "Web")] Web = 5
}