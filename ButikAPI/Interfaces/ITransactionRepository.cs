using ButikAPI.DTOs;
using ButikAPI.ViewModels;

namespace ButikAPI.Interfaces
{
    public interface ITransactionRepository
    {
        Task<List<TransactionViewModel>> GetFiltered(FilterDto filterDto);
        Task<TransactionViewModel> GetTotalInYear(FilterDto filterDto);
    }
}
