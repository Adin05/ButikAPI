using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ButikAPI.Controllers
{
    public class BranchController : BaseApiController<Branch, BranchViewModel, BranchDto>
    {
        private readonly IBaseRepository<Branch> _baseRepository;
        private readonly IMapper _mapper;

        public BranchController(IBaseRepository<Branch> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
