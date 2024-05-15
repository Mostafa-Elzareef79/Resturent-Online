using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Interfaces
{
    public interface IItemOrder
    {
        public List<ItemOrder> GetAll();
       
        public void Add(ItemOrder item);
       
        
        public void Save();
    }
}
