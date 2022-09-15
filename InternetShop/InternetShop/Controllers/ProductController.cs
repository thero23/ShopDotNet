using AutoMapper;
using InternetShop.API.ViewModels.Product;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace InternetShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;
        private readonly IProductCharacteristicService _characteristicService;

        public ProductController(IProductService service, IProductCharacteristicService productCharacteristic, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _characteristicService = productCharacteristic;
        }

        [HttpGet]
        public async Task<IEnumerable<ShortProductViewModel>> GetAll([FromQuery] string key, [FromQuery]int value, CancellationToken ct)
        {
            var productList = await _service.GetAll(key, value, ct);
          /*  foreach (var el in productList)
            {
                el.Characteristic = "Characteristic1";
            }
          */

            string json = JsonConvert.SerializeObject(productList, new JsonSerializerSettings
            {
                  ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            using (StreamWriter writer = new("products.json", true, System.Text.Encoding.Default))
            {
                await writer.WriteAsync(json);
            }

            return _mapper.Map<IEnumerable<ShortProductViewModel>>(productList);
        }

        [HttpGet("{id}")]
        public async Task<ProductViewModel> GetById(int id, CancellationToken ct)
        {
            var result = await _service.GetById(id, ct);
            var mappedresult = _mapper.Map<ProductViewModel>(result);
          //  mappedresult.ProductsCharacteristic = mappedresult.ProductsCharacteristics.Select(x => x.Characteristics).ToList();
            return _mapper.Map<ProductViewModel>(mappedresult);
        }

        [HttpPost]
        public async Task<ProductViewModel> Post([FromBody] AddProductViewModel addProductViewModel, CancellationToken ct)
        {
            var product = await _service.Add(_mapper.Map<Product>(addProductViewModel), ct);
            return _mapper.Map<ProductViewModel>(product);
        }

        [HttpPut("{id}")]
        public async Task<ProductViewModel> Put(int id, [FromBody] UpdateProductViewModel updateProductViewModel, CancellationToken ct)
        {
            var mappedObject = _mapper.Map<Product>(updateProductViewModel);
            mappedObject.Id = id;

            var result = await _service.Update(mappedObject, ct);
            return _mapper.Map<ProductViewModel>(result);
        }
        [Authorize(Policy = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            await _service.Delete(id, ct);
            return Ok();
        }


        [HttpGet("category/{categoryId}")]
        public async Task<IEnumerable<ProductViewModel>> GetProductWithCategoryId(int categoryId, CancellationToken ct)
        {
            var result = await _service.GetProductWithCategory(categoryId, ct);
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);
        }

        [HttpGet("Product/SubCategory/{subCategoryId}")]
        public async Task<IEnumerable<ProductViewModel>> GetProductsWithSubCategory(int subCategoryId, CancellationToken ct)
        {
            var result = await _service.GetProductsBySubCategory(subCategoryId, ct);
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);
        }
    }
}
