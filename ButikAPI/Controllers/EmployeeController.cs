
using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButikAPI.Controllers
{
    public class EmployeeController : BaseController<Employee, EmployeeViewModel, EmployeeDto>
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
