using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class District:IEntity
    {

    
        public string DistrictName { get; set; }

        public List<string> ZipCodeList { get; set; }
 


    }
}
