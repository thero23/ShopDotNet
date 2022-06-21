using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class UserDataService : GenericService<UserData, UserDataEntity>, IUserDataService
    {
        private readonly IMapper _mapper;
        private readonly IUserDataRepository _userDataRepository;
        public UserDataService(IUserDataRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _userDataRepository = repository;
            _mapper = mapper;
        }

        public async Task<UserData> GetLastUserDataById(int userId, CancellationToken ct)
        {
            var result = await _userDataRepository.GetLastUserDataById(userId, ct);
            return _mapper.Map<UserData>(result);
        }
    }
}