using Microsoft.EntityFrameworkCore;

namespace Resterurnt_Delevery_online.Models
{
    public class ResteruntDB:DbContext
    {
        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Resterunt> Resteruntes { get; set; }

        public virtual DbSet<Item> Items { get; set; }
       
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ItemOrder> ItemOrders { get; set; }


        // Constructor overloading to allow for IoC injection of RestruntDB context
        public ResteruntDB() : base() { }
        public ResteruntDB(DbContextOptions options) : base(options) { }


    }
}
