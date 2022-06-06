using AutoMapper;
using InternetShop.API.ViewModels.ProviderCountry;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderCountryController : ControllerBase
    {
        private readonly IProviderCountryService _service;
        private readonly IMapper _mapper;

        public ProviderCountryController(IProviderCountryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProviderCountryViewModel>> GetAll(CancellationToken ct)
        {
            var providerCountryList = await _service.GetAll(ct);
            return _mapper.Map<IEnumerable<ProviderCountryViewModel>>(providerCountryList);
        }

        [HttpGet("{id}")]
        public async Task<ProviderCountryViewModel> GetById(int id, CancellationToken ct)
        {
            var result = await _service.GetById(id, ct);

            return _mapper.Map<ProviderCountryViewModel>(result);
        }

        [HttpPost]
        public async Task<ProviderCountryViewModel> Post([FromBody] AddProviderCountryViewModel addProviderCountryView, CancellationToken ct)
        {
            var category = await _service.Add(_mapper.Map<ProviderCountry>(addProviderCountryView), ct);
            return _mapper.Map<ProviderCountryViewModel>(category);
        }


        [HttpPut("{id}")]
        public async Task<ProviderCountryViewModel> Put(int id, [FromBody] UpdateProviderCountryViewModel updateProviderCountryViewModel, CancellationToken ct)
        {
            var mappedObject = _mapper.Map<ProviderCountry>(updateProviderCountryViewModel);
            mappedObject.Id = id;

            var result = await _service.Update(mappedObject, ct);
            return _mapper.Map<ProviderCountryViewModel>(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
            return Ok();
        }

    }
}
