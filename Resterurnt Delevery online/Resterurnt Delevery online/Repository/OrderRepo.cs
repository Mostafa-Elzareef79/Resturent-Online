using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Repository
{
    public class OrderRepo:IOrder
    {
        private ResteruntDB context;
        public OrderRepo(ResteruntDB context) { 
            this.context = context;
        }



        public void Add(Order item)
        {
            context.Orders.Add(item);
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order GetById(int orderId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
