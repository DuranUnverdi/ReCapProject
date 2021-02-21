using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150000,Description="2018 model Opel Astra.",ModelYear="2018" },
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=110000,Description="2014 Opel Corsa.",ModelYear="2014" },
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=120000,Description="2010 model Renault Clio.",ModelYear="2010" },
                new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=180000,Description="2019 model Renault Megane",ModelYear="2019" },
                new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=200000,Description="2013 model Audi A3",ModelYear="2013" },
               // new Car{Id=6,BrandId=4,ColorId=3,DailyPrice=400000,Description="2016 model Mercedes CLE",ModelYear="2016" }
            };
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,Name="Opel"},
                new Brand{BrandId=2,Name="Renault"},
                new Brand{BrandId=3,Name="Audi"},
                 new Brand{BrandId=4,Name="Mercedes"}
            };
            _colors = new List<Color>
            {
                new Color{ColorId=1,Name="Beyaz"},
                new Color{ColorId=2,Name="Siyah"},
                new Color{ColorId=3,Name="Gri"}
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

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
