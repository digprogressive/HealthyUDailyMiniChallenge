using HealthyUDailyMiniChallenge.Domain.Concrete;
using HealthyUDailyMiniChallenge.Domain.Entities;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HealthyUDailyMiniChallenge.Infrastructure
{
    public class HealthyUFactory : DefaultControllerFactory
    {
        IKernel healthyUKernel;

        public HealthyUFactory()
        {
            healthyUKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestcontext, Type controllertype)
        {
            return controllertype == null ? null : (IController)healthyUKernel.Get(controllertype);
        }

        public void AddBindings() 
        {
            Mock<IChallengeRepository> mockChallengeRepository = new Mock<IChallengeRepository>();
            //mockChallengeRepository.Setup(r => r.Challenges()).Returns(new List<Challenge> 
            //{ 
            //    new Challenge { 
            //        ChallengeId = Guid.NewGuid(), 
            //        ChallengeDescription = "a difficult challenge", 
            //        MaxDurationInSeconds = 300,
            //        ListOfActivities = new List<Activity> 
            //        { 
            //            new Activity
            //            { 
            //                ActivityId = Guid.NewGuid(),
            //                ActivityDesc = "push up",
            //                ActivityReps = 50,
            //                ActivityDurationInSeconds = 60,
            //                ActivityImage = null,
            //                ActivityDistanceInFeet = null
            //            }
            //        },
            //        CreatedBy = new User() {Name = "Eric"}
            //    }
            //}.AsQueryable);

            healthyUKernel.Bind<IChallengeRepository>().To<ChallengeRepository>();

 
        }
    }
}