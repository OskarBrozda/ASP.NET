using Lab3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3___App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1, new Contact(){Id = 1, first_name = "Oskar", surname = "Karolczyk", birth_date = new DateTime(2007, 12, 24)} },
            {2, new Contact(){Id = 2, first_name = "Tomasz", surname = "Murawski", birth_date = new DateTime(2008, 08, 01)} },
            {3, new Contact(){Id = 3, first_name = "Zuzanna", surname = "Boska", birth_date = new DateTime(2000, 01, 19)} }

        };


        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet] // wyświetla formularz
        public IActionResult Create() => View();

        [HttpPost] // pobiera dane z formularza
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                int id = _contacts.Keys.Count != 0 ? _contacts.Keys.Max() : 0;
                model.Id = ++id;
                _contacts[id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Update(int id) => View(_contacts[id]);

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Details(int id) => View(_contacts[id]);


        [HttpGet]
        public IActionResult Delete(int id) => View(_contacts[id]);

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _contacts.Remove(id);
            return RedirectToAction("Index");
        }
    }
}

