using Data;
using Data.Entities;
using System.Diagnostics.Contracts;

namespace Lab3___App.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact book)
        {
            var entity = _context.Contacts.Add(ContactMapper.ToEntity(book));
            int id = entity.Entity.contactId;
            _context.SaveChanges();
            return id;
        }

        public void Delete(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            if(find != null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();
        }

        public Contact? FindById(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            return find == null ? null : ContactMapper.FromEntity(find);

            // return ContactMapper.FromEntity(_context.Contacts.Find(id));
        }

        public void Update(Contact book)
        {
            ContactEntity entity = ContactMapper.ToEntity(book);
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
