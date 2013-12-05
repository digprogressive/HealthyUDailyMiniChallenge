using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class ActivityStatus
    {
        public Guid ActivityStatusId { get; set; }
        public string Status { get; set; }
        public Activity AssignedActivity { get; set; }
    }
}
