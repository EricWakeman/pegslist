using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pegslist.Models;
using pegslist.Services;

namespace pegslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
      private readonly HousesService _housesService;
      public HousesController(HousesService housesService)
      {
        _housesService = housesService;
      }

      [HttpGet]
        public ActionResult<List<House>> GetAllHouses()
        {
          try
          {
              List<House> houses = _housesService.GetAllHouses();
              if(houses == null)
              {
                return NoContent();
              }
              return Ok(houses);
          }
          catch (System.Exception e)
          {
              return NotFound(e.Message);
          }
        }
    }
}