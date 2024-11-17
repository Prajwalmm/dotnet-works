using FirstWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentdetailsController : ControllerBase
    {
        public static List<student> list = new List<student>
        {
            new student{Id=101,Name="abc",section=6,City="chennai"},
            new student{Id=102,Name="sdf",section=5,City="banglore"},
            new student{Id=103,Name="we",section=3,City="davanagere"},
            new student{Id=104,Name="ertyu",section=8,City="trivendrum"},
        };
        [HttpGet]
        public ActionResult<IEnumerable<student>> Get()
        { return list;
        }
        [HttpGet("{id}")]
        public ActionResult<student> getstudent(int id)
        {
            var stu = list.FirstOrDefault(p => p.Id == id);
            if(stu==null)
            {
                return NotFound();
            }
            return stu;
        }
        [HttpPost]
        public ActionResult<student> postdetail(student detail)
        {
            list.Add(detail);
            return detail;
            //return CreatedAtAction(nameof(getstudent), new { Id = detail.Id }, detail);
            //return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Putdetail(int id,student details)
        {   if(id!=details.Id)
            {
                return BadRequest();
            }
            var existingProduct = list.FirstOrDefault(p => p.Id == id);
            if(existingProduct is null)
            {
                return NotFound();
            }
            existingProduct.Name = details.Name;
            existingProduct.section = details.section;
            existingProduct.City = details.City;

            return NoContent();

        }
        [HttpDelete("{id}")]
        public IActionResult Deletedetail(int id)
        {
            var studentdetail = list.FirstOrDefault(p => p.Id == id);
            if (studentdetail is null)
            { return NotFound(); }
            list.Remove(studentdetail);
            return NoContent();
        }
            

    }
}
