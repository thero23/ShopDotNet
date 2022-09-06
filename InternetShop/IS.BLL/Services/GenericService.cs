using AutoMapper;
using IS.BLL.Interfaces;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class GenericService<TModel, TEntity> : IGenericService<TModel>
        where TModel : class
        where TEntity : class
    {
        protected readonly IGenericRepository<TEntity> Repository;
        protected readonly IMapper Mapper;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        public virtual async Task<IEnumerable<TModel>> GetAll(CancellationToken ct)
        {
            return Mapper.Map<IEnumerable<TModel>>(await Repository.GetAll(ct));
        }


        public virtual async Task<TModel?> GetById(int id, CancellationToken ct)
        {
            return Mapper.Map<TModel>(await Repository.GetById(id, ct));
        }

        public virtual async Task<TModel> Add(TModel model, CancellationToken ct)
        {
            return Mapper.Map<TModel>(await Repository.Add(
                Mapper.Map<TEntity>(model), ct
            ));
        }

        public ValueTask Delete(TModel model, CancellationToken ct)
        {
            return Repository.Delete(Mapper.Map<TEntity>(model), ct);
        }

        public async Task<TModel> Update(TModel entity, CancellationToken ct)
        {
            return Mapper.Map<TModel>(
                await Repository.Update(Mapper.Map<TEntity>(entity), ct)
            );
        }

        public async ValueTask Delete(int id, CancellationToken ct)
        {
            var result = await Repository.GetById(id, ct);
            await Repository.Delete(result, ct);
        }

        public async Task AddRange(IEnumerable<TModel> entities, CancellationToken ct)
        {
            await Repository.AddRange(Mapper.Map<IEnumerable<TEntity>>(entities), ct);
        }
    }
}
