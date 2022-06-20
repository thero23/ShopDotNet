using AutoMapper;
using InternetShop.Api.ViewModels.ProductInOrder;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInOrderController : ControllerBase
    {
        private readonly IProductInOrderService _productInOrderService;
        private readonly IMapper _mapper;
        public ProductInOrderController(IProductInOrderService productInOrderService, IMapper mapper)
        {
            _productInOrderService = productInOrderService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProductInOrderViewModel prodctInOrderViewModel, CancellationToken ct)
        {
            await _productInOrderService.Post(_mapper.Map<ProductInOrder>(prodctInOrderViewModel), ct);
            return Ok();
        }
    }
}
