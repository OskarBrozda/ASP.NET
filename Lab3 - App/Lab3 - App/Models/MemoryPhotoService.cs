using System.Reflection;

namespace Lab3___App.Models
{
    public class MemoryPhotoService : IPhotoService
    {
        static readonly Dictionary<int, Photo> _photos = new Dictionary<int, Photo>()
        {
             {1, new Photo() { Id = 1, Description = "Krajobraz morski", Author = "Tomasz Karolczyk", Date_time = new DateTime(2022, 12, 24, 12, 22, 35), Camera = "Canon", Definition=Definition.Format1600x900, Format = Format.GIF} },
             {2, new Photo() { Id = 2, Description = "Rower", Author = "Iga Świątek", Date_time = new DateTime(2023, 09, 10, 10, 12, 55), Camera = "Sony", Definition=Definition.Format4096x2160, Format = Format.JPEG} },
             {3, new Photo() { Id = 3, Description = "Domek w Karkonoszach", Author = "Nieznany", Date_time = new DateTime(2022, 01, 02, 19, 18, 17), Camera = "Nokia", Definition=Definition.Format375x667, Format = Format.PNG} },
        };

        public int Add(Photo photo)
        {
            int id = _photos.Keys.Count != 0 ? _photos.Keys.Max() : 0;
            photo.Id = ++id;
            _photos[id] = photo;
            return photo.Id;
        }

        public void Delete(int id)
        {
            _photos.Remove(id);
        }

        public List<Photo> FindAll()
        {
            return _photos.Values.ToList();
        }

        public Photo? FindById(int id)
        {
            return _photos[id];
        }

        public void Update(Photo photo)
        {
            _photos[photo.Id] = photo;
        }
    }
}
