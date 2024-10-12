using Infrastructure.RepositoryInterface;
using Infrastructure.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryClasses
{

    public class RoleRepository : IRoleRepository
    {

        private readonly OnlineTicketReservationDbContext _ticketReservationDbContext;
        public RoleRepository(OnlineTicketReservationDbContext onlineTicketReservationDbContext)
        {
            _ticketReservationDbContext = onlineTicketReservationDbContext;
        }
        public  async Task<Role> GetRole(Expression<Func<Role, bool>> predicate)
        {
            return await _ticketReservationDbContext.Role.FirstOrDefaultAsync(predicate);
        }

        public async Task<Role> GetRoleById(Guid id)
        {
          return await _ticketReservationDbContext.Role.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public Task<IQueryable<Role>> GetRoles(Expression<Func<Role, bool>> predicate = null)
        {
            return Task.Run(()=>_ticketReservationDbContext.Role.Where(predicate));
        }
        public async Task<Role> CreateRole(Role role)
        {
          await _ticketReservationDbContext.Role.AddAsync(role);
            await _ticketReservationDbContext.SaveChangesAsync();
            return role;
        }

        public async Task<bool> DeleteRole(Guid Id)
        {
          var role= await GetRoleById(Id);
         _ticketReservationDbContext.Role.Remove(role);
            await _ticketReservationDbContext.SaveChangesAsync();
            return true;
            
        }

       

        public async Task<Role> UpdateRole(Role role)
        {
           _ticketReservationDbContext.Role.Update(role);
           await _ticketReservationDbContext.SaveChangesAsync();
            return role;
        }
    }
}
