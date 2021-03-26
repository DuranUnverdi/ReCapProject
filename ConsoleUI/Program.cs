using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CarTest2();
            // CustomerTest();
            CarTest3();

        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.Id + "--" + customer.UserId+"---" +customer.CompanyName);
            }
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal(),new BrandManager(new EfBrandDal()));
            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.DailyPrice + "--" + car.ColorName);
            }
        }
        private static void CarTest3()
        {
            BrandManager carManager = new BrandManager(new EfBrandDal());
            foreach (var brand in carManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "--" + brand.Name);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(result.Message);

            }
else
                {
                    Console.WriteLine(result.Message);
                }
            }
            
        }
    
}
