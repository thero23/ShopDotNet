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
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserViewModel productInOrderViewModel, CancellationToken ct)
        {
            await _orderService.Post(_mapper.Map<User>(productInOrderViewModel), ct);
            return Ok();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IEnumerable<OrderViewModel>> GetByuserId(string id, CancellationToken ct)
        {
            var result = await _orderService.GetByUserId(id, ct);
            return _mapper.Map<IEnumerable<OrderViewModel>>(result);
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public async Task<IEnumerable<OrderViewModel>> GetAll(CancellationToken ct)
        {
            var result = await _orderService.GetAll(ct);
            return _mapper.Map<IEnumerable<OrderViewModel>>(result);
        }

    }
}
