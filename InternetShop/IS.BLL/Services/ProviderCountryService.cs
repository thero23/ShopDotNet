using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProviderCountryService:GenericService<ProviderCountry, ProviderCountryEntity>, IProviderCountryService
    {
        public ProviderCountryService(IGenericRepository<ProviderCountryEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
