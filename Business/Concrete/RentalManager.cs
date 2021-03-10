using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetAllByCustomerdId(int id)
        {
            return _rentalDal.GetAll(r => r.CustomerId == id);
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }
}
