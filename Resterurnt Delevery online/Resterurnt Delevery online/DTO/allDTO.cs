namespace Resterurnt_Delevery_online.DTO
{
    public class allDTO
    {
       
        public OrderDTO order { get; set; }  
        public ICollection<itemDTO> items { get; set; }

    }
}
