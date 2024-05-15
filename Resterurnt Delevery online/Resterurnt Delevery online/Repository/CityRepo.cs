using Resterurnt_Delevery_online.Interfaces;
using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Repository
{
    public class CityRepo : Icity
    {
        private ResteruntDB context;
        public CityRepo(ResteruntDB context) {
            this.context = context;
        
        }
        public List<City> GetAll()
        {
            return context.Cities.ToList();
        }

        public City GetId(int id)
        {
            return context.Cities.SingleOrDefault(c => c.id == id);
        }
    }
}
