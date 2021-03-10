using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<Rental> GetAll();
        List<Rental> GetAllByCustomerdId(int id);
        void Add(Rental rental);
        void Update(Rental rental);
       
    }
}
