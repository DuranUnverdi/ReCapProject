using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
       IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailDto> >GetCarDetailDtos();
    }
}
