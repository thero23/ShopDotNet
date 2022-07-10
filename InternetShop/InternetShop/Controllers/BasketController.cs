﻿using AutoMapper;
using InternetShop.Api.ViewModels.Basket;
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
    public class BasketController : Controller
    {
        private readonly IBasketService _service;
        private readonly IMapper _mapper;

        public BasketController(IBasketService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<BasketViewModel>> GetAll(CancellationToken ct)
        {
            var result = _mapper.Map<IEnumerable<BasketViewModel>>(await _service.GetAll(ct));
            return result;
        }

       /* [HttpGet("{id}")]
        public async Task<IEnumerable<ProductInBasketViewModel>> GetProductsInBasketByUserId(string id, CancellationToken ct)
        {
            var result = await _service.GetById(id, ct);
            return _mapper.Map<IEnumerable<ProductInBasketViewModel>>(result);
        }*/

        [HttpPost]
        public async Task<BasketViewModel> Post([FromBody] AddBasketViewModel addBasketViewModel, CancellationToken ct)
        {
            var result = await _service.Add(_mapper.Map<Basket>(addBasketViewModel), ct);
            return _mapper.Map<BasketViewModel>(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
            return Ok();
        }

        [HttpPut]
        public async Task<BasketViewModel> Put(UpdateBasketViewModel updateBasketViewModel, CancellationToken ct)
        {
            var result = await _service.Update(_mapper.Map<Basket>(updateBasketViewModel), ct);
            return _mapper.Map<BasketViewModel>(result);
        }

        [HttpGet("{authId}")]
        public async Task<IEnumerable<ShortProductBasketViewModel>> GetBasketWithProduct(string authId, CancellationToken ct)
        {
            var productsBasket = await _service.GetBasketWithProductsByUserId(authId, ct);
            return _mapper.Map<IEnumerable<ShortProductBasketViewModel>>(productsBasket);
        }
    }
}