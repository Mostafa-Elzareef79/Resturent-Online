namespace Resterurnt_Delevery_online.DTO
{
    public class OrderDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public decimal subtotal { get; set;}
    }
}
