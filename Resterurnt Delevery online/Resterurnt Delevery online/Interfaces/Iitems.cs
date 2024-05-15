using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Interfaces
{
    public interface Iitems
    {
        public List<Item> GetAll(int id);
        public Item GetById(int id);
        public void Add(Item Item);
        public void Delete(int id);
        
        public void Update(Item Item);




        public void Save();
    }
}
