using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByModelYear(int modelYear);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        //List<Car> GetAllByUnitPrice(decimal min, decimal max);
        //List<CarDetailDto> GetProductDetails();
    }
}
