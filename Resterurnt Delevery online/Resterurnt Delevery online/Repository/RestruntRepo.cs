using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Repository
{
    public class RestruntRepo : IRestrunt
    {
        private ResteruntDB context;
        public RestruntRepo(ResteruntDB context)
        {
            this.context = context;

        }
        public List<Resterunt> GetAll(int id)
        {
            return context.Resteruntes.Where(n=>n.City_Id==id).ToList();
        }

        public List<Resterunt> GetAllRestrunt()
        {
            return context.Resteruntes.ToList();
        }

      
    }
}
