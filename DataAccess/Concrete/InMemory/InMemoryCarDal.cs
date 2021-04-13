using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
              new Car{Id=1 , BrandId = 1, ColorId=1, DailyPrice=200, Description="Hyundai i20 Otomatik vites", ModelYear=2018 },
              new Car{Id=2 , BrandId = 1, ColorId=2, DailyPrice=190, Description="Hyundai i20 Otomatik vites", ModelYear=2017 },
              new Car{Id=3 , BrandId = 2, ColorId=3, DailyPrice=300, Description="Kia Sorento Otomatik vites", ModelYear=2015 },
              new Car{Id=4 , BrandId = 3, ColorId=4, DailyPrice=450, Description="Mercedes e200 Otomatik vites", ModelYear=2019 },
              new Car{Id=5 , BrandId = 4, ColorId=4, DailyPrice=425, Description="Bmw 520d Otomatik vites", ModelYear=2020 },
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car UpdatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            UpdatedCar.Id = car.Id;
            UpdatedCar.BrandId = car.BrandId;
            UpdatedCar.ColorId = car.ColorId;
            UpdatedCar.DailyPrice = car.DailyPrice;
            UpdatedCar.Description = car.Description;
            UpdatedCar.ModelYear = car.ModelYear;
        }
        public void Delete(Car car)
        {
            Car DeletedCar = _cars.SingleOrDefault<Car>(p => p.Id == car.Id);
            _cars.Remove(DeletedCar);
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
