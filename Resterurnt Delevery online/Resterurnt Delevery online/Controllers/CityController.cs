using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Interfaces;

namespace Resterurnt_Delevery_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private Icity CityDB { get; set; }
        public CityController(Icity CityDB) {
            this.CityDB = CityDB;
        
        }
        [HttpGet]
        public IActionResult AllCities() {
           var Cities= CityDB.GetAll();
            var CitiesDTO=new List<CityDTO>();
            foreach (var city in Cities)
            {
                var cityDTO = new CityDTO();
                cityDTO.id = city.id;
                cityDTO.name = city.name;
                CitiesDTO.Add(cityDTO);
            }
            if (Cities.Count == 0)
            {
                return NotFound();
            }

            return Ok(CitiesDTO);


        }
      
    }
}
