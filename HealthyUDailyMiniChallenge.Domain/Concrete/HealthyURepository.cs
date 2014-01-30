using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Concrete
{
    public class HealthyURepository: HealthyUEFDbContext
    {
        protected HealthyUEFDbContext _healthyUEFDBContext;
        public HealthyURepository()
        {
            _healthyUEFDBContext = new HealthyUEFDbContext();
        }

        public HealthyURepository(HealthyUEFDbContext healthyDbContext)
        {
            _healthyUEFDBContext = healthyDbContext;
        }
    }
}
