using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class SubCategoryService : GenericService<SubCategory, SubCategoryEntity>, ISubCategoryService
    {
        private readonly IMapper _mapper;
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryService(ISubCategoryRepository subCategoryRepository, IMapper mapper) : base(subCategoryRepository, mapper)
        {
            _subCategoryRepository = subCategoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SubCategory>> GetAll(int id, CancellationToken ct)
        {
            var result = await _subCategoryRepository.GetAllAsync(id, ct);
            return _mapper.Map<IEnumerable<SubCategory>>(result);
        }
    }
}
