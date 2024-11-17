using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Repository;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICatagoryRepository _CatagoryRepository;

        public CategoryController(ICatagoryRepository productRepository)

        {

            _CatagoryRepository = productRepository;

        }


        [HttpGet]

        public IActionResult Get()

        {
            var category = _CatagoryRepository.GetCategory();

            return new OkObjectResult(category);


        }


        [HttpGet("{id}", Name = "Gete")]

        public IActionResult Get(int id)

        {

            var category = _CatagoryRepository.GetCategoryByID(id);

            return new OkObjectResult(category);

        }


        [HttpPost]

        public IActionResult Post([FromBody] Category category)

        {

            using (var scope = new TransactionScope())

            {

                _CatagoryRepository.InsertCategory(category);

                scope.Complete();

                return CreatedAtAction(nameof(Get), new { id = category.Id }, category);

            }

        }

        
        [HttpPut]

        public IActionResult Put([FromBody] Category category)

        {

            if (category != null)

            {

                using (var scope = new TransactionScope())

                {

                    _CatagoryRepository.UpdateCategory(category);

                    scope.Complete();

                    return new OkResult();

                }

            }

            return new NoContentResult();

        }


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)

        {

            _CatagoryRepository.DeleteCategory(id);

            return new OkResult();

        }
    }
}
