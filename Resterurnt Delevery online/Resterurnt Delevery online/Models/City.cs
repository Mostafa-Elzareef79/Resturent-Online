namespace Resterurnt_Delevery_online.Models
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        //navigation prop
        public virtual List<Resterunt> Resterunts { set; get; } = new List<Resterunt>();

    }
}
