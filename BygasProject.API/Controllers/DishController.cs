using BygasProject.Domain.Models;
using BygasProject.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BygasProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _service;

        public DishController(IDishService service)
        {
            _service = service;
        }


        // GET: api/<DishController>
        [HttpGet]
        public ActionResult<Dish> Get()
        {
            var dish = _service.GetAllDishes();

            return Ok(dish);
        }

        // GET api/<DishController>/5
        [HttpGet("{id}")]
        public ActionResult<Dish> Get(int id)
        {
            var dish = _service.GetDish(id);
            return dish is null ? Ok(dish) : NotFound();
        }

        // POST api/<DishController>
        [HttpPost]
        public ActionResult<Dish> Post([FromBody] Dish item)
        {
            var dish = _service.AddDish(item);

            return Ok(dish);
        }

        // PUT api/<DishController>/5
        [HttpPut("{id}")]
        public ActionResult<Dish> Put(int id, [FromBody] Dish item)
        {
            var dish = _service.EditDish(item);

            return dish is null ? Ok(dish) : BadRequest();
        }

        // DELETE api/<DishController>/5
        [HttpDelete("{id}")]
        public ActionResult<Dish> Delete(int id)
        {
            var dish = (_service.DeleteDish(id));

            return dish ? Ok() : NotFound(); 
        }
    }
}
