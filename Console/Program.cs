using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameworrk;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { Id = 3, BrandId = 2, ColorId = 4, DailyPrice = 650, ModelYear=2016,Description = "Merhaba" };

            foreach (var car in carManager.GetAll().Data)
            {
                System.Console.WriteLine(car.Description);
            }
            
            //System.Console.WriteLine(carManager.GetByModelYear(2011).Description);

        }
    }
}
