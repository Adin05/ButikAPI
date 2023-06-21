using AutoMapper;
using ButikAPI.Interfaces;
using ButikAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ButikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,T2, T3> : ControllerBase
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly IMapper _mapper;

        public BaseController(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            this._baseRepository = baseRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var vm = new BaseViewModel<T2>();

            var datas = await _baseRepository.GetAllAsync();
            vm.Datas = _mapper.Map<List<T2>>(datas);

            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var vm = new BaseViewModel<T2>();

            var data = await _baseRepository.GetByIdAsync(id);
            vm.Data = _mapper.Map<T2>(data);

            return Ok(vm);
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateAsync(T3 Data)
        {
            var vm = new BaseViewModel<T2>();

            var entity = _mapper.Map<T>(Data);
            await _baseRepository.CreateAsync(entity);
            await _baseRepository.SaveChangeAsync();

            return Ok(vm);
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult> Update(int id, T3 Data)
        {
            var vm = new BaseViewModel<T2>();

            var entity = await _baseRepository.GetByIdAsync(id);
            _mapper.Map(Data, entity);
            await _baseRepository.UpdateAsync(id, entity);
            await _baseRepository.SaveChangeAsync();

            return Ok(vm);
        }
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var vm = new BaseViewModel<T2>();

            await _baseRepository.DeleteAsync(id);
            await _baseRepository.SaveChangeAsync();

            return Ok(vm);
        }
    }
}
