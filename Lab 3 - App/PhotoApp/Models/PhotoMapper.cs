using Data.Entities;

namespace PhotoApp.Models;

public abstract class PhotoMapper
{
    public static Photo FromEntity(PhotoEntity entity)
    {
        return new Photo
        {
            PhotoId = entity.PhotoId,
            Date_time = entity.Date_time,
            Description = entity.Description,
            Camera = entity.Camera,
            AuthorId = entity.AuthorId,
            Definition = (Definition)entity.Definition,
            Format = (Format)entity.Format
        };
    }

    public static PhotoEntity ToEntity(Photo model)
    {
        return new PhotoEntity
        {
            PhotoId = model.PhotoId,
            Date_time = model.Date_time,
            Description = model.Description,
            Camera = model.Camera,
            AuthorId = model.AuthorId,
            Definition = (int)model.Definition,
            Format = (int)model.Format
        };
    }
}