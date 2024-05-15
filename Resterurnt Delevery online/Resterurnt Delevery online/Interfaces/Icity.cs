using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Interfaces
{
    public interface Icity
    {
        public List<City> GetAll();
        public City GetId(int id);

    }
}
