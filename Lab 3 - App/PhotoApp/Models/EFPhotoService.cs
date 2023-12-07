using Data;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PhotoApp.Models;

public class EFPhotoService : IPhotoService
{
    private readonly AppDbContext _context;
    
    public EFPhotoService(AppDbContext context)
    {
        _context = context;
    }
    
    public PagingList<Photo> FindPage(int page, int size) 
    { 
        int totalCount = _context.Photos.Count();
        var pagingList = PagingList<Photo>.Create(null, totalCount, page, size);
        var authors = _context.Authors.ToList();
        var data = _context.Photos
            .OrderBy(c => c.Date_time)
            .Skip((pagingList.Number - 1) * pagingList.Size)
            .Take(pagingList.Size)
            .Include(c=>c.Authors)
            .Select(e => PhotoMapper.FromEntity(e))
            .ToList();
        foreach (var photo in data)
        {
            photo.Author = authors.Select(a => new SelectListItem { Value = a.AuthorId.ToString(), Text = $"{a.Name} {a.Surname}" }).ToList();
        }
        pagingList.Data = data;
        return pagingList;
    }
    
    public int Add(Photo photo)
    {
        var entity = _context.Photos.Add(PhotoMapper.ToEntity(photo));
        var id = entity.Entity.PhotoId;
        _context.SaveChanges();
        return id;
    }

    public void Delete(int id)
    {
        var find = _context.Photos.Find(id);
        if (find != null)
        {
            _context.Photos.Remove(find);
            _context.SaveChanges();
        }
    }

    public void Update(Photo photo)
    {
        _context.Photos.Update(PhotoMapper.ToEntity(photo));
        _context.SaveChanges();
    }

    public List<Photo> FindAll()
    {
        return _context.Photos
            .Include(p =>p.Authors)
            .Select(e => PhotoMapper.FromEntity(e))
            .ToList();
    }

    public Photo? FindById(int id)
    {
        return PhotoMapper.FromEntity(_context.Photos.Find(id));
    }

    public List<AuthorEntity> FindAllAuthors()
    {
        return _context.Authors
            .Include(o => o.Photos)
            .ToList();
    }
}