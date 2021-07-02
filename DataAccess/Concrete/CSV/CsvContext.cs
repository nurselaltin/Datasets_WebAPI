using Entities.Concrete;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace DataAccess.Concrete.CSV
{
    public class CsvContext
    {

 
       
        public List<City> CityList;
        readonly string[] rows;


        public CsvContext()
        {
            rows = File.ReadAllLines(@"C:\Users\Nursel\Desktop\Projects\C#\Ornek-Projeler\API_Project\DataAccess\Datasets\sample_data.csv");
        }


        public List<City> GetCityList()
        {
            List<City> CityList = new List<City>();
            for (int i = 1; i < rows.Count(); i++)
            {

                string[] row = rows[i].Split(',');
                for (int j = 0; j < row.Count(); j++)
                {
                    var cityOld = CityList.SingleOrDefault(x => x.CityCode == row[1]);
                    if (cityOld == null)
                    {
                        City city = new City();
                        city.CityName = row[0];
                        city.CityCode = row[1];
                        city.DistrictList = new List<District>();

                        CityList.Add(city);
                    }
                    else
                    {
                        var districtOld = cityOld.DistrictList.SingleOrDefault(d => d.DistrictName == row[2]);
                        if (districtOld == null)
                        {
                            District district = new District();
                            district.DistrictName = row[2];
                            district.ZipCodeList = new List<string>();
                            district.ZipCodeList.Add(row[3]);
                            cityOld.DistrictList.Add(district);
                        }
                        else
                        {
                            districtOld.ZipCodeList.Add(row[3]);
                           
                        }

                        break;
                    }


                }

            }
            return CityList;
        }



    }
}
