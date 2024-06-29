using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;




namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=1995, DailyPrice=1000, Description="Ucuz araba"},
                new Car{Id=2, BrandId=2, ColorId=1, ModelYear=2015, DailyPrice=3000, Description="Ortalama araba"},
                new Car{Id=3, BrandId=2, ColorId=1, ModelYear=2020, DailyPrice=7000, Description="Lüks araba"},
            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
