﻿using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class EqualsRepository : GenericRepository<EqualsEntity>, IEqualsRepository
    {
        public EqualsRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<EqualsEntity>> GetByUserId(string userId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Where(x => x.UserId == userId).ToListAsync(ct);
            return result;
        }
    }
}
