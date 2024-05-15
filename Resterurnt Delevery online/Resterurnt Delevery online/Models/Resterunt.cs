using System.ComponentModel.DataAnnotations.Schema;

namespace Resterurnt_Delevery_online.Models
{
    public class Resterunt
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? image { get; set; }


        public string? description { get; set; }

        [ForeignKey("City")]
        public int? City_Id { get; set; }
        public virtual City City { get; set; }
       
        public virtual List<Item> Items { get; set; }=new List<Item>();
    }
}
