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
    public interface IBaseRepository<T,KeyTypeId>where T : BaseEntity<KeyTypeId>where KeyTypeId : struct
    {
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);
        Task<T> GetByIdAsync(KeyTypeId id);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> CreateDataAsync(T data);
        Task<T> UpdateDataAsync(T data);
        Task<bool> DeleteDataAsync(KeyTypeId id);
    }
}
