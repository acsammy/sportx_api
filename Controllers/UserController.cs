using System.Threading.Tasks;
using sportx_api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace sportx_api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class UserController
    {
        [HttpGet("oi")]
        public string oi(){
            return "Hello World";
        }
        
    }
}