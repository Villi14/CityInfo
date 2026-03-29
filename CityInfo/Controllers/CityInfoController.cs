using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CityInfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            var cities = CitiesDataStore.Current.Cities;
            if (cities == null)
            {
                return NotFound();
            }

            return Ok(cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
