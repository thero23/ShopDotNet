using AutoMapper;
using InternetShop.Api.ViewModels.Equals;
using InternetShop.API.ViewModels.Product;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EqualsController : Controller
    {
        private readonly IEqualsService _equalsService;
        private readonly IMapper _mapper;

        public EqualsController(IEqualsService equalsService, IMapper mapper)
        {
            _equalsService = equalsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<EqualsViewModel>> GetAll(CancellationToken ct)
        {
            var result = await _equalsService.GetAll(ct);
            return _mapper.Map<IEnumerable<EqualsViewModel>>(result);
        }

        [HttpPost]
        public async Task<EqualsViewModel> Post(AddEqualsViewModel addEqualsViewModel, CancellationToken ct)
        {
            var result = await _equalsService.Add(_mapper.Map<Equals>(addEqualsViewModel), ct);
            return _mapper.Map<EqualsViewModel>(result);
        }

        [HttpGet("{authId}")]
        public async Task<IEnumerable<ProductViewModel>> GetById(string authId, CancellationToken ct)
        {
            var result = await _equalsService.GetByUserId(authId, ct);
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);

        }
    }
}
