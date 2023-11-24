using Lab_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_3___App.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;
    private readonly IDateTimeProvider _timeProvider;

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
        return View();
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

        return View(model);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        return View(_contactService.FindById(id));
    }


    [HttpPost]
    public IActionResult Edit(Contact model)
    {
        if (ModelState.IsValid)
        {
            _contactService.Update(model);
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        return View(_contactService.FindById(id));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        return View(_contactService.FindById(id));
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        _contactService.Delete(id);
        return RedirectToAction("Index");
    }
}