using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoApp.Models;

namespace PhotoApp.Controllers;


public class AuthorController : Controller
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }
    
    public IActionResult Index() => View(_authorService.FindAll());

    [Authorize(Roles = "admin")]
    [HttpGet]
    public IActionResult Create() => View(new Author());

    [Authorize(Roles = "admin")]
    [HttpPost]
    public IActionResult Create(Author model)
    {
        if (ModelState.IsValid)
        {
            _authorService.Add(model);
            return RedirectToAction("Index");
        }   
        return View(model);
    }

    [Authorize(Roles = "admin")]
    [HttpGet]
    public IActionResult Update(int id) => View(_authorService.FindById(id));

    [Authorize(Roles = "admin")]
    [HttpPost]
    public IActionResult Update(Author model)
    {
        if (ModelState.IsValid)
        {
            _authorService.Update(model);
            return RedirectToAction("Index");
        }   
        return View(model);
    }

    [Authorize]
    [HttpGet]
    public IActionResult Details(int id) => View(_authorService.FindById(id));

    [Authorize(Roles = "admin")]
    [HttpGet]
    public IActionResult Delete(int id) => View(_authorService.FindById(id));

    [Authorize(Roles = "admin")]
    [HttpPost]
    public IActionResult DeleteConfirmed(Author model)
    {
        _authorService.Delete(model.AuthorId);
        return RedirectToAction("Index");
    }
}