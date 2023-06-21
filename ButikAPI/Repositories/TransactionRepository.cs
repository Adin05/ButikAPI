using AutoMapper;
using ButikAPI.Data;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ButikAPI.Repositories
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        private readonly IMapper _mapper;

        public TransactionRepository(DataContext context, IMapper mapper) : base(context)
        {
            this._mapper = mapper;
        }

        public async Task<List<TransactionViewModel>> GetFiltered(FilterDto filterDto)
        {
            var datas = await _context.Transactions
                .Where(m => m.BranchId == filterDto.BranchId && m.TransactionDate.Year == filterDto.Year)
                .ToListAsync();

            return _mapper.Map<List<TransactionViewModel>>(datas);
        }

        public async Task<TransactionViewModel> GetTotalInYear(FilterDto filterDto)
        {
            var datas = await _context.Transactions
                 .Where(m => m.BranchId == filterDto.BranchId && m.TransactionDate.Year == filterDto.Year)
                 .ToListAsync();

            return new TransactionViewModel()
            {
                TotalInYear = datas.Sum(m => m.TotalPrice)
            };
        }
    }
}
