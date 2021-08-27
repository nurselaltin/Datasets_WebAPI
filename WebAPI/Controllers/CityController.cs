using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("[controller]s")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;

        }


        [HttpGet]
        public List<City> GetAll()
        {

            return _cityService.GetAll();
        }

        [HttpPost("getbycity")]
        public City GetByCity(City city)
        {
            return _cityService.GetByCity(city);
        }

        [HttpGet("getbycodeasc")]
        public List<City> GetByCodeASC()
        {

            return _cityService.GetByCodeASC();
        }


        [HttpGet("getbycodedesc")]
        public List<City> GetByCodeDESC()
        {

            return _cityService.GetByCodeDESC();
        }



    }
}
