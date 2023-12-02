using Data.Entities;

namespace PhotoApp.Models;

public abstract class AuthorMapper
{
    public static Author FromEntity(AuthorEntity entity)
    {
        return new Author
        {
            AuthorId = entity.AuthorId,
            Name = entity.Name,
            Surname = entity.Surname,
            Email = entity.Email,
            Address = entity.Address
        };
    }

    public static AuthorEntity ToEntity(Author model)
    {
        return new AuthorEntity
        {
            AuthorId = model.AuthorId,
            Name = model.Name,
            Surname = model.Surname,
            Email = model.Email,
            Address = model.Address
        };
    }
}