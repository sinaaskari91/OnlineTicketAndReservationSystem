using Microsoft.EntityFrameworkCore;
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
         await   CommitAsync();
            return data;
            
        }
              
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
               return await Task.Run(()=> _entitySet.AsQueryable());
            }
            return await Task.Run(() => _entitySet.Where(predicate));
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
