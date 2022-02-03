using System.Threading.Tasks;
using sportx_api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sportx_api.Models;

namespace sportx_api.Controllers
{
  [Controller]
  [Route("[controller]")]
  public class PartnerController : ControllerBase
  {
    private DataContext _dataContext;

    public PartnerController(DataContext context)
    {
      this._dataContext = context;
    }

    [HttpPost("")]
    public async Task<ActionResult> Create([FromBody] Partner partner)
    {
      _dataContext.Partners.Add(partner);
      await _dataContext.SaveChangesAsync();

      return Created("Partner", partner);
    }

    [HttpGet("")]
    public async Task<ActionResult> Index()
    {
      var partners = await _dataContext.Partners.ToListAsync();

      return Ok(partners);
    }

    [HttpGet("{id}")]
    public Partner Show(int Id)
    {
      Partner partner = _dataContext.Partners.Find(Id);
      return partner;
    }

    [HttpPut("")]
    public async Task<ActionResult> Update([FromBody] Partner partner)
    {
      _dataContext.Partners.Update(partner);
      await _dataContext.SaveChangesAsync();

      return Ok(partner);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int Id)
    {
      Partner partner = Show(Id);

      if (partner == null)
      {
        return NotFound();
      }

      _dataContext.Partners.Remove(partner);
      await _dataContext.SaveChangesAsync();

      return Ok();
    }
    

  }
}