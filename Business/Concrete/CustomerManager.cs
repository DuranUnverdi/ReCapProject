using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
       
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>> (_customerDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Customer>> GetAllByUserId(int id)
        {
            return  new SuccessDataResult<List<Customer>>( _customerDal.GetAll(p => p.UserId == id));
        }

        public IDataResult<Customer> GetById(int Id)
        {
            return new SuccessDataResult<Customer> (_customerDal.Get(c=>c.Id==Id));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
