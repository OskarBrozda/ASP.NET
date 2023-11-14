using Data.Entities;

namespace Lab3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Contact> _items = new Dictionary<int, Contact>()
        {
            {1, new Contact() { Id = 1, first_name = "Oskar", surname = "Karolczyk", birth_date = new DateTime(2007, 12, 24), Priority = Priority.Low} },
            {2, new Contact() { Id = 2, first_name = "Tomasz", surname = "Murawski", birth_date = new DateTime(2008, 08, 01), Priority = Priority.Normal } },
            {3, new Contact() { Id = 3, first_name = "Zuzanna", surname = "Boska", birth_date = new DateTime(2000, 01, 19), Priority = Priority.High } }
        };

        public int Add(Contact item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
           _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            throw new NotImplementedException();
        }

        public Contact? FindById(int id)
        {
            return _items[id];
        }

        public void Update(Contact item)
        {
            _items[item.Id] = item;
        }
    }
}
