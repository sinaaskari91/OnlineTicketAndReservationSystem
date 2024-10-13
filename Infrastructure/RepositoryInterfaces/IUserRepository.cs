﻿using Infrastructure.RepositoryPattern;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryInterface
{
    public interface IUserRepository:IBaseRepository<User,Guid>
    {
    }
}
