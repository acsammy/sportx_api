using System.Threading.Tasks;
using sportx_api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sportx_api.Models;

namespace sportx_api.Controllers
{
  [Controller]
  [Route("[controller]")]
  public class PartnerPhoneController : ControllerBase
  {
    private DataContext _dataContext;

    public PartnerPhoneController(DataContext context)
    {
      this._dataContext = context;
    }

    [HttpGet("")]
    public async Task<ActionResult> Index([FromBody] PartnerPhones phone)
    {
      List<PartnerPhones> phones = await _dataContext.PartnerPhones.ToListAsync();

      return Ok(phones);
    }

    [HttpPost("")]
    public async Task<ActionResult> Create([FromBody] PartnerPhones phone)
    {
      Partner partner = _dataContext.Partners.FirstOrDefault(u => u.Id == phone.Partner.Id);
      _dataContext.PartnerPhones.Add(phone);
      await _dataContext.SaveChangesAsync();

      return Created("Phone", phone);
    }

  }
}