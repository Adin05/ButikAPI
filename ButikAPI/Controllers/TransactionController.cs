using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;

namespace ButikAPI.Controllers
{
    public class TransactionController : BaseApiController<Transaction, TransactionViewModel, TransactionDto>
    {
        private readonly IBaseRepository<Transaction> _baseRepository;
        private readonly IMapper _mapper;

        public TransactionController(IBaseRepository<Transaction> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
