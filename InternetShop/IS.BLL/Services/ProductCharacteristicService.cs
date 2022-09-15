using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductCharacteristicService : GenericService<ProductsCharacteristic, ProductsCharacteristicEntity>, IProductCharacteristicService
    {
        private readonly IProductsCharacteristicRepository _repository;
        private readonly IMapper _mapper;
        private readonly ICharacteristicRepository _characteristicsRepository;
        private readonly IAdditionalCharacteristicRepository _additionalCharacteristicsRepository;
        public ProductCharacteristicService(IProductsCharacteristicRepository repository, 
            ICharacteristicRepository characteristicsRepository,
            IAdditionalCharacteristicRepository additionalCharacteristicRepository,
            IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _characteristicsRepository = characteristicsRepository;
            _additionalCharacteristicsRepository = additionalCharacteristicRepository;
        }

        public async Task<IEnumerable<ProductsCharacteristic>> GetCharacteristicByProduct(IEnumerable<int> productsIds, CancellationToken ct)
        {
            var result = await _repository.GetProductById(productsIds, ct);
            var characteristic = await _characteristicsRepository.Get(ConvertToList(result), ct);
            return _mapper.Map<IEnumerable<ProductsCharacteristic>>(result);
        }
        private IEnumerable<int> ConvertToList(IEnumerable<ProductsCharacteristicEntity> productsCharacteristic)
        {
            List<int> ids = new();
            foreach (var el in productsCharacteristic)
            {
                ids.Add(el.CharacteristicsId);
            }
            return ids;
        }
    }
}
