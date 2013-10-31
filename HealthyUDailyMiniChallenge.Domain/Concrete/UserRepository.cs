using HealthyUDailyMiniChallenge.Domain.Entities;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Concrete
{
    public class UserRepository : HealthyURepository, IUserRepository
    {
        public IQueryable<User> Users()
        {
            return _healthyUEFDBContext.Users;
        }


    }
}
