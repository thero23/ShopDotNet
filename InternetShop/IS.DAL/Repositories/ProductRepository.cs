﻿using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IS.DAL.Repositories
{
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<ProductEntity>> GetAll(CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().Include(x=> x.Currency).Include(x=> x.ProviderCountry).ToListAsync(ct);
        }

        public async Task<IEnumerable<ProductEntity>> GetAll(Expression<Func<ProductEntity, bool>> expression, CancellationToken ct)
        {
            return await _context.Products.AsNoTracking().Where(expression).Include(x=> x.ProductsCharacteristics).ThenInclude(x=> x.Characteristics).ThenInclude(x=> x.AdditionalCharacteristics).Select(u=> u).ToListAsync(ct);
        }

        public async Task<ProductEntity> GetById(int id, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x=> x.ProductsCharacteristics).ThenInclude(x => x.Characteristics).ThenInclude(x=> x.AdditionalCharacteristics).FirstOrDefaultAsync(x=> x.Id == id, ct);
            return result;
        }

        public async Task<IEnumerable<ProductEntity>> GetProductFromwhishList(IEnumerable<int> ids, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Where(x => ids.Contains(x.Id)).ToListAsync(ct);
            return result;
        }

        public async Task<IEnumerable<ProductEntity>> GetProductsBySubCategory(int subCategoryId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Where(x => x.SubCategoryId == subCategoryId).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<ProductEntity>> GetProductWithCategory(int categoryId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().ToListAsync(ct);
            result = result.Where(x => x.CategoryId == categoryId).ToList();
            return result;
        }
        public async Task<IEnumerable<ProductEntity>> GetFullInformationOfProductsInEquals(IEnumerable<int> productsListIds, CancellationToken ct)
        {
            var test = await _dbSet.AsNoTracking().Where(x => productsListIds.Contains(x.Id)).Include(x => x.ProductsCharacteristics).ToListAsync();
            var result = await _dbSet.AsNoTracking().Where(
                x => productsListIds.Contains(x.Id))
                .Include(x => x.ProductsCharacteristics)
                .ThenInclude(x => x.Characteristics)
                .ThenInclude(x => x.AdditionalCharacteristics)
                .ToListAsync(ct);
            return result;
        }
    }
}
