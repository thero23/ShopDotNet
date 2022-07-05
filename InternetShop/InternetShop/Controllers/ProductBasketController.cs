using AutoMapper;
using InternetShop.Api.ViewModels.ProductBasket;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBasketController : ControllerBase
    {
        private readonly IProductBasketService _service;
        private readonly IMapper _mapper;

        public ProductBasketController(IProductBasketService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductBasketViewModel>> GetAll(CancellationToken ct)
        {
            var result = await _service.GetAll(ct);
            return _mapper.Map<IEnumerable<ProductBasketViewModel>>(result);
        }

        [HttpDelete]
        public async Task Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
        }

        [HttpPost]
        public async Task<ProductBasketViewModel> Post(AddProductBasketViewModel addProductBasketViewModel, CancellationToken ct)
        {
            var result = await _service.AddProductToBasket("", ct);// (_mapper.Map<ProductBasket>(addProductBasketViewModel), ct);
            return _mapper.Map<ProductBasketViewModel>(result);
        }

        [HttpPut]
        public async Task<ProductBasketViewModel> Put(UpdateProductBasketViewModel updateProductViewModel, CancellationToken ct)
        {
            var result = await _service.Update(_mapper.Map<ProductBasket>(updateProductViewModel), ct);
            return _mapper.Map<ProductBasketViewModel>(result);
        }
    }
}
