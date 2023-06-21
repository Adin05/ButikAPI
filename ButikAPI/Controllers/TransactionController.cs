using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ButikAPI.Controllers
{
    public class TransactionController : BaseApiController<Transaction, TransactionViewModel, TransactionDto>
    {
        private readonly IBaseRepository<Transaction> _baseRepository;
        private readonly IMapper _mapper;
        private readonly ITransactionRepository _transactionRepository;

        public TransactionController(IBaseRepository<Transaction> baseRepository, IMapper mapper, ITransactionRepository transactionRepository) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
            this._transactionRepository = transactionRepository;
        }

        [HttpPost("filter")]
        public async Task<ActionResult> GetTransactionFilteredAsync(FilterDto filterDto)
        {
            var vm = new ResponseViewModel<TransactionViewModel>();

            var datas = await _transactionRepository.GetFiltered(filterDto);
            vm.Datas = datas;

            return Ok(vm);
        }

        [HttpPost("getTotalInYear")]
        public async Task<ActionResult> GetTotalInYear(FilterDto filterDto)
        {
            var vm = new ResponseViewModel<TransactionViewModel>();

            var data = await _transactionRepository.GetTotalInYear(filterDto);
            vm.Data = data;

            return Ok(vm);
        }
    }
}
