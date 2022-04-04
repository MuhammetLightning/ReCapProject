using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Renault"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2010,DailyPrice=550,Description="Citroen"},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=600,Description="Fiat"},
                new Car{Id=4,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=700,Description="Toyota"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpadate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpadate.BrandId = car.BrandId;
            carToUpadate.ColorId = car.ColorId;
            carToUpadate.DailyPrice = car.DailyPrice;
            carToUpadate.Description = car.Description;
        }
    }
}
