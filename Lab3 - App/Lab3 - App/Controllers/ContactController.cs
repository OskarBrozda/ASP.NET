using Lab3___App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab3___App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private IDateTimeProvider _timeProvider;

        public ContactController(IContactService contactService, IDateTimeProvider timeProvider)
        {
            _contactService = contactService;
            _timeProvider = timeProvider;
        }


        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Contact model = new Contact();
            model.Organizations = _contactService.FindAllOrganizations()
                .Select(oe => new SelectListItem()
                {
                    Text = oe.Name,
                    Value = oe.Id.ToString()
                }).ToList();
            model.Organizations.Add(new SelectListItem()
            {
                Text = "--",
                Value = ""
            });
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                model.Created = _timeProvider.GetDateTime();
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }


        [HttpGet]
        public IActionResult Update(int id) => View(_contactService.FindById(id));

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Details(int id) => View(_contactService.FindById(id));


        [HttpGet]
        public IActionResult Delete(int id) => View(_contactService.FindById(id));

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

