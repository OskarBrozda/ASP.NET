using Data;

namespace Lab_3___App.Models;

public class EFContactService : IContactService
{
    private readonly AppDbContext _context;

    public EFContactService(AppDbContext context)
    {
        _context = context;
    }

    public int Add(Contact contact)
    {
        var entity = _context.Contacts.Add(ContactMapper.ToEntity(contact));
        var id = entity.Entity.ContactId;
        _context.SaveChanges();
        return id;
    }

    public void Delete(int id)
    {
        var find = _context.Contacts.Find(id);
        if (find != null)
        {
            _context.Contacts.Remove(find);
            _context.SaveChanges();
        }
    }

    public void Update(Contact contact)
    {
        _context.Contacts.Update(ContactMapper.ToEntity(contact));
    }

    public List<Contact> FindAll()
    {
        return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();
    }

    public Contact? FindById(int id)
    {
        return ContactMapper.FromEntity(_context.Contacts.Find(id));
    }
}