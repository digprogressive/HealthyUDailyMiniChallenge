using HealthyUDailyMiniChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeathyUDailyMiniChallenge.Models
{
    public class ChallengeUser
    {
        public IEnumerable<Challenge> AssignedChallenges;
        public IEnumerable<Challenge> AvailableChallenges;

        public IEnumerable<User> AssignedUsers;
        public IEnumerable<User> AvailableUsers;
    }
}