using Data;
using Microsoft.AspNetCore.Mvc;

namespace PhotoApp.Controllers;

[Route("api/authors")]
[ApiController]
public class AuthorApiController : ControllerBase
{
    private readonly AppDbContext _context;
        
    public AuthorApiController(AppDbContext context)
    {
        _context = context;
    }
        
    // //[Route("filter")]
    [HttpGet]
    public IActionResult GetFilteredAuthors(string? q)
    {
            var authors = q is null ? _context.Authors
                    .ToList()
                    .Select(o => new{ o.Name, o.Surname, o.AuthorId})
                    .ToList()
                :
                _context.Authors
                    .Where(o => o.Name.ToUpper().StartsWith(q.ToUpper()))
                    .Select(o => new { o.Name, o.Surname, o.AuthorId })
                    .ToList();
    
            return Ok(authors);
    }
    
    [Route("{id}")]
    [HttpGet]
    public IActionResult GetAuthorById(int id)
    {
        var entity = _context.Authors.Find(id);
        if (entity is null) return NotFound();
        else return Ok(entity);
    }
}