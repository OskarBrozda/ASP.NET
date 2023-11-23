using Data;
using Data.Entities;

namespace Lab_3___App.Models;

public class EFContactService : IContactService
{
    private AppDbContext _context;
    public EFContactService(AppDbContext context)
    {
        _context = context;
    }

    public int Add(Contact contact)
    {
        var entity = _context.Contacts.Add(ContactMapper.ToEntity(contact));
        int id = entity.Entity.ContactId;
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

    public void Update(Contact contact) => _context.Contacts.Update(ContactMapper.ToEntity(contact));
    public List<Contact> FindAll() => _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();

    public Contact? FindById(int id) => ContactMapper.FromEntity(_context.Contacts.Find(id));
}