using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]   
        public string get()
        {
            return "Student no 1 ";
        }
        [HttpGet]
        public string getStudent()
        {
            return " Student no 2 is here";

        }
    }
}
