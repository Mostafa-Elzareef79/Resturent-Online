using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestruntController : ControllerBase
    {
        private IRestrunt Restrunt { get; set; }
        public RestruntController(IRestrunt Restrunt) {
            this.Restrunt = Restrunt;
        }
        [HttpGet("{id}")]
        public  IActionResult AllRestrunt(int id)
        {
            var Restruntes = Restrunt.GetAll(id);
            if (Restruntes.Count == 0)
            {
                return BadRequest("no restrunt at this city");
            }
            var RestruntDTOs=new List<RestruntDTO>();
            foreach (var rsetrunt in Restruntes)
            {
                var rsetruntDTO = new RestruntDTO();
                rsetruntDTO.id = rsetrunt.id;
                rsetruntDTO.name= rsetrunt.name;
                rsetruntDTO.description= rsetrunt.description;
                rsetruntDTO.NameCity = rsetrunt.City.name;
                

                RestruntDTOs.Add(rsetruntDTO);

            }
            
            return Ok(RestruntDTOs);
        }
        [HttpGet]
        public IActionResult AllRestrunts()
        {
            var Restruntes = Restrunt.GetAllRestrunt();
            if (Restruntes.Count == 0)
            {
                return BadRequest("no restrunt at all");
            }
            var RestruntDTOs = new List<RestruntDTO>();
            foreach (var rsetrunt in Restruntes)
            {
                var rsetruntDTO = new RestruntDTO();
                rsetruntDTO.id = rsetrunt.id;
                rsetruntDTO.name = rsetrunt.name;
                rsetruntDTO.description = rsetrunt.description;
                rsetruntDTO.NameCity = rsetrunt.City.name;


                RestruntDTOs.Add(rsetruntDTO);

            }

            return Ok(RestruntDTOs);
        }
    }
}
