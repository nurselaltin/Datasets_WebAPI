using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public List<City> GetAll()
        {

            return _cityDal.GetAll();
            
        }

        public City GetByCity(City city)
        {
            return _cityDal.GetByCity(city);
        }

        public List<City> GetByCodeASC()
        {
            return _cityDal.GetByCodeASC();
        }

        public List<City> GetByCodeDESC()
        {
            return _cityDal.GetByCodeDESC();
        }
    }
}
