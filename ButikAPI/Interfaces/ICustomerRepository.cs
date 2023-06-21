using ButikAPI.DTOs;
using ButikAPI.ViewModels;

namespace ButikAPI.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerViewModel>> GetCustomerByRegister(FilterDto filterDto);
        Task<List<CustomerViewModel>> GetTopTen(FilterDto filterDto);
    }
}
