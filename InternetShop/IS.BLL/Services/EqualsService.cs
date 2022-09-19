using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class EqualsService : GenericService<Equals, EqualsEntity>, IEqualsService
    {
        private readonly IMapper _mapper;
        private readonly IEqualsRepository _equalsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        public EqualsService(IEqualsRepository repository,
            IMapper mapper,
            IUserRepository userRepository,
            IProductRepository productRepository) : base(repository, mapper)
        {
            _equalsRepository = repository;
            _userRepository = userRepository;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetByUserId(string authId, CancellationToken ct)
        {
            var user = await _userRepository.GetByAuthId(authId, ct);
            var productsListInEquals = await _equalsRepository.GetByUserId(user.Id, ct);
            var productsIds = ConvertToList(productsListInEquals);
            List<ProductEntity> products = new();
            foreach(var el in productsIds)
            {
                products.Add(await _productRepository.GetFullInformationOfProductsInEquals(el, ct));
            }          
            
            return GetGeneralNameCharacteristic(_mapper.Map<IEnumerable<Product>>(products));
        }

        public override async Task<Equals> Add(Equals model, CancellationToken ct)
        {
            var user = await _userRepository.GetByAuthId(model.UserId, ct);
            model.UserId = user.Id;
            var isExists = await _equalsRepository.IsExistsProduct(user.Id, model.ProductId, ct);
            if(isExists is not null)
            {
                return model;
            }
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
        private IEnumerable<Product> GetGeneralNameCharacteristic(IEnumerable<Product> products)
        {
            HashSet<string> generalCharacteristicName = new();

            foreach (var el in products)
            {
                foreach (var el1 in el.Characteristics)
                {
                    generalCharacteristicName.Add(el1.Name);
                }
                el.GeneralCharacteristicName = generalCharacteristicName;
            }
            return products;
        }
    }
}
