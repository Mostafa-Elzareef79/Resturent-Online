using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Repository
{
    public class ItemRepo : Iitems
    {
        private ResteruntDB context;
        public ItemRepo(ResteruntDB context)
        {
            this.context = context;

        }
        public void Add(Item Item)
        {
            context.Items.Add(Item);    
        }

        public void Delete(int id)
        {
           context.Items.Remove(GetById(id));
        }

        public List<Item> GetAll(int id)
        {
         return context.Items.Where(c=>c.Resterunt.id == id).ToList();
        }

        public Item GetById(int id)
        {
            return context.Items.SingleOrDefault(n => n.id == id);
        }

        public void Save()
        {
           context.SaveChanges();
        }

        public void Update(Item Item)
        {
            context.Items.Update(Item);
        }
    }
}
