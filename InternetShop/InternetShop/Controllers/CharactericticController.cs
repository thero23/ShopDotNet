using AutoMapper;
using InternetShop.Api.ViewModels.Characteristics;
using IS.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactericticController : Controller
    {
        private readonly ICharacteristicsService _characteristicsService;
        private readonly IMapper _mapper;

        public CharactericticController(ICharacteristicsService characteristicsService, IMapper mapper)
        {
            _characteristicsService = characteristicsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CharacteristicsViewModel>> GetAll(CancellationToken ct)
        {
            var result = await _characteristicsService.GetAll(ct);
            return _mapper.Map<IEnumerable<CharacteristicsViewModel>>(result);
        }
    }
}
