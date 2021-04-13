using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EnitityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, EfDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (EfDbContext context = new EfDbContext())
            {
                var result = from brand in context.Brands
                             join car in context.Cars on brand.Id equals car.BrandId
                             join color in context.Colors on car.ColorId equals color.Id
                             select new CarDetailDto()
                             {
                                 CarDetail = car.Description,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ColorName = color.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
