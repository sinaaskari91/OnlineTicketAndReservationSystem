using Infrastructure.RepositoryInterface;
using Infrastructure.RepositoryPattern;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryClasses
{
    public class UserRepository : BaseRepository<User, Guid>, IUserRepository
    {
        public UserRepository(OnlineTicketReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
