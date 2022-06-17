using AutoMapper;
using InternetShop.Api.ViewModels.WhishList;
using InternetShop.API.ViewModels.Product;
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
    public class WhishListController : ControllerBase
    {
        private readonly IGenericService<WhishList> _service;
        private readonly IMapper _mapper;
        private readonly IWhishListService _whishListService;

        public WhishListController(IGenericService<WhishList> service, IWhishListService whishListService, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _whishListService = whishListService;
        }

        [HttpPost]
        public async Task<WhishListViewModel> Post([FromBody] WhishListAddViewModel whishListAdd, CancellationToken ct)
        {
            var whishList = await _service.Add(_mapper.Map<WhishList>(whishListAdd), ct);
            return _mapper.Map<WhishListViewModel>(whishList);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int userId, int productId, CancellationToken ct)
        {
            await _whishListService.Delete(userId, productId, ct);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<ProductViewModel>> GetByUserId(int id, CancellationToken ct)
        {
            var result = await _whishListService.GetByUserId(id, ct);
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);
        }

    }
}
