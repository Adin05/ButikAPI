using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;

namespace ButikAPI.Controllers
{
    public class ProductController : BaseApiController<Product, ProductViewModel, ProductDto>
    {
        private readonly IBaseRepository<Product> _baseRepository;
        private readonly IMapper _mapper;

        public ProductController(IBaseRepository<Product> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
