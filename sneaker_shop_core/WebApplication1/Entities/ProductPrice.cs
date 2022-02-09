namespace WebApplication1.Entities
{
    public class ProductPrice
    {
        public int ProductID { get; set; }
        public string ProductSize { get; set; }
        public double Price { get; set; }   
        public DateTime EffectTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }

    }
}
