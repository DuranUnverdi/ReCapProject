﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllByCustomerdId(int id);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
       
    }
}
