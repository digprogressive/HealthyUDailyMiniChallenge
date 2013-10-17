using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class ChallengeStatus
    {
        public Guid ChallengeStatusId { get; set; }
        public Guid ChallengedId { get; set; }
        public Challenge AssignedChallenge { get; set; }
        public bool Status { get; set; }
    }
}
