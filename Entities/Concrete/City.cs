using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class City:IEntity
    {


        public string CityName { get; set; }
        public string CityCode { get; set; }

        public List<District> DistrictList { get; set; }


    }
}
