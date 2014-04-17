using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public partial class Activity
    {
        public Activity()
        {
            this.ActivityStatus = new List<ActivityStatus>();
        }
        public Guid ActivityId { get; set; }
        public string ActivityDesc { get; set; }
        public int ActivityReps { get; set; }
        public int ActivityDurationInSeconds { get; set; }
        public string ActivityImage { get; set; }
        public int? ActivityDistanceInFeet { get; set; }

        public Guid ChallengeId { get; set; }
        public virtual Challenge Challenge { get; set; }
        public virtual ICollection<ActivityStatus> ActivityStatus { get; set; }
    }
}
