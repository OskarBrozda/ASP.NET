using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhotoApp.Models;

namespace PhotoApp.Controllers;



public class PhotoController : Controller
{
    private readonly IPhotoService _photoService;

    public PhotoController(IPhotoService photoService)
    {
        _photoService = photoService;
    }
    
    [AllowAnonymous]
    public IActionResult PagedGallery([FromQuery]int page = 1,[FromQuery] int size = 6) 
    { 
        return View(_photoService.FindPage(page, size)); 
    }

    [Authorize]
    [HttpGet]
    public IActionResult CreateApi() => View();

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateApi(Photo model)
    {
        if (ModelState.IsValid)
        {
            model.Author = CreateSelectListItem();
            _photoService.Add(model); 
            return RedirectToAction("PagedGallery");
        }   
        return View(model);
    }
    
    [Authorize(Roles = "admin")]
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

    [Authorize(Roles = "admin")]
    [HttpPost]
    public IActionResult Update(Photo model)
    {
        if (ModelState.IsValid)
        {
            _photoService.Update(model);
            return RedirectToAction("PagedGallery");
        }

        return View(model);
    }
    
    [Authorize]
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

    [Authorize(Roles = "admin")]
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var photo = _photoService.FindById(id);

        if (photo == null)
        {
            return NotFound();
        }

        photo.Author = CreateSelectListItem();

        return View(photo);
    }
    
    
    [Authorize(Roles = "admin")]
    [HttpPost]
    public IActionResult DeleteConfirmed(Photo photo)
    {
        _photoService.Delete(photo.PhotoId);
        return RedirectToAction("PagedGallery");
    }
    
    
    [Authorize]
    public IActionResult Download(int id)
    {
        var photo = _photoService.FindById(id);

        if (photo == null)
        {
            return NotFound();
        }

        byte[] fileContents;
        using (var webClient = new WebClient())
        {
            fileContents = webClient.DownloadData(photo.PhotoUrl);
        }

        string fileName = $"{photo.Description}_{photo.PhotoId}_Brozda.jpg";
        string contentType = "image/jpeg";
        return File(fileContents, contentType, fileName);
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