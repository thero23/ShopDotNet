using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using InternetShop.ViewModels.Basket;
using InternetShop.ViewModels.Product;
using IS.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IBasketService _service;

        public BasketController(IMapper mapper, IBasketService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("userId")]
        public async Task<BasketViewModel> Get(string userId)
        {
            var basket = await _service.GetBasketProducts(userId);
            return _mapper.Map<BasketViewModel>(basket);
        }

        [HttpPost]
        public async Task<ProductViewModel> AddProduct([FromBody] AddProductIntoBasketViewModel addProductIntoBasketViewModel, CancellationToken ct)
        {
            var product = await _service.AddProductToBasketAsync(addProductIntoBasketViewModel.UserId,
                addProductIntoBasketViewModel.ProductId, addProductIntoBasketViewModel.Quantity, ct);
            return _mapper.Map<ProductViewModel>(product);
        }


        [HttpDelete("{userId}/{productId}")]
        public async Task<IActionResult> RemoveProductFromBasket(string userId, int productId, CancellationToken ct)
        {
            await _service.RemoveProductFromBasketAsync(userId, productId, ct);
            return Ok();
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> ClearBasket(string userId, CancellationToken ct)
        {
            await _service.ClearBasketAsync(userId, ct);
            return Ok();
        }
    }
}
