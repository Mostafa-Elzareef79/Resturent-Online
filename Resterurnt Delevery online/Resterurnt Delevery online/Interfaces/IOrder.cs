using Resterurnt_Delevery_online.DTO;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Interfaces
{
    public interface IOrder
    {
        public List<Order> GetAll();
        public Order GetById( int orderId);
        public void Add(Order item);


        public void Save();
    }
}
