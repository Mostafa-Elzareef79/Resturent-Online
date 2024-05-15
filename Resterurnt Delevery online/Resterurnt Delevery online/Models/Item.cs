using System.ComponentModel.DataAnnotations.Schema;

namespace Resterurnt_Delevery_online.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        [ForeignKey("Resterunt")]
        public int Rest_id { get; set; }

        //navigation prop
        public virtual Resterunt Resterunt { set; get; } 
    
        public virtual List<ItemOrder> ItemOrders { get; set; } = new List<ItemOrder>();




    }
}
