using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryInterfaces
{
    public interface IRoleRepository
    {
        Task<IQueryable<Role>> GetRoles(Expression<Func<Role, bool>> predicate = null);
        Task<Role> GetRoleById(Guid id);
        Task<Role> GetRole(Expression<Func<Role, bool>> predicate);
        Task<Role> CreateRole(Role role);
        Task<Role> UpdateRole(Role role);
        Task<bool> DeleteRole(Guid Id);
    }
}
