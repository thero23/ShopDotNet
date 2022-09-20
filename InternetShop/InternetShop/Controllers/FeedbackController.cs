using AutoMapper;
using InternetShop.Api.ViewModels.FeedBack;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InternetShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IMapper mapper, IFeedbackService feedbackService)
        {
            _mapper = mapper;
            _feedbackService = feedbackService;
        }
        [HttpPost]
        public async Task<FeedBackViewModel> Add(AddFeedBackViewModel addFeedBackViewModel, CancellationToken ct)
        {
            var result = await _feedbackService.Add(_mapper.Map<Feedback>(addFeedBackViewModel), ct);
            return _mapper.Map<FeedBackViewModel>(result);
        }

        [HttpGet]
        public async Task<IEnumerable<FeedBackViewModel>> GetAll(CancellationToken ct)
        {
            var result = await _feedbackService.GetAll(ct);
            return _mapper.Map<IEnumerable<FeedBackViewModel>>(result);
        }

        [HttpGet("{productId}")]
        public async Task<IEnumerable<FeedBackViewModel>> GetFeedBacksByProduct(int productId, CancellationToken ct)
        {
            var result = await _feedbackService.GetFeedBacksByProduct(productId, ct);
            return _mapper.Map<IEnumerable<FeedBackViewModel>>(result);
        }
    }
}
