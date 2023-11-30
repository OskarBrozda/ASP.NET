using System.Security.Claims;
using Lab_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_3___App.Controllers;

[Authorize(Roles = "admin")]
public class OrganizationController : Controller
{
    private readonly IOrganizationService _organizationService;

    public OrganizationController(IOrganizationService organizationService)
    {
        _organizationService = organizationService;
    }

    public IActionResult Index() => View(_organizationService.FindAll());

    [HttpGet]
    public IActionResult Create() => View(new Organization());

    [HttpPost]
    public IActionResult Create(Organization model)
    {
        if (ModelState.IsValid)
        {
            _organizationService.Add(model);
            return RedirectToAction("Index");
        }   
        return View(model);
    }

    [HttpGet]
    public IActionResult Edit(int id) => View(_organizationService.FindById(id));


    [HttpPost]
    public IActionResult Edit(Organization model)
    {
        if (ModelState.IsValid)
        {
            _organizationService.Update(model);
            return RedirectToAction("Index");
        }   
        return View(model);
    }

    [HttpGet]
    public IActionResult Details(int id) => View(_organizationService.FindById(id));

    [HttpGet]
    public IActionResult Delete(int id) => View(_organizationService.FindById(id));

    [HttpPost]
    public IActionResult DeleteConfirmed(Organization model)
    {
        _organizationService.Delete(model.OrganizationId);
        return RedirectToAction("Index");
    }
}