namespace WebApplication1.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string ? Description { get; set; }
        public double DiscountPercent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
        public virtual List<Product> Products { get; set; }

    }
}
