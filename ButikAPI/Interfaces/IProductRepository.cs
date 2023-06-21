using ButikAPI.ViewModels;

namespace ButikAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetProductWithHighLowPrice(bool isHigh);
        Task<List<ProductViewModel>> GetTopTen(int branchId);
    }
}
