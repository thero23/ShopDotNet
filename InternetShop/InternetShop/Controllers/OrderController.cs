using AutoMapper;
using InternetShop.Api.ViewModels.Order;
using InternetShop.Api.ViewModels.User;
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
    public class OrderController : ControllerBase
    {
        private readonly IProductInOrderService _productInOrderService;
        private readonly IMapper _mapper;
        public OrderController(IProductInOrderService productInOrderService, IMapper mapper)
        {
            _productInOrderService = productInOrderService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserViewModel productInOrderViewModel, CancellationToken ct)
        {
            await _productInOrderService.Post(_mapper.Map<User>(productInOrderViewModel), ct);
            return Ok();
        }

       // [Authorize]
        [HttpGet("{id}")]
        public async Task<IEnumerable<OrderViewModel>> GetByuserId(string id, CancellationToken ct)
        {
            var result = await _productInOrderService.GetByUserId(id, ct);
            return _mapper.Map<IEnumerable<OrderViewModel>>(result);
        }
    }
}
