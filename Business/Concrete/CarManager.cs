using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.ProductAdded);
            }
           
                return new ErrorResult(Messages.ProductNameInvalid);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Product Deleted");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductListed);
        }
        //Select * from Cars where ModelYear =2010
        public IDataResult<Car> GetByModelYear(int modelYear)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ModelYear == modelYear));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "Ürün güncellendi");
        }
    }
}
