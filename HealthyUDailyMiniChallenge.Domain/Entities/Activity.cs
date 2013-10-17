using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class Activity
    {
        public Guid ActivityId { get; set; }
        public string ActivityDesc { get; set; }
        public int ActivityReps { get; set; }
        public int ActivityDurationInSeconds { get; set; }
        public object ActivityImage { get; set; }
        public int? ActivityDistanceInFeet { get; set; }
    }
}
