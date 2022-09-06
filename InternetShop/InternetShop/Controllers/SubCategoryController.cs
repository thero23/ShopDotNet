using AutoMapper;
using InternetShop.Api.ViewModels.SubCategories;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _service;
        private readonly IGenericService<GeneralSubCategoryName> _generalSubCategoryNameService;
        private readonly IGenericService<SubCategoryName> _subCategoryNameService;
        private readonly IMapper _mapper;

        public SubCategoryController(ISubCategoryService service,
            IGenericService<GeneralSubCategoryName> generalSubCategoryNameService,
            IGenericService<SubCategoryName> subCategoryNameService,
            IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _generalSubCategoryNameService = generalSubCategoryNameService;
            _subCategoryNameService = subCategoryNameService;
        }


        [HttpGet("SubCategories/{id}")]
        public async Task<IEnumerable<SubCategoryViewModel>> GetAll(int id, CancellationToken ct)
        {
            var subCategories = await _service.GetAll(id, ct);

            return _mapper.Map<IEnumerable<SubCategoryViewModel>>(subCategories);
        }

        [HttpGet("{id}")]
        public async Task<SubCategoryViewModel> GetById(int id, CancellationToken ct)
        {
            var result = await _service.GetById(id, ct);
            return _mapper.Map<SubCategoryViewModel>(result);
        }

        [HttpPost]
        public async Task<SubCategoryViewModel> Post([FromBody] AddSubCategoryViewModel subCategoryviewModel, CancellationToken ct)
        {
            var result = await _service.Add(_mapper.Map<SubCategory>(subCategoryviewModel), ct);
            return _mapper.Map<SubCategoryViewModel>(result);
        }

        [HttpPost("AddGeneralSubCategoryName")]
        public async Task<GeneralSubCategoryNameViewModel> AddGeneralSubCategoryName(AddGeneralSubCategoryNameViewModel addGeneralSubcategoryNameViewModel, CancellationToken ct)
        {
            var result = await _generalSubCategoryNameService.Add(_mapper.Map<GeneralSubCategoryName>(addGeneralSubcategoryNameViewModel), ct);
            return _mapper.Map<GeneralSubCategoryNameViewModel>(result);
        }

        [HttpPost("AddSubCategories")]
        public async ValueTask AddSubCategoriesNameViewModel(IEnumerable<AddSubCategoryNameViewModel> subCategoriesViewModel, CancellationToken ct)
        {
            await _subCategoryNameService.AddRange(_mapper.Map<IEnumerable<SubCategoryName>>(subCategoriesViewModel), ct);
        }

        [HttpPut("{id}")]
        public async Task<SubCategoryViewModel> Put(int id, [FromBody] SubCategoryViewModel subcategoryViewModel, CancellationToken ct)
        {
            var mappedObject = _mapper.Map<SubCategory>(subcategoryViewModel);
            mappedObject.Id = id;

            var result = await _service.Update(mappedObject, ct);
            return _mapper.Map<SubCategoryViewModel>(result);
        }
        [Authorize(Policy = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
            return Ok();
        }
    }
}
