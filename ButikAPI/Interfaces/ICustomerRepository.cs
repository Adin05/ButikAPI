using ButikAPI.ViewModels;

namespace ButikAPI.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerViewModel>> GetCustomerByRegister(bool isOld);
        Task<List<CustomerViewModel>> GetTopTen(int branchId);
    }
}
