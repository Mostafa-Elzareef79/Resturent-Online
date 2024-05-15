using System.ComponentModel.DataAnnotations.Schema;

namespace Resterurnt_Delevery_online.Models
{
    public class ItemOrder
    {
        public int id { get; set; }
        [ForeignKey("Item")]
        public int Item_id { get; set; }
       public virtual Item Item { get; set; }
        [ForeignKey("Order")]
        public int Order_id { get; set; }
        public virtual Order? Order { get; set; }
        public int Quntity { get; set; }
    }
}
