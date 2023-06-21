using AutoMapper;
using ButikAPI.Data;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ButikAPI.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly IMapper _mapper;

        public CustomerRepository(DataContext context, IMapper mapper) : base(context)
        {
            this._mapper = mapper;
        }

        public async Task<List<CustomerViewModel>> GetCustomerByRegister(bool isOld)
        {
            var datas = await _context.Customers.OrderBy(m => m.RegisteredDate).ToListAsync();
            if (isOld)
            {
                datas = datas.OrderByDescending(m => m.RegisteredDate).ToList();
            }
            return _mapper.Map<List<CustomerViewModel>>(datas);
        }

        public async Task<List<CustomerViewModel>> GetTopTen(int branchId)
        {
            var customerIds = await _context.Transactions.Where(m => m.BranchId == branchId && m.TransactionDate.Month == DateTime.UtcNow.Month)
                .GroupBy(m => m.CustomerId)
                .Select(m => new
                {
                    CustomerId = m.Key,
                    Total = m.Sum(x => x.TotalPrice)
                })
                .OrderByDescending(m => m.Total)
                .Take(10)
                .Select(m => m.CustomerId)
                .ToListAsync();

            var datas = await _context.Customers.Where(m => customerIds.Contains(m.Id)).ToListAsync();

            return _mapper.Map<List<CustomerViewModel>>(datas);
        }
    }
}
