using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetByCity(City city);

        List<City> GetByCodeASC();
        List<City> GetByCodeDESC();

    }
}
