using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2005, DailyPrice=2000, Description="Saatte 80km/h hıza çıkabilir" },
                new Car{Id=2, BrandId=1, ColorId=1, ModelYear=2007, DailyPrice=3500, Description="Saatte 90km/h hıza çıkabilir" },
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear=2010, DailyPrice=4800, Description="Saatte 110km/h hıza çıkabilir" },
                new Car{Id=4, BrandId=2, ColorId=3, ModelYear=2012, DailyPrice=5000, Description="Saatte 100km/h hıza çıkabilir" },
                new Car{Id=5, BrandId=3, ColorId=4, ModelYear=2015, DailyPrice=8000, Description="Saatte 180km/h hıza çıkabilir" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
