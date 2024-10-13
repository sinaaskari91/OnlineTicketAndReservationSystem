using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryPattern
{
    public class BaseRepository<T, KeyTypeId> : IBaseRepository<T, KeyTypeId> where T : BaseEntity<KeyTypeId> where KeyTypeId : struct
    {
        private readonly OnlineTicketReservationDbContext _dbContext;
        private readonly DbSet<T> _entitySet;
        public BaseRepository(OnlineTicketReservationDbContext dbContext)
        {
            _dbContext = dbContext;
            _entitySet = dbContext.Set<T>();
        }
        public async Task<T> CreateDataAsync(T data)
        {
         await _entitySet.AddAsync(data);
            _entitySet.Entry(data).State = EntityState.Added;
         await   CommitAsync();
            return data;
            
        }
              
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null ,bool IsNoTracking=true)
        {
            if (predicate == null)
            {
               return await Task.Run(()=> IsNoTracking? _entitySet.AsNoTracking(): _entitySet.AsQueryable());
            }
            return await Task.Run(() => IsNoTracking ? _entitySet.Where(predicate).AsNoTracking() : _entitySet.Where(predicate));
        }
        public async Task<IQueryable<TResult>> GetAllAsync<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool IsNoTracking = true)
        {
            IQueryable<T> query=_entitySet;
            query=IsNoTracking==true ? query.AsNoTracking() : query.AsQueryable();
            query = predicate != null ? query.Where(predicate) : query;
            query = include != null ? include(query) : query;
           return  query != null && query.Any() ? query.Select(selector) : default;
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
           return await _entitySet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetByIdAsync(KeyTypeId id)
        {
            return await _entitySet.FirstOrDefaultAsync(x=>x.Equals(id));
        }

        public async Task<T> UpdateDataAsync(T data)
        {
            _entitySet.Update(data);
            await CommitAsync();
            return data;
        }
        public async Task<bool> DeleteDataAsync(KeyTypeId id)
        {
           var data=await GetByIdAsync(id);
            if (data != null)
            {
                _entitySet.Remove(data);
                await CommitAsync();
                return true;
            }
            return false;
        }
        public async Task<int> CommitAsync()=>await _dbContext.SaveChangesAsync();

        
    }
}
