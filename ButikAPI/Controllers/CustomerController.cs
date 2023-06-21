using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;

namespace ButikAPI.Controllers
{
    public class CustomerController : BaseApiController<Customer, CustomerViewModel, CustomerDto>
    {
        private readonly IBaseRepository<Customer> _baseRepository;
        private readonly IMapper _mapper;

        public CustomerController(IBaseRepository<Customer> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
