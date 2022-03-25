namespace WebApplication1.Infrastructure.ViewModels
{
    public class ProductListViewModel
    {
        public List<ProductCardViewModel> ProductList { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int NumberOfRecords { get; set; }
        public ProductListViewModel(List<ProductCardViewModel> ProductList, string Title, string Description, int NumberOfRecrds, string Icon)
        {
            this.ProductList = ProductList;
            this.Title = Title;
            this.Description = Description;
            this.NumberOfRecords = NumberOfRecrds;
            this.Icon = Icon;
        }
    }
}
