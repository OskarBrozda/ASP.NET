using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.DependencyResolver;
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
            //     if (model.PhotoFile != null)
            //     {
            //         string folder = "photos_folder/";
            //         folder += Guid.NewGuid().ToString() + "_" + model.PhotoFile.FileName;
            //         model.PhotoUrl = "/" + folder;
            //         string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);
            //
            //         model.PhotoFile.CopyTo(new FileStream(serverFolder, FileMode.Create));
            //     }
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