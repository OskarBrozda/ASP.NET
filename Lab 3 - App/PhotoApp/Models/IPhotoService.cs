using Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace PhotoApp.Models;

public interface IPhotoService
{
    int Add(Photo photo);
    void Delete(int id);
    void Update(Photo photo);
    List<Photo> FindAll();
    Photo? FindById(int id);
    List<AuthorEntity> FindAllAuthors();
    public PagingList<Photo> FindPage(int page, int size);
}