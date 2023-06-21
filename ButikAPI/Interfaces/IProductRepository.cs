using ButikAPI.DTOs;
using ButikAPI.ViewModels;

namespace ButikAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetProductWithHighLowPrice(FilterDto filterDto);
        Task<List<ProductViewModel>> GetTopTen(FilterDto filterDto);
    }
}
