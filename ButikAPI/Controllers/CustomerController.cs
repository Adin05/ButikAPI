using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ButikAPI.Controllers
{
    public class CustomerController : BaseApiController<Customer, CustomerViewModel, CustomerDto>
    {
        private readonly IBaseRepository<Customer> _baseRepository;
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(IBaseRepository<Customer> baseRepository, IMapper mapper, ICustomerRepository customerRepository) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
            this._customerRepository = customerRepository;
        }
        [HttpPost("filter")]
        public async Task<ActionResult> CustomerFilteredAsync(FilterDto filterDto)
        {
            var vm = new ResponseViewModel<CustomerViewModel>();

            var datas = await _customerRepository.GetCustomerByRegister(filterDto);
            vm.Datas = datas; ;

            return Ok(vm);
        }
        [HttpPost("topTen")]
        public async Task<ActionResult> GetTopTen(FilterDto filterDto)
        {
            var vm = new ResponseViewModel<CustomerViewModel>();

            var datas = await _customerRepository.GetTopTen(filterDto);
            vm.Datas = datas; ;

            return Ok(vm);
        }
    }
}
