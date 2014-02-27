using HealthyUDailyMiniChallenge.Domain.Concrete;
using HealthyUDailyMiniChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HeathyUDailyMiniChallenge.Controllers
{
    public class ChallengeUsersController : ApiController
    {
        private UserRepository repository = new UserRepository();

        public IEnumerable<User> GetAllUsers()
        {
            return repository.Users();
        }
    }
}
