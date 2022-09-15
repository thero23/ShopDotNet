using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using IS.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IS.BLL.Services
{
    public class EqualsService : GenericService<Equals, EqualsEntity>, IEqualsService
    {
        private readonly IMapper _mapper;
        private readonly IEqualsRepository _equalsRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICharacteristicRepository _characteristicRepository;
        private readonly IProductCharacteristicService _productCharacteristicService;
        private readonly IProductRepository _productRepository;
        public EqualsService(IEqualsRepository repository,
            IMapper mapper,
            IUserRepository userRepository,
            ICharacteristicRepository characteristicRepository,
            IProductCharacteristicService productCharacteristicService,
            IProductRepository productRepository) : base(repository, mapper)
        {
            _equalsRepository = repository;
            _userRepository = userRepository;
            _mapper = mapper;
            _characteristicRepository = characteristicRepository;
            _productCharacteristicService = productCharacteristicService;
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetByUserId(string authId, CancellationToken ct)
        {
            var user = await _userRepository.GetByAuthId(authId, ct);
            var productsListInEquals = await _equalsRepository.GetByUserId(user.Id, ct);
            var productsIds = ConvertToList(productsListInEquals);
            var result = await _productRepository.GetFullInformationOfProductsInEquals(productsIds, ct);

            return _mapper.Map<IEnumerable<Product>>(result);
        }

        public override async Task<Equals> Add(Equals model, CancellationToken ct)
        {
            var user = await _userRepository.GetByAuthId(model.UserId, ct);
            model.UserId = user.Id;
            var result = await _equalsRepository.Add(_mapper.Map<EqualsEntity>(model), ct);
            return _mapper.Map<Equals>(result);
        }


        private IEnumerable<int> ConvertToList(IEnumerable<EqualsEntity> productInEquals)
        {
            List<int> ids = new List<int>();
            foreach (var el in productInEquals)
            {
                ids.Add(el.ProductId);
            }
            return ids;
        }
        private IEnumerable<Equals> AddCharacteristicsToProduct(List<Equals> equals, List<ProductsCharacteristic> productsCharacteristics)
        {
            for(int i =0; i < equals.Count(); i++)
            {
                for(int j = 0; j < productsCharacteristics.Count(); j++)
                {
                    equals[i].Characteristics = productsCharacteristics[j];
                    break;
                }
            }
            return equals;
        }
    }
}
