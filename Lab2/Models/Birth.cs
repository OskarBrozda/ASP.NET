using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab2.Models
{
    public class Birth
    {
        public string name { get; set; }
        public int dayOfBirth { get; set; }
        public int monthOfBirth { get; set; }
        public int yearOfBirth { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(name) ||
                dayOfBirth > 0 && dayOfBirth <= 31 &&
                monthOfBirth > 0 && monthOfBirth <= 12 &&
                yearOfBirth > 0 && yearOfBirth <= DateTime.Today.Year;
        }

        public int Calculate()
        {
            DateTime dateOfBirth = Convert.ToDateTime($"{yearOfBirth}/{monthOfBirth}/{dayOfBirth}");
            return new DateTime(DateTime.Now.Subtract(dateOfBirth).Ticks).Year - 1;
        }

        public List<SelectListItem> GetDays()
        {
            List<SelectListItem> days = new List<SelectListItem>();
            for (int i = 1; i <= 31; i++)
            {
                days.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            return days;
        }

        public List<SelectListItem> GetMonths()
        {
            List<SelectListItem> months = new List<SelectListItem>();
            for (int i = 1; i <= 12; i++)
            {
                months.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            return months;
        }

        public List<SelectListItem> GetYears()
        {
            List<SelectListItem> years = new List<SelectListItem>();
            for (int i = 1; i <= 2023; i++)
            {
                years.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            return years;
        }

    }
}
