namespace WebApplication1.Entities
{
    public class Discount
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public string ? Description { get; set; }
        public double DiscountPercent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }

    }
}
