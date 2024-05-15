using Resterurnt_Delevery_online.Models;

namespace Resterurnt_Delevery_online.Interfaces
{
    public interface IRestrunt
    {
        public List<Resterunt> GetAll(int id);
        public List<Resterunt> GetAllRestrunt();
    }
}
