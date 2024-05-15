using System.ComponentModel.DataAnnotations.Schema;

namespace Resterurnt_Delevery_online.Models
{
    public class Order
    {

        public int id { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public decimal Subtotal { get; set; }
        public virtual List<ItemOrder> ItemOrders { get; set; } = new List<ItemOrder>();
    }
}
