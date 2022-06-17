using IS.DAL.Contexts;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DatabaseContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll(CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().ToListAsync(ct);
        }
        
        public virtual async Task<TEntity?> GetById(int id, CancellationToken ct)
        {
            return await _dbSet.FindAsync(new object[] { id }, ct);
        }

        public virtual async Task<TEntity> Add(TEntity entity, CancellationToken ct)
        {
            await _dbSet.AddAsync(entity, ct);
            await _context.SaveChangesAsync(ct);
            return entity;
        }

        public virtual async ValueTask Delete(int id, CancellationToken ct)
        {
            var entity = await _dbSet.FindAsync(new object[] { id }, ct);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync(ct);
            }
           
        }

        public virtual async Task<TEntity> Update(TEntity entity, CancellationToken ct)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(ct);
            return entity;
        }
    }
}
