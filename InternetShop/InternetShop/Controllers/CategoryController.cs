using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using InternetShop.ViewModels.Category;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IGenericService<Category> _genericService;
        protected readonly IMapper _mapper;

        public CategoryController(IGenericService<Category> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        [HttpGet] 
        public async Task<IEnumerable<CategoryViewModel>> GetAll(CancellationToken ct)
        {
            var categoryList = await _genericService.GetAll(ct);
            return _mapper.Map<IEnumerable<CategoryViewModel>>(categoryList);
        }

        [HttpGet("{id}")]
        public async Task<CategoryViewModel> GetById(int id, CancellationToken ct)
        {
            var result = await _genericService.GetById(id, ct);
            return _mapper.Map<CategoryViewModel>(result);
        }

        [HttpPost]
        public async Task<CategoryViewModel> Post([FromBody] AddCategoryViewModel addCategoryViewModel, CancellationToken ct)
        {
            var category = await _genericService.Add(_mapper.Map<Category>(addCategoryViewModel), ct);
            return _mapper.Map<CategoryViewModel>(category);
        }

        
        [HttpPut("{id}")]
        public async Task<CategoryViewModel> Put(int id, [FromBody] UpdateCategoryViewModel updateCategoryViewModel, CancellationToken ct)
        {
            var mappedObject = _mapper.Map<Category>(updateCategoryViewModel);
            mappedObject.Id = id;

            var result = await _genericService.Update(mappedObject, ct);
            return _mapper.Map<CategoryViewModel>(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _genericService.Delete(id, ct);
            return Ok();
        }
    }
}
