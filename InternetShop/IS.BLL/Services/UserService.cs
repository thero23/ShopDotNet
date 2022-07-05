using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class UserService : GenericService<User, UserEntity>, IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        public UserService(IUserRepository repository, IBasketRepository basketRepository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _basketRepository = basketRepository;
        }

        public async Task<User> GetById(string id, CancellationToken ct)
        {
            var result = await _repository.GetById(id, ct);
            return _mapper.Map<User>(result);
        }

        public async Task<User> Put(User user, CancellationToken ct)
        {
            var result = await _repository.GetById(user.Auth0Id, ct);
            if (result is not null)
            {
                var mappedObject = _mapper.Map<UserEntity>(user);
                return _mapper.Map<User>(await _repository.Update(mappedObject, ct));
            }
            return _mapper.Map<User>(await Add(user, ct));
        }
        public async Task<User> Add(User user, CancellationToken ct)
        {
            var isUserExists = await _repository.GetById(user.Auth0Id, ct);
            if (isUserExists is not null)
            {
                return user;
            }
            var result = await _repository.Add(_mapper.Map<UserEntity>(user), ct);
            await _basketRepository.Add(new BasketEntity {User = result}, ct);
            
            return _mapper.Map<User>(result);
        }
    }
}