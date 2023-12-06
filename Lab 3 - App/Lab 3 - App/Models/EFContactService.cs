using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        _context.SaveChanges();
    }

    public List<Contact> FindAll()
    {
        return _context.Contacts
            .Include(c => c.Organization)
            .Select(e => ContactMapper.FromEntity(e))
            .ToList();
    }

    public PagingList<Contact> FindPage(int page, int size)
    {
        int totalCount = _context.Contacts.Count();
        var pagingList = PagingList<Contact>.Create(null, totalCount, page, size);
        var organization = _context.Organizations.ToList();
        var data = _context.Contacts
            .OrderBy(c => c.Name)
            .Skip((pagingList.Number - 1) * pagingList.Size)
            .Take(pagingList.Size)
            .Include(c => c.Organization)
            .Select(e => ContactMapper.FromEntity(e))
            .ToList();
        
        foreach (var photo in data)
        {
            photo.Organizations = organization.Select(a => new SelectListItem { Value = a.OrganizationId.ToString(), Text = a.Title }).ToList();
        }
        pagingList.Data = data;
        return pagingList;
    }


    public Contact? FindById(int id)
    {
        return ContactMapper.FromEntity(_context.Contacts.Find(id));
    }
    
    public List<OrganizationEntity> FindAllOrganizations()
    {
        return _context.Organizations
            .Include(o => o.Contacts)
            .ToList();
    }
}