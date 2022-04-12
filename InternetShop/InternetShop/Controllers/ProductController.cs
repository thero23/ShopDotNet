using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using InternetShop.ViewModels.Product;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;


namespace InternetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<ShortProductViewModel>> GetAll(CancellationToken ct)
        {
            var productList = await _service.GetAll(ct);
            return _mapper.Map<IEnumerable<ShortProductViewModel>>(productList);

        }

        [HttpGet("{id}")]
        public async Task<ProductViewModel> GetById(int id, CancellationToken ct)
        {
            var result = await _service.GetById(id, ct);
            return _mapper.Map<ProductViewModel>(result);
        }

        [HttpPost]
        public async Task<ProductViewModel> Post([FromBody] AddProductViewModel addProductViewModel, CancellationToken ct)
        {
            var product = await _service.Add(_mapper.Map<Product>(addProductViewModel), ct);
            return _mapper.Map<ProductViewModel>(product);
        }


        [HttpPut("{id}")]
        public async Task<ProductViewModel> Put(int id, [FromBody] UpdateProductViewModel updateProductViewModel, CancellationToken ct)
        {
            var mappedObject = _mapper.Map<Product>(updateProductViewModel);
            mappedObject.Id = id;

            var result = await _service.Update(mappedObject, ct);
            return _mapper.Map<ProductViewModel>(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
            return Ok();
        }
    }
}
