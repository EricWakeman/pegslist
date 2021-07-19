using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pegslist.Models;
using pegslist.Services;

namespace pegslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
      private readonly CarsService _carsService;
      public CarsController(CarsService carsService)
      {
        _carsService = carsService;
      }
        [HttpGet]
        public ActionResult<List<Car>> GetAllCars()
        {
          try
          {
              List<Car> cars = _carsService.GetAllCars();
              if(cars == null)
              {
                return NoContent();
              }
              return Ok(cars);
          }
          catch (System.Exception e)
          {
              return NotFound(e.Message);
          }
        }

        [HttpPost]
        public ActionResult<Car> CreateCar([FromBody] Car carData)
        {
          try
          {
              var car = _carsService.CreateCar(carData);
              return Created("api/cars/"+ car.Id, car);
          }
          catch (System.Exception e)
          {
              return BadRequest(e.Message);
          }
        }
        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
          try
          {
             var car = _carsService.GetCarById(id);
             if(car == null)
             {
               return BadRequest("Invalid Id");
             }
             return car;

          }
          catch (System.Exception e)
          {
              return BadRequest(e.Message);
          }

        }
        [HttpPut("{id}")]
        public ActionResult<Car> EditCar(int id, [FromBody]Car cardata)
        {
          try
          {
              _carsService.EditCar(id, cardata);
          }
          catch (System.Exception e)
          {
              return BadRequest(e.Message);
          }
          return Ok(cardata);
          
        }
        [HttpDelete("{id}")]
        public ActionResult<Car> DeleteCar(int id)
        {
          try
          {
             Car car = _carsService.DeleteCar(id);
            return Ok(car);

          }
          catch (System.Exception e)
          {
              return BadRequest(e.Message);
          }
        }

    }
}