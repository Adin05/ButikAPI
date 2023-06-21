using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ButikAPI.Controllers
{
    public class ProductController : BaseApiController<Product, ProductViewModel, ProductDto>
    {
        private readonly IBaseRepository<Product> _baseRepository;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductController(IBaseRepository<Product> baseRepository, IMapper mapper, IProductRepository productRepository) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
            this._productRepository = productRepository;
        }

        [HttpPost("filter")]
        public async Task<ActionResult> FilterProductAsync(FilterDto filterDto)
        {
            var vm = new ResponseViewModel<ProductViewModel>();

            var datas = await _productRepository.GetProductWithHighLowPrice(filterDto.IsHigh);
            vm.Datas = _mapper.Map<List<ProductViewModel>>(datas);

            return Ok(vm);
        }

        [HttpPost("topTen")]
        public async Task<ActionResult> GetTopTen(FilterDto filterDto)
        {
            var vm = new ResponseViewModel<CustomerViewModel>();

            var datas = await _productRepository.GetTopTen(filterDto.BranchId);
            vm.Datas = _mapper.Map<List<CustomerViewModel>>(datas);

            return Ok(vm);
        }
    }
}
