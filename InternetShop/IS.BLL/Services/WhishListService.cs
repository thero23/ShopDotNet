using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using System.Collections.Generic;

namespace IS.BLL.Services
{
    public class WhishListService : GenericService<WhishList, WhishListEntity>, IWhishListService
    {
        private readonly IWhishListRepository _whishListRepository;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public WhishListService(IWhishListRepository repository, IMapper mapper, IProductRepository productRepository) : base(repository, mapper)
        {
            _whishListRepository = repository;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async ValueTask Delete(int userId, int productId, CancellationToken ct)
        {
            await _whishListRepository.Delete(userId, productId, ct);
        }

        public async Task<IEnumerable<Product>> GetByUserId(int userId, CancellationToken ct)
        {
            var result = await _whishListRepository.GetByUserId(userId, ct);
            var productIdsList = GetIds(_mapper.Map<IEnumerable<WhishList>>(result));
            var result2 = await _productRepository.GetProductFromwhishList(productIdsList, ct);
            return _mapper.Map<IEnumerable<Product>>(result2);
        }

        private IEnumerable<int> GetIds(IEnumerable<WhishList> whishList)
        {
            var list = new List<int>();
            foreach(var el in whishList)
            {
                list.Add(el.ProductId);
            }
            return list;
        }
    }
}
