using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhotoApp.Models;

namespace PhotoApp.Controllers;



public class PhotoController : Controller
{
    public IWebHostEnvironment _webHostEnvironment;
    private readonly IPhotoService _photoService;

    public PhotoController(IPhotoService photoService, IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
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
    
    [AllowAnonymous]
    public IActionResult PagedGallery([FromQuery]int page = 1,[FromQuery] int size = 5) 
    { 
        var photos = _photoService.FindAll();
        foreach (var photo in photos)
        {
            photo.Author = CreateSelectListItem();
        }
        
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
            if (model.PhotoFile != null)
            {
                string folder = "photos_folder/";
                folder += Guid.NewGuid().ToString() + "_" + model.PhotoFile.FileName;
                model.PhotoUrl = "/" + folder;
                string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                await model.PhotoFile.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            }
            _photoService.Add(model); 
            return RedirectToAction("Gallery");
        }   
        model.Author = CreateSelectListItem();
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
            return RedirectToAction("Gallery");
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
    public IActionResult Delete(int id) => View(_photoService.FindById(id));
    
    [Authorize(Roles = "admin")]
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