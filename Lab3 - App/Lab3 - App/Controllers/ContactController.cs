using Lab3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3___App.Controllers
{
    public class ContactController : Controller
    {
        static int index = 1;
        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        public IActionResult Index()
        {
            return View(_contacts);
        }

        [HttpGet] // wyświetla formularz
        public IActionResult Create() => View();

        [HttpPost] // pobiera dane z formularza
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                model.Id = index++;
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id) => View(_contacts[id]);

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if(ModelState.IsValid)
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
    }
}
