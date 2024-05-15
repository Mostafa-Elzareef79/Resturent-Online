using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private Iitems ItemDB { get; set; }
        public ItemController(Iitems ItemDB)
        {
            this.ItemDB = ItemDB;

        }
        [HttpGet("{id}")]

        public ActionResult GetAll(int id) {
            var AllItems = ItemDB.GetAll(id);
            var AllItemsDTO = new List<itemDTO>();
            if (AllItems.Count == 0)
            {
                return BadRequest("There is no items in this retrunt");
            }
            foreach (var item in AllItems)
            {
                var itemDTO = new itemDTO();
                itemDTO.id = item.id;
                itemDTO.name = item.name;
                itemDTO.image = item.image;
       
                itemDTO.description = item.description;
                itemDTO.quantity = item.quantity;

                itemDTO.price = item.price;
                AllItemsDTO.Add(itemDTO);


            }
            return Ok(AllItemsDTO);
        }
        
    }
}
