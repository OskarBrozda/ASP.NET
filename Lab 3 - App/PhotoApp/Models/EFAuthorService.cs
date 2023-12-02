using Data;

namespace PhotoApp.Models;

public class EFAuthorService : IAuthorService
{
    private readonly AppDbContext _context;
    
    public EFAuthorService(AppDbContext context)
    {
        _context = context;
    }
    
    public int Add(Author author)
    {
        var entity = _context.Authors.Add(AuthorMapper.ToEntity(author));
        var id = entity.Entity.AuthorId;
        _context.SaveChanges();
        return id;    
    }

    public void Delete(int id)
    {
        var find = _context.Authors.Find(id);
        if (find != null)
        {
            _context.Authors.Remove(find);
            _context.SaveChanges();
        }
    }

    public void Update(Author author)
    {
        _context.Authors.Update(AuthorMapper.ToEntity(author));
        _context.SaveChanges();
    }

    public List<Author> FindAll()
    {
        return _context.Authors
            .Select(e => AuthorMapper.FromEntity(e))
            .ToList();
    }

    public Author? FindById(int id)
    {
        return AuthorMapper.FromEntity(_context.Authors.Find(id));
    }
}