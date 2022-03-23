namespace WebApplication1.Infrastructure.ViewModels
{
    public class ProductCardRankingViewModel : ProductCardViewModel
    {
        public int rank;
        public ProductCardRankingViewModel(Product product, int _rank) : base(product)
        {
            rank = _rank;
        }
    }
}
