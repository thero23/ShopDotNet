using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;


namespace IS.BLL.Services
{
    public class CharacteristicsService : GenericService<Characteristics, CharacteristicsEntity>, ICharacteristicsService
    {
        public CharacteristicsService(ICharacteristicRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
