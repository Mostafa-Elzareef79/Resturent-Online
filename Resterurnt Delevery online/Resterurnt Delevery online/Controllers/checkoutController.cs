using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class checkoutController : ControllerBase
    {
        private IOrder orderDB { get; set; }
        private IItemOrder itemOrderDB { get; set; }
        public checkoutController(IOrder orderDB, IItemOrder itemOrderDB)
        {
            this.orderDB = orderDB;
            this.itemOrderDB = itemOrderDB;
            
        }
        [HttpPost]
        public IActionResult Add(allDTO all)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var orderDTO = new Order();
            orderDTO.email = all.order.email;
            orderDTO.phone = all.order.phone;
            orderDTO.Subtotal = all.order.subtotal;
            orderDTO.address = all.order.address;
            orderDTO.name = all.order.name;
            orderDB.Add(orderDTO);
            orderDB.Save();


     
            foreach (var item in all.items)
            {
                ItemOrder itemOrder = new ItemOrder();
                itemOrder.Item_id = item.id;
                itemOrder.Order_id = orderDTO.id;
                itemOrder.Quntity = item.quantity;
                itemOrderDB.Add(itemOrder);
                itemOrderDB.Save();

            }
           


            return Ok("sucess add order");
        }
       
       
    }
}
