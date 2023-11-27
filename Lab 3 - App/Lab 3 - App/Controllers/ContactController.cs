using System.Security.Claims;
using Lab_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_3___App.Controllers;

[Authorize(Roles = "admin")]
public class ContactController : Controller
{
    private readonly IContactService _contactService;
    private readonly IDateTimeProvider _timeProvider;

    public ContactController(IContactService contactService, IDateTimeProvider timeProvider)
    {
        _contactService = contactService;
        _timeProvider = timeProvider;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {
        var contacts = _contactService.FindAll();
        foreach (var contact in contacts)
        {
            contact.Organizations = CreateSelectListItem();
        }

        return View(contacts);
    }

    [HttpGet]
    public IActionResult Create() => View(new Contact { Organizations = CreateSelectListItem() });

    [HttpPost]
    public IActionResult Create(Contact model)
    {
        if (ModelState.IsValid)
        {
            model.Created = _timeProvider.GetDateTime();
            _contactService.Add(model);
            return RedirectToAction("Index");
        }   
        model.Organizations = CreateSelectListItem();
        return View(model);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var contact = _contactService.FindById(id);

        if (contact == null)
        {
            return NotFound();
        }

        contact.Organizations = CreateSelectListItem();

        return View(contact);
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
        var contact = _contactService.FindById(id);

        if (contact == null)
        {
            return NotFound();
        }

        contact.Organizations = CreateSelectListItem();

        return View(contact);
    }

    [HttpGet]
    public IActionResult Delete(int id) => View(_contactService.FindById(id));

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        _contactService.Delete(id);
        return RedirectToAction("Index");
    }
    
    private List<SelectListItem> CreateSelectListItem()
    {
        var items = _contactService.FindAllOrganizations()
            .Select(e => new SelectListItem()
            {
                Text = e.Title,
                Value = e.OrganizationId.ToString()
            }).ToList();
        return items;
    }
}