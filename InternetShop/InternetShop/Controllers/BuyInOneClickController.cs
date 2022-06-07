using AutoMapper;
using InternetShop.Api.ViewModels.Product;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyInOneClickController : ControllerBase
    {
        private readonly IBuyInOneClickService _service;
        private readonly IMapper _mapper;

        public BuyInOneClickController(IBuyInOneClickService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<BuyInOneClickViewModel> Post([FromBody] BuyInOneClickViewModel addProductViewModel, CancellationToken ct)
        {
            var product = await _service.Add(_mapper.Map<BuyInOneClick>(addProductViewModel), ct);
            return _mapper.Map<BuyInOneClickViewModel>(product);
        }
    }
}
