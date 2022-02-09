namespace WebApplication1.Entities
{
    public class Product
    {
        public int Id { get; set; }    
        public string Name { get; set; }    
        public string ? Description { get; set; }
        public int  Brand_ID { get; set; }
        public string ? Cover_Image { get; set; }
        public string Wallpaper { get; set; }
        public DateOnly Release_date { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public string User_Type { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Modified_At { get; set; }
        public int Discount_ID { get; set; }
    }
}
