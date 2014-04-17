using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class User
    {
        public User()
        {
            this.Challenges = new List<Challenge>();
            this.ChallengeStatus = new List<ChallengeStatus>();
        }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Challenge> Challenges { get; set; }
        public virtual ICollection<ChallengeStatus> ChallengeStatus { get; set; }
    }
}
