using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Karmaplusplus.Models;

namespace Karmaplusplus.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ServicesController : ControllerBase
  {
    private readonly KarmaplusplusContext _db;

    public ServicesController(KarmaplusplusContext db)
    {
      _db = db;
    }

    // GET: api/services?page=1&pagesize=20
    [HttpGet]
    public async Task<IActionResult> GetServices( int id, string userId, string serviceName, string description, string email, string zipCode, int page = 1, int pageSize = 10)
    {
      IQueryable<Service> query = _db.Services.AsQueryable();

      if (userId != null)
      {
        query = query.Where(entry => entry.UserId == userId);
      }
      if (serviceName != null)
      {
        query = query.Where(entry => entry.ServiceName == serviceName);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      if (email != null)
      {  
        query = query.Where(entry => entry.Email == email);
      }
      if (id != 0)
      {  
        query = query.Where(entry => entry.ServiceId  == id);
      }
      if (zipCode != null)
      {
        query = query.Where(entry => entry.ZipCode == zipCode);
      }  
      
      
        // Calculate the number of items to skip based on the page size and requested page. 
        int skip = (page - 1) * pageSize;

        // Retrieve the data from your data source, applying the pagination parameters.  
        List<Service> services = await query
            .Skip(skip)
            .Take(pageSize)
            .ToListAsync();

        // Determine the total number of items in your data source.
        int totalCount = _db.Services.Count();

        // Create a response object to hold the paginated data and total count.
        var response = new
        {
            Data = services,
            TotalCount = totalCount,
            Page = page,
            PageSize = pageSize
        };

        // Return the paginated data to the client.
        return Ok(response);
    }

    // GET: api/services/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Service>> GetService(int id)
    {
      Service service = await _db.Services.FindAsync(id);

      if (service == null)
      {
        return NotFound();
      }

      return service;
    }
    
    // POST api/services
    [HttpPost]
    public async Task<ActionResult<Service>> Post(Service service)
    {
      _db.Services.Add(service);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetService), new { id = service.ServiceId }, service);
    }

    // PUT: api/services/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Service service)
    {
      if (id != service.ServiceId)
      {
        return BadRequest();
      }

      _db.Services.Update(service);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ServiceExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // DELETE: api/services/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteService(int id)
    {
      Service Service = await _db.Services.FindAsync(id);
      if (Service == null)
      {
        return NotFound();
      }

      _db.Services.Remove(Service);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool ServiceExists(int id)
    {
      return _db.Services.Any(e => e.ServiceId == id);
    }
  }
}