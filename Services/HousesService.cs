using System.Collections.Generic;
using pegslist.Data;
using pegslist.Models;

namespace pegslist.Services
{
    public class HousesService
    {
      public List<House> GetAllHouses()
      {
        return FakeDb.Houses;
      }
    }
}