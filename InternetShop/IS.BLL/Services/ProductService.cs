using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductService:GenericService<Product, ProductEntity>, IProductService
    {

        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
            
        }
    }
}
