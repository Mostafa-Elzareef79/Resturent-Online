using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Repository
{
    public class ItemOrderRepo : IItemOrder
    {
        private ResteruntDB context;
        public ItemOrderRepo(ResteruntDB context) {
            this.context = context;
        
        }
        public void Add(ItemOrder item)
        {
            context.ItemOrders.Add(item);
        }

        public List<ItemOrder> GetAll()
        {
            return context.ItemOrders.ToList();
        }

      

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
