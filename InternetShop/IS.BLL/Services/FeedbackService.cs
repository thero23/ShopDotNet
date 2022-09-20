using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class FeedbackService : GenericService<Feedback, FeedbackEntity>, IFeedbackService
    {
        private readonly IMapper _mapper;
        private readonly IFeedbackRepository _feedbackRepository;
        private readonly IUserRepository _userRepository;
        public FeedbackService(IFeedbackRepository repository, IUserRepository userRepository, IMapper mapper) : base(repository, mapper)
        {
            _mapper = mapper;
            _feedbackRepository = repository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Feedback>> GetFeedBacksByProduct(int productId, CancellationToken ct)
        {
            var result = await _feedbackRepository.GetFeedBacksByProduct(productId, ct);
            return _mapper.Map<IEnumerable<Feedback>>(result);
        }
        public override async Task<Feedback> Add(Feedback model, CancellationToken ct)
        {
            var user = await _userRepository.GetByAuthId(model.AuthId, ct);
            model.UserId = user.Id;
            var result = await _feedbackRepository.Add(_mapper.Map<FeedbackEntity>(model), ct);
            return _mapper.Map<Feedback>(result);
        }
    }
}
