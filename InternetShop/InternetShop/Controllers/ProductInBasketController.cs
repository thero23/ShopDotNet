using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using InternetShop.Api.ViewModels.ProductInBasket;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInBasketController : Controller
    {
        private readonly IProductInBasketService _service;
        private readonly IMapper _mapper;

        public ProductInBasketController(IProductInBasketService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<ProductInBasketViewModel>> GetById(int id, CancellationToken ct)
        {
            var result = await _service.GetById(id, ct);
            return _mapper.Map<IEnumerable<ProductInBasketViewModel>>(result);
        }

        [HttpPost]
        public async Task<ProductInBasketViewModel> Post([FromBody] AddProductInBasketViewModel productInBasket, CancellationToken ct)
        {
            var result = await _service.Add(_mapper.Map<ProductInBasket>(productInBasket), ct);
            return _mapper.Map<ProductInBasketViewModel>(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
            return Ok();
        }

        [HttpPut]
        public async Task<IEnumerable<ProductInBasketViewModel>> Put(IEnumerable<UpdateProductInBasketViewModel> updateProductInBasketViewModels, CancellationToken ct)
        {
            
            var result = await _service.Update(_mapper.Map<IEnumerable<ProductInBasket>>(updateProductInBasketViewModels), ct);
            return _mapper.Map<IEnumerable<ProductInBasketViewModel>>(result);
        }
    }
}
