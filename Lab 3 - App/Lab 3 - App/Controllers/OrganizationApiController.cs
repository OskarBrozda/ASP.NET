using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_3___App.Controllers
{
    [Route("api/organizations")]
    [ApiController]
    public class OrganizationApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public OrganizationApiController(AppDbContext context)
        {
            _context = context;
        }
        
        //[Route("filter")]
        [HttpGet]
        public IActionResult GetFilteredOrganizations(string? q)
        {
            return Ok(
                q is null ? _context.Organizations
                        .ToList()
                        .Select(o => new{ o.Title, o.OrganizationId})
                        .ToList()
                    :
                    _context.Organizations
                        .Where(o => o.Title.ToUpper().StartsWith(q.ToUpper()))
                        .Select(o => new { o.Title, o.OrganizationId })
                        .ToList());
        }
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetOrganizationById(int id)
        {
            var entity = _context.Organizations.Find(id);
            if (entity is null) return NotFound();
            else return Ok(entity);
        }
    }
}