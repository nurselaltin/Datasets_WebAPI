using Entities.Concrete;
using System.Collections.Generic;
using System.Xml;

namespace DataAccess.Concrete.XML
{
    public class XmlContext
    {

        readonly XmlDocument xmlDocument;
        readonly XmlNode xmlNode;
        public List<City> CityList;

        public XmlContext()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(@"C:\Users\Nursel\Desktop\Software\Projects\C#\Ornek-Projeler\APIs\Datasets_WebAPI\DataAccess\Datasets\sample_data.xml");
            xmlNode = xmlDocument.SelectSingleNode("AddressInfo");
        }


        public List<City> GetCities()
        {
            XmlNodeList xmlNodeCityList = xmlNode.SelectNodes("City");
            CityList = new List<City>();
            
            foreach (XmlNode xmlNodeCity in xmlNodeCityList)
            {
                City city = new City();
                city.CityName = xmlNodeCity.Attributes["name"].Value;
                city.CityCode = xmlNodeCity.Attributes["code"].Value;
                city.DistrictList = new List<District>();

                XmlNodeList xmlNodeDistrictList = xmlNodeCity.SelectNodes("District");
                foreach (XmlNode xmlNodeDistrict in xmlNodeDistrictList)
                {
                    District district = new District();
                    district.DistrictName = xmlNodeDistrict.Attributes["name"].Value;

                    XmlNodeList xmlNodeZipList = xmlNodeDistrict.SelectNodes("Zip");
                    district.ZipCodeList = new List<string>();

                    foreach (XmlNode xmlNodeZip in xmlNodeZipList)
                    {
                        
                        district.ZipCodeList.Add(xmlNodeZip.Attributes["code"].Value);

                    }

                    city.DistrictList.Add(district);

                }


                CityList.Add(city);


            }


            return CityList;








        }

    }
}
