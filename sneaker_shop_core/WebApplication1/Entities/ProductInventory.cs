namespace WebApplication1.Entities
{
    public class ProductInventory
    {
        public int ProductID { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiledAt { get; set; }
    }
}
