
using DataAccess.Abstract;
using Entities.Concrete;

using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete.CSV
{
    public class CsvCityDal : ICityDal
    {

     

        public List<City> CityList;


        public CsvCityDal()
        {
            CsvContext context = new CsvContext();
            CityList = context.GetCityList();
        }

      



        public List<City> GetAll()
        {
            return CityList;
        }

        public City GetByCity(City city)
        {

           
            return CityList.SingleOrDefault(c => c.CityName == city.CityName);

        }

        public List<City> GetByCodeASC()
        {
          
            return CityList.OrderBy(o => o.CityCode).ToList();
        }

        public List<City> GetByCodeDESC()
        {
            return CityList.OrderByDescending(d => d.CityCode).ToList();
        }

    }
}
