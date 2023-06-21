using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;

namespace ButikAPI.Controllers
{
    public class EmployeeController : BaseApiController<Employee, EmployeeViewModel, EmployeeDto>
    {
        private readonly IBaseRepository<Employee> _baseRepository;
        private readonly IMapper _mapper;

        public EmployeeController(IBaseRepository<Employee> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
