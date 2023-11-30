using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab_3___App.Models;

public class EFOrganizationService : IOrganizationService
{
    private readonly AppDbContext _context;

    public EFOrganizationService(AppDbContext context)
    {
        _context = context;
    }
    
    public int Add(Organization organization)
    {
        var entity = _context.Organizations.Add(OrganizationMapper.ToEntity(organization));
        var id = entity.Entity.OrganizationId;
        _context.SaveChanges();
        return id;    
    }

    public void Delete(int id)
    {
        var find = _context.Organizations.Find(id);
        if (find != null)
        {
            _context.Organizations.Remove(find);
            _context.SaveChanges();
        }
    }

    public void Update(Organization organization)
    {
        _context.Organizations.Update(OrganizationMapper.ToEntity(organization));
        _context.SaveChanges();
    }

    public List<Organization> FindAll()
    {
        return _context.Organizations
            .Select(e => OrganizationMapper.FromEntity(e))
            .ToList();
    }

    public Organization? FindById(int id)
    {
        return OrganizationMapper.FromEntity(_context.Organizations.Find(id));
    }
}