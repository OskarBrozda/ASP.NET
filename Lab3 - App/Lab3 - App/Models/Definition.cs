using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab3___App.Models
{
    public enum Definition
    {
        [Display(Name = "360 × 640")]
        Format360x640 = 1,

        [Display(Name = "375 × 667")]
        Format375x667 = 2,

        [Display(Name = "576 x 480")]
        Format576x480 = 3,

        [Display(Name = "1366 × 768")]
        Format1366x768 = 4,

        [Display(Name = "1600 × 900")]
        Format1600x900 = 5,

        [Display(Name = "1920 × 1080")]
        Format1920x1080 = 6,

        [Display(Name = "2560 x 1440")]
        Format2560x1440 = 7,

        [Display(Name = "4096 x 2160")]
        Format4096x2160 = 8
    }
}