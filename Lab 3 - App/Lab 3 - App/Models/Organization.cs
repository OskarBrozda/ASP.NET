// using System.ComponentModel.DataAnnotations;
// using Data.Entities;
// using Microsoft.AspNetCore.Mvc;
//
// namespace Lab_3___App.Models;
//
// public class Organization
// {
//     [HiddenInput]
//     public int OrganizationId { get; set; }
//
//     [Required(ErrorMessage = "Proszę podać nazwę firmy!")]
//     [Display(Name = "Nazwa")]
//     public string Title { get; set; }
//     
//     [RegularExpression("[0-9]{9}")]
//     [Required(ErrorMessage = "Proszę podać regon!")]
//     [Display(Name = "Regon")]
//     public long Regon { get; set; }
//     
//     [RegularExpression("[0-9]{10}")]
//     [Required(ErrorMessage = "Proszę podać nip!")]
//     [Display(Name = "Nip")]
//     public long Nip { get; set; }
//     
//     [Display(Name = "Adres")]
//     public Data.Address? Address { get; set; }
//     
//     [HiddenInput]
//     public ISet<ContactEntity> Contacts { get; set; }
// }