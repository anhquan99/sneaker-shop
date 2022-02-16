namespace WebApplication1.Entities
{
    public class WantedProduct
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
