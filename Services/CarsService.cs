using System;
using System.Collections.Generic;
using pegslist.Data;
using pegslist.Models;

namespace pegslist.Services
{
    public class CarsService
    {
      public List<Car> GetAllCars()
      {
        return FakeDb.Cars;
      }
      public Car CreateCar(Car carData)
      {
        var r = new Random();
        carData.Id = r.Next(100, 9999);
        FakeDb.Cars.Add(carData);
        return carData;
      }

    public Car GetCarById(int id)
    {
      return FakeDb.Cars.Find(c => c.Id == id);

    }

    public Car EditCar(int id, Car cardata)
    {
      Car car = FakeDb.Cars.Find(c => c.Id == id);
      if(car != null)
      {
      FakeDb.Cars.Remove(car);
      FakeDb.Cars.Add(cardata);
      return cardata;
      }
      throw new Exception("Invalid Id");
    }

    public Car DeleteCar(int id)
    {
      Car car = FakeDb.Cars.Find(c => c.Id == id);
      if(car != null){
        FakeDb.Cars.Remove(car);
        return car;
      }
      throw new Exception("Invalid Id");
    }
  }
}