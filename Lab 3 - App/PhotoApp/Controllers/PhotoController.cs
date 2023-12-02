using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhotoApp.Models;

namespace PhotoApp.Controllers;


[Authorize(Roles = "admin")]
public class PhotoController : Controller
{
    private readonly IPhotoService _photoService;

    public PhotoController(IPhotoService photoService)
    {
        _photoService = photoService;
    }
    
    [AllowAnonymous]
    public IActionResult Gallery()
    {
        var photos = _photoService.FindAll();
        foreach (var photo in photos)
        {
            photo.Author = CreateSelectListItem();
        }

        return View(photos);
    }

    [HttpGet]
    public IActionResult CreateApi() => View();

    [HttpPost]
    public IActionResult CreateApi(Photo model)
    {
        if (ModelState.IsValid)
        {
            _photoService.Add(model);
            return RedirectToAction("Gallery");
        }   
        model.Author = CreateSelectListItem();
        return View(model);
    }
    
    [HttpGet]
    public IActionResult Update(int id)
    {
        var photo = _photoService.FindById(id);

        if (photo == null)
        {
            return NotFound();
        }

        photo.Author = CreateSelectListItem();

        return View(photo);
    }


    [HttpPost]
    public IActionResult Update(Photo model)
    {
        if (ModelState.IsValid)
        {
            _photoService.Update(model);
            return RedirectToAction("Gallery");
        }

        return View(model);
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        var photo = _photoService.FindById(id);

        if (photo == null)
        {
            return NotFound();
        }

        photo.Author = CreateSelectListItem();

        return View(photo);
    }

    [HttpGet]
    public IActionResult Delete(int id) => View(_photoService.FindById(id));
    
    
    [HttpPost]
    public IActionResult DeleteConfirmed(Photo photo)
    {
        _photoService.Delete(photo.PhotoId);
        return RedirectToAction("Gallery");
    }
    
    private List<SelectListItem> CreateSelectListItem()
    {
        var items = _photoService.FindAllAuthors()
            .Select(e => new SelectListItem()
            {
                Text = $"{e.Name} {e.Surname}",
                Value = e.AuthorId.ToString()
            }).ToList();
        return items;
    }
}