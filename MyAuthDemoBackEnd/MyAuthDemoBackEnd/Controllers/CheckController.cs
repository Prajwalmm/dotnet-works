using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAuthDemoBackEnd.Data;
using MyAuthDemoBackEnd.Models;
using MyAuthDemoBackEnd.Services;

namespace MyAuthDemoBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        private readonly IUserServices _userServices;
        //private readonly UserDbContext userDbContext;
        public CheckController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpPost]

        public async Task<IActionResult> PostLogin(Services.UserDto Details)
        {
            var checkin =  _userServices.check(Details.UserName, Details.Password);
            if(checkin)
                 return Ok(true); 
            return Ok(false);
        }
        

    }
}
